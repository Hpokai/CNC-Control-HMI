namespace JCNC
{
    partial class ToolWarningMSG
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
            this.WMsg = new System.Windows.Forms.Button();
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
            this.WMsg.Size = new System.Drawing.Size(276, 64);
            this.WMsg.TabIndex = 0;
            this.WMsg.Text = "警告 : 刀具異常";
            this.WMsg.UseVisualStyleBackColor = false;
            this.WMsg.Click += new System.EventHandler(this.WMsg_Click);
            // 
            // ToolWarningMSG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(302, 90);
            this.ControlBox = false;
            this.Controls.Add(this.WMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolWarningMSG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToolWarningMSG";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WMsg;
    }
}