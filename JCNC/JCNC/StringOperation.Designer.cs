namespace JCNC
{
    partial class StringOperation
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.replaceComboBox = new System.Windows.Forms.ComboBox();
            this.replaceAllCheckBox = new System.Windows.Forms.CheckBox();
            this.editSearchButton = new System.Windows.Forms.Button();
            this.editReplaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchLabel.Location = new System.Drawing.Point(12, 13);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(114, 23);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "尋找目標：";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // replaceLabel
            // 
            this.replaceLabel.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.replaceLabel.Location = new System.Drawing.Point(12, 88);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(114, 23);
            this.replaceLabel.TabIndex = 0;
            this.replaceLabel.Text = "取代成：";
            this.replaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.searchButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchButton.Location = new System.Drawing.Point(18, 185);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(108, 64);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.replaceButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.replaceButton.Location = new System.Drawing.Point(135, 185);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(108, 64);
            this.replaceButton.TabIndex = 2;
            this.replaceButton.Text = "取代";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cancelButton.Location = new System.Drawing.Point(252, 185);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 64);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // searchComboBox
            // 
            this.searchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchComboBox.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(16, 39);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(260, 35);
            this.searchComboBox.TabIndex = 3;
            // 
            // replaceComboBox
            // 
            this.replaceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replaceComboBox.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.replaceComboBox.FormattingEnabled = true;
            this.replaceComboBox.Location = new System.Drawing.Point(16, 114);
            this.replaceComboBox.Name = "replaceComboBox";
            this.replaceComboBox.Size = new System.Drawing.Size(260, 35);
            this.replaceComboBox.TabIndex = 3;
            // 
            // replaceAllCheckBox
            // 
            this.replaceAllCheckBox.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.replaceAllCheckBox.Location = new System.Drawing.Point(154, 155);
            this.replaceAllCheckBox.Name = "replaceAllCheckBox";
            this.replaceAllCheckBox.Size = new System.Drawing.Size(80, 31);
            this.replaceAllCheckBox.TabIndex = 4;
            this.replaceAllCheckBox.Text = "全部";
            this.replaceAllCheckBox.UseVisualStyleBackColor = true;
            this.replaceAllCheckBox.CheckedChanged += new System.EventHandler(this.replaceAllCheckBox_CheckedChanged);
            // 
            // editSearchButton
            // 
            this.editSearchButton.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editSearchButton.Location = new System.Drawing.Point(282, 30);
            this.editSearchButton.Name = "editSearchButton";
            this.editSearchButton.Size = new System.Drawing.Size(78, 52);
            this.editSearchButton.TabIndex = 5;
            this.editSearchButton.Text = "編輯";
            this.editSearchButton.UseVisualStyleBackColor = true;
            this.editSearchButton.Click += new System.EventHandler(this.editSearchButton_Click);
            // 
            // editReplaceButton
            // 
            this.editReplaceButton.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editReplaceButton.Location = new System.Drawing.Point(282, 105);
            this.editReplaceButton.Name = "editReplaceButton";
            this.editReplaceButton.Size = new System.Drawing.Size(78, 52);
            this.editReplaceButton.TabIndex = 6;
            this.editReplaceButton.Text = "編輯";
            this.editReplaceButton.UseVisualStyleBackColor = true;
            this.editReplaceButton.Click += new System.EventHandler(this.editReplaceButton_Click);
            // 
            // StringOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(372, 259);
            this.ControlBox = false;
            this.Controls.Add(this.editReplaceButton);
            this.Controls.Add(this.editSearchButton);
            this.Controls.Add(this.replaceAllCheckBox);
            this.Controls.Add(this.replaceComboBox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.replaceLabel);
            this.Controls.Add(this.searchLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(60, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StringOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "尋找與取代";
            this.Load += new System.EventHandler(this.StringOperation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.ComboBox replaceComboBox;
        private System.Windows.Forms.CheckBox replaceAllCheckBox;
        private System.Windows.Forms.Button editSearchButton;
        private System.Windows.Forms.Button editReplaceButton;
    }
}