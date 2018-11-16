namespace Offset
{
    partial class FORM_Off_CoordinateSystem
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
            this.MacCood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RelX = new System.Windows.Forms.Label();
            this.RelY = new System.Windows.Forms.Label();
            this.RelZ = new System.Windows.Forms.Label();
            this.RelC = new System.Windows.Forms.Label();
            this.AbsCood_XValue = new System.Windows.Forms.Label();
            this.AbsCood_YValue = new System.Windows.Forms.Label();
            this.AbsCood_ZValue = new System.Windows.Forms.Label();
            this.AbsCood_CValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OffsetFuncPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.CSUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.MacCood_X = new System.Windows.Forms.Button();
            this.MacCood_Y = new System.Windows.Forms.Button();
            this.MacCood_Z = new System.Windows.Forms.Button();
            this.MacCood_C_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MacCood
            // 
            this.MacCood.AutoSize = true;
            this.MacCood.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.MacCood.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MacCood.ForeColor = System.Drawing.Color.Navy;
            this.MacCood.Location = new System.Drawing.Point(32, 5);
            this.MacCood.Name = "MacCood";
            this.MacCood.Size = new System.Drawing.Size(147, 32);
            this.MacCood.TabIndex = 31;
            this.MacCood.Text = "相對座標";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "機械座標";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 31);
            this.label5.TabIndex = 35;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 29;
            this.label4.Text = "Z";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(30, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 153);
            this.panel2.TabIndex = 37;
            // 
            // RelX
            // 
            this.RelX.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.RelX.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelX.ForeColor = System.Drawing.Color.Navy;
            this.RelX.Location = new System.Drawing.Point(91, 42);
            this.RelX.Name = "RelX";
            this.RelX.Size = new System.Drawing.Size(198, 40);
            this.RelX.TabIndex = 38;
            this.RelX.Text = "0.000";
            this.RelX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RelY
            // 
            this.RelY.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.RelY.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelY.ForeColor = System.Drawing.Color.Navy;
            this.RelY.Location = new System.Drawing.Point(91, 88);
            this.RelY.Name = "RelY";
            this.RelY.Size = new System.Drawing.Size(198, 40);
            this.RelY.TabIndex = 39;
            this.RelY.Text = "0.000";
            this.RelY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RelZ
            // 
            this.RelZ.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.RelZ.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelZ.ForeColor = System.Drawing.Color.Navy;
            this.RelZ.Location = new System.Drawing.Point(91, 134);
            this.RelZ.Name = "RelZ";
            this.RelZ.Size = new System.Drawing.Size(198, 40);
            this.RelZ.TabIndex = 40;
            this.RelZ.Text = "0.000";
            this.RelZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RelC
            // 
            this.RelC.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.RelC.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelC.ForeColor = System.Drawing.Color.Navy;
            this.RelC.Location = new System.Drawing.Point(91, 180);
            this.RelC.Name = "RelC";
            this.RelC.Size = new System.Drawing.Size(198, 40);
            this.RelC.TabIndex = 41;
            this.RelC.Text = "0.000";
            this.RelC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbsCood_XValue
            // 
            this.AbsCood_XValue.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AbsCood_XValue.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsCood_XValue.ForeColor = System.Drawing.Color.Navy;
            this.AbsCood_XValue.Location = new System.Drawing.Point(75, 272);
            this.AbsCood_XValue.Name = "AbsCood_XValue";
            this.AbsCood_XValue.Size = new System.Drawing.Size(170, 34);
            this.AbsCood_XValue.TabIndex = 42;
            this.AbsCood_XValue.Text = "0.000";
            this.AbsCood_XValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbsCood_YValue
            // 
            this.AbsCood_YValue.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AbsCood_YValue.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsCood_YValue.ForeColor = System.Drawing.Color.Navy;
            this.AbsCood_YValue.Location = new System.Drawing.Point(75, 311);
            this.AbsCood_YValue.Name = "AbsCood_YValue";
            this.AbsCood_YValue.Size = new System.Drawing.Size(170, 34);
            this.AbsCood_YValue.TabIndex = 43;
            this.AbsCood_YValue.Text = "0.000";
            this.AbsCood_YValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbsCood_ZValue
            // 
            this.AbsCood_ZValue.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AbsCood_ZValue.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsCood_ZValue.ForeColor = System.Drawing.Color.Navy;
            this.AbsCood_ZValue.Location = new System.Drawing.Point(75, 350);
            this.AbsCood_ZValue.Name = "AbsCood_ZValue";
            this.AbsCood_ZValue.Size = new System.Drawing.Size(170, 34);
            this.AbsCood_ZValue.TabIndex = 44;
            this.AbsCood_ZValue.Text = "0.000";
            this.AbsCood_ZValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbsCood_CValue
            // 
            this.AbsCood_CValue.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AbsCood_CValue.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsCood_CValue.ForeColor = System.Drawing.Color.Navy;
            this.AbsCood_CValue.Location = new System.Drawing.Point(75, 389);
            this.AbsCood_CValue.Name = "AbsCood_CValue";
            this.AbsCood_CValue.Size = new System.Drawing.Size(170, 34);
            this.AbsCood_CValue.TabIndex = 45;
            this.AbsCood_CValue.Text = "0.000";
            this.AbsCood_CValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(5, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 430);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // OffsetFuncPanel
            // 
            this.OffsetFuncPanel.Location = new System.Drawing.Point(379, 2);
            this.OffsetFuncPanel.Name = "OffsetFuncPanel";
            this.OffsetFuncPanel.Size = new System.Drawing.Size(814, 430);
            this.OffsetFuncPanel.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(311, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 430);
            this.button2.TabIndex = 49;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CSUpdateTimer
            // 
            this.CSUpdateTimer.Tick += new System.EventHandler(this.CSUpdateTimer_Tick);
            // 
            // MacCood_X
            // 
            this.MacCood_X.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MacCood_X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MacCood_X.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MacCood_X.Location = new System.Drawing.Point(32, 48);
            this.MacCood_X.Name = "MacCood_X";
            this.MacCood_X.Size = new System.Drawing.Size(38, 36);
            this.MacCood_X.TabIndex = 50;
            this.MacCood_X.Text = "X";
            this.MacCood_X.UseVisualStyleBackColor = false;
            this.MacCood_X.Click += new System.EventHandler(this.MacCood_X_Click);
            // 
            // MacCood_Y
            // 
            this.MacCood_Y.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MacCood_Y.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MacCood_Y.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MacCood_Y.Location = new System.Drawing.Point(32, 93);
            this.MacCood_Y.Name = "MacCood_Y";
            this.MacCood_Y.Size = new System.Drawing.Size(38, 36);
            this.MacCood_Y.TabIndex = 51;
            this.MacCood_Y.Text = "Y";
            this.MacCood_Y.UseVisualStyleBackColor = false;
            this.MacCood_Y.Click += new System.EventHandler(this.MacCood_Y_Click);
            // 
            // MacCood_Z
            // 
            this.MacCood_Z.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MacCood_Z.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MacCood_Z.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MacCood_Z.Location = new System.Drawing.Point(32, 138);
            this.MacCood_Z.Name = "MacCood_Z";
            this.MacCood_Z.Size = new System.Drawing.Size(38, 36);
            this.MacCood_Z.TabIndex = 52;
            this.MacCood_Z.Text = "Z";
            this.MacCood_Z.UseVisualStyleBackColor = false;
            this.MacCood_Z.Click += new System.EventHandler(this.MacCood_Z_Click);
            // 
            // MacCood_C_
            // 
            this.MacCood_C_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MacCood_C_.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MacCood_C_.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MacCood_C_.Location = new System.Drawing.Point(32, 183);
            this.MacCood_C_.Name = "MacCood_C_";
            this.MacCood_C_.Size = new System.Drawing.Size(38, 36);
            this.MacCood_C_.TabIndex = 53;
            this.MacCood_C_.Text = "C";
            this.MacCood_C_.UseVisualStyleBackColor = false;
            this.MacCood_C_.Click += new System.EventHandler(this.MacCood_C__Click);
            // 
            // FORM_Off_CoordinateSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1196, 436);
            this.Controls.Add(this.MacCood_C_);
            this.Controls.Add(this.MacCood_Z);
            this.Controls.Add(this.MacCood_Y);
            this.Controls.Add(this.MacCood_X);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OffsetFuncPanel);
            this.Controls.Add(this.AbsCood_CValue);
            this.Controls.Add(this.AbsCood_ZValue);
            this.Controls.Add(this.AbsCood_YValue);
            this.Controls.Add(this.AbsCood_XValue);
            this.Controls.Add(this.RelC);
            this.Controls.Add(this.RelZ);
            this.Controls.Add(this.RelY);
            this.Controls.Add(this.RelX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MacCood);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_Off_CoordinateSystem";
            this.Text = "v";
            this.Load += new System.EventHandler(this.MF_Offset_CS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MacCood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RelX;
        private System.Windows.Forms.Label RelY;
        private System.Windows.Forms.Label RelZ;
        private System.Windows.Forms.Label RelC;
        private System.Windows.Forms.Label AbsCood_XValue;
        private System.Windows.Forms.Label AbsCood_YValue;
        private System.Windows.Forms.Label AbsCood_ZValue;
        private System.Windows.Forms.Label AbsCood_CValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel OffsetFuncPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer CSUpdateTimer;
        private System.Windows.Forms.Button MacCood_X;
        private System.Windows.Forms.Button MacCood_Y;
        private System.Windows.Forms.Button MacCood_Z;
        private System.Windows.Forms.Button MacCood_C_;
    }
}