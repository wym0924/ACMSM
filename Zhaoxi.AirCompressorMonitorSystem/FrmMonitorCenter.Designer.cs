namespace Zhaoxi.AirCompressorMonitorSystem
{
    partial class FrmMonitorCenter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonitorCenter));
            uLabel1 = new Zhaoxi.CustControls.ULabel();
            pictureBox1 = new PictureBox();
            uGroupPanel41 = new Zhaoxi.CustControls01.UGroupPanel4();
            label16 = new Label();
            label15 = new Label();
            swAuto = new Zhaoxi.CustControls.UEllipseSwitch();
            btnGet = new Zhaoxi.CustControls.UButton();
            panelDevList = new Panel();
            uLabel4 = new Zhaoxi.CustControls.ULabel();
            uLabel3 = new Zhaoxi.CustControls.ULabel();
            uLabel2 = new Zhaoxi.CustControls.ULabel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnUnloadDev = new Zhaoxi.CustControls.UButton();
            btnLoadDev = new Zhaoxi.CustControls.UButton();
            btnStopDev = new Zhaoxi.CustControls.UButton();
            btnStartDev = new Zhaoxi.CustControls.UButton();
            lblBreakTimes = new Label();
            lblStopTime = new Label();
            lblLoadTimes = new Label();
            lblLoadTime = new Label();
            lblStartTimes = new Label();
            lblRunTime = new Label();
            label13 = new Label();
            label9 = new Label();
            label12 = new Label();
            label7 = new Label();
            label11 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            jsBreak = new Zhaoxi.CustControls.UJogSwitch();
            jsLoad = new Zhaoxi.CustControls.UJogSwitch();
            jsRun = new Zhaoxi.CustControls.UJogSwitch();
            swRunMode = new Zhaoxi.CustControls.UEllipseSwitch();
            label14 = new Label();
            label10 = new Label();
            label8 = new Label();
            label3 = new Label();
            uGroupPanel42 = new Zhaoxi.CustControls01.UGroupPanel4();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            meter_Flow = new Zhaoxi.CustControls.UCircleMeter();
            meter_Temperature = new Zhaoxi.CustControls.UMeter();
            meter_Pressure = new Zhaoxi.CustControls.UMeter();
            label17 = new Label();
            gpDatas2 = new Zhaoxi.CustControls01.UGroupPanel4();
            picAlarm_MotorT = new PictureBox();
            picAlarm_OutT = new PictureBox();
            picAlarm_InF = new PictureBox();
            picAlarm_OutF = new PictureBox();
            picAlarm_InP = new PictureBox();
            picAlarm_OutP = new PictureBox();
            dial_InFlow = new Zhaoxi.WinNewCustControls.UDial();
            dial_MotorTemperature = new Zhaoxi.WinNewCustControls.UDial();
            dial_InPressure = new Zhaoxi.WinNewCustControls.UDial();
            dial_OutFlow = new Zhaoxi.WinNewCustControls.UDial();
            dial_OutTemperature = new Zhaoxi.WinNewCustControls.UDial();
            dial_OutPressure = new Zhaoxi.WinNewCustControls.UDial();
            uPanel1 = new Zhaoxi.CustControls.UPanel();
            label6 = new Label();
            label5 = new Label();
            lblBreakState03 = new Label();
            lblBreakState02 = new Label();
            lblRunState03 = new Label();
            lblBreakState01 = new Label();
            lblRunState02 = new Label();
            lblRunState01 = new Label();
            label4 = new Label();
            label1 = new Label();
            lblConnectState = new Label();
            btnConnect = new Button();
            lblLoginUser = new Label();
            btnExit = new Button();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uGroupPanel41.SuspendLayout();
            panelDevList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            uGroupPanel42.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            gpDatas2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAlarm_MotorT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_OutT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_InF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_OutF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_InP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_OutP).BeginInit();
            uPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uLabel1
            // 
            uLabel1.BgColor = Color.FromArgb(180, 200, 202);
            uLabel1.Font = new Font("幼圆", 12F, FontStyle.Bold);
            uLabel1.ForeColor = Color.DarkBlue;
            uLabel1.Location = new Point(35, 12);
            uLabel1.Name = "uLabel1";
            uLabel1.Padding = new Padding(0, 0, 40, 0);
            uLabel1.Radius = 20;
            uLabel1.Size = new Size(361, 45);
            uLabel1.TabIndex = 1;
            uLabel1.Text = "朝夕教育-空压机监控系统";
            uLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // uGroupPanel41
            // 
            uGroupPanel41.BackColor = Color.Transparent;
            uGroupPanel41.Background = Color.FromArgb(226, 234, 237);
            uGroupPanel41.Controls.Add(label16);
            uGroupPanel41.Controls.Add(label15);
            uGroupPanel41.Controls.Add(swAuto);
            uGroupPanel41.Controls.Add(btnGet);
            uGroupPanel41.CornerRadius = 5;
            uGroupPanel41.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel41.Location = new Point(461, 123);
            uGroupPanel41.Name = "uGroupPanel41";
            uGroupPanel41.Size = new Size(300, 141);
            uGroupPanel41.TabIndex = 6;
            uGroupPanel41.TabStop = false;
            uGroupPanel41.Text = "采集模式";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("黑体", 9.75F, FontStyle.Bold);
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(31, 101);
            label16.Name = "label16";
            label16.Size = new Size(84, 17);
            label16.TabIndex = 10;
            label16.Text = "自动采集";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("黑体", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(32, 58);
            label15.Name = "label15";
            label15.Size = new Size(84, 17);
            label15.TabIndex = 10;
            label15.Text = "手动采集";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // swAuto
            // 
            swAuto.Checked = true;
            swAuto.Location = new Point(185, 96);
            swAuto.Name = "swAuto";
            swAuto.Size = new Size(75, 30);
            swAuto.TabIndex = 11;
            swAuto.Text = "uEllipseSwitch1";
            swAuto.Texts = null;
            swAuto.TrueColor = Color.Orange;
            swAuto.CheckedChanged += swAuto_CheckedChanged;
            // 
            // btnGet
            // 
            btnGet.BgColor = Color.WhiteSmoke;
            btnGet.BorderWidth = 1;
            btnGet.FlatAppearance.BorderSize = 0;
            btnGet.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGet.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGet.FlatStyle = FlatStyle.Flat;
            btnGet.FocusBgColor = Color.White;
            btnGet.FocusForeColor = Color.Black;
            btnGet.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnGet.ForeColor = Color.Gray;
            btnGet.Location = new Point(185, 49);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(75, 35);
            btnGet.TabIndex = 21;
            btnGet.Text = "获取";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // panelDevList
            // 
            panelDevList.Controls.Add(uLabel4);
            panelDevList.Controls.Add(uLabel3);
            panelDevList.Controls.Add(uLabel2);
            panelDevList.Location = new Point(19, 85);
            panelDevList.Name = "panelDevList";
            panelDevList.Size = new Size(155, 241);
            panelDevList.TabIndex = 7;
            // 
            // uLabel4
            // 
            uLabel4.BgColor = Color.FromArgb(194, 207, 206);
            uLabel4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            uLabel4.ForeColor = Color.White;
            uLabel4.Location = new Point(16, 167);
            uLabel4.Name = "uLabel4";
            uLabel4.Radius = 20;
            uLabel4.Size = new Size(130, 40);
            uLabel4.TabIndex = 0;
            uLabel4.Tag = "3";
            uLabel4.Text = "3#空压机";
            uLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uLabel3
            // 
            uLabel3.BgColor = Color.FromArgb(194, 207, 206);
            uLabel3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            uLabel3.ForeColor = Color.White;
            uLabel3.Location = new Point(16, 98);
            uLabel3.Name = "uLabel3";
            uLabel3.Radius = 20;
            uLabel3.Size = new Size(130, 40);
            uLabel3.TabIndex = 0;
            uLabel3.Tag = "2";
            uLabel3.Text = "2#空压机";
            uLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uLabel2
            // 
            uLabel2.BgColor = Color.DodgerBlue;
            uLabel2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            uLabel2.ForeColor = Color.White;
            uLabel2.Location = new Point(16, 31);
            uLabel2.Name = "uLabel2";
            uLabel2.Radius = 20;
            uLabel2.Size = new Size(130, 40);
            uLabel2.TabIndex = 0;
            uLabel2.Tag = "1";
            uLabel2.Text = "1#空压机";
            uLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dev_img;
            pictureBox2.Location = new Point(180, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 240);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnUnloadDev);
            panel2.Controls.Add(btnLoadDev);
            panel2.Controls.Add(btnStopDev);
            panel2.Controls.Add(btnStartDev);
            panel2.Controls.Add(lblBreakTimes);
            panel2.Controls.Add(lblStopTime);
            panel2.Controls.Add(lblLoadTimes);
            panel2.Controls.Add(lblLoadTime);
            panel2.Controls.Add(lblStartTimes);
            panel2.Controls.Add(lblRunTime);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(19, 339);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 231);
            panel2.TabIndex = 7;
            // 
            // btnUnloadDev
            // 
            btnUnloadDev.BgColor = Color.Gray;
            btnUnloadDev.BorderColor = Color.LightGray;
            btnUnloadDev.FlatAppearance.BorderSize = 0;
            btnUnloadDev.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUnloadDev.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUnloadDev.FlatStyle = FlatStyle.Flat;
            btnUnloadDev.FocusBgColor = Color.DimGray;
            btnUnloadDev.FocusForeColor = Color.White;
            btnUnloadDev.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnUnloadDev.ForeColor = Color.White;
            btnUnloadDev.Location = new Point(246, 164);
            btnUnloadDev.Name = "btnUnloadDev";
            btnUnloadDev.Size = new Size(154, 38);
            btnUnloadDev.TabIndex = 21;
            btnUnloadDev.Text = "设备卸载";
            btnUnloadDev.UseVisualStyleBackColor = true;
            btnUnloadDev.Click += btnUnloadDev_Click;
            // 
            // btnLoadDev
            // 
            btnLoadDev.BgColor = Color.Chocolate;
            btnLoadDev.BgColor2 = Color.Orange;
            btnLoadDev.BorderColor = Color.LightGray;
            btnLoadDev.BorderWidth = 1;
            btnLoadDev.FlatAppearance.BorderSize = 0;
            btnLoadDev.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLoadDev.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLoadDev.FlatStyle = FlatStyle.Flat;
            btnLoadDev.FocusBgColor = Color.Orange;
            btnLoadDev.FocusForeColor = Color.White;
            btnLoadDev.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnLoadDev.ForeColor = Color.White;
            btnLoadDev.Location = new Point(246, 120);
            btnLoadDev.Name = "btnLoadDev";
            btnLoadDev.Size = new Size(154, 38);
            btnLoadDev.TabIndex = 21;
            btnLoadDev.Text = "设备加载";
            btnLoadDev.UseVisualStyleBackColor = true;
            btnLoadDev.Click += btnLoadDev_Click;
            // 
            // btnStopDev
            // 
            btnStopDev.BgColor = Color.Gray;
            btnStopDev.BorderColor = Color.LightGray;
            btnStopDev.FlatAppearance.BorderSize = 0;
            btnStopDev.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStopDev.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStopDev.FlatStyle = FlatStyle.Flat;
            btnStopDev.FocusBgColor = Color.DimGray;
            btnStopDev.FocusForeColor = Color.White;
            btnStopDev.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnStopDev.ForeColor = Color.White;
            btnStopDev.Location = new Point(246, 58);
            btnStopDev.Name = "btnStopDev";
            btnStopDev.Size = new Size(154, 38);
            btnStopDev.TabIndex = 21;
            btnStopDev.Text = "停止设备";
            btnStopDev.UseVisualStyleBackColor = true;
            btnStopDev.Click += btnStopDev_Click;
            // 
            // btnStartDev
            // 
            btnStartDev.BgColor = Color.Chocolate;
            btnStartDev.BgColor2 = Color.Orange;
            btnStartDev.BorderColor = Color.LightGray;
            btnStartDev.BorderWidth = 1;
            btnStartDev.FlatAppearance.BorderSize = 0;
            btnStartDev.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStartDev.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStartDev.FlatStyle = FlatStyle.Flat;
            btnStartDev.FocusBgColor = Color.Orange;
            btnStartDev.FocusForeColor = Color.White;
            btnStartDev.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnStartDev.ForeColor = Color.White;
            btnStartDev.Location = new Point(246, 14);
            btnStartDev.Name = "btnStartDev";
            btnStartDev.Size = new Size(154, 38);
            btnStartDev.TabIndex = 21;
            btnStartDev.Text = "启动设备";
            btnStartDev.UseVisualStyleBackColor = true;
            btnStartDev.Click += btnStartDev_Click;
            // 
            // lblBreakTimes
            // 
            lblBreakTimes.AutoSize = true;
            lblBreakTimes.BackColor = Color.Transparent;
            lblBreakTimes.Font = new Font("黑体", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblBreakTimes.ForeColor = Color.SteelBlue;
            lblBreakTimes.Location = new Point(146, 179);
            lblBreakTimes.Name = "lblBreakTimes";
            lblBreakTimes.Size = new Size(23, 23);
            lblBreakTimes.TabIndex = 5;
            lblBreakTimes.Text = "5";
            // 
            // lblStopTime
            // 
            lblStopTime.AutoSize = true;
            lblStopTime.BackColor = Color.Transparent;
            lblStopTime.Font = new Font("黑体", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblStopTime.ForeColor = Color.SteelBlue;
            lblStopTime.Location = new Point(27, 179);
            lblStopTime.Name = "lblStopTime";
            lblStopTime.Size = new Size(36, 23);
            lblStopTime.TabIndex = 10;
            lblStopTime.Text = "10";
            // 
            // lblLoadTimes
            // 
            lblLoadTimes.AutoSize = true;
            lblLoadTimes.BackColor = Color.Transparent;
            lblLoadTimes.Font = new Font("黑体", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblLoadTimes.ForeColor = Color.SteelBlue;
            lblLoadTimes.Location = new Point(140, 115);
            lblLoadTimes.Name = "lblLoadTimes";
            lblLoadTimes.Size = new Size(36, 23);
            lblLoadTimes.TabIndex = 14;
            lblLoadTimes.Text = "14";
            // 
            // lblLoadTime
            // 
            lblLoadTime.AutoSize = true;
            lblLoadTime.BackColor = Color.Transparent;
            lblLoadTime.Font = new Font("黑体", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblLoadTime.ForeColor = Color.SteelBlue;
            lblLoadTime.Location = new Point(27, 115);
            lblLoadTime.Name = "lblLoadTime";
            lblLoadTime.Size = new Size(36, 23);
            lblLoadTime.TabIndex = 10;
            lblLoadTime.Text = "25";
            // 
            // lblStartTimes
            // 
            lblStartTimes.AutoSize = true;
            lblStartTimes.BackColor = Color.Transparent;
            lblStartTimes.Font = new Font("黑体", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblStartTimes.ForeColor = Color.SteelBlue;
            lblStartTimes.Location = new Point(140, 52);
            lblStartTimes.Name = "lblStartTimes";
            lblStartTimes.Size = new Size(36, 23);
            lblStartTimes.TabIndex = 20;
            lblStartTimes.Text = "20";
            // 
            // lblRunTime
            // 
            lblRunTime.AutoSize = true;
            lblRunTime.BackColor = Color.Transparent;
            lblRunTime.Font = new Font("黑体", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblRunTime.ForeColor = Color.SteelBlue;
            lblRunTime.Location = new Point(27, 52);
            lblRunTime.Name = "lblRunTime";
            lblRunTime.Size = new Size(36, 23);
            lblRunTime.TabIndex = 10;
            lblRunTime.Text = "40";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("黑体", 9F);
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(129, 153);
            label13.Name = "label13";
            label13.Size = new Size(71, 15);
            label13.TabIndex = 10;
            label13.Text = "故障次数";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("黑体", 9F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(16, 153);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 10;
            label9.Text = "停机时间";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("黑体", 9F);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(129, 89);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 10;
            label12.Text = "加载次数";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("黑体", 9F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(16, 89);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 10;
            label7.Text = "加载时间";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("黑体", 9F);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(129, 26);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 10;
            label11.Text = "启动次数";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("黑体", 9F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(16, 26);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 10;
            label2.Text = "运行时间";
            // 
            // panel3
            // 
            panel3.Controls.Add(jsBreak);
            panel3.Controls.Add(jsLoad);
            panel3.Controls.Add(jsRun);
            panel3.Controls.Add(swRunMode);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(19, 590);
            panel3.Name = "panel3";
            panel3.Size = new Size(417, 135);
            panel3.TabIndex = 7;
            // 
            // jsBreak
            // 
            jsBreak.BackColor = Color.Transparent;
            jsBreak.BorderWidth = 2;
            jsBreak.IsOn = true;
            jsBreak.Location = new Point(333, 61);
            jsBreak.Name = "jsBreak";
            jsBreak.OffColor = Color.Gray;
            jsBreak.OnColor = Color.Red;
            jsBreak.Size = new Size(48, 48);
            jsBreak.TabIndex = 12;
            jsBreak.Text = "uJogSwitch1";
            // 
            // jsLoad
            // 
            jsLoad.BackColor = Color.Transparent;
            jsLoad.BorderWidth = 2;
            jsLoad.IsOn = true;
            jsLoad.Location = new Point(233, 59);
            jsLoad.Name = "jsLoad";
            jsLoad.OffColor = Color.Gray;
            jsLoad.OnColor = Color.Orange;
            jsLoad.Size = new Size(48, 48);
            jsLoad.TabIndex = 12;
            jsLoad.Text = "uJogSwitch1";
            // 
            // jsRun
            // 
            jsRun.BackColor = Color.Transparent;
            jsRun.BorderWidth = 2;
            jsRun.Location = new Point(128, 61);
            jsRun.Name = "jsRun";
            jsRun.OffColor = Color.Gray;
            jsRun.OnColor = Color.LightSeaGreen;
            jsRun.Size = new Size(48, 48);
            jsRun.TabIndex = 12;
            jsRun.Text = "uJogSwitch1";
            // 
            // swRunMode
            // 
            swRunMode.Checked = true;
            swRunMode.Location = new Point(11, 69);
            swRunMode.Name = "swRunMode";
            swRunMode.Size = new Size(86, 38);
            swRunMode.TabIndex = 11;
            swRunMode.Text = "uEllipseSwitch1";
            swRunMode.Texts = new string[]
    {
    "自动",
    "手动"
    };
            swRunMode.TrueColor = Color.DodgerBlue;
            swRunMode.Click += swRunMode_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("黑体", 9F);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(321, 25);
            label14.Name = "label14";
            label14.Size = new Size(79, 15);
            label14.TabIndex = 10;
            label14.Text = "正常/故障";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("黑体", 9F);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(221, 25);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 10;
            label10.Text = "加载/卸载";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("黑体", 9F);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(121, 25);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 10;
            label8.Text = "运行/停止";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("黑体", 9F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(16, 25);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 10;
            label3.Text = "运行模式";
            // 
            // uGroupPanel42
            // 
            uGroupPanel42.BackColor = Color.Transparent;
            uGroupPanel42.Background = Color.FromArgb(226, 234, 237);
            uGroupPanel42.Controls.Add(chart1);
            uGroupPanel42.Controls.Add(meter_Flow);
            uGroupPanel42.Controls.Add(meter_Temperature);
            uGroupPanel42.Controls.Add(meter_Pressure);
            uGroupPanel42.Controls.Add(label17);
            uGroupPanel42.CornerRadius = 5;
            uGroupPanel42.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel42.Location = new Point(785, 122);
            uGroupPanel42.Name = "uGroupPanel42";
            uGroupPanel42.Size = new Size(670, 610);
            uGroupPanel42.TabIndex = 6;
            uGroupPanel42.TabStop = false;
            uGroupPanel42.Text = "仪表与实时曲线图";
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chart1.BackColor = Color.Transparent;
            chart1.BackImageTransparentColor = Color.Transparent;
            chart1.BackSecondaryColor = Color.Transparent;
            chart1.BorderlineColor = Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.ForeColor = Color.FromArgb(125, 140, 166);
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX.LineColor = Color.LightGray;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.ForeColor = Color.Gray;
            chartArea1.AxisY.LineColor = Color.LightGray;
            chartArea1.AxisY.LogarithmBase = 50D;
            chartArea1.AxisY.MajorGrid.LineColor = Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = Color.Transparent;
            chartArea1.BorderColor = Color.LightGray;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 88F;
            chartArea1.InnerPlotPosition.Width = 88F;
            chartArea1.InnerPlotPosition.X = 5F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 6F;
            chartArea1.Position.Y = 3F;
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(6, 298);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = Color.FromArgb(255, 128, 0);
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series.Add(series1);
            chart1.Size = new Size(658, 293);
            chart1.TabIndex = 11;
            chart1.Text = "chart1";
            // 
            // meter_Flow
            // 
            meter_Flow.BackColor = Color.Transparent;
            meter_Flow.FillColor = Color.DodgerBlue;
            meter_Flow.Location = new Point(472, 46);
            meter_Flow.MaxValue = 100D;
            meter_Flow.MinValue = 0D;
            meter_Flow.Name = "meter_Flow";
            meter_Flow.NeedleColor = Color.Linen;
            meter_Flow.ScaleDivisions = 11;
            meter_Flow.ScaleSubDivisions = 4;
            meter_Flow.Size = new Size(165, 158);
            meter_Flow.TabIndex = 2;
            meter_Flow.Text = "uCircleMeter1";
            meter_Flow.Value = 30D;
            meter_Flow.ViewGlass = true;
            // 
            // meter_Temperature
            // 
            meter_Temperature.Background = Color.White;
            meter_Temperature.CenterElipseColor = Color.DodgerBlue;
            meter_Temperature.Header = "主管温度";
            meter_Temperature.HeaderColor = Color.FromArgb(3, 94, 173);
            meter_Temperature.Location = new Point(242, 50);
            meter_Temperature.MinCount = 10;
            meter_Temperature.Name = "meter_Temperature";
            meter_Temperature.PointColor = Color.RoyalBlue;
            meter_Temperature.ScaleLineColor = Color.DimGray;
            meter_Temperature.ScaleValueColor = Color.DimGray;
            meter_Temperature.Size = new Size(188, 188);
            meter_Temperature.SurroundColor = Color.FromArgb(0, 33, 97, 216);
            meter_Temperature.TabIndex = 1;
            meter_Temperature.Text = "uMeter1";
            meter_Temperature.Unit = "℃";
            meter_Temperature.UnitColor = Color.FromArgb(3, 94, 173);
            meter_Temperature.Value = 45.8D;
            // 
            // meter_Pressure
            // 
            meter_Pressure.Background = Color.White;
            meter_Pressure.CenterElipseColor = Color.Gold;
            meter_Pressure.DCount = 2;
            meter_Pressure.Header = "主管压力";
            meter_Pressure.HeaderColor = Color.FromArgb(3, 94, 173);
            meter_Pressure.Location = new Point(23, 50);
            meter_Pressure.MaxCount = 5;
            meter_Pressure.MaxValue = 50D;
            meter_Pressure.MinCount = 10;
            meter_Pressure.Name = "meter_Pressure";
            meter_Pressure.PointColor = Color.Orange;
            meter_Pressure.ScaleLineColor = Color.DimGray;
            meter_Pressure.ScaleValueColor = Color.DimGray;
            meter_Pressure.Size = new Size(188, 188);
            meter_Pressure.SurroundColor = Color.FromArgb(0, 33, 97, 216);
            meter_Pressure.TabIndex = 1;
            meter_Pressure.Text = "uMeter1";
            meter_Pressure.Unit = "Bar";
            meter_Pressure.UnitColor = Color.FromArgb(3, 94, 173);
            meter_Pressure.Value = 7.65D;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label17.ForeColor = Color.FromArgb(3, 94, 173);
            label17.Location = new Point(521, 207);
            label17.Name = "label17";
            label17.Size = new Size(69, 20);
            label17.TabIndex = 10;
            label17.Text = "主管流量";
            // 
            // gpDatas2
            // 
            gpDatas2.BackColor = Color.Transparent;
            gpDatas2.Background = Color.FromArgb(226, 234, 237);
            gpDatas2.Controls.Add(picAlarm_MotorT);
            gpDatas2.Controls.Add(picAlarm_OutT);
            gpDatas2.Controls.Add(picAlarm_InF);
            gpDatas2.Controls.Add(picAlarm_OutF);
            gpDatas2.Controls.Add(picAlarm_InP);
            gpDatas2.Controls.Add(picAlarm_OutP);
            gpDatas2.Controls.Add(dial_InFlow);
            gpDatas2.Controls.Add(dial_MotorTemperature);
            gpDatas2.Controls.Add(dial_InPressure);
            gpDatas2.Controls.Add(dial_OutFlow);
            gpDatas2.Controls.Add(dial_OutTemperature);
            gpDatas2.Controls.Add(dial_OutPressure);
            gpDatas2.CornerRadius = 5;
            gpDatas2.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            gpDatas2.Location = new Point(461, 279);
            gpDatas2.Name = "gpDatas2";
            gpDatas2.Size = new Size(300, 453);
            gpDatas2.TabIndex = 6;
            gpDatas2.TabStop = false;
            gpDatas2.Text = "数据监控";
            // 
            // picAlarm_MotorT
            // 
            picAlarm_MotorT.Image = Properties.Resources.alarm_high;
            picAlarm_MotorT.Location = new Point(258, 201);
            picAlarm_MotorT.Name = "picAlarm_MotorT";
            picAlarm_MotorT.Size = new Size(25, 25);
            picAlarm_MotorT.SizeMode = PictureBoxSizeMode.Zoom;
            picAlarm_MotorT.TabIndex = 2;
            picAlarm_MotorT.TabStop = false;
            // 
            // picAlarm_OutT
            // 
            picAlarm_OutT.Image = Properties.Resources.alarm_high;
            picAlarm_OutT.Location = new Point(114, 199);
            picAlarm_OutT.Name = "picAlarm_OutT";
            picAlarm_OutT.Size = new Size(25, 25);
            picAlarm_OutT.SizeMode = PictureBoxSizeMode.Zoom;
            picAlarm_OutT.TabIndex = 2;
            picAlarm_OutT.TabStop = false;
            // 
            // picAlarm_InF
            // 
            picAlarm_InF.Image = Properties.Resources.alarm_low;
            picAlarm_InF.Location = new Point(258, 322);
            picAlarm_InF.Name = "picAlarm_InF";
            picAlarm_InF.Size = new Size(25, 25);
            picAlarm_InF.SizeMode = PictureBoxSizeMode.Zoom;
            picAlarm_InF.TabIndex = 2;
            picAlarm_InF.TabStop = false;
            // 
            // picAlarm_OutF
            // 
            picAlarm_OutF.Image = Properties.Resources.alarm_low;
            picAlarm_OutF.Location = new Point(114, 320);
            picAlarm_OutF.Name = "picAlarm_OutF";
            picAlarm_OutF.Size = new Size(25, 25);
            picAlarm_OutF.SizeMode = PictureBoxSizeMode.Zoom;
            picAlarm_OutF.TabIndex = 2;
            picAlarm_OutF.TabStop = false;
            // 
            // picAlarm_InP
            // 
            picAlarm_InP.Image = Properties.Resources.alarm_low;
            picAlarm_InP.Location = new Point(258, 71);
            picAlarm_InP.Name = "picAlarm_InP";
            picAlarm_InP.Size = new Size(25, 25);
            picAlarm_InP.SizeMode = PictureBoxSizeMode.Zoom;
            picAlarm_InP.TabIndex = 2;
            picAlarm_InP.TabStop = false;
            // 
            // picAlarm_OutP
            // 
            picAlarm_OutP.Image = Properties.Resources.alarm_low;
            picAlarm_OutP.Location = new Point(114, 69);
            picAlarm_OutP.Name = "picAlarm_OutP";
            picAlarm_OutP.Size = new Size(25, 25);
            picAlarm_OutP.SizeMode = PictureBoxSizeMode.Zoom;
            picAlarm_OutP.TabIndex = 2;
            picAlarm_OutP.TabStop = false;
            // 
            // dial_InFlow
            // 
            dial_InFlow.BackColor = Color.Transparent;
            dial_InFlow.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dial_InFlow.ForeColor = Color.Gray;
            dial_InFlow.Location = new Point(161, 316);
            dial_InFlow.Name = "dial_InFlow";
            dial_InFlow.ProgressColor = Color.DodgerBlue;
            dial_InFlow.ProgressThinckness = 8;
            dial_InFlow.Size = new Size(105, 100);
            dial_InFlow.TabIndex = 1;
            dial_InFlow.Text = "进气流量";
            dial_InFlow.Unit = "m3/min";
            dial_InFlow.UnitColor = Color.Gray;
            dial_InFlow.UnitFont = new Font("微软雅黑", 8F);
            dial_InFlow.ValueColor = Color.DimGray;
            dial_InFlow.ValueFont = new Font("微软雅黑", 11F);
            // 
            // dial_MotorTemperature
            // 
            dial_MotorTemperature.BackColor = Color.Transparent;
            dial_MotorTemperature.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dial_MotorTemperature.ForeColor = Color.Gray;
            dial_MotorTemperature.Location = new Point(161, 187);
            dial_MotorTemperature.Maximum = 200F;
            dial_MotorTemperature.Name = "dial_MotorTemperature";
            dial_MotorTemperature.ProgressColor = Color.DodgerBlue;
            dial_MotorTemperature.ProgressThinckness = 8;
            dial_MotorTemperature.Size = new Size(105, 100);
            dial_MotorTemperature.TabIndex = 1;
            dial_MotorTemperature.Text = "电机温度";
            dial_MotorTemperature.Unit = "℃";
            dial_MotorTemperature.UnitColor = Color.DimGray;
            dial_MotorTemperature.UnitFont = new Font("微软雅黑", 8F);
            dial_MotorTemperature.Value = 45F;
            dial_MotorTemperature.ValueFont = new Font("微软雅黑", 11F);
            // 
            // dial_InPressure
            // 
            dial_InPressure.BackColor = Color.Transparent;
            dial_InPressure.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dial_InPressure.ForeColor = Color.Gray;
            dial_InPressure.Location = new Point(161, 60);
            dial_InPressure.Maximum = 2F;
            dial_InPressure.Name = "dial_InPressure";
            dial_InPressure.ProgressColor = Color.DodgerBlue;
            dial_InPressure.ProgressThinckness = 8;
            dial_InPressure.Size = new Size(105, 100);
            dial_InPressure.TabIndex = 1;
            dial_InPressure.Text = "进气压力";
            dial_InPressure.Unit = "Bar";
            dial_InPressure.UnitColor = Color.DimGray;
            dial_InPressure.UnitFont = new Font("微软雅黑", 8F);
            dial_InPressure.Value = 0.95F;
            dial_InPressure.ValueFont = new Font("微软雅黑", 11F);
            // 
            // dial_OutFlow
            // 
            dial_OutFlow.BackColor = Color.Transparent;
            dial_OutFlow.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dial_OutFlow.ForeColor = Color.Gray;
            dial_OutFlow.Location = new Point(18, 320);
            dial_OutFlow.Maximum = 50F;
            dial_OutFlow.Name = "dial_OutFlow";
            dial_OutFlow.ProgressColor = Color.SkyBlue;
            dial_OutFlow.ProgressThinckness = 8;
            dial_OutFlow.Size = new Size(105, 100);
            dial_OutFlow.TabIndex = 1;
            dial_OutFlow.Text = "排气流量";
            dial_OutFlow.Unit = "m3/min";
            dial_OutFlow.UnitColor = Color.Gray;
            dial_OutFlow.UnitFont = new Font("微软雅黑", 8F);
            dial_OutFlow.Value = 24.6F;
            dial_OutFlow.ValueColor = Color.SkyBlue;
            dial_OutFlow.ValueFont = new Font("微软雅黑", 11F);
            // 
            // dial_OutTemperature
            // 
            dial_OutTemperature.BackColor = Color.Transparent;
            dial_OutTemperature.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dial_OutTemperature.ForeColor = Color.Gray;
            dial_OutTemperature.Location = new Point(18, 191);
            dial_OutTemperature.Maximum = 150F;
            dial_OutTemperature.Name = "dial_OutTemperature";
            dial_OutTemperature.ProgressThinckness = 8;
            dial_OutTemperature.Size = new Size(105, 100);
            dial_OutTemperature.TabIndex = 1;
            dial_OutTemperature.Text = "排气温度";
            dial_OutTemperature.Unit = "℃";
            dial_OutTemperature.UnitColor = Color.Gray;
            dial_OutTemperature.UnitFont = new Font("微软雅黑", 8F);
            dial_OutTemperature.Value = 86F;
            dial_OutTemperature.ValueColor = Color.Orange;
            dial_OutTemperature.ValueFont = new Font("微软雅黑", 11F);
            // 
            // dial_OutPressure
            // 
            dial_OutPressure.BackColor = Color.Transparent;
            dial_OutPressure.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dial_OutPressure.ForeColor = Color.Gray;
            dial_OutPressure.Location = new Point(18, 60);
            dial_OutPressure.Maximum = 200F;
            dial_OutPressure.Name = "dial_OutPressure";
            dial_OutPressure.ProgressColor = Color.SkyBlue;
            dial_OutPressure.ProgressThinckness = 8;
            dial_OutPressure.Size = new Size(105, 100);
            dial_OutPressure.TabIndex = 1;
            dial_OutPressure.Text = "排气压力";
            dial_OutPressure.Unit = "Bar";
            dial_OutPressure.UnitColor = Color.Gray;
            dial_OutPressure.UnitFont = new Font("微软雅黑", 8F);
            dial_OutPressure.ValueColor = Color.SkyBlue;
            dial_OutPressure.ValueFont = new Font("微软雅黑", 11F);
            // 
            // uPanel1
            // 
            uPanel1.BgColor = Color.FromArgb(226, 234, 237);
            uPanel1.Controls.Add(label6);
            uPanel1.Controls.Add(label5);
            uPanel1.Controls.Add(lblBreakState03);
            uPanel1.Controls.Add(lblBreakState02);
            uPanel1.Controls.Add(lblRunState03);
            uPanel1.Controls.Add(lblBreakState01);
            uPanel1.Controls.Add(lblRunState02);
            uPanel1.Controls.Add(lblRunState01);
            uPanel1.Controls.Add(label4);
            uPanel1.Location = new Point(461, 55);
            uPanel1.Name = "uPanel1";
            uPanel1.Radius = 15;
            uPanel1.Size = new Size(994, 45);
            uPanel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("黑体", 9F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(664, 16);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 10;
            label6.Text = "3#空压机：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("黑体", 9F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(324, 16);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 10;
            label5.Text = "2#空压机：";
            // 
            // lblBreakState03
            // 
            lblBreakState03.AutoSize = true;
            lblBreakState03.BackColor = Color.Transparent;
            lblBreakState03.Font = new Font("黑体", 9F, FontStyle.Bold);
            lblBreakState03.ForeColor = Color.Red;
            lblBreakState03.Location = new Point(831, 16);
            lblBreakState03.Name = "lblBreakState03";
            lblBreakState03.Size = new Size(41, 15);
            lblBreakState03.TabIndex = 10;
            lblBreakState03.Tag = "BreakState-3";
            lblBreakState03.Text = "故障";
            // 
            // lblBreakState02
            // 
            lblBreakState02.AutoSize = true;
            lblBreakState02.BackColor = Color.Transparent;
            lblBreakState02.Font = new Font("黑体", 9F, FontStyle.Bold);
            lblBreakState02.ForeColor = Color.DodgerBlue;
            lblBreakState02.Location = new Point(495, 16);
            lblBreakState02.Name = "lblBreakState02";
            lblBreakState02.Size = new Size(41, 15);
            lblBreakState02.TabIndex = 10;
            lblBreakState02.Tag = "BreakState-2";
            lblBreakState02.Text = "正常";
            // 
            // lblRunState03
            // 
            lblRunState03.AutoSize = true;
            lblRunState03.BackColor = Color.Transparent;
            lblRunState03.Font = new Font("黑体", 9F, FontStyle.Bold);
            lblRunState03.ForeColor = Color.Orange;
            lblRunState03.Location = new Point(763, 16);
            lblRunState03.Name = "lblRunState03";
            lblRunState03.Size = new Size(58, 15);
            lblRunState03.TabIndex = 10;
            lblRunState03.Tag = "RunState-3";
            lblRunState03.Text = "运行中";
            // 
            // lblBreakState01
            // 
            lblBreakState01.AutoSize = true;
            lblBreakState01.BackColor = Color.Transparent;
            lblBreakState01.Font = new Font("黑体", 9F, FontStyle.Bold);
            lblBreakState01.ForeColor = Color.DodgerBlue;
            lblBreakState01.Location = new Point(185, 16);
            lblBreakState01.Name = "lblBreakState01";
            lblBreakState01.Size = new Size(41, 15);
            lblBreakState01.TabIndex = 10;
            lblBreakState01.Tag = "BreakState-1";
            lblBreakState01.Text = "正常";
            // 
            // lblRunState02
            // 
            lblRunState02.AutoSize = true;
            lblRunState02.BackColor = Color.Transparent;
            lblRunState02.Font = new Font("黑体", 9F, FontStyle.Bold);
            lblRunState02.ForeColor = Color.Gray;
            lblRunState02.Location = new Point(417, 16);
            lblRunState02.Name = "lblRunState02";
            lblRunState02.Size = new Size(58, 15);
            lblRunState02.TabIndex = 10;
            lblRunState02.Tag = "RunState-2";
            lblRunState02.Text = "已停止";
            // 
            // lblRunState01
            // 
            lblRunState01.AutoSize = true;
            lblRunState01.BackColor = Color.Transparent;
            lblRunState01.Font = new Font("黑体", 9F, FontStyle.Bold);
            lblRunState01.ForeColor = Color.Orange;
            lblRunState01.Location = new Point(110, 16);
            lblRunState01.Name = "lblRunState01";
            lblRunState01.Size = new Size(58, 15);
            lblRunState01.TabIndex = 10;
            lblRunState01.Tag = "RunState-1";
            lblRunState01.Text = "运行中";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("黑体", 9F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(17, 16);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 10;
            label4.Text = "1#空压机：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("黑体", 9F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(956, 18);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 10;
            label1.Text = "通信状态：";
            // 
            // lblConnectState
            // 
            lblConnectState.Font = new Font("黑体", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblConnectState.ForeColor = Color.DimGray;
            lblConnectState.Location = new Point(1041, 13);
            lblConnectState.Name = "lblConnectState";
            lblConnectState.Size = new Size(92, 29);
            lblConnectState.TabIndex = 10;
            lblConnectState.Text = "未连接";
            lblConnectState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.ForeColor = Color.DimGray;
            btnConnect.Image = Properties.Resources.connect;
            btnConnect.ImageAlign = ContentAlignment.MiddleLeft;
            btnConnect.Location = new Point(1149, 7);
            btnConnect.Name = "btnConnect";
            btnConnect.Padding = new Padding(5, 0, 8, 0);
            btnConnect.Size = new Size(80, 35);
            btnConnect.TabIndex = 11;
            btnConnect.Text = "连接";
            btnConnect.TextAlign = ContentAlignment.MiddleRight;
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            btnConnect.MouseEnter += btnConnect_MouseEnter;
            btnConnect.MouseLeave += btnConnect_MouseLeave;
            // 
            // lblLoginUser
            // 
            lblLoginUser.Image = Properties.Resources.user;
            lblLoginUser.ImageAlign = ContentAlignment.MiddleLeft;
            lblLoginUser.Location = new Point(1248, 11);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Padding = new Padding(5, 0, 0, 0);
            lblLoginUser.Size = new Size(97, 29);
            lblLoginUser.TabIndex = 12;
            lblLoginUser.Text = "Admin";
            lblLoginUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Image = Properties.Resources.exit;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1375, 7);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5, 0, 8, 0);
            btnExit.Size = new Size(80, 35);
            btnExit.TabIndex = 13;
            btnExit.Text = "退出";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.MenuHighlight;
            btnLogin.Image = Properties.Resources.denglu_blue;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(1375, 7);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(5, 0, 8, 0);
            btnLogin.Size = new Size(80, 35);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "登录";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmMonitorCenter
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 245);
            ClientSize = new Size(1475, 744);
            Controls.Add(lblLoginUser);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(btnConnect);
            Controls.Add(lblConnectState);
            Controls.Add(label1);
            Controls.Add(uPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelDevList);
            Controls.Add(gpDatas2);
            Controls.Add(uGroupPanel42);
            Controls.Add(uGroupPanel41);
            Controls.Add(pictureBox1);
            Controls.Add(uLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMonitorCenter";
            Text = "朝夕教育-空压机监控系统";
            FormClosing += FrmMonitorCenter_FormClosing;
            Load += FrmMonitorCenter_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uGroupPanel41.ResumeLayout(false);
            uGroupPanel41.PerformLayout();
            panelDevList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            uGroupPanel42.ResumeLayout(false);
            uGroupPanel42.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            gpDatas2.ResumeLayout(false);
            gpDatas2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAlarm_MotorT).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_OutT).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_InF).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_OutF).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_InP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAlarm_OutP).EndInit();
            uPanel1.ResumeLayout(false);
            uPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustControls.ULabel uLabel1;
        private PictureBox pictureBox1;
        private CustControls01.UGroupPanel4 uGroupPanel41;
        private Panel panelDevList;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        private CustControls01.UGroupPanel4 uGroupPanel42;
        private CustControls01.UGroupPanel4 gpDatas2;
        private CustControls.UPanel uPanel1;
        private Label label1;
        private Label lblConnectState;
        private Button btnConnect;
        private Label lblLoginUser;
        private Label label6;
        private Label label5;
        private Label lblBreakState01;
        private Label lblRunState01;
        private Label label4;
        private Button btnExit;
        private Button btnLogin;
        private Label lblBreakState03;
        private Label lblBreakState02;
        private Label lblRunState03;
        private Label lblRunState02;
        private CustControls.ULabel uLabel4;
        private CustControls.ULabel uLabel3;
        private CustControls.ULabel uLabel2;
        private Label label2;
        private CustControls.UButton btnUnloadDev;
        private CustControls.UButton btnLoadDev;
        private CustControls.UButton btnStopDev;
        private CustControls.UButton btnStartDev;
        private Label lblBreakTimes;
        private Label lblStopTime;
        private Label lblLoadTimes;
        private Label lblLoadTime;
        private Label lblStartTimes;
        private Label lblRunTime;
        private Label label13;
        private Label label9;
        private Label label12;
        private Label label7;
        private Label label11;
        private Label label14;
        private Label label10;
        private Label label8;
        private Label label3;
        private CustControls.UJogSwitch jsBreak;
        private CustControls.UJogSwitch jsLoad;
        private CustControls.UJogSwitch jsRun;
        private CustControls.UEllipseSwitch swRunMode;
        private Label label16;
        private Label label15;
        private CustControls.UButton btnGet;
        private CustControls.UEllipseSwitch swAuto;
        private WinNewCustControls.UDial dial_OutPressure;
        private WinNewCustControls.UDial dial_InFlow;
        private WinNewCustControls.UDial dial_MotorTemperature;
        private WinNewCustControls.UDial dial_InPressure;
        private WinNewCustControls.UDial dial_OutFlow;
        private WinNewCustControls.UDial dial_OutTemperature;
        private PictureBox picAlarm_OutF;
        private PictureBox picAlarm_OutP;
        private PictureBox picAlarm_MotorT;
        private PictureBox picAlarm_OutT;
        private PictureBox picAlarm_InF;
        private PictureBox picAlarm_InP;
        private CustControls.UCircleMeter meter_Flow;
        private CustControls.UMeter meter_Temperature;
        private CustControls.UMeter meter_Pressure;
        private Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
