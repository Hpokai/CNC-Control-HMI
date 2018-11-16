namespace JCNC
{
    partial class jcncMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jcncMainForm));
            this.formTabControl = new System.Windows.Forms.TabControl();
            this.cycleStartTimer = new System.Windows.Forms.Timer(this.components);
            this.systemStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.homeStateTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.shutDownToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.powerOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.systemTimeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateStatusBartimer = new System.Windows.Forms.Timer(this.components);
            this.toolAbnormalTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.singleBlockPanel = new System.Windows.Forms.Panel();
            this.zLimitLightPanel = new System.Windows.Forms.Panel();
            this.yLimitLightPanel = new System.Windows.Forms.Panel();
            this.xLimitLightPanel = new System.Windows.Forms.Panel();
            this.emgStopLightPanel = new System.Windows.Forms.Panel();
            this.controlFunctionPanel = new System.Windows.Forms.Panel();
            this.aHomeLightPanel = new System.Windows.Forms.Panel();
            this.zHomeLightPanel = new System.Windows.Forms.Panel();
            this.yHomeLightPanel = new System.Windows.Forms.Panel();
            this.xHomeLightPanel = new System.Windows.Forms.Panel();
            this.resetPanel = new System.Windows.Forms.Panel();
            this.feedratePercentDown = new System.Windows.Forms.Panel();
            this.feedratePercentUp = new System.Windows.Forms.Panel();
            this.feedratePercent100 = new System.Windows.Forms.Panel();
            this.feedrateTypePanel = new System.Windows.Forms.Panel();
            this.cycleStartPanel = new System.Windows.Forms.Panel();
            this.feedHoldPanel = new System.Windows.Forms.Panel();
            this.aJogMinusPanel = new System.Windows.Forms.Panel();
            this.xJogPlusPanel = new System.Windows.Forms.Panel();
            this.yJogPlusPanel = new System.Windows.Forms.Panel();
            this.zJogMinusPanel = new System.Windows.Forms.Panel();
            this.jogRapidPanel = new System.Windows.Forms.Panel();
            this.zJogPlusPanel = new System.Windows.Forms.Panel();
            this.yJogMinusPanel = new System.Windows.Forms.Panel();
            this.xJogMinusPanel = new System.Windows.Forms.Panel();
            this.aJogPlusPanel = new System.Windows.Forms.Panel();
            this.spindlePercentDown = new System.Windows.Forms.Panel();
            this.spindlePercent100 = new System.Windows.Forms.Panel();
            this.spindlePercentUp = new System.Windows.Forms.Panel();
            this.spindleCcwPanel = new System.Windows.Forms.Panel();
            this.spindleOffPanel = new System.Windows.Forms.Panel();
            this.spindleCwPanel = new System.Windows.Forms.Panel();
            this.ncModeMemPanel = new System.Windows.Forms.Panel();
            this.ncModeMpgPanel = new System.Windows.Forms.Panel();
            this.ncModeIncJogPanel = new System.Windows.Forms.Panel();
            this.ncModeMdiPanel = new System.Windows.Forms.Panel();
            this.ncModeZrnPanel = new System.Windows.Forms.Panel();
            this.ncModeJogPanel = new System.Windows.Forms.Panel();
            this.formParameterPanel = new System.Windows.Forms.Panel();
            this.formMaintenPanel = new System.Windows.Forms.Panel();
            this.formDiagnosisPanel = new System.Windows.Forms.Panel();
            this.formOffsetPanel = new System.Windows.Forms.Panel();
            this.formProgramPanel = new System.Windows.Forms.Panel();
            this.formMonitorPanel = new System.Windows.Forms.Panel();
            this.mouseTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formTabControl
            // 
            this.formTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.formTabControl.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.formTabControl.ItemSize = new System.Drawing.Size(100, 60);
            this.formTabControl.Location = new System.Drawing.Point(1, 38);
            this.formTabControl.Name = "formTabControl";
            this.formTabControl.Padding = new System.Drawing.Point(30, 3);
            this.formTabControl.SelectedIndex = 0;
            this.formTabControl.Size = new System.Drawing.Size(1204, 504);
            this.formTabControl.TabIndex = 6;
            this.formTabControl.SelectedIndexChanged += new System.EventHandler(this.formTabControl_SelectedIndexChanged);
            // 
            // cycleStartTimer
            // 
            this.cycleStartTimer.Interval = 300;
            this.cycleStartTimer.Tick += new System.EventHandler(this.cycleStartTimer_Tick);
            // 
            // systemStatusTimer
            // 
            this.systemStatusTimer.Interval = 500;
            this.systemStatusTimer.Tick += new System.EventHandler(this.SYSTSTATUSTIMER_Tick);
            // 
            // homeStateTimer
            // 
            this.homeStateTimer.Tick += new System.EventHandler(this.homeStateTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutDownToolStripSplitButton,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel1,
            this.systemTimeToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 730);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1366, 38);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 54;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // shutDownToolStripSplitButton
            // 
            this.shutDownToolStripSplitButton.AutoSize = false;
            this.shutDownToolStripSplitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.shutDownToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shutDownToolStripSplitButton.DropDownButtonWidth = 0;
            this.shutDownToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerOffToolStripMenuItem});
            this.shutDownToolStripSplitButton.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutDownToolStripSplitButton.ForeColor = System.Drawing.Color.Gold;
            this.shutDownToolStripSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.shutDownToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shutDownToolStripSplitButton.Name = "shutDownToolStripSplitButton";
            this.shutDownToolStripSplitButton.Size = new System.Drawing.Size(50, 36);
            this.shutDownToolStripSplitButton.ButtonClick += new System.EventHandler(this.shutDownToolStripSplitButton_ButtonClick);
            // 
            // powerOffToolStripMenuItem
            // 
            this.powerOffToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.powerOffToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.powerOffToolStripMenuItem.Name = "powerOffToolStripMenuItem";
            this.powerOffToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolStripStatusLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(61, 33);
            this.toolStripStatusLabel5.Text = "CNC";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(15, 33);
            this.toolStripStatusLabel6.Text = " ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1006, 33);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // systemTimeToolStripStatusLabel
            // 
            this.systemTimeToolStripStatusLabel.BackColor = System.Drawing.Color.SlateGray;
            this.systemTimeToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.systemTimeToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.systemTimeToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.systemTimeToolStripStatusLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemTimeToolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.systemTimeToolStripStatusLabel.Name = "systemTimeToolStripStatusLabel";
            this.systemTimeToolStripStatusLabel.Size = new System.Drawing.Size(188, 33);
            this.systemTimeToolStripStatusLabel.Text = "2013/05/24 12:25";
            this.systemTimeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // updateStatusBartimer
            // 
            this.updateStatusBartimer.Interval = 15000;
            this.updateStatusBartimer.Tick += new System.EventHandler(this.updateStatusBartimer_Tick);
            // 
            // toolAbnormalTimer
            // 
            this.toolAbnormalTimer.Interval = 200;
            this.toolAbnormalTimer.Tick += new System.EventHandler(this.ToolAbnormalTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(659, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "R000";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(537, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "R000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "M";
            this.label1.Visible = false;
            // 
            // singleBlockPanel
            // 
            this.singleBlockPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.singleBlockPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.singleBlockPanel.ForeColor = System.Drawing.Color.Red;
            this.singleBlockPanel.Location = new System.Drawing.Point(1026, 543);
            this.singleBlockPanel.Name = "singleBlockPanel";
            this.singleBlockPanel.Size = new System.Drawing.Size(82, 89);
            this.singleBlockPanel.TabIndex = 51;
            this.singleBlockPanel.Tag = "";
            this.singleBlockPanel.Click += new System.EventHandler(this.singleBlockPanel_Click);
            this.singleBlockPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.singleBlockPanel_Paint);
            // 
            // zLimitLightPanel
            // 
            this.zLimitLightPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.zLimitLightPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zLimitLightPanel.ForeColor = System.Drawing.Color.Red;
            this.zLimitLightPanel.Location = new System.Drawing.Point(853, 3);
            this.zLimitLightPanel.Name = "zLimitLightPanel";
            this.zLimitLightPanel.Size = new System.Drawing.Size(34, 34);
            this.zLimitLightPanel.TabIndex = 50;
            this.zLimitLightPanel.Tag = "";
            this.zLimitLightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LimitLightPanel_Paint);
            // 
            // yLimitLightPanel
            // 
            this.yLimitLightPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.yLimitLightPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yLimitLightPanel.ForeColor = System.Drawing.Color.Red;
            this.yLimitLightPanel.Location = new System.Drawing.Point(815, 3);
            this.yLimitLightPanel.Name = "yLimitLightPanel";
            this.yLimitLightPanel.Size = new System.Drawing.Size(34, 34);
            this.yLimitLightPanel.TabIndex = 49;
            this.yLimitLightPanel.Tag = "";
            this.yLimitLightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LimitLightPanel_Paint);
            // 
            // xLimitLightPanel
            // 
            this.xLimitLightPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.xLimitLightPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xLimitLightPanel.ForeColor = System.Drawing.Color.Red;
            this.xLimitLightPanel.Location = new System.Drawing.Point(777, 3);
            this.xLimitLightPanel.Name = "xLimitLightPanel";
            this.xLimitLightPanel.Size = new System.Drawing.Size(34, 34);
            this.xLimitLightPanel.TabIndex = 48;
            this.xLimitLightPanel.Tag = "";
            this.xLimitLightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LimitLightPanel_Paint);
            // 
            // emgStopLightPanel
            // 
            this.emgStopLightPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emgStopLightPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.emgStopLightPanel.ForeColor = System.Drawing.Color.Red;
            this.emgStopLightPanel.Location = new System.Drawing.Point(898, 3);
            this.emgStopLightPanel.Name = "emgStopLightPanel";
            this.emgStopLightPanel.Size = new System.Drawing.Size(151, 34);
            this.emgStopLightPanel.TabIndex = 43;
            this.emgStopLightPanel.Tag = "";
            this.emgStopLightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.emgStopLightPanel_Paint);
            // 
            // controlFunctionPanel
            // 
            this.controlFunctionPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.controlFunctionPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.controlFunctionPanel.ForeColor = System.Drawing.Color.Red;
            this.controlFunctionPanel.Location = new System.Drawing.Point(1110, 543);
            this.controlFunctionPanel.Name = "controlFunctionPanel";
            this.controlFunctionPanel.Size = new System.Drawing.Size(82, 89);
            this.controlFunctionPanel.TabIndex = 42;
            this.controlFunctionPanel.Tag = "";
            this.controlFunctionPanel.Click += new System.EventHandler(this.controlFunctionPanel_Click);
            this.controlFunctionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.controlFunctionPanel_Paint);
            // 
            // aHomeLightPanel
            // 
            this.aHomeLightPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aHomeLightPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.aHomeLightPanel.ForeColor = System.Drawing.Color.Red;
            this.aHomeLightPanel.Location = new System.Drawing.Point(1169, 3);
            this.aHomeLightPanel.Name = "aHomeLightPanel";
            this.aHomeLightPanel.Size = new System.Drawing.Size(34, 34);
            this.aHomeLightPanel.TabIndex = 41;
            this.aHomeLightPanel.Tag = "";
            this.aHomeLightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeLightPanel_Paint);
            // 
            // zHomeLightPanel
            // 
            this.zHomeLightPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.zHomeLightPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zHomeLightPanel.ForeColor = System.Drawing.Color.Red;
            this.zHomeLightPanel.Location = new System.Drawing.Point(1131, 3);
            this.zHomeLightPanel.Name = "zHomeLightPanel";
            this.zHomeLightPanel.Size = new System.Drawing.Size(34, 34);
            this.zHomeLightPanel.TabIndex = 40;
            this.zHomeLightPanel.Tag = "";
            this.zHomeLightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeLightPanel_Paint);
            // 
            // yHomeLightPanel
            // 
            this.yHomeLightPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.yHomeLightPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yHomeLightPanel.ForeColor = System.Drawing.Color.Red;
            this.yHomeLightPanel.Location = new System.Drawing.Point(1093, 3);
            this.yHomeLightPanel.Name = "yHomeLightPanel";
            this.yHomeLightPanel.Size = new System.Drawing.Size(34, 34);
            this.yHomeLightPanel.TabIndex = 39;
            this.yHomeLightPanel.Tag = "";
            this.yHomeLightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeLightPanel_Paint);
            // 
            // xHomeLightPanel
            // 
            this.xHomeLightPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.xHomeLightPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xHomeLightPanel.ForeColor = System.Drawing.Color.Red;
            this.xHomeLightPanel.Location = new System.Drawing.Point(1055, 3);
            this.xHomeLightPanel.Name = "xHomeLightPanel";
            this.xHomeLightPanel.Size = new System.Drawing.Size(34, 34);
            this.xHomeLightPanel.TabIndex = 38;
            this.xHomeLightPanel.Tag = "";
            this.xHomeLightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeLightPanel_Paint);
            // 
            // resetPanel
            // 
            this.resetPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resetPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resetPanel.ForeColor = System.Drawing.Color.Red;
            this.resetPanel.Location = new System.Drawing.Point(1208, 3);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(154, 34);
            this.resetPanel.TabIndex = 37;
            this.resetPanel.Tag = "";
            this.resetPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.resetPanel_Paint);
            this.resetPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resetPanel_MouseDown);
            this.resetPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resetPanel_MouseUp);
            // 
            // feedratePercentDown
            // 
            this.feedratePercentDown.BackColor = System.Drawing.Color.PaleTurquoise;
            this.feedratePercentDown.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.feedratePercentDown.ForeColor = System.Drawing.Color.Red;
            this.feedratePercentDown.Location = new System.Drawing.Point(86, 666);
            this.feedratePercentDown.Name = "feedratePercentDown";
            this.feedratePercentDown.Size = new System.Drawing.Size(89, 58);
            this.feedratePercentDown.TabIndex = 34;
            this.feedratePercentDown.Tag = "";
            this.feedratePercentDown.Paint += new System.Windows.Forms.PaintEventHandler(this.feedratePercentDown_Paint);
            this.feedratePercentDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.feedratePercentDown_MouseDown);
            this.feedratePercentDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.feedratePercentDown_MouseUp);
            // 
            // feedratePercentUp
            // 
            this.feedratePercentUp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.feedratePercentUp.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.feedratePercentUp.ForeColor = System.Drawing.Color.Red;
            this.feedratePercentUp.Location = new System.Drawing.Point(86, 605);
            this.feedratePercentUp.Name = "feedratePercentUp";
            this.feedratePercentUp.Size = new System.Drawing.Size(89, 58);
            this.feedratePercentUp.TabIndex = 33;
            this.feedratePercentUp.Tag = "";
            this.feedratePercentUp.Paint += new System.Windows.Forms.PaintEventHandler(this.feedratePercentUp_Paint);
            this.feedratePercentUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.feedratePercentUp_MouseDown);
            this.feedratePercentUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.feedratePercentUp_MouseUp);
            // 
            // feedratePercent100
            // 
            this.feedratePercent100.BackColor = System.Drawing.Color.PaleTurquoise;
            this.feedratePercent100.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.feedratePercent100.ForeColor = System.Drawing.Color.Red;
            this.feedratePercent100.Location = new System.Drawing.Point(2, 605);
            this.feedratePercent100.Name = "feedratePercent100";
            this.feedratePercent100.Size = new System.Drawing.Size(82, 120);
            this.feedratePercent100.TabIndex = 32;
            this.feedratePercent100.Tag = "";
            this.feedratePercent100.Paint += new System.Windows.Forms.PaintEventHandler(this.feedratePercent100_Paint);
            this.feedratePercent100.MouseDown += new System.Windows.Forms.MouseEventHandler(this.feedratePercent100_MouseDown);
            this.feedratePercent100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.feedratePercent100_MouseUp);
            // 
            // feedrateTypePanel
            // 
            this.feedrateTypePanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.feedrateTypePanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.feedrateTypePanel.ForeColor = System.Drawing.Color.Red;
            this.feedrateTypePanel.Location = new System.Drawing.Point(2, 543);
            this.feedrateTypePanel.Name = "feedrateTypePanel";
            this.feedrateTypePanel.Size = new System.Drawing.Size(173, 59);
            this.feedrateTypePanel.TabIndex = 31;
            this.feedrateTypePanel.Tag = "";
            this.feedrateTypePanel.Click += new System.EventHandler(this.feedrateTypePanel_Click);
            this.feedrateTypePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.feedrateTypePanel_Paint);
            // 
            // cycleStartPanel
            // 
            this.cycleStartPanel.BackColor = System.Drawing.Color.Thistle;
            this.cycleStartPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cycleStartPanel.ForeColor = System.Drawing.Color.Red;
            this.cycleStartPanel.Location = new System.Drawing.Point(1196, 543);
            this.cycleStartPanel.Name = "cycleStartPanel";
            this.cycleStartPanel.Size = new System.Drawing.Size(166, 182);
            this.cycleStartPanel.TabIndex = 30;
            this.cycleStartPanel.Tag = "";
            this.cycleStartPanel.Click += new System.EventHandler(this.cycleStartPanel_Click);
            this.cycleStartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cycleStartPanel_Paint);
            // 
            // feedHoldPanel
            // 
            this.feedHoldPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.feedHoldPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.feedHoldPanel.ForeColor = System.Drawing.Color.Red;
            this.feedHoldPanel.Location = new System.Drawing.Point(1026, 635);
            this.feedHoldPanel.Name = "feedHoldPanel";
            this.feedHoldPanel.Size = new System.Drawing.Size(166, 89);
            this.feedHoldPanel.TabIndex = 29;
            this.feedHoldPanel.Tag = "";
            this.feedHoldPanel.Click += new System.EventHandler(this.feedHoldPanel_Click);
            this.feedHoldPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.feedHoldPanel_Paint);
            // 
            // aJogMinusPanel
            // 
            this.aJogMinusPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.aJogMinusPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.aJogMinusPanel.ForeColor = System.Drawing.Color.Red;
            this.aJogMinusPanel.Location = new System.Drawing.Point(905, 666);
            this.aJogMinusPanel.Name = "aJogMinusPanel";
            this.aJogMinusPanel.Size = new System.Drawing.Size(118, 59);
            this.aJogMinusPanel.TabIndex = 27;
            this.aJogMinusPanel.Tag = "";
            this.aJogMinusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.aJogMinusPanel_Paint);
            this.aJogMinusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aJogMinusPanel_MouseDown);
            this.aJogMinusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aJogMinusPanel_MouseUp);
            // 
            // xJogPlusPanel
            // 
            this.xJogPlusPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.xJogPlusPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xJogPlusPanel.ForeColor = System.Drawing.Color.Red;
            this.xJogPlusPanel.Location = new System.Drawing.Point(905, 604);
            this.xJogPlusPanel.Name = "xJogPlusPanel";
            this.xJogPlusPanel.Size = new System.Drawing.Size(118, 59);
            this.xJogPlusPanel.TabIndex = 26;
            this.xJogPlusPanel.Tag = "";
            this.xJogPlusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.xJogPlusPanel_Paint);
            this.xJogPlusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xJogPlusPanel_MouseDown);
            this.xJogPlusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.xJogPlusPanel_MouseUp);
            // 
            // yJogPlusPanel
            // 
            this.yJogPlusPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.yJogPlusPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yJogPlusPanel.ForeColor = System.Drawing.Color.Red;
            this.yJogPlusPanel.Location = new System.Drawing.Point(905, 543);
            this.yJogPlusPanel.Name = "yJogPlusPanel";
            this.yJogPlusPanel.Size = new System.Drawing.Size(118, 59);
            this.yJogPlusPanel.TabIndex = 25;
            this.yJogPlusPanel.Tag = "";
            this.yJogPlusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.yJogPlusPanel_Paint);
            this.yJogPlusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.yJogPlusPanel_MouseDown);
            this.yJogPlusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.yJogPlusPanel_MouseUp);
            // 
            // zJogMinusPanel
            // 
            this.zJogMinusPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.zJogMinusPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zJogMinusPanel.ForeColor = System.Drawing.Color.Red;
            this.zJogMinusPanel.Location = new System.Drawing.Point(784, 666);
            this.zJogMinusPanel.Name = "zJogMinusPanel";
            this.zJogMinusPanel.Size = new System.Drawing.Size(118, 59);
            this.zJogMinusPanel.TabIndex = 24;
            this.zJogMinusPanel.Tag = "";
            this.zJogMinusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.zJogMinusPanel_Paint);
            this.zJogMinusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zJogMinusPanel_MouseDown);
            this.zJogMinusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zJogMinusPanel_MouseUp);
            // 
            // jogRapidPanel
            // 
            this.jogRapidPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.jogRapidPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.jogRapidPanel.ForeColor = System.Drawing.Color.Red;
            this.jogRapidPanel.Location = new System.Drawing.Point(784, 604);
            this.jogRapidPanel.Name = "jogRapidPanel";
            this.jogRapidPanel.Size = new System.Drawing.Size(118, 59);
            this.jogRapidPanel.TabIndex = 23;
            this.jogRapidPanel.Tag = "";
            this.jogRapidPanel.Click += new System.EventHandler(this.jogRapidPanel_Click);
            this.jogRapidPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.jogRapidPanel_Paint);
            // 
            // zJogPlusPanel
            // 
            this.zJogPlusPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.zJogPlusPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zJogPlusPanel.ForeColor = System.Drawing.Color.Red;
            this.zJogPlusPanel.Location = new System.Drawing.Point(784, 543);
            this.zJogPlusPanel.Name = "zJogPlusPanel";
            this.zJogPlusPanel.Size = new System.Drawing.Size(118, 59);
            this.zJogPlusPanel.TabIndex = 22;
            this.zJogPlusPanel.Tag = "";
            this.zJogPlusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.zJogPlusPanel_Paint);
            this.zJogPlusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zJogPlusPanel_MouseDown);
            this.zJogPlusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zJogPlusPanel_MouseUp);
            // 
            // yJogMinusPanel
            // 
            this.yJogMinusPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.yJogMinusPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yJogMinusPanel.ForeColor = System.Drawing.Color.Red;
            this.yJogMinusPanel.Location = new System.Drawing.Point(663, 666);
            this.yJogMinusPanel.Name = "yJogMinusPanel";
            this.yJogMinusPanel.Size = new System.Drawing.Size(118, 59);
            this.yJogMinusPanel.TabIndex = 21;
            this.yJogMinusPanel.Tag = "";
            this.yJogMinusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.yJogMinusPanel_Paint);
            this.yJogMinusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.yJogMinusPanel_MouseDown);
            this.yJogMinusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.yJogMinusPanel_MouseUp);
            // 
            // xJogMinusPanel
            // 
            this.xJogMinusPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.xJogMinusPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xJogMinusPanel.ForeColor = System.Drawing.Color.Red;
            this.xJogMinusPanel.Location = new System.Drawing.Point(663, 604);
            this.xJogMinusPanel.Name = "xJogMinusPanel";
            this.xJogMinusPanel.Size = new System.Drawing.Size(118, 59);
            this.xJogMinusPanel.TabIndex = 20;
            this.xJogMinusPanel.Tag = "";
            this.xJogMinusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.xJogMinusPanel_Paint);
            this.xJogMinusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xJogMinusPanel_MouseDown);
            this.xJogMinusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.xJogMinusPanel_MouseUp);
            // 
            // aJogPlusPanel
            // 
            this.aJogPlusPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.aJogPlusPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.aJogPlusPanel.ForeColor = System.Drawing.Color.Red;
            this.aJogPlusPanel.Location = new System.Drawing.Point(663, 543);
            this.aJogPlusPanel.Name = "aJogPlusPanel";
            this.aJogPlusPanel.Size = new System.Drawing.Size(118, 59);
            this.aJogPlusPanel.TabIndex = 19;
            this.aJogPlusPanel.Tag = "";
            this.aJogPlusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.aJogPlusPanel_Paint);
            this.aJogPlusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aJogPlusPanel_MouseDown);
            this.aJogPlusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aJogPlusPanel_MouseUp);
            // 
            // spindlePercentDown
            // 
            this.spindlePercentDown.BackColor = System.Drawing.SystemColors.Info;
            this.spindlePercentDown.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spindlePercentDown.ForeColor = System.Drawing.Color.Red;
            this.spindlePercentDown.Location = new System.Drawing.Point(299, 666);
            this.spindlePercentDown.Name = "spindlePercentDown";
            this.spindlePercentDown.Size = new System.Drawing.Size(118, 59);
            this.spindlePercentDown.TabIndex = 18;
            this.spindlePercentDown.Tag = "";
            this.spindlePercentDown.Paint += new System.Windows.Forms.PaintEventHandler(this.spindlePercentDown_Paint);
            this.spindlePercentDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spindlePercentDown_MouseDown);
            this.spindlePercentDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spindlePercentDown_MouseUp);
            // 
            // spindlePercent100
            // 
            this.spindlePercent100.BackColor = System.Drawing.SystemColors.Info;
            this.spindlePercent100.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spindlePercent100.ForeColor = System.Drawing.Color.Red;
            this.spindlePercent100.Location = new System.Drawing.Point(299, 604);
            this.spindlePercent100.Name = "spindlePercent100";
            this.spindlePercent100.Size = new System.Drawing.Size(118, 59);
            this.spindlePercent100.TabIndex = 17;
            this.spindlePercent100.Tag = "";
            this.spindlePercent100.Paint += new System.Windows.Forms.PaintEventHandler(this.spindlePercent100_Paint);
            this.spindlePercent100.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spindlePercent100_MouseDown);
            this.spindlePercent100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spindlePercent100_MouseUp);
            // 
            // spindlePercentUp
            // 
            this.spindlePercentUp.BackColor = System.Drawing.SystemColors.Info;
            this.spindlePercentUp.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spindlePercentUp.ForeColor = System.Drawing.Color.Red;
            this.spindlePercentUp.Location = new System.Drawing.Point(299, 543);
            this.spindlePercentUp.Name = "spindlePercentUp";
            this.spindlePercentUp.Size = new System.Drawing.Size(118, 59);
            this.spindlePercentUp.TabIndex = 16;
            this.spindlePercentUp.Tag = "";
            this.spindlePercentUp.Paint += new System.Windows.Forms.PaintEventHandler(this.spindlePercentUp_Paint);
            this.spindlePercentUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spindlePercentUp_MouseDown);
            this.spindlePercentUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spindlePercentUp_MouseUp);
            // 
            // spindleCcwPanel
            // 
            this.spindleCcwPanel.BackColor = System.Drawing.SystemColors.Info;
            this.spindleCcwPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spindleCcwPanel.ForeColor = System.Drawing.Color.Red;
            this.spindleCcwPanel.Location = new System.Drawing.Point(178, 666);
            this.spindleCcwPanel.Name = "spindleCcwPanel";
            this.spindleCcwPanel.Size = new System.Drawing.Size(118, 59);
            this.spindleCcwPanel.TabIndex = 15;
            this.spindleCcwPanel.Tag = "";
            this.spindleCcwPanel.Click += new System.EventHandler(this.spindleCcwPanel_Click);
            this.spindleCcwPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.spindleCcwPanel_Paint);
            // 
            // spindleOffPanel
            // 
            this.spindleOffPanel.BackColor = System.Drawing.SystemColors.Info;
            this.spindleOffPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spindleOffPanel.ForeColor = System.Drawing.Color.Red;
            this.spindleOffPanel.Location = new System.Drawing.Point(178, 604);
            this.spindleOffPanel.Name = "spindleOffPanel";
            this.spindleOffPanel.Size = new System.Drawing.Size(118, 59);
            this.spindleOffPanel.TabIndex = 14;
            this.spindleOffPanel.Tag = "";
            this.spindleOffPanel.Click += new System.EventHandler(this.spindleOffPanel_Click);
            this.spindleOffPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.spindleOffPanel_Paint);
            // 
            // spindleCwPanel
            // 
            this.spindleCwPanel.BackColor = System.Drawing.SystemColors.Info;
            this.spindleCwPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spindleCwPanel.ForeColor = System.Drawing.Color.Red;
            this.spindleCwPanel.Location = new System.Drawing.Point(178, 543);
            this.spindleCwPanel.Name = "spindleCwPanel";
            this.spindleCwPanel.Size = new System.Drawing.Size(118, 59);
            this.spindleCwPanel.TabIndex = 13;
            this.spindleCwPanel.Tag = "";
            this.spindleCwPanel.Click += new System.EventHandler(this.spindleCwPanel_Click);
            this.spindleCwPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.spindleCwPanel_Paint);
            // 
            // ncModeMemPanel
            // 
            this.ncModeMemPanel.BackColor = System.Drawing.Color.LightBlue;
            this.ncModeMemPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ncModeMemPanel.ForeColor = System.Drawing.Color.Red;
            this.ncModeMemPanel.Location = new System.Drawing.Point(541, 666);
            this.ncModeMemPanel.Name = "ncModeMemPanel";
            this.ncModeMemPanel.Size = new System.Drawing.Size(118, 59);
            this.ncModeMemPanel.TabIndex = 12;
            this.ncModeMemPanel.Tag = "";
            this.ncModeMemPanel.Click += new System.EventHandler(this.ncModeMemPanel_Click);
            this.ncModeMemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ncModeMemPanel_Paint);
            // 
            // ncModeMpgPanel
            // 
            this.ncModeMpgPanel.BackColor = System.Drawing.Color.LightBlue;
            this.ncModeMpgPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ncModeMpgPanel.ForeColor = System.Drawing.Color.Red;
            this.ncModeMpgPanel.Location = new System.Drawing.Point(541, 604);
            this.ncModeMpgPanel.Name = "ncModeMpgPanel";
            this.ncModeMpgPanel.Size = new System.Drawing.Size(118, 59);
            this.ncModeMpgPanel.TabIndex = 11;
            this.ncModeMpgPanel.Tag = "";
            this.ncModeMpgPanel.Click += new System.EventHandler(this.ncModeMpgPanel_Click);
            this.ncModeMpgPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ncModeMpgPanel_Paint);
            // 
            // ncModeIncJogPanel
            // 
            this.ncModeIncJogPanel.BackColor = System.Drawing.Color.LightBlue;
            this.ncModeIncJogPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ncModeIncJogPanel.ForeColor = System.Drawing.Color.Red;
            this.ncModeIncJogPanel.Location = new System.Drawing.Point(541, 543);
            this.ncModeIncJogPanel.Name = "ncModeIncJogPanel";
            this.ncModeIncJogPanel.Size = new System.Drawing.Size(118, 59);
            this.ncModeIncJogPanel.TabIndex = 10;
            this.ncModeIncJogPanel.Tag = "";
            this.ncModeIncJogPanel.Click += new System.EventHandler(this.ncModeIncJogPanel_Click);
            this.ncModeIncJogPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ncModeIncJogPanel_Paint);
            // 
            // ncModeMdiPanel
            // 
            this.ncModeMdiPanel.BackColor = System.Drawing.Color.LightBlue;
            this.ncModeMdiPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ncModeMdiPanel.ForeColor = System.Drawing.Color.Red;
            this.ncModeMdiPanel.Location = new System.Drawing.Point(420, 666);
            this.ncModeMdiPanel.Name = "ncModeMdiPanel";
            this.ncModeMdiPanel.Size = new System.Drawing.Size(118, 59);
            this.ncModeMdiPanel.TabIndex = 9;
            this.ncModeMdiPanel.Tag = "";
            this.ncModeMdiPanel.Click += new System.EventHandler(this.ncModeMdiPanel_Click);
            this.ncModeMdiPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ncModeMdiPanel_Paint);
            // 
            // ncModeZrnPanel
            // 
            this.ncModeZrnPanel.BackColor = System.Drawing.Color.LightBlue;
            this.ncModeZrnPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ncModeZrnPanel.ForeColor = System.Drawing.Color.Red;
            this.ncModeZrnPanel.Location = new System.Drawing.Point(420, 604);
            this.ncModeZrnPanel.Name = "ncModeZrnPanel";
            this.ncModeZrnPanel.Size = new System.Drawing.Size(118, 59);
            this.ncModeZrnPanel.TabIndex = 8;
            this.ncModeZrnPanel.Tag = "";
            this.ncModeZrnPanel.Click += new System.EventHandler(this.ncModeZrnPanel_Click);
            this.ncModeZrnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ncModeZrnPanel_Paint);
            // 
            // ncModeJogPanel
            // 
            this.ncModeJogPanel.BackColor = System.Drawing.Color.LightBlue;
            this.ncModeJogPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ncModeJogPanel.ForeColor = System.Drawing.Color.Red;
            this.ncModeJogPanel.Location = new System.Drawing.Point(420, 543);
            this.ncModeJogPanel.Name = "ncModeJogPanel";
            this.ncModeJogPanel.Size = new System.Drawing.Size(118, 59);
            this.ncModeJogPanel.TabIndex = 7;
            this.ncModeJogPanel.Tag = "";
            this.ncModeJogPanel.Click += new System.EventHandler(this.ncModeJogPanel_Click);
            this.ncModeJogPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ncModeJogPanel_Paint);
            // 
            // formParameterPanel
            // 
            this.formParameterPanel.BackColor = System.Drawing.Color.MistyRose;
            this.formParameterPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.formParameterPanel.ForeColor = System.Drawing.Color.Red;
            this.formParameterPanel.Location = new System.Drawing.Point(1208, 456);
            this.formParameterPanel.Name = "formParameterPanel";
            this.formParameterPanel.Size = new System.Drawing.Size(154, 79);
            this.formParameterPanel.TabIndex = 5;
            this.formParameterPanel.Tag = "";
            this.formParameterPanel.Click += new System.EventHandler(this.formParameterPanel_Click);
            this.formParameterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formParameterPanel_Paint);
            // 
            // formMaintenPanel
            // 
            this.formMaintenPanel.BackColor = System.Drawing.Color.MistyRose;
            this.formMaintenPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.formMaintenPanel.ForeColor = System.Drawing.Color.Red;
            this.formMaintenPanel.Location = new System.Drawing.Point(1208, 373);
            this.formMaintenPanel.Name = "formMaintenPanel";
            this.formMaintenPanel.Size = new System.Drawing.Size(154, 79);
            this.formMaintenPanel.TabIndex = 4;
            this.formMaintenPanel.Tag = "";
            this.formMaintenPanel.Click += new System.EventHandler(this.formMaintenPanel_Click);
            this.formMaintenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formMaintenPanel_Paint);
            // 
            // formDiagnosisPanel
            // 
            this.formDiagnosisPanel.BackColor = System.Drawing.Color.MistyRose;
            this.formDiagnosisPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.formDiagnosisPanel.ForeColor = System.Drawing.Color.Red;
            this.formDiagnosisPanel.Location = new System.Drawing.Point(1208, 290);
            this.formDiagnosisPanel.Name = "formDiagnosisPanel";
            this.formDiagnosisPanel.Size = new System.Drawing.Size(154, 79);
            this.formDiagnosisPanel.TabIndex = 3;
            this.formDiagnosisPanel.Tag = "";
            this.formDiagnosisPanel.Click += new System.EventHandler(this.formDiagnosisPanel_Click);
            this.formDiagnosisPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formDiagnosisPanel_Paint);
            // 
            // formOffsetPanel
            // 
            this.formOffsetPanel.BackColor = System.Drawing.Color.MistyRose;
            this.formOffsetPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.formOffsetPanel.ForeColor = System.Drawing.Color.Red;
            this.formOffsetPanel.Location = new System.Drawing.Point(1208, 207);
            this.formOffsetPanel.Name = "formOffsetPanel";
            this.formOffsetPanel.Size = new System.Drawing.Size(154, 79);
            this.formOffsetPanel.TabIndex = 2;
            this.formOffsetPanel.Tag = "";
            this.formOffsetPanel.Click += new System.EventHandler(this.formOffsetPanel_Click);
            this.formOffsetPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formOffsetPanel_Paint);
            // 
            // formProgramPanel
            // 
            this.formProgramPanel.BackColor = System.Drawing.Color.MistyRose;
            this.formProgramPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.formProgramPanel.ForeColor = System.Drawing.Color.Red;
            this.formProgramPanel.Location = new System.Drawing.Point(1208, 124);
            this.formProgramPanel.Name = "formProgramPanel";
            this.formProgramPanel.Size = new System.Drawing.Size(154, 79);
            this.formProgramPanel.TabIndex = 1;
            this.formProgramPanel.Tag = "";
            this.formProgramPanel.Click += new System.EventHandler(this.formProgramPanel_Click);
            this.formProgramPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formProgramPanel_Paint);
            // 
            // formMonitorPanel
            // 
            this.formMonitorPanel.BackColor = System.Drawing.Color.MistyRose;
            this.formMonitorPanel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.formMonitorPanel.ForeColor = System.Drawing.Color.Red;
            this.formMonitorPanel.Location = new System.Drawing.Point(1208, 41);
            this.formMonitorPanel.Name = "formMonitorPanel";
            this.formMonitorPanel.Size = new System.Drawing.Size(154, 79);
            this.formMonitorPanel.TabIndex = 0;
            this.formMonitorPanel.Tag = "";
            this.formMonitorPanel.Click += new System.EventHandler(this.formMonitorPanel_Click);
            this.formMonitorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formMonitorPanel_Paint);
            // 
            // mouseTimer
            // 
            this.mouseTimer.Interval = 1000;
            this.mouseTimer.Tick += new System.EventHandler(this.mouseTimer_Tick);
            // 
            // jcncMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.singleBlockPanel);
            this.Controls.Add(this.zLimitLightPanel);
            this.Controls.Add(this.yLimitLightPanel);
            this.Controls.Add(this.xLimitLightPanel);
            this.Controls.Add(this.emgStopLightPanel);
            this.Controls.Add(this.controlFunctionPanel);
            this.Controls.Add(this.aHomeLightPanel);
            this.Controls.Add(this.zHomeLightPanel);
            this.Controls.Add(this.yHomeLightPanel);
            this.Controls.Add(this.xHomeLightPanel);
            this.Controls.Add(this.resetPanel);
            this.Controls.Add(this.feedratePercentDown);
            this.Controls.Add(this.feedratePercentUp);
            this.Controls.Add(this.feedratePercent100);
            this.Controls.Add(this.feedrateTypePanel);
            this.Controls.Add(this.cycleStartPanel);
            this.Controls.Add(this.feedHoldPanel);
            this.Controls.Add(this.aJogMinusPanel);
            this.Controls.Add(this.xJogPlusPanel);
            this.Controls.Add(this.yJogPlusPanel);
            this.Controls.Add(this.zJogMinusPanel);
            this.Controls.Add(this.jogRapidPanel);
            this.Controls.Add(this.zJogPlusPanel);
            this.Controls.Add(this.yJogMinusPanel);
            this.Controls.Add(this.xJogMinusPanel);
            this.Controls.Add(this.aJogPlusPanel);
            this.Controls.Add(this.spindlePercentDown);
            this.Controls.Add(this.spindlePercent100);
            this.Controls.Add(this.spindlePercentUp);
            this.Controls.Add(this.spindleCcwPanel);
            this.Controls.Add(this.spindleOffPanel);
            this.Controls.Add(this.spindleCwPanel);
            this.Controls.Add(this.ncModeMemPanel);
            this.Controls.Add(this.ncModeMpgPanel);
            this.Controls.Add(this.ncModeIncJogPanel);
            this.Controls.Add(this.ncModeMdiPanel);
            this.Controls.Add(this.ncModeZrnPanel);
            this.Controls.Add(this.ncModeJogPanel);
            this.Controls.Add(this.formTabControl);
            this.Controls.Add(this.formParameterPanel);
            this.Controls.Add(this.formMaintenPanel);
            this.Controls.Add(this.formDiagnosisPanel);
            this.Controls.Add(this.formOffsetPanel);
            this.Controls.Add(this.formProgramPanel);
            this.Controls.Add(this.formMonitorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "jcncMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "t";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JCNCMainFormClosing);
            this.Load += new System.EventHandler(this.JCNCMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formMonitorPanel;
        private System.Windows.Forms.Panel formProgramPanel;
        private System.Windows.Forms.Panel formOffsetPanel;
        private System.Windows.Forms.Panel formDiagnosisPanel;
        private System.Windows.Forms.Panel formMaintenPanel;
        private System.Windows.Forms.Panel formParameterPanel;
        private System.Windows.Forms.TabControl formTabControl;
        private System.Windows.Forms.Panel ncModeJogPanel;
        private System.Windows.Forms.Panel ncModeZrnPanel;
        private System.Windows.Forms.Panel ncModeMdiPanel;
        private System.Windows.Forms.Panel ncModeMemPanel;
        private System.Windows.Forms.Panel ncModeMpgPanel;
        private System.Windows.Forms.Panel ncModeIncJogPanel;
        private System.Windows.Forms.Panel spindlePercentDown;
        private System.Windows.Forms.Panel spindlePercent100;
        private System.Windows.Forms.Panel spindlePercentUp;
        private System.Windows.Forms.Panel spindleCcwPanel;
        private System.Windows.Forms.Panel spindleOffPanel;
        private System.Windows.Forms.Panel spindleCwPanel;
        private System.Windows.Forms.Panel zJogMinusPanel;
        private System.Windows.Forms.Panel jogRapidPanel;
        private System.Windows.Forms.Panel zJogPlusPanel;
        private System.Windows.Forms.Panel yJogMinusPanel;
        private System.Windows.Forms.Panel xJogMinusPanel;
        private System.Windows.Forms.Panel aJogPlusPanel;
        private System.Windows.Forms.Panel aJogMinusPanel;
        private System.Windows.Forms.Panel xJogPlusPanel;
        private System.Windows.Forms.Panel yJogPlusPanel;
        private System.Windows.Forms.Timer cycleStartTimer;
        private System.Windows.Forms.Panel feedHoldPanel;
        private System.Windows.Forms.Panel cycleStartPanel;
        private System.Windows.Forms.Panel feedrateTypePanel;
        private System.Windows.Forms.Panel feedratePercent100;
        private System.Windows.Forms.Panel feedratePercentUp;
        private System.Windows.Forms.Panel feedratePercentDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel resetPanel;
        private System.Windows.Forms.Panel xHomeLightPanel;
        private System.Windows.Forms.Panel yHomeLightPanel;
        private System.Windows.Forms.Panel aHomeLightPanel;
        private System.Windows.Forms.Panel zHomeLightPanel;
        private System.Windows.Forms.Panel controlFunctionPanel;
        private System.Windows.Forms.Panel emgStopLightPanel;
        private System.Windows.Forms.Timer systemStatusTimer;
        private System.Windows.Forms.Panel zLimitLightPanel;
        private System.Windows.Forms.Panel yLimitLightPanel;
        private System.Windows.Forms.Panel xLimitLightPanel;
        private System.Windows.Forms.Panel singleBlockPanel;
        private System.Windows.Forms.Timer homeStateTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem powerOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton shutDownToolStripSplitButton;
        private System.Windows.Forms.ToolStripStatusLabel systemTimeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.Timer updateStatusBartimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer toolAbnormalTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer mouseTimer;
    }
}

