namespace PureCoordinate
{
    partial class FORM_Mon_PureCoordinate
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
            this.cValueLabel = new System.Windows.Forms.Label();
            this.zValueLabel = new System.Windows.Forms.Label();
            this.yValueLabel = new System.Windows.Forms.Label();
            this.xValueLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.machineCoordinateRadioButton = new System.Windows.Forms.RadioButton();
            this.programCoordinateRadioButton = new System.Windows.Forms.RadioButton();
            this.relativeCoordinateRadioButton = new System.Windows.Forms.RadioButton();
            this.distanceToGoRadioButton = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.coordinateLabel = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cValueLabel
            // 
            this.cValueLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.cValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cValueLabel.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.cValueLabel.ForeColor = System.Drawing.Color.White;
            this.cValueLabel.Location = new System.Drawing.Point(115, 320);
            this.cValueLabel.Name = "cValueLabel";
            this.cValueLabel.Size = new System.Drawing.Size(200, 71);
            this.cValueLabel.TabIndex = 8;
            this.cValueLabel.Text = "0.000";
            this.cValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zValueLabel
            // 
            this.zValueLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.zValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zValueLabel.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.zValueLabel.ForeColor = System.Drawing.Color.White;
            this.zValueLabel.Location = new System.Drawing.Point(115, 244);
            this.zValueLabel.Name = "zValueLabel";
            this.zValueLabel.Size = new System.Drawing.Size(200, 71);
            this.zValueLabel.TabIndex = 7;
            this.zValueLabel.Text = "000.000";
            this.zValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yValueLabel
            // 
            this.yValueLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.yValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yValueLabel.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.yValueLabel.ForeColor = System.Drawing.Color.White;
            this.yValueLabel.Location = new System.Drawing.Point(115, 168);
            this.yValueLabel.Name = "yValueLabel";
            this.yValueLabel.Size = new System.Drawing.Size(200, 71);
            this.yValueLabel.TabIndex = 6;
            this.yValueLabel.Text = "999.999";
            this.yValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xValueLabel
            // 
            this.xValueLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.xValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xValueLabel.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.xValueLabel.ForeColor = System.Drawing.Color.White;
            this.xValueLabel.Location = new System.Drawing.Point(115, 92);
            this.xValueLabel.Name = "xValueLabel";
            this.xValueLabel.Size = new System.Drawing.Size(200, 71);
            this.xValueLabel.TabIndex = 5;
            this.xValueLabel.Text = "label19";
            this.xValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel
            // 
            this.cLabel.BackColor = System.Drawing.Color.LightGreen;
            this.cLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.Location = new System.Drawing.Point(39, 320);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(71, 71);
            this.cLabel.TabIndex = 4;
            this.cLabel.Text = "C";
            this.cLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLabel.Click += new System.EventHandler(this.axisLabel_Click);
            // 
            // zLabel
            // 
            this.zLabel.BackColor = System.Drawing.Color.LightGreen;
            this.zLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zLabel.Location = new System.Drawing.Point(39, 244);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(71, 71);
            this.zLabel.TabIndex = 3;
            this.zLabel.Text = "Z";
            this.zLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zLabel.Click += new System.EventHandler(this.axisLabel_Click);
            // 
            // yLabel
            // 
            this.yLabel.BackColor = System.Drawing.Color.LightGreen;
            this.yLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yLabel.Location = new System.Drawing.Point(39, 168);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(71, 71);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Y";
            this.yLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yLabel.Click += new System.EventHandler(this.axisLabel_Click);
            // 
            // xLabel
            // 
            this.xLabel.BackColor = System.Drawing.Color.LightGreen;
            this.xLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(39, 92);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(71, 71);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "X";
            this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xLabel.Click += new System.EventHandler(this.axisLabel_Click);
            // 
            // machineCoordinateRadioButton
            // 
            this.machineCoordinateRadioButton.Checked = true;
            this.machineCoordinateRadioButton.Font = new System.Drawing.Font("標楷體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.machineCoordinateRadioButton.Location = new System.Drawing.Point(793, 62);
            this.machineCoordinateRadioButton.Name = "machineCoordinateRadioButton";
            this.machineCoordinateRadioButton.Size = new System.Drawing.Size(287, 56);
            this.machineCoordinateRadioButton.TabIndex = 1;
            this.machineCoordinateRadioButton.TabStop = true;
            this.machineCoordinateRadioButton.Text = "機械座標";
            this.machineCoordinateRadioButton.UseVisualStyleBackColor = true;
            this.machineCoordinateRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // programCoordinateRadioButton
            // 
            this.programCoordinateRadioButton.Font = new System.Drawing.Font("標楷體", 30F, System.Drawing.FontStyle.Bold);
            this.programCoordinateRadioButton.Location = new System.Drawing.Point(793, 148);
            this.programCoordinateRadioButton.Name = "programCoordinateRadioButton";
            this.programCoordinateRadioButton.Size = new System.Drawing.Size(287, 56);
            this.programCoordinateRadioButton.TabIndex = 2;
            this.programCoordinateRadioButton.Text = "程式座標";
            this.programCoordinateRadioButton.UseVisualStyleBackColor = true;
            this.programCoordinateRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // relativeCoordinateRadioButton
            // 
            this.relativeCoordinateRadioButton.Font = new System.Drawing.Font("標楷體", 30F, System.Drawing.FontStyle.Bold);
            this.relativeCoordinateRadioButton.Location = new System.Drawing.Point(793, 234);
            this.relativeCoordinateRadioButton.Name = "relativeCoordinateRadioButton";
            this.relativeCoordinateRadioButton.Size = new System.Drawing.Size(287, 56);
            this.relativeCoordinateRadioButton.TabIndex = 3;
            this.relativeCoordinateRadioButton.Text = "相對座標";
            this.relativeCoordinateRadioButton.UseVisualStyleBackColor = true;
            this.relativeCoordinateRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // distanceToGoRadioButton
            // 
            this.distanceToGoRadioButton.Font = new System.Drawing.Font("標楷體", 30F, System.Drawing.FontStyle.Bold);
            this.distanceToGoRadioButton.Location = new System.Drawing.Point(796, 320);
            this.distanceToGoRadioButton.Name = "distanceToGoRadioButton";
            this.distanceToGoRadioButton.Size = new System.Drawing.Size(284, 56);
            this.distanceToGoRadioButton.TabIndex = 4;
            this.distanceToGoRadioButton.Text = "殘餘指令";
            this.distanceToGoRadioButton.UseVisualStyleBackColor = true;
            this.distanceToGoRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel.Controls.Add(this.coordinateLabel);
            this.panel.Controls.Add(this.xLabel);
            this.panel.Controls.Add(this.yLabel);
            this.panel.Controls.Add(this.zLabel);
            this.panel.Controls.Add(this.cLabel);
            this.panel.Controls.Add(this.xValueLabel);
            this.panel.Controls.Add(this.yValueLabel);
            this.panel.Controls.Add(this.zValueLabel);
            this.panel.Controls.Add(this.cValueLabel);
            this.panel.Location = new System.Drawing.Point(421, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(355, 414);
            this.panel.TabIndex = 0;
            // 
            // coordinateLabel
            // 
            this.coordinateLabel.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coordinateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.coordinateLabel.Location = new System.Drawing.Point(39, 23);
            this.coordinateLabel.Name = "coordinateLabel";
            this.coordinateLabel.Size = new System.Drawing.Size(276, 54);
            this.coordinateLabel.TabIndex = 0;
            this.coordinateLabel.Text = "某某座標";
            this.coordinateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // FORM_Mon_PureCoordinate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1196, 438);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.distanceToGoRadioButton);
            this.Controls.Add(this.relativeCoordinateRadioButton);
            this.Controls.Add(this.programCoordinateRadioButton);
            this.Controls.Add(this.machineCoordinateRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_Mon_PureCoordinate";
            this.ShowIcon = false;
            this.Text = "Pure Coordinate";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cValueLabel;
        private System.Windows.Forms.Label zValueLabel;
        private System.Windows.Forms.Label yValueLabel;
        private System.Windows.Forms.Label xValueLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.RadioButton machineCoordinateRadioButton;
        private System.Windows.Forms.RadioButton programCoordinateRadioButton;
        private System.Windows.Forms.RadioButton relativeCoordinateRadioButton;
        private System.Windows.Forms.RadioButton distanceToGoRadioButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label coordinateLabel;
        private System.Windows.Forms.Timer mainTimer;

    }
}