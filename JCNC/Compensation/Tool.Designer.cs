namespace Compensation
{
    partial class Tool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.inputButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.toolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.toolDBDataSet = new Compensation.ToolDBDataSet();
            this.copyButton = new System.Windows.Forms.Button();
            this.offsetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offsetTableAdapter = new Compensation.ToolDBDataSetTableAdapters.OffsetTableAdapter();
            this.pasteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.recoverButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.relativeInputButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.updateHeightTimer = new System.Windows.Forms.Timer(this.components);
            this.diameterWasteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightWasteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolDataGridView = new System.Windows.Forms.DataGridView();
            this.toolVScrollBar = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.toolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(814, 430);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(398, 386);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(109, 36);
            this.inputButton.TabIndex = 5;
            this.inputButton.Text = "Input";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inputTextBox.Location = new System.Drawing.Point(77, 386);
            this.inputTextBox.MaxLength = 20;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(280, 36);
            this.inputTextBox.TabIndex = 6;
            this.inputTextBox.Text = "12345.56";
            this.inputTextBox.Click += new System.EventHandler(this.inputTextBox_Click);
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(655, 277);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(147, 66);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "全部清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // toolDBDataSet
            // 
            this.toolDBDataSet.DataSetName = "ToolDBDataSet";
            this.toolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(655, 127);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(147, 66);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "複製";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // offsetBindingSource
            // 
            this.offsetBindingSource.DataMember = "Offset";
            this.offsetBindingSource.DataSource = this.toolDBDataSet;
            // 
            // offsetTableAdapter
            // 
            this.offsetTableAdapter.ClearBeforeFill = true;
            // 
            // pasteButton
            // 
            this.pasteButton.Location = new System.Drawing.Point(655, 202);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(147, 66);
            this.pasteButton.TabIndex = 7;
            this.pasteButton.Text = "貼上";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(655, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(147, 66);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "刀號搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // recoverButton
            // 
            this.recoverButton.Location = new System.Drawing.Point(655, 352);
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Size = new System.Drawing.Size(147, 66);
            this.recoverButton.TabIndex = 7;
            this.recoverButton.Text = "單筆復原";
            this.recoverButton.UseVisualStyleBackColor = true;
            this.recoverButton.Click += new System.EventHandler(this.recoverButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchTextBox.Location = new System.Drawing.Point(655, 12);
            this.searchTextBox.MaxLength = 3;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(147, 33);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.Text = "1";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // relativeInputButton
            // 
            this.relativeInputButton.Location = new System.Drawing.Point(513, 386);
            this.relativeInputButton.Name = "relativeInputButton";
            this.relativeInputButton.Size = new System.Drawing.Size(55, 36);
            this.relativeInputButton.TabIndex = 10;
            this.relativeInputButton.Text = "(+)";
            this.relativeInputButton.UseVisualStyleBackColor = true;
            this.relativeInputButton.Click += new System.EventHandler(this.relativeInputButton_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.valueLabel.Location = new System.Drawing.Point(12, 386);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(59, 36);
            this.valueLabel.TabIndex = 11;
            this.valueLabel.Text = "數值：";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateHeightTimer
            // 
            this.updateHeightTimer.Interval = 300;
            this.updateHeightTimer.Tick += new System.EventHandler(this.updateHeightTimer_Tick);
            // 
            // diameterWasteDataGridViewTextBoxColumn
            // 
            this.diameterWasteDataGridViewTextBoxColumn.DataPropertyName = "DiameterWaste";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.diameterWasteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.diameterWasteDataGridViewTextBoxColumn.HeaderText = "刀徑磨損";
            this.diameterWasteDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.diameterWasteDataGridViewTextBoxColumn.Name = "diameterWasteDataGridViewTextBoxColumn";
            this.diameterWasteDataGridViewTextBoxColumn.ReadOnly = true;
            this.diameterWasteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.diameterWasteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.diameterWasteDataGridViewTextBoxColumn.Width = 130;
            // 
            // diameterDataGridViewTextBoxColumn
            // 
            this.diameterDataGridViewTextBoxColumn.DataPropertyName = "Diameter";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.diameterDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.diameterDataGridViewTextBoxColumn.HeaderText = "刀徑補正";
            this.diameterDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.diameterDataGridViewTextBoxColumn.Name = "diameterDataGridViewTextBoxColumn";
            this.diameterDataGridViewTextBoxColumn.ReadOnly = true;
            this.diameterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.diameterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.diameterDataGridViewTextBoxColumn.Width = 130;
            // 
            // heightWasteDataGridViewTextBoxColumn
            // 
            this.heightWasteDataGridViewTextBoxColumn.DataPropertyName = "HeightWaste";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.heightWasteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.heightWasteDataGridViewTextBoxColumn.HeaderText = "刀長磨損";
            this.heightWasteDataGridViewTextBoxColumn.Name = "heightWasteDataGridViewTextBoxColumn";
            this.heightWasteDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightWasteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.heightWasteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.heightWasteDataGridViewTextBoxColumn.Width = 130;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.heightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.heightDataGridViewTextBoxColumn.HeaderText = "刀長補正";
            this.heightDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.heightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.heightDataGridViewTextBoxColumn.Width = 130;
            // 
            // toolNumDataGridViewTextBoxColumn
            // 
            this.toolNumDataGridViewTextBoxColumn.DataPropertyName = "ToolNum";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.toolNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.toolNumDataGridViewTextBoxColumn.HeaderText = "刀號";
            this.toolNumDataGridViewTextBoxColumn.Name = "toolNumDataGridViewTextBoxColumn";
            this.toolNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.toolNumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.toolNumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.toolNumDataGridViewTextBoxColumn.Width = 60;
            // 
            // toolDataGridView
            // 
            this.toolDataGridView.AllowUserToAddRows = false;
            this.toolDataGridView.AllowUserToDeleteRows = false;
            this.toolDataGridView.AllowUserToResizeColumns = false;
            this.toolDataGridView.AllowUserToResizeRows = false;
            this.toolDataGridView.AutoGenerateColumns = false;
            this.toolDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.toolDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.toolDataGridView.ColumnHeadersHeight = 35;
            this.toolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.toolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toolNumDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.heightWasteDataGridViewTextBoxColumn,
            this.diameterDataGridViewTextBoxColumn,
            this.diameterWasteDataGridViewTextBoxColumn});
            this.toolDataGridView.DataSource = this.offsetBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.toolDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.toolDataGridView.Location = new System.Drawing.Point(12, 12);
            this.toolDataGridView.MultiSelect = false;
            this.toolDataGridView.Name = "toolDataGridView";
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.toolDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.toolDataGridView.RowHeadersVisible = false;
            this.toolDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.toolDataGridView.RowTemplate.Height = 35;
            this.toolDataGridView.Size = new System.Drawing.Size(600, 410);
            this.toolDataGridView.TabIndex = 4;
            this.toolDataGridView.SelectionChanged += new System.EventHandler(this.toolDataGridView_SelectionChanged);
            // 
            // toolVScrollBar
            // 
            this.toolVScrollBar.Location = new System.Drawing.Point(592, 12);
            this.toolVScrollBar.Name = "toolVScrollBar";
            this.toolVScrollBar.Size = new System.Drawing.Size(43, 409);
            this.toolVScrollBar.TabIndex = 97;
            this.toolVScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.toolVScrollBar_Scroll);
            // 
            // Tool
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(814, 430);
            this.Controls.Add(this.toolVScrollBar);
            this.Controls.Add(this.toolDataGridView);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.relativeInputButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tool";
            this.Text = "Tool";
            this.Load += new System.EventHandler(this.Tool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.BindingSource toolBindingSource;
        private System.Windows.Forms.Button clearButton;
        private ToolDBDataSet toolDBDataSet;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.BindingSource offsetBindingSource;
        private ToolDBDataSetTableAdapters.OffsetTableAdapter offsetTableAdapter;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button recoverButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button relativeInputButton;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Timer updateHeightTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameterWasteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightWasteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView toolDataGridView;
        private System.Windows.Forms.VScrollBar toolVScrollBar;


    }
}