using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhaoxi.AirCompressorMonitorSystem.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zhaoxi.AirCompressorMonitorSystem
{
    public partial class FrmConnection : FrmParent
    {
        public FrmConnection()
        {
            InitializeComponent();
            uGroupPanel11.MouseDown += base.FrmParent_MouseDown;
            uGroupPanel11.MouseMove += base.FrmParent_MouseMove;
            uGroupPanel11.MouseUp += base.FrmParent_MouseUp;
        }

        private void FrmConnection_Load(object sender, EventArgs e)
        {
            if (CommonHelper.connSets != null)
            {
                txtIP.Text = CommonHelper.connSets.IP;
                txtPort.Text = CommonHelper.connSets.Port.ToString();
            }
            else
            {
                txtIP.Text = "192.168.101.1";
                txtPort.Text = "502";
            }
        }

        /// <summary>
        /// 连接处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ip = txtIP.Text.Trim();
            int port = txtPort.Text.GetInt();
            if (string.IsNullOrEmpty(ip))
            {
                lblMsg.Text = "请输入服务器IP！";
                txtIP.Focus();
                return;
            }
            if (port <= 0)
            {
                lblMsg.Text = "请输入端口！";
                txtPort.Focus();
                return;
            }
            try
            {
                CommonHelper.tcpClient = new TcpClient(ip, port);
                CommonHelper.master = ModbusIpMaster.CreateIp(CommonHelper.tcpClient);
                CommonHelper.isConnected = true;
                this.Close();
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim().Length > 0)
            {
                lblMsg.Text = "";
            }
        }

        /// <summary>
        /// 保存通信设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string ip = txtIP.Text.Trim();
            int port = txtPort.Text.GetInt();
            if (string.IsNullOrEmpty(ip))
            {
                lblMsg.Text = "请输入服务器IP！";
                txtIP.Focus();
                return;
            }
            if (port <= 0)
            {
                lblMsg.Text = "请输入端口！";
                txtPort.Focus();
                return;
            }
            List<string> lines= new List<string>();
            lines.Add($"IP:{ip}");
            lines.Add($"Port:{port}");
            //写入文件
            File.WriteAllLines("Communication.txt",lines);
            //保存在程序中
            if(CommonHelper.connSets==null)
            {
                CommonHelper.connSets = new Models.CommunicationSet()
                {
                    IP = ip,
                    Port = port
                };
            }
            else
            {
                //更新原的来ip和port
                CommonHelper.connSets.IP = ip;
                CommonHelper.connSets.Port = port;
            }
            MessageHelper.Success("保存提示", "通信设置保存成功！");
        }
    }
}
