namespace PagesAuthority
{
    partial class FORM_Main_Priority
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
            this.AuthorityTabControl = new System.Windows.Forms.TabControl();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.tabOffset = new System.Windows.Forms.TabPage();
            this.tabDiagnosis = new System.Windows.Forms.TabPage();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabParameter = new System.Windows.Forms.TabPage();
            this.AuthorityTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorityTabControl
            // 
            this.AuthorityTabControl.Controls.Add(this.tabMonitor);
            this.AuthorityTabControl.Controls.Add(this.tabProgram);
            this.AuthorityTabControl.Controls.Add(this.tabOffset);
            this.AuthorityTabControl.Controls.Add(this.tabDiagnosis);
            this.AuthorityTabControl.Controls.Add(this.tabMain);
            this.AuthorityTabControl.Controls.Add(this.tabParameter);
            this.AuthorityTabControl.ItemSize = new System.Drawing.Size(160, 50);
            this.AuthorityTabControl.Location = new System.Drawing.Point(41, 12);
            this.AuthorityTabControl.Name = "AuthorityTabControl";
            this.AuthorityTabControl.SelectedIndex = 0;
            this.AuthorityTabControl.Size = new System.Drawing.Size(1119, 412);
            this.AuthorityTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AuthorityTabControl.TabIndex = 0;
            this.AuthorityTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.AuthorityTabControl_Selecting);
            // 
            // tabMonitor
            // 
            this.tabMonitor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMonitor.Location = new System.Drawing.Point(4, 54);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitor.Size = new System.Drawing.Size(1111, 354);
            this.tabMonitor.TabIndex = 0;
            this.tabMonitor.Text = "Monitor";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // tabProgram
            // 
            this.tabProgram.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProgram.Location = new System.Drawing.Point(4, 54);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(1111, 354);
            this.tabProgram.TabIndex = 1;
            this.tabProgram.Text = "Program";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // tabOffset
            // 
            this.tabOffset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOffset.Location = new System.Drawing.Point(4, 54);
            this.tabOffset.Name = "tabOffset";
            this.tabOffset.Size = new System.Drawing.Size(1111, 354);
            this.tabOffset.TabIndex = 2;
            this.tabOffset.Text = "Offset";
            this.tabOffset.UseVisualStyleBackColor = true;
            // 
            // tabDiagnosis
            // 
            this.tabDiagnosis.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDiagnosis.Location = new System.Drawing.Point(4, 54);
            this.tabDiagnosis.Name = "tabDiagnosis";
            this.tabDiagnosis.Size = new System.Drawing.Size(1111, 354);
            this.tabDiagnosis.TabIndex = 3;
            this.tabDiagnosis.Text = "Diagnosis";
            this.tabDiagnosis.UseVisualStyleBackColor = true;
            // 
            // tabMain
            // 
            this.tabMain.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(4, 54);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(1111, 354);
            this.tabMain.TabIndex = 4;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabParameter
            // 
            this.tabParameter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabParameter.Location = new System.Drawing.Point(4, 54);
            this.tabParameter.Name = "tabParameter";
            this.tabParameter.Size = new System.Drawing.Size(1111, 354);
            this.tabParameter.TabIndex = 5;
            this.tabParameter.Text = "Parameter";
            this.tabParameter.UseVisualStyleBackColor = true;
            // 
            // FORM_Main_Priority
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 436);
            this.Controls.Add(this.AuthorityTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_Main_Priority";
            this.Text = "Authority";
            this.Load += new System.EventHandler(this.MF_Main_Authority_Load);
            this.AuthorityTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AuthorityTabControl;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.TabPage tabProgram;
        private System.Windows.Forms.TabPage tabOffset;
        private System.Windows.Forms.TabPage tabDiagnosis;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabParameter;
    }
}