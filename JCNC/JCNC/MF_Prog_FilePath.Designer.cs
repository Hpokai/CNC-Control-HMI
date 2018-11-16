namespace JCNC
{
    partial class FORM_Prog_MemFileEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FilePathInfo = new System.Windows.Forms.ListBox();
            this.PathFileName = new System.Windows.Forms.Label();
            this.FileContent = new System.Windows.Forms.Label();
            this.FileOpen = new System.Windows.Forms.Button();
            this.ChangeFileName = new System.Windows.Forms.Button();
            this.FileDelete = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.memGridView = new System.Windows.Forms.DataGridView();
            this.MGcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.isMultiLineCheckBox = new System.Windows.Forms.CheckBox();
            this.pasteButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.closeFileButton = new System.Windows.Forms.Button();
            this.lineNumLabel = new System.Windows.Forms.Label();
            this.clearRowButton = new System.Windows.Forms.Button();
            this.searchLineButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.saveAsFileButton = new System.Windows.Forms.Button();
            this.unsaveLabel = new System.Windows.Forms.Label();
            this.NewFileOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileListVScrollBar = new System.Windows.Forms.VScrollBar();
            this.FileUpload = new System.Windows.Forms.Button();
            this.refreshFileListButton = new System.Windows.Forms.Button();
            this.memVScrollBar = new System.Windows.Forms.VScrollBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.memGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilePathInfo
            // 
            this.FilePathInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.FilePathInfo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.FilePathInfo.FormattingEnabled = true;
            this.FilePathInfo.HorizontalScrollbar = true;
            this.FilePathInfo.ItemHeight = 27;
            this.FilePathInfo.Location = new System.Drawing.Point(148, 50);
            this.FilePathInfo.Name = "FilePathInfo";
            this.FilePathInfo.ScrollAlwaysVisible = true;
            this.FilePathInfo.Size = new System.Drawing.Size(288, 382);
            this.FilePathInfo.TabIndex = 30;
            this.FilePathInfo.SelectedIndexChanged += new System.EventHandler(this.FilePathInfo_SelectedIndexChanged);
            // 
            // PathFileName
            // 
            this.PathFileName.AutoSize = true;
            this.PathFileName.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PathFileName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PathFileName.Location = new System.Drawing.Point(239, 11);
            this.PathFileName.Name = "PathFileName";
            this.PathFileName.Size = new System.Drawing.Size(147, 32);
            this.PathFileName.TabIndex = 31;
            this.PathFileName.Text = "檔案名稱";
            this.PathFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileContent
            // 
            this.FileContent.AutoSize = true;
            this.FileContent.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FileContent.Location = new System.Drawing.Point(653, 11);
            this.FileContent.Name = "FileContent";
            this.FileContent.Size = new System.Drawing.Size(147, 32);
            this.FileContent.TabIndex = 32;
            this.FileContent.Text = "檔案內容";
            this.FileContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileOpen
            // 
            this.FileOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FileOpen.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FileOpen.Location = new System.Drawing.Point(464, 126);
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(118, 72);
            this.FileOpen.TabIndex = 33;
            this.FileOpen.Text = "檔案開啟";
            this.FileOpen.UseVisualStyleBackColor = true;
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // ChangeFileName
            // 
            this.ChangeFileName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChangeFileName.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChangeFileName.Location = new System.Drawing.Point(464, 359);
            this.ChangeFileName.Name = "ChangeFileName";
            this.ChangeFileName.Size = new System.Drawing.Size(118, 72);
            this.ChangeFileName.TabIndex = 37;
            this.ChangeFileName.Text = "更新檔名";
            this.ChangeFileName.UseVisualStyleBackColor = true;
            this.ChangeFileName.Click += new System.EventHandler(this.ChangeFileName_Click);
            // 
            // FileDelete
            // 
            this.FileDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FileDelete.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FileDelete.Location = new System.Drawing.Point(464, 282);
            this.FileDelete.Name = "FileDelete";
            this.FileDelete.Size = new System.Drawing.Size(118, 72);
            this.FileDelete.TabIndex = 38;
            this.FileDelete.Text = "檔案刪除";
            this.FileDelete.UseVisualStyleBackColor = true;
            this.FileDelete.Click += new System.EventHandler(this.FileDelete_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.inputTextBox.Location = new System.Drawing.Point(527, 337);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.inputTextBox.Size = new System.Drawing.Size(273, 35);
            this.inputTextBox.TabIndex = 86;
            this.inputTextBox.Text = "G00X0Y0";
            this.inputTextBox.Click += new System.EventHandler(this.inputTextBox_Click);
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inputButton.Location = new System.Drawing.Point(806, 337);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(78, 35);
            this.inputButton.TabIndex = 85;
            this.inputButton.Text = "Input";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // memGridView
            // 
            this.memGridView.AllowUserToAddRows = false;
            this.memGridView.AllowUserToDeleteRows = false;
            this.memGridView.AllowUserToResizeColumns = false;
            this.memGridView.AllowUserToResizeRows = false;
            this.memGridView.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.memGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.memGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.memGridView.ColumnHeadersHeight = 25;
            this.memGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.memGridView.ColumnHeadersVisible = false;
            this.memGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MGcode});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.memGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.memGridView.Location = new System.Drawing.Point(449, 50);
            this.memGridView.MultiSelect = false;
            this.memGridView.Name = "memGridView";
            this.memGridView.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.memGridView.RowHeadersVisible = false;
            this.memGridView.RowHeadersWidth = 10;
            this.memGridView.RowTemplate.Height = 36;
            this.memGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memGridView.Size = new System.Drawing.Size(501, 382);
            this.memGridView.TabIndex = 87;
            this.memGridView.SelectionChanged += new System.EventHandler(this.memGridView_SelectionChanged);
            this.memGridView.Click += new System.EventHandler(this.memGridView_Click);
            // 
            // MGcode
            // 
            this.MGcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MGcode.DefaultCellStyle = dataGridViewCellStyle2;
            this.MGcode.FillWeight = 149.2386F;
            this.MGcode.HeaderText = "";
            this.MGcode.Name = "MGcode";
            this.MGcode.ReadOnly = true;
            this.MGcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MGcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // saveFileButton
            // 
            this.saveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveFileButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveFileButton.Location = new System.Drawing.Point(3, 293);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(96, 72);
            this.saveFileButton.TabIndex = 88;
            this.saveFileButton.Text = "檔案\r\n儲存";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // isMultiLineCheckBox
            // 
            this.isMultiLineCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.isMultiLineCheckBox.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.isMultiLineCheckBox.Location = new System.Drawing.Point(865, 5);
            this.isMultiLineCheckBox.Name = "isMultiLineCheckBox";
            this.isMultiLineCheckBox.Size = new System.Drawing.Size(116, 38);
            this.isMultiLineCheckBox.TabIndex = 89;
            this.isMultiLineCheckBox.Text = "多行編輯";
            this.isMultiLineCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isMultiLineCheckBox.UseVisualStyleBackColor = true;
            this.isMultiLineCheckBox.CheckedChanged += new System.EventHandler(this.isMultiLineCheckBox_CheckedChanged);
            // 
            // pasteButton
            // 
            this.pasteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pasteButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pasteButton.Location = new System.Drawing.Point(100, 5);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(96, 72);
            this.pasteButton.TabIndex = 88;
            this.pasteButton.Text = "行貼上";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.copyButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.copyButton.Location = new System.Drawing.Point(3, 5);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(96, 72);
            this.copyButton.TabIndex = 88;
            this.copyButton.Text = "行複製";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteButton.Location = new System.Drawing.Point(3, 77);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 72);
            this.deleteButton.TabIndex = 88;
            this.deleteButton.Text = "行刪除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.insertButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertButton.Location = new System.Drawing.Point(100, 77);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(96, 72);
            this.insertButton.TabIndex = 88;
            this.insertButton.Text = "行插入";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // closeFileButton
            // 
            this.closeFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeFileButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeFileButton.Location = new System.Drawing.Point(3, 371);
            this.closeFileButton.Name = "closeFileButton";
            this.closeFileButton.Size = new System.Drawing.Size(193, 64);
            this.closeFileButton.TabIndex = 88;
            this.closeFileButton.Text = "檔案關閉";
            this.closeFileButton.UseVisualStyleBackColor = true;
            this.closeFileButton.Click += new System.EventHandler(this.closeFileButton_Click);
            // 
            // lineNumLabel
            // 
            this.lineNumLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineNumLabel.Location = new System.Drawing.Point(450, 18);
            this.lineNumLabel.Name = "lineNumLabel";
            this.lineNumLabel.Size = new System.Drawing.Size(154, 26);
            this.lineNumLabel.TabIndex = 32;
            this.lineNumLabel.Text = "LN: 10000";
            this.lineNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clearRowButton
            // 
            this.clearRowButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearRowButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearRowButton.Location = new System.Drawing.Point(3, 149);
            this.clearRowButton.Name = "clearRowButton";
            this.clearRowButton.Size = new System.Drawing.Size(96, 72);
            this.clearRowButton.TabIndex = 88;
            this.clearRowButton.Text = "行清除";
            this.clearRowButton.UseVisualStyleBackColor = true;
            this.clearRowButton.Click += new System.EventHandler(this.clearRowButton_Click);
            // 
            // searchLineButton
            // 
            this.searchLineButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchLineButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchLineButton.Location = new System.Drawing.Point(100, 149);
            this.searchLineButton.Name = "searchLineButton";
            this.searchLineButton.Size = new System.Drawing.Size(96, 72);
            this.searchLineButton.TabIndex = 88;
            this.searchLineButton.Text = "行跳躍";
            this.searchLineButton.UseVisualStyleBackColor = true;
            this.searchLineButton.Click += new System.EventHandler(this.searchLineButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchButton.Location = new System.Drawing.Point(3, 221);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 72);
            this.searchButton.TabIndex = 88;
            this.searchButton.Text = "字串\r\n搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.replaceButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.replaceButton.Location = new System.Drawing.Point(100, 221);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(96, 72);
            this.replaceButton.TabIndex = 88;
            this.replaceButton.Text = "字串\r\n取代";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // saveAsFileButton
            // 
            this.saveAsFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveAsFileButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveAsFileButton.Location = new System.Drawing.Point(100, 293);
            this.saveAsFileButton.Name = "saveAsFileButton";
            this.saveAsFileButton.Size = new System.Drawing.Size(96, 72);
            this.saveAsFileButton.TabIndex = 88;
            this.saveAsFileButton.Text = "另存\r\n新檔";
            this.saveAsFileButton.UseVisualStyleBackColor = true;
            this.saveAsFileButton.Click += new System.EventHandler(this.saveAsFileButton_Click);
            // 
            // unsaveLabel
            // 
            this.unsaveLabel.AutoSize = true;
            this.unsaveLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.unsaveLabel.Location = new System.Drawing.Point(626, 11);
            this.unsaveLabel.Name = "unsaveLabel";
            this.unsaveLabel.Size = new System.Drawing.Size(31, 36);
            this.unsaveLabel.TabIndex = 90;
            this.unsaveLabel.Text = "*";
            this.unsaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewFileOpen
            // 
            this.NewFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewFileOpen.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewFileOpen.Location = new System.Drawing.Point(464, 204);
            this.NewFileOpen.Name = "NewFileOpen";
            this.NewFileOpen.Size = new System.Drawing.Size(118, 72);
            this.NewFileOpen.TabIndex = 93;
            this.NewFileOpen.Text = "檔案新增";
            this.NewFileOpen.UseVisualStyleBackColor = true;
            this.NewFileOpen.Click += new System.EventHandler(this.NewFileOpen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.copyButton);
            this.panel1.Controls.Add(this.pasteButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.insertButton);
            this.panel1.Controls.Add(this.searchLineButton);
            this.panel1.Controls.Add(this.clearRowButton);
            this.panel1.Controls.Add(this.closeFileButton);
            this.panel1.Controls.Add(this.replaceButton);
            this.panel1.Controls.Add(this.saveFileButton);
            this.panel1.Controls.Add(this.saveAsFileButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Location = new System.Drawing.Point(997, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 468);
            this.panel1.TabIndex = 94;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.fileListVScrollBar);
            this.panel2.Controls.Add(this.FileUpload);
            this.panel2.Controls.Add(this.FileOpen);
            this.panel2.Controls.Add(this.ChangeFileName);
            this.panel2.Controls.Add(this.NewFileOpen);
            this.panel2.Controls.Add(this.FileDelete);
            this.panel2.Controls.Add(this.PathFileName);
            this.panel2.Controls.Add(this.FilePathInfo);
            this.panel2.Location = new System.Drawing.Point(-141, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 473);
            this.panel2.TabIndex = 95;
            // 
            // fileListVScrollBar
            // 
            this.fileListVScrollBar.Location = new System.Drawing.Point(417, 50);
            this.fileListVScrollBar.Name = "fileListVScrollBar";
            this.fileListVScrollBar.Size = new System.Drawing.Size(41, 381);
            this.fileListVScrollBar.TabIndex = 97;
            this.fileListVScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fileListVScrollBar_Scroll);
            // 
            // FileUpload
            // 
            this.FileUpload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FileUpload.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FileUpload.Location = new System.Drawing.Point(464, 48);
            this.FileUpload.Name = "FileUpload";
            this.FileUpload.Size = new System.Drawing.Size(118, 72);
            this.FileUpload.TabIndex = 94;
            this.FileUpload.Text = "上傳";
            this.FileUpload.UseVisualStyleBackColor = true;
            this.FileUpload.Click += new System.EventHandler(this.FileUpload_Click);
            // 
            // refreshFileListButton
            // 
            this.refreshFileListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshFileListButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.refreshFileListButton.Image = global::JCNC.Properties.Resources.refresh;
            this.refreshFileListButton.Location = new System.Drawing.Point(7, 3);
            this.refreshFileListButton.Name = "refreshFileListButton";
            this.refreshFileListButton.Size = new System.Drawing.Size(40, 40);
            this.refreshFileListButton.TabIndex = 91;
            this.refreshFileListButton.UseVisualStyleBackColor = true;
            this.refreshFileListButton.Click += new System.EventHandler(this.refreshFileListButton_Click);
            // 
            // memVScrollBar
            // 
            this.memVScrollBar.Location = new System.Drawing.Point(950, 50);
            this.memVScrollBar.Name = "memVScrollBar";
            this.memVScrollBar.Size = new System.Drawing.Size(43, 382);
            this.memVScrollBar.TabIndex = 96;
            this.memVScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.memVScrollBar_Scroll);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(492, 201);
            this.progressBar.MarqueeAnimationSpeed = 30;
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(416, 53);
            this.progressBar.TabIndex = 97;
            this.progressBar.Value = 40;
            this.progressBar.Visible = false;
            // 
            // FORM_Prog_MemFileEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1196, 438);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.memVScrollBar);
            this.Controls.Add(this.memGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshFileListButton);
            this.Controls.Add(this.unsaveLabel);
            this.Controls.Add(this.isMultiLineCheckBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.lineNumLabel);
            this.Controls.Add(this.FileContent);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_Prog_MemFileEdit";
            this.Text = "MF_Prog_FilePath";
            this.Load += new System.EventHandler(this.MF_Prog_FilePath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilePathInfo;
        private System.Windows.Forms.Label PathFileName;
        private System.Windows.Forms.Label FileContent;
        private System.Windows.Forms.Button FileOpen;
        private System.Windows.Forms.Button ChangeFileName;
        private System.Windows.Forms.Button FileDelete;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.DataGridView memGridView;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.CheckBox isMultiLineCheckBox;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button closeFileButton;
        private System.Windows.Forms.Label lineNumLabel;
        private System.Windows.Forms.Button clearRowButton;
        private System.Windows.Forms.Button searchLineButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button saveAsFileButton;
        private System.Windows.Forms.Label unsaveLabel;
        private System.Windows.Forms.Button refreshFileListButton;
        private System.Windows.Forms.Button NewFileOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MGcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FileUpload;
        private System.Windows.Forms.VScrollBar memVScrollBar;
        private System.Windows.Forms.VScrollBar fileListVScrollBar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer progressTimer;
    }
}