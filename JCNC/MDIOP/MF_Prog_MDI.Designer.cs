namespace MDIOP
{
    partial class FORM_Prog_MdiFileEdit
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
            this.MDIGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.AbsCood_CValue = new System.Windows.Forms.Label();
            this.AbsCood_ZValue = new System.Windows.Forms.Label();
            this.AbsCood_YValue = new System.Windows.Forms.Label();
            this.AbsCood_XValue = new System.Windows.Forms.Label();
            this.ProgCood = new System.Windows.Forms.Label();
            this.MacCood = new System.Windows.Forms.Label();
            this.ProgCood_C = new System.Windows.Forms.Label();
            this.ProgCood_Z = new System.Windows.Forms.Label();
            this.ProgCood_Y = new System.Windows.Forms.Label();
            this.ProgCood_X = new System.Windows.Forms.Label();
            this.MacCood_C = new System.Windows.Forms.Label();
            this.MacCood_Z = new System.Windows.Forms.Label();
            this.MacCood_Y = new System.Windows.Forms.Label();
            this.MacCood_X = new System.Windows.Forms.Label();
            this.mdiInputButton = new System.Windows.Forms.Button();
            this.mdiInputTextBox = new System.Windows.Forms.TextBox();
            this.copyLineButton = new System.Windows.Forms.Button();
            this.pasteLineButton = new System.Windows.Forms.Button();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.searchLineButton = new System.Windows.Forms.Button();
            this.deleteAllLinesButton = new System.Windows.Forms.Button();
            this.insertRowButton = new System.Windows.Forms.Button();
            this.clearRowButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.RelCood_CValue = new System.Windows.Forms.Label();
            this.RelCood_ZValue = new System.Windows.Forms.Label();
            this.RelCood_YValue = new System.Windows.Forms.Label();
            this.RelCood_XValue = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.showCoordinateTimer = new System.Windows.Forms.Timer(this.components);
            this.CSTimer = new System.Windows.Forms.Timer(this.components);
            this.mdiVScrollBar = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.MDIGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MDIGridView
            // 
            this.MDIGridView.AllowUserToAddRows = false;
            this.MDIGridView.AllowUserToDeleteRows = false;
            this.MDIGridView.AllowUserToResizeColumns = false;
            this.MDIGridView.AllowUserToResizeRows = false;
            this.MDIGridView.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.MDIGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.MDIGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MDIGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MDIGridView.ColumnHeadersHeight = 25;
            this.MDIGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MDIGridView.ColumnHeadersVisible = false;
            this.MDIGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Command});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MDIGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MDIGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.MDIGridView.Location = new System.Drawing.Point(577, 0);
            this.MDIGridView.MultiSelect = false;
            this.MDIGridView.Name = "MDIGridView";
            this.MDIGridView.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MDIGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MDIGridView.RowHeadersVisible = false;
            this.MDIGridView.RowHeadersWidth = 10;
            this.MDIGridView.RowTemplate.Height = 36;
            this.MDIGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MDIGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MDIGridView.Size = new System.Drawing.Size(587, 433);
            this.MDIGridView.TabIndex = 8;
            this.MDIGridView.SelectionChanged += new System.EventHandler(this.MDIGridView_SelectionChanged);
            this.MDIGridView.Click += new System.EventHandler(this.MDIGridView_Click);
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Index.DefaultCellStyle = dataGridViewCellStyle2;
            this.Index.FillWeight = 80F;
            this.Index.HeaderText = "";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Index.Width = 80;
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Command.FillWeight = 149.2386F;
            this.Command.HeaderText = "";
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            this.Command.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Command.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Command.Width = 492;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(574, 433);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AbsCood_CValue
            // 
            this.AbsCood_CValue.BackColor = System.Drawing.Color.MediumBlue;
            this.AbsCood_CValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AbsCood_CValue.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsCood_CValue.ForeColor = System.Drawing.Color.White;
            this.AbsCood_CValue.Location = new System.Drawing.Point(77, 228);
            this.AbsCood_CValue.Name = "AbsCood_CValue";
            this.AbsCood_CValue.Size = new System.Drawing.Size(195, 50);
            this.AbsCood_CValue.TabIndex = 82;
            this.AbsCood_CValue.Text = "0.000";
            this.AbsCood_CValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbsCood_ZValue
            // 
            this.AbsCood_ZValue.BackColor = System.Drawing.Color.MediumBlue;
            this.AbsCood_ZValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AbsCood_ZValue.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsCood_ZValue.ForeColor = System.Drawing.Color.White;
            this.AbsCood_ZValue.Location = new System.Drawing.Point(77, 172);
            this.AbsCood_ZValue.Name = "AbsCood_ZValue";
            this.AbsCood_ZValue.Size = new System.Drawing.Size(195, 50);
            this.AbsCood_ZValue.TabIndex = 81;
            this.AbsCood_ZValue.Text = "label19";
            this.AbsCood_ZValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbsCood_YValue
            // 
            this.AbsCood_YValue.BackColor = System.Drawing.Color.MediumBlue;
            this.AbsCood_YValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AbsCood_YValue.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsCood_YValue.ForeColor = System.Drawing.Color.White;
            this.AbsCood_YValue.Location = new System.Drawing.Point(77, 116);
            this.AbsCood_YValue.Name = "AbsCood_YValue";
            this.AbsCood_YValue.Size = new System.Drawing.Size(195, 50);
            this.AbsCood_YValue.TabIndex = 80;
            this.AbsCood_YValue.Text = "label19";
            this.AbsCood_YValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbsCood_XValue
            // 
            this.AbsCood_XValue.BackColor = System.Drawing.Color.MediumBlue;
            this.AbsCood_XValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AbsCood_XValue.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsCood_XValue.ForeColor = System.Drawing.Color.White;
            this.AbsCood_XValue.Location = new System.Drawing.Point(77, 60);
            this.AbsCood_XValue.Name = "AbsCood_XValue";
            this.AbsCood_XValue.Size = new System.Drawing.Size(195, 50);
            this.AbsCood_XValue.TabIndex = 79;
            this.AbsCood_XValue.Text = "label19";
            this.AbsCood_XValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProgCood
            // 
            this.ProgCood.AutoSize = true;
            this.ProgCood.Location = new System.Drawing.Point(368, 18);
            this.ProgCood.Name = "ProgCood";
            this.ProgCood.Size = new System.Drawing.Size(33, 12);
            this.ProgCood.TabIndex = 77;
            this.ProgCood.Text = "label2";
            // 
            // MacCood
            // 
            this.MacCood.AutoSize = true;
            this.MacCood.Location = new System.Drawing.Point(86, 18);
            this.MacCood.Name = "MacCood";
            this.MacCood.Size = new System.Drawing.Size(33, 12);
            this.MacCood.TabIndex = 76;
            this.MacCood.Text = "label1";
            // 
            // ProgCood_C
            // 
            this.ProgCood_C.AutoSize = true;
            this.ProgCood_C.Location = new System.Drawing.Point(293, 228);
            this.ProgCood_C.Name = "ProgCood_C";
            this.ProgCood_C.Size = new System.Drawing.Size(33, 12);
            this.ProgCood_C.TabIndex = 75;
            this.ProgCood_C.Text = "label5";
            // 
            // ProgCood_Z
            // 
            this.ProgCood_Z.AutoSize = true;
            this.ProgCood_Z.Location = new System.Drawing.Point(293, 172);
            this.ProgCood_Z.Name = "ProgCood_Z";
            this.ProgCood_Z.Size = new System.Drawing.Size(33, 12);
            this.ProgCood_Z.TabIndex = 74;
            this.ProgCood_Z.Text = "label6";
            // 
            // ProgCood_Y
            // 
            this.ProgCood_Y.AutoSize = true;
            this.ProgCood_Y.Location = new System.Drawing.Point(293, 116);
            this.ProgCood_Y.Name = "ProgCood_Y";
            this.ProgCood_Y.Size = new System.Drawing.Size(33, 12);
            this.ProgCood_Y.TabIndex = 73;
            this.ProgCood_Y.Text = "label7";
            // 
            // ProgCood_X
            // 
            this.ProgCood_X.AutoSize = true;
            this.ProgCood_X.Location = new System.Drawing.Point(293, 60);
            this.ProgCood_X.Name = "ProgCood_X";
            this.ProgCood_X.Size = new System.Drawing.Size(33, 12);
            this.ProgCood_X.TabIndex = 72;
            this.ProgCood_X.Text = "label8";
            // 
            // MacCood_C
            // 
            this.MacCood_C.AutoSize = true;
            this.MacCood_C.Location = new System.Drawing.Point(16, 228);
            this.MacCood_C.Name = "MacCood_C";
            this.MacCood_C.Size = new System.Drawing.Size(33, 12);
            this.MacCood_C.TabIndex = 71;
            this.MacCood_C.Text = "label4";
            // 
            // MacCood_Z
            // 
            this.MacCood_Z.AutoSize = true;
            this.MacCood_Z.Location = new System.Drawing.Point(16, 172);
            this.MacCood_Z.Name = "MacCood_Z";
            this.MacCood_Z.Size = new System.Drawing.Size(33, 12);
            this.MacCood_Z.TabIndex = 70;
            this.MacCood_Z.Text = "label3";
            // 
            // MacCood_Y
            // 
            this.MacCood_Y.AutoSize = true;
            this.MacCood_Y.Location = new System.Drawing.Point(16, 116);
            this.MacCood_Y.Name = "MacCood_Y";
            this.MacCood_Y.Size = new System.Drawing.Size(33, 12);
            this.MacCood_Y.TabIndex = 69;
            this.MacCood_Y.Text = "label2";
            // 
            // MacCood_X
            // 
            this.MacCood_X.AutoSize = true;
            this.MacCood_X.Location = new System.Drawing.Point(16, 60);
            this.MacCood_X.Name = "MacCood_X";
            this.MacCood_X.Size = new System.Drawing.Size(33, 12);
            this.MacCood_X.TabIndex = 68;
            this.MacCood_X.Text = "label1";
            // 
            // mdiInputButton
            // 
            this.mdiInputButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mdiInputButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mdiInputButton.Location = new System.Drawing.Point(1116, 398);
            this.mdiInputButton.Name = "mdiInputButton";
            this.mdiInputButton.Size = new System.Drawing.Size(78, 35);
            this.mdiInputButton.TabIndex = 2;
            this.mdiInputButton.Text = "Input";
            this.mdiInputButton.UseVisualStyleBackColor = true;
            this.mdiInputButton.Click += new System.EventHandler(this.mdiInputButton_Click);
            // 
            // mdiInputTextBox
            // 
            this.mdiInputTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mdiInputTextBox.Location = new System.Drawing.Point(597, 393);
            this.mdiInputTextBox.Name = "mdiInputTextBox";
            this.mdiInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mdiInputTextBox.Size = new System.Drawing.Size(518, 36);
            this.mdiInputTextBox.TabIndex = 84;
            this.mdiInputTextBox.Click += new System.EventHandler(this.mdiInputTextBox_Click);
            this.mdiInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mdiInputTextBox_KeyDown);
            // 
            // copyLineButton
            // 
            this.copyLineButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.copyLineButton.Location = new System.Drawing.Point(427, 298);
            this.copyLineButton.Name = "copyLineButton";
            this.copyLineButton.Size = new System.Drawing.Size(139, 65);
            this.copyLineButton.TabIndex = 83;
            this.copyLineButton.Text = "行複製";
            this.copyLineButton.UseVisualStyleBackColor = true;
            this.copyLineButton.Click += new System.EventHandler(this.copyLineButton_Click);
            // 
            // pasteLineButton
            // 
            this.pasteLineButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pasteLineButton.Location = new System.Drawing.Point(427, 364);
            this.pasteLineButton.Name = "pasteLineButton";
            this.pasteLineButton.Size = new System.Drawing.Size(139, 65);
            this.pasteLineButton.TabIndex = 83;
            this.pasteLineButton.Text = "行貼上";
            this.pasteLineButton.UseVisualStyleBackColor = true;
            this.pasteLineButton.Click += new System.EventHandler(this.pasteLineButton_Click);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteRowButton.Location = new System.Drawing.Point(147, 364);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(139, 65);
            this.deleteRowButton.TabIndex = 83;
            this.deleteRowButton.Text = "行刪除";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // searchLineButton
            // 
            this.searchLineButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchLineButton.Location = new System.Drawing.Point(287, 298);
            this.searchLineButton.Name = "searchLineButton";
            this.searchLineButton.Size = new System.Drawing.Size(139, 65);
            this.searchLineButton.TabIndex = 83;
            this.searchLineButton.Text = "行跳躍";
            this.searchLineButton.UseVisualStyleBackColor = true;
            this.searchLineButton.Click += new System.EventHandler(this.searchLineButton_Click);
            // 
            // deleteAllLinesButton
            // 
            this.deleteAllLinesButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteAllLinesButton.Location = new System.Drawing.Point(7, 364);
            this.deleteAllLinesButton.Name = "deleteAllLinesButton";
            this.deleteAllLinesButton.Size = new System.Drawing.Size(139, 65);
            this.deleteAllLinesButton.TabIndex = 83;
            this.deleteAllLinesButton.Text = "刪除檔案";
            this.deleteAllLinesButton.UseVisualStyleBackColor = true;
            this.deleteAllLinesButton.Click += new System.EventHandler(this.deleteAllLinesButton_Click);
            // 
            // insertRowButton
            // 
            this.insertRowButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertRowButton.Location = new System.Drawing.Point(287, 364);
            this.insertRowButton.Name = "insertRowButton";
            this.insertRowButton.Size = new System.Drawing.Size(139, 65);
            this.insertRowButton.TabIndex = 85;
            this.insertRowButton.Text = "行插入";
            this.insertRowButton.UseVisualStyleBackColor = true;
            this.insertRowButton.Click += new System.EventHandler(this.insertRowButton_Click);
            // 
            // clearRowButton
            // 
            this.clearRowButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearRowButton.Location = new System.Drawing.Point(147, 298);
            this.clearRowButton.Name = "clearRowButton";
            this.clearRowButton.Size = new System.Drawing.Size(139, 65);
            this.clearRowButton.TabIndex = 86;
            this.clearRowButton.Text = "行清除";
            this.clearRowButton.UseVisualStyleBackColor = true;
            this.clearRowButton.Click += new System.EventHandler(this.clearRowButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveFileButton.Location = new System.Drawing.Point(7, 298);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(139, 65);
            this.saveFileButton.TabIndex = 87;
            this.saveFileButton.Text = "儲存檔案";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.recoverButton_Click);
            // 
            // RelCood_CValue
            // 
            this.RelCood_CValue.BackColor = System.Drawing.Color.MediumBlue;
            this.RelCood_CValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RelCood_CValue.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelCood_CValue.ForeColor = System.Drawing.Color.White;
            this.RelCood_CValue.Location = new System.Drawing.Point(357, 228);
            this.RelCood_CValue.Name = "RelCood_CValue";
            this.RelCood_CValue.Size = new System.Drawing.Size(195, 50);
            this.RelCood_CValue.TabIndex = 129;
            this.RelCood_CValue.Text = "0.000";
            this.RelCood_CValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RelCood_ZValue
            // 
            this.RelCood_ZValue.BackColor = System.Drawing.Color.MediumBlue;
            this.RelCood_ZValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RelCood_ZValue.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelCood_ZValue.ForeColor = System.Drawing.Color.White;
            this.RelCood_ZValue.Location = new System.Drawing.Point(357, 172);
            this.RelCood_ZValue.Name = "RelCood_ZValue";
            this.RelCood_ZValue.Size = new System.Drawing.Size(195, 50);
            this.RelCood_ZValue.TabIndex = 128;
            this.RelCood_ZValue.Text = "label19";
            this.RelCood_ZValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RelCood_YValue
            // 
            this.RelCood_YValue.BackColor = System.Drawing.Color.MediumBlue;
            this.RelCood_YValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RelCood_YValue.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelCood_YValue.ForeColor = System.Drawing.Color.White;
            this.RelCood_YValue.Location = new System.Drawing.Point(357, 116);
            this.RelCood_YValue.Name = "RelCood_YValue";
            this.RelCood_YValue.Size = new System.Drawing.Size(195, 50);
            this.RelCood_YValue.TabIndex = 127;
            this.RelCood_YValue.Text = "label19";
            this.RelCood_YValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RelCood_XValue
            // 
            this.RelCood_XValue.BackColor = System.Drawing.Color.MediumBlue;
            this.RelCood_XValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RelCood_XValue.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelCood_XValue.ForeColor = System.Drawing.Color.White;
            this.RelCood_XValue.Location = new System.Drawing.Point(357, 60);
            this.RelCood_XValue.Name = "RelCood_XValue";
            this.RelCood_XValue.Size = new System.Drawing.Size(195, 50);
            this.RelCood_XValue.TabIndex = 126;
            this.RelCood_XValue.Text = "label19";
            this.RelCood_XValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(7, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(559, 280);
            this.button4.TabIndex = 78;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CSTimer
            // 
            this.CSTimer.Tick += new System.EventHandler(this.CSTimer_Tick);
            // 
            // mdiVScrollBar
            // 
            this.mdiVScrollBar.Location = new System.Drawing.Point(1151, 0);
            this.mdiVScrollBar.Name = "mdiVScrollBar";
            this.mdiVScrollBar.Size = new System.Drawing.Size(43, 433);
            this.mdiVScrollBar.TabIndex = 130;
            this.mdiVScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.mdiVScrollBar_Scroll);
            // 
            // FORM_Prog_MdiFileEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 438);
            this.Controls.Add(this.mdiVScrollBar);
            this.Controls.Add(this.MDIGridView);
            this.Controls.Add(this.RelCood_CValue);
            this.Controls.Add(this.RelCood_ZValue);
            this.Controls.Add(this.RelCood_YValue);
            this.Controls.Add(this.RelCood_XValue);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.clearRowButton);
            this.Controls.Add(this.insertRowButton);
            this.Controls.Add(this.mdiInputTextBox);
            this.Controls.Add(this.searchLineButton);
            this.Controls.Add(this.deleteAllLinesButton);
            this.Controls.Add(this.deleteRowButton);
            this.Controls.Add(this.pasteLineButton);
            this.Controls.Add(this.copyLineButton);
            this.Controls.Add(this.AbsCood_CValue);
            this.Controls.Add(this.AbsCood_ZValue);
            this.Controls.Add(this.AbsCood_YValue);
            this.Controls.Add(this.AbsCood_XValue);
            this.Controls.Add(this.ProgCood);
            this.Controls.Add(this.MacCood);
            this.Controls.Add(this.ProgCood_C);
            this.Controls.Add(this.ProgCood_Z);
            this.Controls.Add(this.ProgCood_Y);
            this.Controls.Add(this.ProgCood_X);
            this.Controls.Add(this.MacCood_C);
            this.Controls.Add(this.MacCood_Z);
            this.Controls.Add(this.MacCood_Y);
            this.Controls.Add(this.MacCood_X);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mdiInputButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_Prog_MdiFileEdit";
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.MF_Prog_MDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MDIGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MDIGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label AbsCood_CValue;
        private System.Windows.Forms.Label AbsCood_ZValue;
        private System.Windows.Forms.Label AbsCood_YValue;
        private System.Windows.Forms.Label AbsCood_XValue;
        private System.Windows.Forms.Label ProgCood;
        private System.Windows.Forms.Label MacCood;
        private System.Windows.Forms.Label ProgCood_C;
        private System.Windows.Forms.Label ProgCood_Z;
        private System.Windows.Forms.Label ProgCood_Y;
        private System.Windows.Forms.Label ProgCood_X;
        private System.Windows.Forms.Label MacCood_C;
        private System.Windows.Forms.Label MacCood_Z;
        private System.Windows.Forms.Label MacCood_Y;
        private System.Windows.Forms.Label MacCood_X;
        private System.Windows.Forms.Button mdiInputButton;
        private System.Windows.Forms.TextBox mdiInputTextBox;
        private System.Windows.Forms.Button copyLineButton;
        private System.Windows.Forms.Button pasteLineButton;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.Button searchLineButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
        private System.Windows.Forms.Button deleteAllLinesButton;
        private System.Windows.Forms.Button insertRowButton;
        private System.Windows.Forms.Button clearRowButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Label RelCood_CValue;
        private System.Windows.Forms.Label RelCood_ZValue;
        private System.Windows.Forms.Label RelCood_YValue;
        private System.Windows.Forms.Label RelCood_XValue;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer showCoordinateTimer;
        private System.Windows.Forms.Timer CSTimer;
        private System.Windows.Forms.VScrollBar mdiVScrollBar;
    }
}