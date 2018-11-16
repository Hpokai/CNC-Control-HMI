namespace IDStatus
{
    partial class FORM_Main_IdStatus
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
            this.button1 = new System.Windows.Forms.Button();
            this.IDStatusListBox = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CKBox6 = new System.Windows.Forms.CheckBox();
            this.CKBox5 = new System.Windows.Forms.CheckBox();
            this.CKBox4 = new System.Windows.Forms.CheckBox();
            this.CKBox3 = new System.Windows.Forms.CheckBox();
            this.CKBox2 = new System.Windows.Forms.CheckBox();
            this.CKBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(28, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1140, 433);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // IDStatusListBox
            // 
            this.IDStatusListBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.IDStatusListBox.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IDStatusListBox.ForeColor = System.Drawing.Color.Yellow;
            this.IDStatusListBox.FormattingEnabled = true;
            this.IDStatusListBox.ItemHeight = 37;
            this.IDStatusListBox.Items.AddRange(new object[] {
            "",
            "                 身份說明",
            "",
            " 1. 一般使用者",
            " 2.",
            " 3.",
            " 4.",
            " 5.",
            " 6. 系統管理員"});
            this.IDStatusListBox.Location = new System.Drawing.Point(41, 29);
            this.IDStatusListBox.Name = "IDStatusListBox";
            this.IDStatusListBox.Size = new System.Drawing.Size(868, 374);
            this.IDStatusListBox.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OK.ForeColor = System.Drawing.Color.Indigo;
            this.OK.Location = new System.Drawing.Point(915, 249);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(242, 75);
            this.OK.TabIndex = 3;
            this.OK.Text = "確定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cancel.ForeColor = System.Drawing.Color.Indigo;
            this.Cancel.Location = new System.Drawing.Point(915, 328);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(242, 75);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.CKBox6);
            this.panel1.Controls.Add(this.CKBox5);
            this.panel1.Controls.Add(this.CKBox4);
            this.panel1.Controls.Add(this.CKBox3);
            this.panel1.Controls.Add(this.CKBox2);
            this.panel1.Controls.Add(this.CKBox1);
            this.panel1.Location = new System.Drawing.Point(915, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 214);
            this.panel1.TabIndex = 5;
            // 
            // CKBox6
            // 
            this.CKBox6.AutoSize = true;
            this.CKBox6.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CKBox6.ForeColor = System.Drawing.Color.Yellow;
            this.CKBox6.Location = new System.Drawing.Point(23, 170);
            this.CKBox6.Name = "CKBox6";
            this.CKBox6.Size = new System.Drawing.Size(180, 28);
            this.CKBox6.TabIndex = 5;
            this.CKBox6.Text = "  系統管理者";
            this.CKBox6.UseVisualStyleBackColor = true;
            this.CKBox6.Click += new System.EventHandler(this.CKBox6_Click);
            // 
            // CKBox5
            // 
            this.CKBox5.AutoSize = true;
            this.CKBox5.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CKBox5.ForeColor = System.Drawing.Color.Yellow;
            this.CKBox5.Location = new System.Drawing.Point(23, 138);
            this.CKBox5.Name = "CKBox5";
            this.CKBox5.Size = new System.Drawing.Size(42, 28);
            this.CKBox5.TabIndex = 4;
            this.CKBox5.Text = " ";
            this.CKBox5.UseVisualStyleBackColor = true;
            this.CKBox5.Click += new System.EventHandler(this.CKBox5_Click);
            // 
            // CKBox4
            // 
            this.CKBox4.AutoSize = true;
            this.CKBox4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CKBox4.ForeColor = System.Drawing.Color.Yellow;
            this.CKBox4.Location = new System.Drawing.Point(23, 106);
            this.CKBox4.Name = "CKBox4";
            this.CKBox4.Size = new System.Drawing.Size(42, 28);
            this.CKBox4.TabIndex = 3;
            this.CKBox4.Text = " ";
            this.CKBox4.UseVisualStyleBackColor = true;
            this.CKBox4.Click += new System.EventHandler(this.CKBox4_Click);
            // 
            // CKBox3
            // 
            this.CKBox3.AutoSize = true;
            this.CKBox3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CKBox3.ForeColor = System.Drawing.Color.Yellow;
            this.CKBox3.Location = new System.Drawing.Point(23, 74);
            this.CKBox3.Name = "CKBox3";
            this.CKBox3.Size = new System.Drawing.Size(42, 28);
            this.CKBox3.TabIndex = 2;
            this.CKBox3.Text = " ";
            this.CKBox3.UseVisualStyleBackColor = true;
            this.CKBox3.Click += new System.EventHandler(this.CKBox3_Click);
            // 
            // CKBox2
            // 
            this.CKBox2.AutoSize = true;
            this.CKBox2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CKBox2.ForeColor = System.Drawing.Color.Yellow;
            this.CKBox2.Location = new System.Drawing.Point(23, 42);
            this.CKBox2.Name = "CKBox2";
            this.CKBox2.Size = new System.Drawing.Size(42, 28);
            this.CKBox2.TabIndex = 1;
            this.CKBox2.Text = " ";
            this.CKBox2.UseVisualStyleBackColor = true;
            this.CKBox2.Click += new System.EventHandler(this.CKBox2_Click);
            // 
            // CKBox1
            // 
            this.CKBox1.AutoSize = true;
            this.CKBox1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CKBox1.ForeColor = System.Drawing.Color.Yellow;
            this.CKBox1.Location = new System.Drawing.Point(23, 10);
            this.CKBox1.Name = "CKBox1";
            this.CKBox1.Size = new System.Drawing.Size(180, 28);
            this.CKBox1.TabIndex = 0;
            this.CKBox1.Text = "  一般使用者";
            this.CKBox1.UseVisualStyleBackColor = true;
            this.CKBox1.Click += new System.EventHandler(this.CKBox1_Click);
            // 
            // FORM_Main_IdStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1196, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.IDStatusListBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_Main_IdStatus";
            this.Load += new System.EventHandler(this.MF_Main_IDStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox IDStatusListBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CKBox1;
        private System.Windows.Forms.CheckBox CKBox6;
        private System.Windows.Forms.CheckBox CKBox5;
        private System.Windows.Forms.CheckBox CKBox4;
        private System.Windows.Forms.CheckBox CKBox3;
        private System.Windows.Forms.CheckBox CKBox2;
//        private IDDatabaseDataSet iDDatabaseDataSet;
   //     private System.Windows.Forms.BindingSource iDDataBindingSource;
  //      private IDDatabaseDataSetTableAdapters.IDDataTableAdapter iDDataTableAdapter;
    //    private IDDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}