namespace ToolMeasurement
{
    partial class TMeas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.plus10Button = new System.Windows.Forms.Button();
            this.minus10Button = new System.Windows.Forms.Button();
            this.toolNumComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolHeightValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.zTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.measuringDeviceValueTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.downDirectionPictureBox = new System.Windows.Forms.PictureBox();
            this.spindlePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showDownDirTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downDirectionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spindlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plus10Button);
            this.groupBox1.Controls.Add(this.minus10Button);
            this.groupBox1.Controls.Add(this.toolNumComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.toolHeightValueTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.setButton);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // plus10Button
            // 
            this.plus10Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plus10Button.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus10Button.Location = new System.Drawing.Point(160, 46);
            this.plus10Button.Name = "plus10Button";
            this.plus10Button.Size = new System.Drawing.Size(76, 60);
            this.plus10Button.TabIndex = 30;
            this.plus10Button.Text = "+10";
            this.plus10Button.UseVisualStyleBackColor = false;
            this.plus10Button.Click += new System.EventHandler(this.plus10Button_Click);
            // 
            // minus10Button
            // 
            this.minus10Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.minus10Button.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus10Button.Location = new System.Drawing.Point(160, 110);
            this.minus10Button.Name = "minus10Button";
            this.minus10Button.Size = new System.Drawing.Size(76, 60);
            this.minus10Button.TabIndex = 30;
            this.minus10Button.Text = "-10";
            this.minus10Button.UseVisualStyleBackColor = false;
            this.minus10Button.Click += new System.EventHandler(this.minus10Button_Click);
            // 
            // toolNumComboBox
            // 
            this.toolNumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolNumComboBox.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolNumComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.toolNumComboBox.Location = new System.Drawing.Point(10, 83);
            this.toolNumComboBox.Name = "toolNumComboBox";
            this.toolNumComboBox.Size = new System.Drawing.Size(144, 48);
            this.toolNumComboBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "刀號：";
            // 
            // toolHeightValueTextBox
            // 
            this.toolHeightValueTextBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHeightValueTextBox.Location = new System.Drawing.Point(10, 225);
            this.toolHeightValueTextBox.MaxLength = 14;
            this.toolHeightValueTextBox.Name = "toolHeightValueTextBox";
            this.toolHeightValueTextBox.ReadOnly = true;
            this.toolHeightValueTextBox.Size = new System.Drawing.Size(226, 39);
            this.toolHeightValueTextBox.TabIndex = 9;
            this.toolHeightValueTextBox.Text = "999.123";
            this.toolHeightValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "刀長補正值：";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.zTextBox);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(10, 272);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 46);
            this.panel6.TabIndex = 19;
            // 
            // zTextBox
            // 
            this.zTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zTextBox.Location = new System.Drawing.Point(35, 6);
            this.zTextBox.MaxLength = 14;
            this.zTextBox.Name = "zTextBox";
            this.zTextBox.ReadOnly = true;
            this.zTextBox.Size = new System.Drawing.Size(181, 32);
            this.zTextBox.TabIndex = 6;
            this.zTextBox.Text = "999.123";
            this.zTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Z";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.resetButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(10, 350);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(111, 60);
            this.resetButton.TabIndex = 27;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // setButton
            // 
            this.setButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.setButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setButton.Location = new System.Drawing.Point(125, 350);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(111, 60);
            this.setButton.TabIndex = 26;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // measuringDeviceValueTextBox
            // 
            this.measuringDeviceValueTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measuringDeviceValueTextBox.Location = new System.Drawing.Point(619, 276);
            this.measuringDeviceValueTextBox.Name = "measuringDeviceValueTextBox";
            this.measuringDeviceValueTextBox.Size = new System.Drawing.Size(121, 32);
            this.measuringDeviceValueTextBox.TabIndex = 7;
            this.measuringDeviceValueTextBox.Text = "999.123";
            this.measuringDeviceValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.measuringDeviceValueTextBox.Click += new System.EventHandler(this.measuringDeviceValueTextBox_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(619, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 21);
            this.label16.TabIndex = 5;
            this.label16.Text = "刀長量測器";
            // 
            // downDirectionPictureBox
            // 
            this.downDirectionPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(205)))), ((int)(((byte)(216)))));
            this.downDirectionPictureBox.Image = global::ToolMeasurement.Properties.Resources.down;
            this.downDirectionPictureBox.Location = new System.Drawing.Point(568, 1);
            this.downDirectionPictureBox.Name = "downDirectionPictureBox";
            this.downDirectionPictureBox.Size = new System.Drawing.Size(45, 71);
            this.downDirectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.downDirectionPictureBox.TabIndex = 32;
            this.downDirectionPictureBox.TabStop = false;
            this.downDirectionPictureBox.Visible = false;
            // 
            // spindlePictureBox
            // 
            this.spindlePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(205)))), ((int)(((byte)(216)))));
            this.spindlePictureBox.Image = global::ToolMeasurement.Properties.Resources.spindle;
            this.spindlePictureBox.Location = new System.Drawing.Point(452, 1);
            this.spindlePictureBox.Name = "spindlePictureBox";
            this.spindlePictureBox.Size = new System.Drawing.Size(179, 150);
            this.spindlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spindlePictureBox.TabIndex = 30;
            this.spindlePictureBox.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(205)))), ((int)(((byte)(216)))));
            this.pictureBox3.Image = global::ToolMeasurement.Properties.Resources.tool_height;
            this.pictureBox3.Location = new System.Drawing.Point(470, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(205)))), ((int)(((byte)(216)))));
            this.pictureBox1.Image = global::ToolMeasurement.Properties.Resources.Desk;
            this.pictureBox1.Location = new System.Drawing.Point(336, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // showDownDirTimer
            // 
            this.showDownDirTimer.Interval = 110;
            this.showDownDirTimer.Tick += new System.EventHandler(this.showDownDirTimer_Tick);
            // 
            // TMeas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(205)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(814, 430);
            this.ControlBox = false;
            this.Controls.Add(this.downDirectionPictureBox);
            this.Controls.Add(this.spindlePictureBox);
            this.Controls.Add(this.measuringDeviceValueTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TMeas";
            this.Text = "TMeas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downDirectionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spindlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox toolHeightValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox measuringDeviceValueTextBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox zTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox spindlePictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox downDirectionPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox toolNumComboBox;
        private System.Windows.Forms.Button plus10Button;
        private System.Windows.Forms.Button minus10Button;
        private System.Windows.Forms.Timer showDownDirTimer;
    }
}