namespace JCNC
{
    partial class WarningMSG
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
            this.components = new System.ComponentModel.Container();
            this.WMsg = new System.Windows.Forms.Button();
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // WMsg
            // 
            this.WMsg.BackColor = System.Drawing.SystemColors.Control;
            this.WMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WMsg.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WMsg.ForeColor = System.Drawing.Color.Red;
            this.WMsg.Location = new System.Drawing.Point(12, 12);
            this.WMsg.Name = "WMsg";
            this.WMsg.Size = new System.Drawing.Size(581, 172);
            this.WMsg.TabIndex = 0;
            this.WMsg.Text = "警告 : 緊急開關已啟動";
            this.WMsg.UseVisualStyleBackColor = false;
            // 
            // closeTimer
            // 
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // WarningMSG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(605, 196);
            this.ControlBox = false;
            this.Controls.Add(this.WMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarningMSG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarningMSG";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WMsg;
        private System.Windows.Forms.Timer closeTimer;
    }
}