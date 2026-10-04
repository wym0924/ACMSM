namespace Zhaoxi.AirCompressorMonitorSystem
{
    partial class FrmParent
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
            SuspendLayout();
            // 
            // FrmParent
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 522);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmParent";
            Text = "FrmParent";
            MouseDown += FrmParent_MouseDown;
            MouseMove += FrmParent_MouseMove;
            MouseUp += FrmParent_MouseUp;
            ResumeLayout(false);
        }

        #endregion
    }
}