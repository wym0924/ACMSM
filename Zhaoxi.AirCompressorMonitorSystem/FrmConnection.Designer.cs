namespace Zhaoxi.AirCompressorMonitorSystem
{
    partial class FrmConnection
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
            uGroupPanel11 = new Zhaoxi.CustControls.UGroupPanel1();
            lblMsg = new Label();
            btnSave = new Zhaoxi.CustControls.UButton();
            btnConnect = new Button();
            txtPort = new TextBox();
            txtIP = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnClose = new Button();
            label2 = new Label();
            uGroupPanel11.SuspendLayout();
            SuspendLayout();
            // 
            // uGroupPanel11
            // 
            uGroupPanel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uGroupPanel11.BackColor = Color.FromArgb(226, 234, 237);
            uGroupPanel11.Background = Color.SteelBlue;
            uGroupPanel11.Controls.Add(lblMsg);
            uGroupPanel11.Controls.Add(btnSave);
            uGroupPanel11.Controls.Add(btnConnect);
            uGroupPanel11.Controls.Add(txtPort);
            uGroupPanel11.Controls.Add(txtIP);
            uGroupPanel11.Controls.Add(label3);
            uGroupPanel11.Controls.Add(label1);
            uGroupPanel11.Controls.Add(btnClose);
            uGroupPanel11.Controls.Add(label2);
            uGroupPanel11.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel11.Location = new Point(3, 3);
            uGroupPanel11.Name = "uGroupPanel11";
            uGroupPanel11.PrimaryColor = Color.Azure;
            uGroupPanel11.Size = new Size(522, 325);
            uGroupPanel11.TabIndex = 0;
            uGroupPanel11.TabStop = false;
            // 
            // lblMsg
            // 
            lblMsg.BackColor = Color.Transparent;
            lblMsg.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(61, 243);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(433, 65);
            lblMsg.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BgColor = Color.SlateGray;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FocusBgColor = Color.DodgerBlue;
            btnSave.FocusForeColor = Color.White;
            btnSave.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(350, 87);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(71, 31);
            btnSave.TabIndex = 8;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.WhiteSmoke;
            btnConnect.FlatAppearance.BorderColor = Color.Gray;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.ForeColor = Color.Gray;
            btnConnect.Location = new Point(113, 186);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(81, 35);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "连接";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(113, 140);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 26);
            txtPort.TabIndex = 6;
            txtPort.Text = "301";
            txtPort.TextChanged += txtBox_TextChanged;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(113, 90);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(216, 26);
            txtIP.TabIndex = 6;
            txtIP.Text = "192.168.101.1";
            txtIP.TextChanged += txtBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(51, 142);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 5;
            label3.Text = "Port：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(68, 93);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 5;
            label1.Text = "IP：";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnClose.ForeColor = Color.Gray;
            btnClose.Location = new Point(479, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 30);
            btnClose.TabIndex = 4;
            btnClose.Text = "r";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(23, 19);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "通信连接";
            // 
            // FrmConnection
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(529, 332);
            Controls.Add(uGroupPanel11);
            Name = "FrmConnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConnection";
            Load += FrmConnection_Load;
            uGroupPanel11.ResumeLayout(false);
            uGroupPanel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustControls.UGroupPanel1 uGroupPanel11;
        private Label label2;
        private TextBox txtIP;
        private Label label3;
        private Label label1;
        private Button btnClose;
        private CustControls.UButton btnSave;
        private Button btnConnect;
        private TextBox txtPort;
        private Label lblMsg;
    }
}