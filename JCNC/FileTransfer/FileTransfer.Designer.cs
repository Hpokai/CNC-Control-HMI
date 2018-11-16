namespace FileTransfer
{
    partial class FORM_Prog_FileTransfer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PathFileName = new System.Windows.Forms.Label();
            this.localFileListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.selectAllLocalButton = new System.Windows.Forms.Button();
            this.deleteLocalButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.usbFileListBox = new System.Windows.Forms.ListBox();
            this.loadUSBButton = new System.Windows.Forms.Button();
            this.selectAllUSBButton = new System.Windows.Forms.Button();
            this.deleteUSBButton = new System.Windows.Forms.Button();
            this.closeUSBFileButton = new System.Windows.Forms.Button();
            this.usbFileNumLabel = new System.Windows.Forms.Label();
            this.localFileNumLabel = new System.Windows.Forms.Label();
            this.toUSBTransferButton = new System.Windows.Forms.Button();
            this.refreshFileListButton = new System.Windows.Forms.Button();
            this.toLocalTransferButton = new System.Windows.Forms.Button();
            this.localVScrollBar = new System.Windows.Forms.VScrollBar();
            this.usbVScrollBar = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // PathFileName
            // 
            this.PathFileName.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PathFileName.Location = new System.Drawing.Point(199, 9);
            this.PathFileName.Name = "PathFileName";
            this.PathFileName.Size = new System.Drawing.Size(117, 32);
            this.PathFileName.TabIndex = 33;
            this.PathFileName.Text = "本機";
            this.PathFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // localFileListBox
            // 
            this.localFileListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.localFileListBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localFileListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.localFileListBox.FormattingEnabled = true;
            this.localFileListBox.HorizontalScrollbar = true;
            this.localFileListBox.ItemHeight = 27;
            this.localFileListBox.Location = new System.Drawing.Point(53, 44);
            this.localFileListBox.Name = "localFileListBox";
            this.localFileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.localFileListBox.Size = new System.Drawing.Size(395, 328);
            this.localFileListBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(873, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "USB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(480, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 72);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(480, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 72);
            this.button3.TabIndex = 36;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // selectAllLocalButton
            // 
            this.selectAllLocalButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectAllLocalButton.Location = new System.Drawing.Point(159, 378);
            this.selectAllLocalButton.Name = "selectAllLocalButton";
            this.selectAllLocalButton.Size = new System.Drawing.Size(101, 51);
            this.selectAllLocalButton.TabIndex = 36;
            this.selectAllLocalButton.Text = "全選";
            this.selectAllLocalButton.UseVisualStyleBackColor = true;
            this.selectAllLocalButton.Click += new System.EventHandler(this.selectAllLocalButton_Click);
            // 
            // deleteLocalButton
            // 
            this.deleteLocalButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteLocalButton.Location = new System.Drawing.Point(265, 378);
            this.deleteLocalButton.Name = "deleteLocalButton";
            this.deleteLocalButton.Size = new System.Drawing.Size(101, 51);
            this.deleteLocalButton.TabIndex = 36;
            this.deleteLocalButton.Text = "刪除";
            this.deleteLocalButton.UseVisualStyleBackColor = true;
            this.deleteLocalButton.Click += new System.EventHandler(this.deleteLocalButton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(371, 378);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 51);
            this.button7.TabIndex = 36;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // usbFileListBox
            // 
            this.usbFileListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usbFileListBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usbFileListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.usbFileListBox.FormattingEnabled = true;
            this.usbFileListBox.HorizontalScrollbar = true;
            this.usbFileListBox.ItemHeight = 27;
            this.usbFileListBox.Location = new System.Drawing.Point(718, 44);
            this.usbFileListBox.Name = "usbFileListBox";
            this.usbFileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.usbFileListBox.Size = new System.Drawing.Size(395, 328);
            this.usbFileListBox.TabIndex = 32;
            // 
            // loadUSBButton
            // 
            this.loadUSBButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loadUSBButton.Location = new System.Drawing.Point(718, 378);
            this.loadUSBButton.Name = "loadUSBButton";
            this.loadUSBButton.Size = new System.Drawing.Size(101, 51);
            this.loadUSBButton.TabIndex = 36;
            this.loadUSBButton.Text = "載入";
            this.loadUSBButton.UseVisualStyleBackColor = true;
            this.loadUSBButton.Click += new System.EventHandler(this.loadUSBButton_Click);
            // 
            // selectAllUSBButton
            // 
            this.selectAllUSBButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectAllUSBButton.Location = new System.Drawing.Point(824, 378);
            this.selectAllUSBButton.Name = "selectAllUSBButton";
            this.selectAllUSBButton.Size = new System.Drawing.Size(101, 51);
            this.selectAllUSBButton.TabIndex = 36;
            this.selectAllUSBButton.Text = "全選";
            this.selectAllUSBButton.UseVisualStyleBackColor = true;
            this.selectAllUSBButton.Click += new System.EventHandler(this.selectAllUSBButton_Click);
            // 
            // deleteUSBButton
            // 
            this.deleteUSBButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteUSBButton.Location = new System.Drawing.Point(930, 378);
            this.deleteUSBButton.Name = "deleteUSBButton";
            this.deleteUSBButton.Size = new System.Drawing.Size(101, 51);
            this.deleteUSBButton.TabIndex = 36;
            this.deleteUSBButton.Text = "刪除";
            this.deleteUSBButton.UseVisualStyleBackColor = true;
            this.deleteUSBButton.Click += new System.EventHandler(this.deleteUSBButton_Click);
            // 
            // closeUSBFileButton
            // 
            this.closeUSBFileButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeUSBFileButton.Location = new System.Drawing.Point(1036, 378);
            this.closeUSBFileButton.Name = "closeUSBFileButton";
            this.closeUSBFileButton.Size = new System.Drawing.Size(101, 51);
            this.closeUSBFileButton.TabIndex = 36;
            this.closeUSBFileButton.Text = "關閉";
            this.closeUSBFileButton.UseVisualStyleBackColor = true;
            this.closeUSBFileButton.Click += new System.EventHandler(this.closeUSBFileButton_Click);
            // 
            // usbFileNumLabel
            // 
            this.usbFileNumLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usbFileNumLabel.Location = new System.Drawing.Point(713, 17);
            this.usbFileNumLabel.Name = "usbFileNumLabel";
            this.usbFileNumLabel.Size = new System.Drawing.Size(154, 26);
            this.usbFileNumLabel.TabIndex = 37;
            this.usbFileNumLabel.Text = "file: 10000";
            this.usbFileNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // localFileNumLabel
            // 
            this.localFileNumLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localFileNumLabel.Location = new System.Drawing.Point(49, 17);
            this.localFileNumLabel.Name = "localFileNumLabel";
            this.localFileNumLabel.Size = new System.Drawing.Size(154, 26);
            this.localFileNumLabel.TabIndex = 38;
            this.localFileNumLabel.Text = "file: 10000";
            this.localFileNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toUSBTransferButton
            // 
            this.toUSBTransferButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toUSBTransferButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toUSBTransferButton.Image = global::FileTransfer.Properties.Resources.right;
            this.toUSBTransferButton.Location = new System.Drawing.Point(480, 129);
            this.toUSBTransferButton.Name = "toUSBTransferButton";
            this.toUSBTransferButton.Size = new System.Drawing.Size(232, 72);
            this.toUSBTransferButton.TabIndex = 36;
            this.toUSBTransferButton.UseVisualStyleBackColor = true;
            this.toUSBTransferButton.Click += new System.EventHandler(this.toUSBTransferButton_Click);
            // 
            // refreshFileListButton
            // 
            this.refreshFileListButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.refreshFileListButton.Image = global::FileTransfer.Properties.Resources.refresh;
            this.refreshFileListButton.Location = new System.Drawing.Point(53, 378);
            this.refreshFileListButton.Name = "refreshFileListButton";
            this.refreshFileListButton.Size = new System.Drawing.Size(101, 51);
            this.refreshFileListButton.TabIndex = 36;
            this.refreshFileListButton.UseVisualStyleBackColor = true;
            this.refreshFileListButton.Click += new System.EventHandler(this.refreshFileListButton_Click);
            // 
            // toLocalTransferButton
            // 
            this.toLocalTransferButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toLocalTransferButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toLocalTransferButton.Image = global::FileTransfer.Properties.Resources.left;
            this.toLocalTransferButton.Location = new System.Drawing.Point(478, 214);
            this.toLocalTransferButton.Name = "toLocalTransferButton";
            this.toLocalTransferButton.Size = new System.Drawing.Size(232, 72);
            this.toLocalTransferButton.TabIndex = 36;
            this.toLocalTransferButton.UseVisualStyleBackColor = true;
            this.toLocalTransferButton.Click += new System.EventHandler(this.toLocalTransferButton_Click);
            // 
            // localVScrollBar
            // 
            this.localVScrollBar.Location = new System.Drawing.Point(429, 44);
            this.localVScrollBar.Name = "localVScrollBar";
            this.localVScrollBar.Size = new System.Drawing.Size(43, 328);
            this.localVScrollBar.TabIndex = 131;
            this.localVScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.localVScrollBar_Scroll);
            // 
            // usbVScrollBar
            // 
            this.usbVScrollBar.Location = new System.Drawing.Point(1094, 44);
            this.usbVScrollBar.Name = "usbVScrollBar";
            this.usbVScrollBar.Size = new System.Drawing.Size(43, 328);
            this.usbVScrollBar.TabIndex = 132;
            this.usbVScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.usbVScrollBar_Scroll);
            // 
            // FORM_Prog_FileTransfer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1196, 438);
            this.Controls.Add(this.usbVScrollBar);
            this.Controls.Add(this.localVScrollBar);
            this.Controls.Add(this.localFileNumLabel);
            this.Controls.Add(this.usbFileNumLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toUSBTransferButton);
            this.Controls.Add(this.closeUSBFileButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.deleteUSBButton);
            this.Controls.Add(this.deleteLocalButton);
            this.Controls.Add(this.selectAllUSBButton);
            this.Controls.Add(this.selectAllLocalButton);
            this.Controls.Add(this.loadUSBButton);
            this.Controls.Add(this.refreshFileListButton);
            this.Controls.Add(this.toLocalTransferButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathFileName);
            this.Controls.Add(this.usbFileListBox);
            this.Controls.Add(this.localFileListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_Prog_FileTransfer";
            this.Text = "FileTransfer";
            this.Load += new System.EventHandler(this.FileTransfer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PathFileName;
        private System.Windows.Forms.ListBox localFileListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toLocalTransferButton;
        private System.Windows.Forms.Button toUSBTransferButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button refreshFileListButton;
        private System.Windows.Forms.Button selectAllLocalButton;
        private System.Windows.Forms.Button deleteLocalButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox usbFileListBox;
        private System.Windows.Forms.Button loadUSBButton;
        private System.Windows.Forms.Button selectAllUSBButton;
        private System.Windows.Forms.Button deleteUSBButton;
        private System.Windows.Forms.Button closeUSBFileButton;
        private System.Windows.Forms.Label usbFileNumLabel;
        private System.Windows.Forms.Label localFileNumLabel;
        private System.Windows.Forms.VScrollBar localVScrollBar;
        private System.Windows.Forms.VScrollBar usbVScrollBar;
    }
}

