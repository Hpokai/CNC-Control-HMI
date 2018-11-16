namespace JCNC
{
    partial class FORM_Diag_AlarmMessage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PMACErrorMsg = new System.Windows.Forms.TabPage();
            this.NCMsgs = new System.Windows.Forms.TabPage();
            this.AppMsgs = new System.Windows.Forms.TabPage();
            this.ParserMsg = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PMACErrorMsg);
            this.tabControl1.Controls.Add(this.NCMsgs);
            this.tabControl1.Controls.Add(this.AppMsgs);
            this.tabControl1.Controls.Add(this.ParserMsg);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(480, 40);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // PMACErrorMsg
            // 
            this.PMACErrorMsg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PMACErrorMsg.Location = new System.Drawing.Point(4, 44);
            this.PMACErrorMsg.Name = "PMACErrorMsg";
            this.PMACErrorMsg.Padding = new System.Windows.Forms.Padding(3);
            this.PMACErrorMsg.Size = new System.Drawing.Size(1186, 366);
            this.PMACErrorMsg.TabIndex = 0;
            this.PMACErrorMsg.Text = "PMAC Errors";
            this.PMACErrorMsg.UseVisualStyleBackColor = true;
            // 
            // NCMsgs
            // 
            this.NCMsgs.Location = new System.Drawing.Point(4, 44);
            this.NCMsgs.Name = "NCMsgs";
            this.NCMsgs.Padding = new System.Windows.Forms.Padding(3);
            this.NCMsgs.Size = new System.Drawing.Size(1186, 366);
            this.NCMsgs.TabIndex = 1;
            this.NCMsgs.Text = "NC Messages";
            this.NCMsgs.UseVisualStyleBackColor = true;
            // 
            // AppMsgs
            // 
            this.AppMsgs.Location = new System.Drawing.Point(4, 44);
            this.AppMsgs.Name = "AppMsgs";
            this.AppMsgs.Size = new System.Drawing.Size(1186, 366);
            this.AppMsgs.TabIndex = 2;
            this.AppMsgs.Text = "Application Messages";
            this.AppMsgs.UseVisualStyleBackColor = true;
            // 
            // ParserMsg
            // 
            this.ParserMsg.Location = new System.Drawing.Point(4, 44);
            this.ParserMsg.Name = "ParserMsg";
            this.ParserMsg.Size = new System.Drawing.Size(1186, 366);
            this.ParserMsg.TabIndex = 3;
            this.ParserMsg.Text = "Parser Messages";
            this.ParserMsg.UseVisualStyleBackColor = true;
            // 
            // FORM_Diag_AlarmMessage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1196, 438);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_Diag_AlarmMessage";
            this.Text = "SystemMessage";
            this.Load += new System.EventHandler(this.SystemMessage_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PMACErrorMsg;
        private System.Windows.Forms.TabPage NCMsgs;
        private System.Windows.Forms.TabPage AppMsgs;
        private System.Windows.Forms.TabPage ParserMsg;
    }
}