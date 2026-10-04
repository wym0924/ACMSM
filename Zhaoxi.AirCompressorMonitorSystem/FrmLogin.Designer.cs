namespace Zhaoxi.AirCompressorMonitorSystem
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            uPanel1 = new Zhaoxi.CustControls.UPanel();
            txtUserName = new TextBox();
            uPanel2 = new Zhaoxi.CustControls.UPanel();
            txtUserPwd = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            lblMsg = new Label();
            uPanel1.SuspendLayout();
            uPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(205, 20);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "空压机监控系统";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(311, 90);
            label2.Name = "label2";
            label2.Size = new Size(129, 37);
            label2.TabIndex = 0;
            label2.Text = "系统登录";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 171);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 1;
            label3.Text = "账号：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 237);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 1;
            label4.Text = "密码：";
            // 
            // uPanel1
            // 
            uPanel1.BackColor = Color.Transparent;
            uPanel1.BgColor = Color.Transparent;
            uPanel1.BorderColor = Color.Silver;
            uPanel1.BorderWidth = 1;
            uPanel1.Controls.Add(txtUserName);
            uPanel1.Location = new Point(280, 161);
            uPanel1.Name = "uPanel1";
            uPanel1.Size = new Size(246, 40);
            uPanel1.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Location = new Point(9, 10);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(225, 20);
            txtUserName.TabIndex = 0;
            txtUserName.Text = "Admin";
            txtUserName.TextChanged += txtBox_TextChanged;
            // 
            // uPanel2
            // 
            uPanel2.BackColor = Color.Transparent;
            uPanel2.BgColor = Color.Transparent;
            uPanel2.BorderColor = Color.Silver;
            uPanel2.BorderWidth = 1;
            uPanel2.Controls.Add(txtUserPwd);
            uPanel2.Location = new Point(280, 227);
            uPanel2.Name = "uPanel2";
            uPanel2.Size = new Size(246, 40);
            uPanel2.TabIndex = 2;
            // 
            // txtUserPwd
            // 
            txtUserPwd.BorderStyle = BorderStyle.None;
            txtUserPwd.Location = new Point(9, 9);
            txtUserPwd.Name = "txtUserPwd";
            txtUserPwd.Size = new Size(225, 20);
            txtUserPwd.TabIndex = 1;
            txtUserPwd.Text = "123456";
            txtUserPwd.UseSystemPasswordChar = true;
            txtUserPwd.TextChanged += txtBox_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(280, 307);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(246, 41);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnClose.ForeColor = Color.Gray;
            btnClose.Location = new Point(707, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 30);
            btnClose.TabIndex = 3;
            btnClose.Text = "r";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(289, 365);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 20);
            lblMsg.TabIndex = 1;
            // 
            // FrmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 420);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(uPanel2);
            Controls.Add(uPanel1);
            Controls.Add(label4);
            Controls.Add(lblMsg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Paint += FrmLogin_Paint;
            uPanel1.ResumeLayout(false);
            uPanel1.PerformLayout();
            uPanel2.ResumeLayout(false);
            uPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CustControls.UPanel uPanel1;
        private CustControls.UPanel uPanel2;
        private TextBox txtUserPwd;
        private TextBox txtUserName;
        private Button btnLogin;
        private Button btnClose;
        private Label lblMsg;
    }
}