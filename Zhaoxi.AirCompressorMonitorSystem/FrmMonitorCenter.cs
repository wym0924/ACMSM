using Modbus.Device;
using System.Windows.Forms.DataVisualization.Charting;
using Zhaoxi.AirCompressorMonitorSystem.Models;
using Zhaoxi.AirCompressorMonitorSystem.Utils;
using Zhaoxi.CustControls;
using Zhaoxi.WinNewCustControls;

namespace Zhaoxi.AirCompressorMonitorSystem
{
    public partial class FrmMonitorCenter : FrmParent
    {
        public FrmMonitorCenter()
        {
            InitializeComponent();
        }

        int curSelNo = 0;//当前选择的编号
        Dictionary<int, List<ParaInfo>> dicParaList = new Dictionary<int, List<ParaInfo>>();//参数列表
        Dictionary<string, float[]> dicAlarmSets = new Dictionary<string, float[]>();//临界值集合
        ManualResetEvent resetEvent = new ManualResetEvent(false);//控制采集线程的暂停与恢复
        IModbusMaster master = null;
        Dictionary<string, uint> dicDatas1 = new Dictionary<string, uint>();//实时数据集合1
        Dictionary<string, float> dicDatas2 = new Dictionary<string, float>();//实时数据集合2
        Dictionary<int, List<TrendData>> dicTrendDatas = new Dictionary<int, List<TrendData>>();//曲线数据列表
        Dictionary<string, bool> dicStates = new Dictionary<string, bool>();//实时状态集合
        List<int> checkResults = new List<int>() { -1, -1, -1, -1, -1, -1 };//检测状态集合
        float minPressure = 4.0f;
        float maxPressure = 10.0f;
        /// <summary>
        /// 加载处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMonitorCenter_Load(object sender, EventArgs e)
        {
            //标题栏右侧初始化
            lblConnectState.Text = "未连接";
            lblConnectState.ForeColor = Color.Gray;
            btnConnect.Text = "连接";
            btnConnect.ForeColor = Color.DimGray;
            lblLoginUser.Visible = false;
            btnLogin.Visible = true;
            btnExit.Visible = false;

            //订阅设备标签的单击事件
            foreach (Control c in panelDevList.Controls)
            {
                ULabel lblDev = c as ULabel;
                lblDev.Click += LblDev_Click;
            }
            //加载参数配置
            LoadParaSets();

            //加载通信配置
            LoadCommunicationSets();

            //初始化检测条件临界值
            InitAlarmSets();
            //存储按钮原始设置
            StoreOldBtnSets();
            //选择默认设备：1#
            SelectDevice(1);
            //初始化左边数据区信息
            InitDeviceData1();
            //初始化状态区信息
            InitStates();
            //采集区
            btnGet.UnableBtn();
            swAuto.Checked = true;
            //初始化数据监测区
            InitDevData2();
            //仪表与图表区初化
            InitMetersAndChart();
        }



        /// <summary>
        /// 设备标签的单击事件处理程序----设备选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblDev_Click(object? sender, EventArgs e)
        {
            ULabel lbl = sender as ULabel;
            if (lbl != null && lbl.Tag != null)
            {
                //选择的编号
                int devNo = Convert.ToInt32(lbl.Tag);
                //设备选择
                SelectDevice(devNo);
            }

        }

        //选择指定的设备
        private void SelectDevice(int devNo)
        {
            foreach (Control c in panelDevList.Controls)
            {
                ULabel lblDev = c as ULabel;
                if (lblDev.Tag != null)
                {
                    if (lblDev.Tag.ToString() == devNo.ToString())
                    {
                        curSelNo = devNo;
                        lblDev.BgColor = Color.DodgerBlue;
                        //切换参数名
                        lblRunTime.Tag = "RunTime-" + devNo;
                        lblLoadTime.Tag = "LoadTime-" + devNo;
                        lblStopTime.Tag = "StopTime-" + devNo;
                        lblStartTimes.Tag = "StartTimes-" + devNo;
                        lblLoadTimes.Tag = "LoadTimes-" + devNo;
                        lblBreakTimes.Tag = "BreakTimes-" + devNo;
                        swRunMode.Text = "RunMode-" + devNo;
                        jsRun.Text = "RunState-" + devNo;
                        jsLoad.Text = "LoadState-" + devNo;
                        jsBreak.Text = "BreakState-" + devNo;
                        dial_InPressure.Tag = "InPressure-" + devNo;
                        dial_OutPressure.Tag = "OutPressure-" + devNo;
                        dial_InFlow.Tag = "InFlow-" + devNo;
                        dial_OutFlow.Tag = "OutFlow-" + devNo;
                        dial_OutTemperature.Tag = "OutTemperature-" + devNo;
                        dial_MotorTemperature.Tag = "MotorTemperature-" + devNo;

                        meter_Pressure.Text = "Pressure-" + devNo;
                        meter_Temperature.Text = "Temperature-" + devNo;
                        meter_Flow.Text = "Flow-" + devNo;
                    }
                    else
                    {
                        lblDev.BgColor = Color.FromArgb(194, 207, 206);
                    }
                }
            }
        }

        //加载参数列表
        private void LoadParaSets()
        {
            string path = "AddressFile.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);//所有行
                if (lines.Length > 0)
                {
                    int devNo = 0;
                    List<ParaInfo> paras = null;
                    foreach (string line in lines)
                    {
                        if (line.Contains("DevNo"))
                        {
                            if (devNo > 0)
                            {
                                dicParaList.Add(devNo, paras);
                            }
                            string[] strs = line.Split(':');
                            devNo = strs[1].GetInt();
                            paras = new List<ParaInfo>();
                        }
                        else
                        {
                            string[] strs = line.Split(";");
                            ParaInfo para = new ParaInfo()
                            {
                                ParaName = strs[0] + "-" + devNo,
                                Address = strs[1].GetUShort(),
                                DataType = strs[2],
                                DCount = strs[3].GetInt()
                            };
                            paras.Add(para);
                        }
                    }
                    dicParaList.Add(devNo, paras);
                }
            }

        }

        //加载通信配置
        private void LoadCommunicationSets()
        {
            string path = "Communication.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);//所有行
                if (lines.Length > 0)
                {
                    string ip = lines[0].Split(':')[1];
                    int port = lines[1].Split(':')[1].GetInt();
                    CommonHelper.connSets = new CommunicationSet()
                    {
                        IP = ip,
                        Port = port
                    };
                }
            }
        }



        //初始化检测条件临界值
        private void InitAlarmSets()
        {
            dicAlarmSets.Add("OutPressure", new float[] { 10.0f, 100.0f });
            dicAlarmSets.Add("InPressure", new float[] { 0.9f, 1.1f });
            dicAlarmSets.Add("OutFlow", new float[] { 0.1f, 10.0f });
            dicAlarmSets.Add("InFlow", new float[] { 2.0f, 50.0f });
            dicAlarmSets.Add("OutTemperature", new float[] { 50.0f, 100.0f });
            dicAlarmSets.Add("MotorTemperature", new float[] { 40.0f, 150.0f });
        }


        //存储按钮原始设置
        private void StoreOldBtnSets()
        {
            btnStartDev.StoreUButton();
            btnStopDev.StoreUButton();
            btnLoadDev.StoreUButton();
            btnUnloadDev.StoreUButton();
            btnGet.StoreUButton();
        }
        //初始化左边数据区信息
        private void InitDeviceData1()
        {
            lblRunTime.Text = "0";
            lblLoadTime.Text = "0";
            lblStopTime.Text = "0";
            lblStartTimes.Text = "0";
            lblLoadTimes.Text = "0";
            lblBreakTimes.Text = "0";
            btnStartDev.UnableBtn();
            btnStopDev.UnableBtn();
            btnLoadDev.UnableBtn();
            btnUnloadDev.UnableBtn();
        }

        //初始化状态区信息
        private void InitStates()
        {
            swRunMode.Checked = true;//默认自动运行模式
            jsRun.IsOn = false;
            jsLoad.IsOn = false;
            jsBreak.IsOn = false;

            Utility.SetDefalutStateLabel(lblRunState01, true);
            Utility.SetDefalutStateLabel(lblBreakState01);
            Utility.SetDefalutStateLabel(lblRunState02, true);
            Utility.SetDefalutStateLabel(lblBreakState02);
            Utility.SetDefalutStateLabel(lblRunState03, true);
            Utility.SetDefalutStateLabel(lblBreakState03);
        }

        //初始化数据监测区
        private void InitDevData2()
        {
            foreach (Control c in gpDatas2.Controls)
            {
                if (c is UDial)
                {
                    UDial dial = (UDial)c;
                    dial.Value = 0.0f;
                    dial.ProgressColor = Color.DodgerBlue;
                    dial.ValueColor = Color.Gray;
                }
                else if (c is PictureBox)
                {
                    c.Visible = false;
                }
            }
            //报警图标相关的Tag值
            picAlarm_OutP.Tag = "0";
            picAlarm_InP.Tag = "1";
            picAlarm_OutT.Tag = "2";
            picAlarm_MotorT.Tag = "3";
            picAlarm_OutF.Tag = "4";
            picAlarm_InF.Tag = "5";
        }

        //仪表与图表区初化
        private void InitMetersAndChart()
        {
            meter_Pressure.Value = 0.0f;
            meter_Temperature.Value = 0.0f;
            meter_Flow.Value = 0.0f;
            chart1.Series.Clear();
            //添加默认序列
            AddDefaultSeries();
        }

        private void AddDefaultSeries()
        {
            AddSplineSeries("主管压力", "Pressure", Color.Gold);
            AddSplineSeries("主管温度", "Temperature", Color.DodgerBlue);
            AddSplineSeries("主管流量", "Flow", Color.SteelBlue);
        }

        //添加默认序列
        private void AddSplineSeries(string seriesName, string paraName, Color color)
        {
            Series series = new Series(seriesName);
            series.ChartType = SeriesChartType.Spline;//曲线图
            series.Tag = paraName;
            series.BorderWidth = 2;
            series.Color = color;
            series.XValueType = ChartValueType.DateTime;//x轴的值类型
            series.ChartArea = chart1.ChartAreas[0].Name;//图表区
            chart1.Series.Add(series);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog(this);
            if (this.Tag != null)
            {
                lblLoginUser.Visible = true;//显示账号标签
                lblLoginUser.Text = this.Tag.ToString();//显示账号
                btnLogin.Visible = false;//隐藏登录按钮
                btnExit.Visible = true;//显示退出按钮
            }
        }

        /// <summary>
        /// 通信连接与断开 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (CommonHelper.isLogin == false)
            {
                MessageHelper.Error("连接提示", "你还未登录系统，不能进行连接！");
                return;
            }
            if (CommonHelper.isConnected == false)
            {
                //显示连接窗口
                FrmConnection frmConnection = new FrmConnection();
                frmConnection.ShowDialog();
                if (CommonHelper.isConnected)
                {
                    //连接后的处理
                    lblConnectState.Text = "已连接";
                    lblConnectState.ForeColor = Color.DodgerBlue;
                    btnConnect.Text = "断开";
                    btnConnect.ForeColor = Color.Orange;
                    btnConnect.Image = Properties.Resources.duankai;
                    //获取主站对象
                    master = CommonHelper.master;
                    if (swAuto.Checked)
                    {
                        //启动采集
                        StartDataMonitor();
                        resetEvent.Set();
                    }
                }
            }
            else
            {
                //断开处理
                //关闭客户端连接
                CommonHelper.tcpClient.Close();
                CommonHelper.isConnected = false;//标识断开
                lblConnectState.Text = "未连接";
                lblConnectState.ForeColor = Color.Gray;
                btnConnect.Text = "连接";
                btnConnect.ForeColor = Color.DimGray;
                btnConnect.Image = Properties.Resources.lianjie;
            }
        }

        /// <summary>
        /// 文字与图标变成蓝色  或 红色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_MouseEnter(object sender, EventArgs e)
        {
            if (CommonHelper.isConnected == false)
            {
                btnConnect.Image = Properties.Resources.lianjie_blue;
                btnConnect.ForeColor = SystemColors.MenuHighlight;
            }
            else
            {
                btnConnect.Image = Properties.Resources.duankai_red;
                btnConnect.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// 文字与图标变成灰色  或 橙色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_MouseLeave(object sender, EventArgs e)
        {
            if (CommonHelper.isConnected == false)
            {
                btnConnect.Image = Properties.Resources.lianjie;
                btnConnect.ForeColor = Color.DimGray;
            }
            else
            {
                btnConnect.Image = Properties.Resources.duankai;
                btnConnect.ForeColor = Color.Orange;
            }
        }

        /// <summary>
        /// 自动采集与手动获取切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (swAuto.Checked)
            {
                //切换到自动采集
                btnGet.UnableBtn();
                resetEvent.Set();//恢复执行
            }
            else
            {
                //手动获取
                btnGet.EnableBtn();
                resetEvent.Reset();//暂停执行
            }
        }

        private void StartDataMonitor()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    if (CommonHelper.isConnected == false)
                    {
                        CommonHelper.master.Dispose();
                        break;
                    }
                    resetEvent.WaitOne();
                    await ReadAndLoadDatas();
                    await Task.Delay(1000);
                }
            });
        }

        private async Task ReadAndLoadDatas()
        {
            //设备数据
            ushort[] udatas = await master.ReadHoldingRegistersAsync(1, 0, 81);
            //状态数据：控制状态、故障状态
            bool[] states = await master.ReadCoilsAsync(1, 0, 9);
            //故障状态
            bool[] breakStates = await master.ReadInputsAsync(1, 0, 3);
            //解析与存储
            if (udatas.Length > 0)
            {
                foreach (int devNo in dicParaList.Keys)
                {
                    //数据相关的参数
                    var paras1 = dicParaList[devNo].Where(p => p.DataType != "bool").ToList();
                    DateTime curTime = DateTime.Now;
                    float flow = 0.0f;
                    float temperature = 0.0f;
                    float pressure = 0.00f;
                    foreach (ParaInfo para in paras1)
                    {
                        string paraName = para.ParaName;//参数名
                        ushort addr = para.Address;//地址
                        if (para.DataType == "uint")
                        {
                            ushort[] datas = udatas.Skip(addr).Take(2).ToArray();
                            uint data = Utility.GetUshortToUInt(datas);
                            if (dicDatas1.ContainsKey(paraName))
                                dicDatas1[paraName] = data;
                            else
                                dicDatas1.Add(paraName, data);
                        }
                        else if (para.DataType == "ushort")
                        {
                            ushort udata = udatas[addr];
                            if (dicDatas1.ContainsKey(paraName))
                                dicDatas1[paraName] = udata;
                            else
                                dicDatas1.Add(paraName, udata);
                        }
                        else if (para.DataType == "float")
                        {
                            ushort[] datas = udatas.Skip(addr).Take(2).ToArray();
                            float data = Utility.GetUshortToFloat(datas);
                            if (dicDatas2.ContainsKey(paraName))
                                dicDatas2[paraName] = data;
                            else
                                dicDatas2.Add(paraName, data);
                            if (paraName == "Pressure-" + devNo)
                                pressure = data;
                            else if (paraName == "Flow-" + devNo)
                                flow = data;
                            else if (paraName == "Temperature-" + devNo)
                                temperature = data;
                        }
                    }
                    //封装曲线数据
                    TrendData trendData = new TrendData()
                    {
                        CollectionTime = curTime,
                        Pressure = pressure,
                        Flow = flow,
                        Temperature = temperature
                    };
                    if (dicTrendDatas.ContainsKey(devNo))
                    {
                        dicTrendDatas[devNo].Add(trendData);
                        //容量保证，数量不超过100个
                        if (dicTrendDatas[devNo].Count > 100)
                            dicTrendDatas[devNo].RemoveAt(0);
                    }
                    else
                        dicTrendDatas.Add(devNo, new List<TrendData> { trendData });

                }
            }

            if (states.Length > 0)
            {
                foreach (int devNo in dicParaList.Keys)
                {
                    var paras = dicParaList[devNo].Where(p => p.DataType == "bool" && !p.ParaName.Contains("BreakState")).ToList();
                    foreach (var para in paras)
                    {
                        string paraName = para.ParaName;//参数名
                        ushort addr = para.Address;//地址
                        bool state = states[addr];//状态
                        if (dicStates.ContainsKey(paraName))
                        {
                            dicStates[paraName] = state;
                        }
                        else
                            dicStates.Add(paraName, state);
                    }
                }
            }

            if (breakStates.Length > 0)
            {
                foreach (int devNo in dicParaList.Keys)
                {
                    var paras = dicParaList[devNo].Where(p => p.DataType == "bool" && p.ParaName.Contains("BreakState")).ToList();
                    foreach (var para in paras)
                    {
                        string paraName = para.ParaName;//参数名
                        ushort addr = para.Address;//地址
                        bool state = breakStates[addr];//状态
                        if (dicStates.ContainsKey(paraName))
                        {
                            dicStates[paraName] = state;
                        }
                        else
                            dicStates.Add(paraName, state);
                    }
                }
            }


            //呈现处理
            this.Invoke(new Action(() =>
            {
                //数据区1呈现
                foreach (Control c in panel2.Controls)
                {
                    if (c is Label && c.Tag != null)
                    {
                        Label lblData = (Label)c;
                        string pName = lblData.Tag.ToString();//参数名
                        lblData.Text = dicDatas1[pName].ToString();
                    }
                }
                //状态呈现
                swRunMode.Checked = dicStates[swRunMode.Text];
                jsRun.IsOn = dicStates[jsRun.Text];
                jsLoad.IsOn = dicStates[jsLoad.Text];
                jsBreak.IsOn = dicStates[jsBreak.Text];

                //设备的运行与故障统计呈现
                ShowDevStates(lblRunState01, lblBreakState01);
                ShowDevStates(lblRunState02, lblBreakState02);
                ShowDevStates(lblRunState03, lblBreakState03);

                //加载控制按钮的启用与禁用状态
                if (swRunMode.Checked)
                {
                    btnStartDev.UnableBtn();
                    btnStopDev.UnableBtn();
                    btnLoadDev.UnableBtn();
                    btnUnloadDev.UnableBtn();
                }
                else
                {
                    //手动模式
                    if (jsRun.IsOn)
                    {
                        btnStartDev.UnableBtn();
                        btnStopDev.EnableBtn();
                        if (jsLoad.IsOn)
                        {
                            btnLoadDev.UnableBtn();
                            btnUnloadDev.EnableBtn();
                        }
                        else
                        {
                            btnLoadDev.EnableBtn();
                            btnUnloadDev.UnableBtn();
                        }
                    }
                    else
                    {
                        btnStartDev.EnableBtn();
                        btnStopDev.UnableBtn();
                        btnLoadDev.UnableBtn();
                        btnUnloadDev.UnableBtn();
                    }
                }

                //自动运行模式时，自动控制
                if (swRunMode.Checked)
                {
                    float curPressure = dicDatas2["Pressure-" + curSelNo];//主管压力值
                    if (curPressure < minPressure)//自动加载---产气
                    {
                        if (jsRun.IsOn == false)
                            SetDeviceState(true);//启动设备
                        SetLoadState(true);
                    }
                    else if (curPressure >= maxPressure)//自动卸载--停止产气
                    {
                        SetLoadState(false);
                        SetDeviceState(false);
                    }
                }

                //呈现数据区2的数据
                foreach (Control c in gpDatas2.Controls)
                {
                    if (c is UDial)
                    {
                        UDial dial = (UDial)c;
                        string? paraName = dial.Tag?.ToString();
                        if (paraName != null)
                        {
                            dial.Value = dicDatas2[paraName];//取值并设置Value
                        }
                    }
                }
                //检测--当前设备的这6个数据的状态
                CheckDatas();

                foreach (Control c in gpDatas2.Controls)
                {
                    if (c is PictureBox)
                    {
                        //报警状态处理-----异常，显示报警灯图标
                        PictureBox pic = (PictureBox)c;
                        if (pic.Tag != null)
                        {
                            int index = pic.Tag.ToString().GetInt();
                            int result = checkResults[index];//取检测状态值
                            if (result != 1)
                            {
                                pic.Visible = true;
                                if (result == 0)
                                {
                                    pic.Image = Properties.Resources.alarm_low;
                                }
                                else if (result == 2)
                                {
                                    pic.Image = Properties.Resources.alarm_high;
                                }
                            }
                            else
                            {
                                pic.Visible = false;//隐藏报警灯图标
                            }
                            ShowAlarm(result, index);
                        }

                    }
                }


                //仪表呈现
                meter_Flow.Value = dicDatas2[meter_Flow.Text];
                meter_Pressure.Value = dicDatas2[meter_Pressure.Text];
                meter_Temperature.Value = dicDatas2[meter_Temperature.Text];

                //刷新曲线图
                List<TrendData> list = new List<TrendData>();
                int actCount = dicTrendDatas[curSelNo].Count;//实际的曲线数据的数目
                int start = 0, end = 0;
                start = actCount <= 20 ? 0 : actCount - 20;//开始索引
                end = actCount;//结束索引
                for (int i = start; i < end; i++)
                {
                    TrendData data = dicTrendDatas[curSelNo][i];//取当前设备第i个索引处的数据
                    list.Add(data);
                }

                foreach (var series in chart1.Series)
                {
                    string paraName = series.Tag.ToString();
                    series.Points.DataBind(list, "CollectionTime", paraName, "");
                }
            }));
        }


        private void btnGet_Click(object sender, EventArgs e)
        {
            ReadAndLoadDatas();
        }

        private void ShowDevStates(Label lblRun, Label lblBreak)
        {
            string runPara = lblRun.Tag.ToString();
            string breakPara = lblBreak.Tag.ToString();
            bool blRun = dicStates[runPara];//运行状态
            if (blRun)
            {
                lblRun.Text = "运行中";
                lblRun.ForeColor = Color.Orange;
            }
            else
            {
                lblRun.Text = "已停止";
                lblRun.ForeColor = Color.Gray;
            }

            bool breakState = dicStates[breakPara];//故障状态
            if (breakState)
            {
                lblBreak.Text = "故障";
                lblBreak.ForeColor = Color.Red;
            }
            else
            {
                if (blRun == false)
                {
                    lblBreak.Text = "无";
                    lblBreak.ForeColor = Color.Gray;
                }
                else
                {
                    lblBreak.Text = "正常";
                    lblBreak.ForeColor = Color.DodgerBlue;
                }

            }
        }

        //检测方法
        private void CheckDatas()
        {
            int result_outP = Utility.CheckData(dial_OutPressure.Value, dicAlarmSets["OutPressure"]);
            int result_inP = Utility.CheckData(dial_InPressure.Value, dicAlarmSets["InPressure"]);
            int result_outT = Utility.CheckData(dial_OutTemperature.Value, dicAlarmSets["OutTemperature"]);
            int result_motorT = Utility.CheckData(dial_MotorTemperature.Value, dicAlarmSets["MotorTemperature"]);
            int result_outF = -1;
            int result_inF = -1;
            if (jsRun.IsOn)
            {
                result_outF = Utility.CheckData(dial_OutFlow.Value, dicAlarmSets["OutFlow"]);
                result_inF = Utility.CheckData(dial_InFlow.Value, dicAlarmSets["InFlow"]);
            }
            //检测结果存储
            checkResults[0] = result_outP;
            checkResults[1] = result_inP;
            checkResults[2] = result_outT;
            checkResults[3] = result_motorT;
            checkResults[4] = result_outF;
            checkResults[5] = result_inF;
        }

        /// <summary>
        /// 检测结果显示处理----圆形进度条的颜色
        /// </summary>
        /// <param name="result"></param>
        /// <param name="index"></param>
        private void ShowAlarm(int result, int index)
        {
            UDial dial = null;
            switch (index)
            {
                case 0:
                    dial = dial_OutPressure;
                    break;
                case 1:
                    dial = dial_InPressure;
                    break;
                case 2:
                    dial = dial_OutTemperature;
                    break;
                case 3:
                    dial = dial_MotorTemperature;
                    break;
                case 4:
                    dial = dial_OutFlow;
                    break;
                case 5:
                    dial = dial_InFlow;
                    break;
            }
            switch (result)
            {
                case 0:
                    dial.ProgressColor = Color.LightBlue;
                    dial.ValueColor = Color.SkyBlue;
                    break;
                case 1:
                    dial.ProgressColor = Color.DodgerBlue;
                    dial.ValueColor = Color.DimGray;
                    break;
                case 2:
                    dial.ProgressColor = Color.Orange;
                    dial.ValueColor = Color.OrangeRed;
                    break;
            }
        }

        private void btnStartDev_Click(object sender, EventArgs e)
        {
            SetDeviceState(true);
        }

        private void btnStopDev_Click(object sender, EventArgs e)
        {
            SetDeviceState(false);
        }

        //修改设备的启停
        private void SetDeviceState(bool state)
        {
            if (!CommonHelper.isLogin)
            {
                MessageHelper.Error("错误提示", "当前未登录！");
                return;
            }
            if (!CommonHelper.isConnected)
            {
                MessageHelper.Error("错误提示", "当前未连接！");
                return;
            }
            ushort addr = dicParaList[curSelNo].Find(p => p.ParaName == "RunState-" + curSelNo).Address;
            if (state == false && jsLoad.IsOn)
            {
                //先卸载
                SetLoadState(false);
            }
            master.WriteSingleCoil(1, addr, state);//修改设备状态
            dicStates["RunState-" + curSelNo] = state;//更新当前设备的状态
        }

        /// <summary>
        /// 设备加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadDev_Click(object sender, EventArgs e)
        {
            SetLoadState(true);
        }

        /// <summary>
        /// 设备卸载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnloadDev_Click(object sender, EventArgs e)
        {
            SetLoadState(false);
        }

        //修改设备的加载状态
        private void SetLoadState(bool state)
        {
            if (!CommonHelper.isLogin)
            {
                MessageHelper.Error("错误提示", "当前未登录！");
                return;
            }
            if (!CommonHelper.isConnected)
            {
                MessageHelper.Error("错误提示", "当前未连接！");
                return;
            }
            //加载状态的地址
            ushort addr = dicParaList[curSelNo].Find(p => p.ParaName == "LoadState-" + curSelNo).Address;
            master.WriteSingleCoil(1, addr, state);//修改设备的加载状态
            if (state == false)
            {
                //进气、排气流量数据立即降低至0
                string paraName1 = dial_InFlow.Tag.ToString();
                string paraName2 = dial_OutFlow.Tag.ToString();
                //获取这两个的数据访问地址
                ushort inF_addr = dicParaList[curSelNo].Find(p => p.ParaName == paraName1).Address;
                ushort outF_addr = dicParaList[curSelNo].Find(p => p.ParaName == paraName2).Address;
                ushort[] values = Utility.GetFloatToUshorts(0.0f);
                master.WriteMultipleRegisters(1, inF_addr, values);
                master.WriteMultipleRegisters(1, outF_addr, values);
                dicDatas2[paraName1] = 0.0f;
                dicDatas2[paraName2] = 0.0f;
            }

            dicStates["LoadState-" + curSelNo] = state;//更新当前设备的加载状态
        }






        /// <summary>
        /// 运行模式的切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swRunMode_Click(object sender, EventArgs e)
        {
            if (swRunMode.Checked)
            {
                SetRunMode(true);//自动模式
            }
            else
            {
                SetRunMode(false);//手动模式
            }
        }

        private void SetRunMode(bool state)
        {
            if (!CommonHelper.isLogin)
            {
                MessageHelper.Error("错误提示", "当前未登录！");
                return;
            }
            if (!CommonHelper.isConnected)
            {
                MessageHelper.Error("错误提示", "当前未连接！");
                return;
            }
            //加载运行模式的地址
            ushort addr = dicParaList[curSelNo].Find(p => p.ParaName == "RunMode-" + curSelNo).Address;
            master.WriteSingleCoil(1, addr, state);//修改设备的运行模式
            dicStates["RunMode-" + curSelNo] = state;
        }

        /// <summary>
        /// 系统退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMonitorCenter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageHelper.Question("退出提示","你确定要退出空压机监控系统吗？")==DialogResult.OK)
            {
                if(CommonHelper.isConnected)
                {
                    CommonHelper.tcpClient.Close();
                    CommonHelper.master.Dispose();
                    CommonHelper.isConnected = false;
                    resetEvent.Close();
                }
                Application.ExitThread();
            }
            else 
                e.Cancel = true;
        }
    }
}
