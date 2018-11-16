namespace PagesAuthority
{
    partial class Functions
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
            this.tabLevel = new System.Windows.Forms.TabControl();
            this.tabLevel1 = new System.Windows.Forms.TabPage();
            this.tabLevel2 = new System.Windows.Forms.TabPage();
            this.tabLevel3 = new System.Windows.Forms.TabPage();
            this.tabLevel4 = new System.Windows.Forms.TabPage();
            this.tabLevel5 = new System.Windows.Forms.TabPage();
            this.tabLevel6 = new System.Windows.Forms.TabPage();
            this.tabLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLevel
            // 
            this.tabLevel.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabLevel.Controls.Add(this.tabLevel1);
            this.tabLevel.Controls.Add(this.tabLevel2);
            this.tabLevel.Controls.Add(this.tabLevel3);
            this.tabLevel.Controls.Add(this.tabLevel4);
            this.tabLevel.Controls.Add(this.tabLevel5);
            this.tabLevel.Controls.Add(this.tabLevel6);
            this.tabLevel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabLevel.ItemSize = new System.Drawing.Size(120, 30);
            this.tabLevel.Location = new System.Drawing.Point(12, 12);
            this.tabLevel.Multiline = true;
            this.tabLevel.Name = "tabLevel";
            this.tabLevel.SelectedIndex = 0;
            this.tabLevel.Size = new System.Drawing.Size(1087, 330);
            this.tabLevel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabLevel.TabIndex = 0;
            this.tabLevel.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabLevel_Selecting);
            // 
            // tabLevel1
            // 
            this.tabLevel1.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabLevel1.Location = new System.Drawing.Point(4, 4);
            this.tabLevel1.Name = "tabLevel1";
            this.tabLevel1.Padding = new System.Windows.Forms.Padding(3);
            this.tabLevel1.Size = new System.Drawing.Size(1079, 292);
            this.tabLevel1.TabIndex = 0;
            this.tabLevel1.Text = "一般使用者";
            this.tabLevel1.UseVisualStyleBackColor = true;
            // 
            // tabLevel2
            // 
            this.tabLevel2.Location = new System.Drawing.Point(4, 4);
            this.tabLevel2.Name = "tabLevel2";
            this.tabLevel2.Padding = new System.Windows.Forms.Padding(3);
            this.tabLevel2.Size = new System.Drawing.Size(1079, 292);
            this.tabLevel2.TabIndex = 1;
            this.tabLevel2.Text = "Levl2";
            this.tabLevel2.UseVisualStyleBackColor = true;
            // 
            // tabLevel3
            // 
            this.tabLevel3.Location = new System.Drawing.Point(4, 4);
            this.tabLevel3.Name = "tabLevel3";
            this.tabLevel3.Size = new System.Drawing.Size(1079, 292);
            this.tabLevel3.TabIndex = 2;
            this.tabLevel3.Text = "Levl3";
            this.tabLevel3.UseVisualStyleBackColor = true;
            // 
            // tabLevel4
            // 
            this.tabLevel4.Location = new System.Drawing.Point(4, 4);
            this.tabLevel4.Name = "tabLevel4";
            this.tabLevel4.Size = new System.Drawing.Size(1079, 292);
            this.tabLevel4.TabIndex = 3;
            this.tabLevel4.Text = "Levl4";
            this.tabLevel4.UseVisualStyleBackColor = true;
            // 
            // tabLevel5
            // 
            this.tabLevel5.Location = new System.Drawing.Point(4, 4);
            this.tabLevel5.Name = "tabLevel5";
            this.tabLevel5.Size = new System.Drawing.Size(1079, 292);
            this.tabLevel5.TabIndex = 4;
            this.tabLevel5.Text = "Levl5";
            this.tabLevel5.UseVisualStyleBackColor = true;
            // 
            // tabLevel6
            // 
            this.tabLevel6.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabLevel6.Location = new System.Drawing.Point(4, 4);
            this.tabLevel6.Name = "tabLevel6";
            this.tabLevel6.Size = new System.Drawing.Size(1079, 292);
            this.tabLevel6.TabIndex = 5;
            this.tabLevel6.Text = "系統管理員";
            this.tabLevel6.UseVisualStyleBackColor = true;
            // 
            // Functions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1111, 354);
            this.Controls.Add(this.tabLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Functions";
            this.Text = "Functions";
            this.Load += new System.EventHandler(this.Functions_Load);
            this.tabLevel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLevel;
        private System.Windows.Forms.TabPage tabLevel1;
        private System.Windows.Forms.TabPage tabLevel2;
        private System.Windows.Forms.TabPage tabLevel3;
        private System.Windows.Forms.TabPage tabLevel4;
        private System.Windows.Forms.TabPage tabLevel5;
        private System.Windows.Forms.TabPage tabLevel6;
    }
}