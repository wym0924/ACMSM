using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhaoxi.AirCompressorMonitorSystem.DAL;
using Zhaoxi.AirCompressorMonitorSystem.Utils;

namespace Zhaoxi.AirCompressorMonitorSystem
{
    public partial class FrmLogin : FrmParent
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登录过程处理......
            string userName = txtUserName.Text.Trim();
            string userPwd=txtUserPwd.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                lblMsg.Text = "请输入登录账号！";
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(userPwd))
            {
                lblMsg.Text = "请输入登录密码！";
                txtUserPwd.Focus();
                return;
            }
            //登录
            UserDAL userDAL = new UserDAL();
            bool blLogin=userDAL.LoginSystem(userName, userPwd);
            if (blLogin)
            {
                CommonHelper.isLogin = true;//登录成功
                this.Owner.Tag =userName;
                this.Close();
            }
            else
            {
                lblMsg.Text = "用户名或密码输入有误，请检查！";
                return;
            }
        }

        /// <summary>
        /// 窗体界面绘制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int width = e.ClipRectangle.Width;
            int height = e.ClipRectangle.Height;
            //路径对象
            GraphicsPath path = new GraphicsPath();
            path.AddLine(0, 0, width / 3 - width / 16, 0);
            path.AddCurve(new Point[]
            {
                new Point(width / 3-width/16,0),
                new Point(width/3-width/8,height/3),
                new Point(width/3-width/15,height-height/5),
                new Point(width/3-width/8,height-1)
            }, 0.6f);
            path.AddLine(width / 3 - width / 8, height - 1, 0, height - 1);
            path.AddLine(0, height - 1, 0, 0);
            path.CloseAllFigures();
            g.FillPath(new SolidBrush(Color.LightSteelBlue), path);
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim().Length > 0)
            {
                lblMsg.Text = "";
            }
        }
    }
}
