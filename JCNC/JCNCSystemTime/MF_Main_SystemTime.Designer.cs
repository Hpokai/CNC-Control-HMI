namespace JCNCSystemTime
{
    partial class FORM_Main_SystemTime
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
            this.STtimer = new System.Windows.Forms.Timer(this.components);
            this.globalDateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.globalTimeLabel = new System.Windows.Forms.Label();
            this.globalMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.infoDisplayPanel = new System.Windows.Forms.Panel();
            this.resetMachiningNumLabelButton = new System.Windows.Forms.Button();
            this.resetAutoOperateTimeButton = new System.Windows.Forms.Button();
            this.machiningNumLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.spanFirstPowerOnTimeLabel = new System.Windows.Forms.Label();
            this.autoRunTimeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autoOperateTimeLabel = new System.Windows.Forms.Label();
            this.getMachiningNumTimer = new System.Windows.Forms.Timer(this.components);
            this.returnDataTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.infoDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // STtimer
            // 
            this.STtimer.Tick += new System.EventHandler(this.STtimer_Tick);
            // 
            // globalDateLabel
            // 
            this.globalDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.globalDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.globalDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.globalDateLabel.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.globalDateLabel.Location = new System.Drawing.Point(37, 48);
            this.globalDateLabel.Name = "globalDateLabel";
            this.globalDateLabel.Size = new System.Drawing.Size(175, 31);
            this.globalDateLabel.TabIndex = 2;
            this.globalDateLabel.Text = "2013-03-26";
            this.globalDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.globalTimeLabel);
            this.groupBox1.Controls.Add(this.globalDateLabel);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "時間";
            // 
            // globalTimeLabel
            // 
            this.globalTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.globalTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.globalTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.globalTimeLabel.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.globalTimeLabel.Location = new System.Drawing.Point(37, 104);
            this.globalTimeLabel.Name = "globalTimeLabel";
            this.globalTimeLabel.Size = new System.Drawing.Size(175, 31);
            this.globalTimeLabel.TabIndex = 3;
            this.globalTimeLabel.Text = "17:03:01";
            this.globalTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // globalMonthCalendar
            // 
            this.globalMonthCalendar.CalendarDimensions = new System.Drawing.Size(4, 1);
            this.globalMonthCalendar.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.globalMonthCalendar.Location = new System.Drawing.Point(280, 12);
            this.globalMonthCalendar.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.globalMonthCalendar.MaxSelectionCount = 1;
            this.globalMonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.globalMonthCalendar.Name = "globalMonthCalendar";
            this.globalMonthCalendar.TabIndex = 4;
            // 
            // infoDisplayPanel
            // 
            this.infoDisplayPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.infoDisplayPanel.Controls.Add(this.resetMachiningNumLabelButton);
            this.infoDisplayPanel.Controls.Add(this.resetAutoOperateTimeButton);
            this.infoDisplayPanel.Controls.Add(this.machiningNumLabel);
            this.infoDisplayPanel.Controls.Add(this.label8);
            this.infoDisplayPanel.Controls.Add(this.label9);
            this.infoDisplayPanel.Controls.Add(this.label10);
            this.infoDisplayPanel.Controls.Add(this.label11);
            this.infoDisplayPanel.Controls.Add(this.label12);
            this.infoDisplayPanel.Controls.Add(this.spanFirstPowerOnTimeLabel);
            this.infoDisplayPanel.Controls.Add(this.autoRunTimeLabel);
            this.infoDisplayPanel.Controls.Add(this.label5);
            this.infoDisplayPanel.Controls.Add(this.label4);
            this.infoDisplayPanel.Controls.Add(this.label3);
            this.infoDisplayPanel.Controls.Add(this.autoOperateTimeLabel);
            this.infoDisplayPanel.Location = new System.Drawing.Point(19, 195);
            this.infoDisplayPanel.Name = "infoDisplayPanel";
            this.infoDisplayPanel.Size = new System.Drawing.Size(1155, 228);
            this.infoDisplayPanel.TabIndex = 5;
            this.infoDisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.infoDisplayPanel_Paint);
            // 
            // resetMachiningNumLabelButton
            // 
            this.resetMachiningNumLabelButton.BackColor = System.Drawing.Color.PaleGreen;
            this.resetMachiningNumLabelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetMachiningNumLabelButton.Location = new System.Drawing.Point(1054, 16);
            this.resetMachiningNumLabelButton.Name = "resetMachiningNumLabelButton";
            this.resetMachiningNumLabelButton.Size = new System.Drawing.Size(61, 46);
            this.resetMachiningNumLabelButton.TabIndex = 19;
            this.resetMachiningNumLabelButton.Text = "Reset";
            this.resetMachiningNumLabelButton.UseVisualStyleBackColor = false;
            this.resetMachiningNumLabelButton.Click += new System.EventHandler(this.resetMachiningNumLabelButton_Click);
            // 
            // resetAutoOperateTimeButton
            // 
            this.resetAutoOperateTimeButton.BackColor = System.Drawing.Color.PaleGreen;
            this.resetAutoOperateTimeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAutoOperateTimeButton.Location = new System.Drawing.Point(466, 87);
            this.resetAutoOperateTimeButton.Name = "resetAutoOperateTimeButton";
            this.resetAutoOperateTimeButton.Size = new System.Drawing.Size(61, 46);
            this.resetAutoOperateTimeButton.TabIndex = 18;
            this.resetAutoOperateTimeButton.Text = "Reset";
            this.resetAutoOperateTimeButton.UseVisualStyleBackColor = false;
            this.resetAutoOperateTimeButton.Click += new System.EventHandler(this.resetAutoOperateTimeButton_Click);
            // 
            // machiningNumLabel
            // 
            this.machiningNumLabel.BackColor = System.Drawing.SystemColors.Control;
            this.machiningNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.machiningNumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.machiningNumLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.machiningNumLabel.Location = new System.Drawing.Point(813, 16);
            this.machiningNumLabel.Name = "machiningNumLabel";
            this.machiningNumLabel.Size = new System.Drawing.Size(235, 46);
            this.machiningNumLabel.TabIndex = 17;
            this.machiningNumLabel.Text = "876000:03:01";
            this.machiningNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Enabled = false;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(813, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 46);
            this.label8.TabIndex = 16;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Enabled = false;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(620, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "外部累計2:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Enabled = false;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(620, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 31);
            this.label10.TabIndex = 14;
            this.label10.Text = "外部累計1:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(620, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 31);
            this.label11.TabIndex = 13;
            this.label11.Text = "加工數量:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Enabled = false;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(813, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 46);
            this.label12.TabIndex = 12;
            this.label12.Text = "0";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spanFirstPowerOnTimeLabel
            // 
            this.spanFirstPowerOnTimeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.spanFirstPowerOnTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spanFirstPowerOnTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spanFirstPowerOnTimeLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.spanFirstPowerOnTimeLabel.Location = new System.Drawing.Point(225, 16);
            this.spanFirstPowerOnTimeLabel.Name = "spanFirstPowerOnTimeLabel";
            this.spanFirstPowerOnTimeLabel.Size = new System.Drawing.Size(235, 46);
            this.spanFirstPowerOnTimeLabel.TabIndex = 11;
            this.spanFirstPowerOnTimeLabel.Text = "876000:03:01";
            this.spanFirstPowerOnTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoRunTimeLabel
            // 
            this.autoRunTimeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.autoRunTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.autoRunTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoRunTimeLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.autoRunTimeLabel.Location = new System.Drawing.Point(225, 158);
            this.autoRunTimeLabel.Name = "autoRunTimeLabel";
            this.autoRunTimeLabel.Size = new System.Drawing.Size(235, 46);
            this.autoRunTimeLabel.TabIndex = 10;
            this.autoRunTimeLabel.Text = "876000:03:01";
            this.autoRunTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(32, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "加工時間:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(32, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "總加工時間:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "電源開啟:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoOperateTimeLabel
            // 
            this.autoOperateTimeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.autoOperateTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.autoOperateTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoOperateTimeLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.autoOperateTimeLabel.Location = new System.Drawing.Point(225, 87);
            this.autoOperateTimeLabel.Name = "autoOperateTimeLabel";
            this.autoOperateTimeLabel.Size = new System.Drawing.Size(235, 46);
            this.autoOperateTimeLabel.TabIndex = 4;
            this.autoOperateTimeLabel.Text = "876000:03:01";
            this.autoOperateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // getMachiningNumTimer
            // 
            this.getMachiningNumTimer.Tick += new System.EventHandler(this.getMachiningNumTimer_Tick);
            // 
            // returnDataTimer
            // 
            this.returnDataTimer.Interval = 800;
            this.returnDataTimer.Tick += new System.EventHandler(this.returnDataTimer_Tick);
            // 
            // FORM_Main_SystemTime
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1195, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoDisplayPanel);
            this.Controls.Add(this.globalMonthCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_Main_SystemTime";
            this.Text = "SystemTime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MF_Main_SystemTime_FormClosing);
            this.Load += new System.EventHandler(this.MF_Main_SystemTime_Load);
            this.groupBox1.ResumeLayout(false);
            this.infoDisplayPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer STtimer;
        private System.Windows.Forms.Label globalDateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label globalTimeLabel;
        private System.Windows.Forms.MonthCalendar globalMonthCalendar;
        private System.Windows.Forms.Panel infoDisplayPanel;
        private System.Windows.Forms.Label autoOperateTimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label spanFirstPowerOnTimeLabel;
        private System.Windows.Forms.Label autoRunTimeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label machiningNumLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button resetAutoOperateTimeButton;
        private System.Windows.Forms.Button resetMachiningNumLabelButton;
        private System.Windows.Forms.Timer getMachiningNumTimer;
        private System.Windows.Forms.Timer returnDataTimer;
    }
}