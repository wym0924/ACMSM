using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zhaoxi.AirCompressorMonitorSystem
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        Point point=new Point();//第一次按下时的位置 
        bool isMove = false;//是否正在拖动中
        public void FrmParent_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            isMove = true;//启动拖动
        }

        public void FrmParent_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
            {
                this.Location += new Size(e.Location.X - point.X, e.Location.Y - point.Y);
            }
        }

        public void FrmParent_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;//释放拖动
        }
    }
}
