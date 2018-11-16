using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using JCNCShareMemory;
using Offset;
using JCNCDTCONECT;

namespace JCNC
{
    public partial class FORM_Mon_Monitor : Form
    {
        private Font drawFont;

        private int iSPOveride;
        private int iFTOverride;
        private int iRapidFTOverride;

        private bool NormalFTOrNot;
        private bool RelProgOn;

        private string[] axis_name = new string[ShareMemory.AxisNum] { "X", "Y", "Z", "C" };
        private Label[] MacCoodLabel, ProgCoodLabel, AbsCoodValue, RelCoodValue;

        private void ObjectArray()
        {
            this.MacCoodLabel = new Label[ShareMemory.AxisNum] { this.MacCood_X, this.MacCood_Y, this.MacCood_Z, this.MacCood_C };
            this.ProgCoodLabel = new Label[ShareMemory.AxisNum] { this.ProgCood_X, this.ProgCood_Y, this.ProgCood_Z, this.ProgCood_C };
            this.AbsCoodValue = new Label[ShareMemory.AxisNum] { this.AbsCood_XValue, this.AbsCood_YValue, this.AbsCood_ZValue, this.AbsCood_CValue };
            this.RelCoodValue = new Label[ShareMemory.AxisNum] { this.RelCood_XValue, this.RelCood_YValue, this.RelCood_ZValue, this.RelCood_CValue };
        }

        private void InitParameter()
        {
            this.drawFont = new Font("Arial", 16);
            this.iSPOveride = 100;
            this.iFTOverride = 100;
            this.iRapidFTOverride = 25;

            this.NormalFTOrNot = true;
            this.RelProgOn = false;
        }

        private void InitUI()
        {
            this.MacCood.Font = new Font("標楷體", 28f, FontStyle.Bold);
            this.ProgCood.Font = new Font("標楷體", 28f, FontStyle.Bold);
            this.MacCood.Text = "機械座標";
            this.ProgCood.Text = "程式座標";

            for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
            {
                this.MacCoodLabel[axis].Font = new Font("Times New Roman", 36f, FontStyle.Bold);
                this.ProgCoodLabel[axis].Font = new Font("Times New Roman", 36f, FontStyle.Bold);
                this.MacCoodLabel[axis].Text = this.axis_name[axis];
                this.ProgCoodLabel[axis].Text = this.axis_name[axis];

                this.MacCoodLabel[axis].BackColor = System.Drawing.SystemColors.ActiveCaption;
                this.ProgCoodLabel[axis].BackColor = System.Drawing.SystemColors.ActiveCaption;
            }

            this.SPStatus.Text = "Status: ";
            this.SPMaxSpeed.Text = "Max. Speed: ";
            this.SPSpeed.Text = "Speed: ";
            this.SPOveride.Text = "";
            this.bStatus.Text = "OFF";
            this.SPOveride.Text = "Overide (%):";
            this.MaxFeed.Text = "Max. Feed:";
            this.Feed.Text = "Feed: ";
            this.FDOveride.Text = "Normal (%):";
            this.FDRapid.Text = "Rapid (%):";
        }

        private void SetParameter()
        {
            ShareMemory.FeedRate.NormalPercentage = iFTOverride;
            ShareMemory.FeedRate.RapidPercentage = iRapidFTOverride;

            this.SPOverideValue.Text = iSPOveride.ToString();
            this.SPMaxSpeedVal.Text = ShareMemory.SpindleMaxSpeed.ToString();
        }

        private void SetTimer()
        {
            this.MF_Mon_Mon_Timer.Interval = 20;
            this.MF_Mon_Mon_Timer.Start();
            this.showSpindleSpeedTimer.Interval = 300;
            this.showSpindleSpeedTimer.Start();
            this.getSystemTimerData.Interval = 800;
            this.getSystemTimerData.Start();
        }

        //-- Constructor
        public FORM_Mon_Monitor()
        {
            InitializeComponent();

            this.ObjectArray();

            this.InitParameter();
            this.InitUI();

            this.SetParameter();
            this.SetTimer();

            ShareMemory.PageInitFinshed = true;
        }

        //int tmpindex = -999;
        //int index = -998;
        private void MF_Mon_Mon_Timer_Tick(object sender, EventArgs e)
        {
            for (int axis_num = 0; axis_num < ShareMemory.CS.AxisNum; axis_num++)
            {
                ShareMemory.CS.Rel[axis_num] = ShareMemory.CS.Machine[axis_num];
            }

            switch (ShareMemory.CS.Swich)
            {
                case 0:     // Machine & Program
                    for (int axis = 0; axis < ShareMemory.CS.AxisNum; axis++)
                    {
                        this.AbsCoodValue[axis].Text = string.Format("{0:0.000}", ShareMemory.CS.Machine[axis]);
                        this.RelCoodValue[axis].Text = string.Format("{0:0.000}", ShareMemory.CS.Prog[axis]);
                    }
                    break;
                case 1:     // Machine & Relative
                    for (int axis = 0; axis < ShareMemory.CS.AxisNum; axis++)
                    {
                        this.AbsCoodValue[axis].Text = string.Format("{0:0.000}", ShareMemory.CS.Machine[axis]);
                        this.RelCoodValue[axis].Text = string.Format("{0:0.000}", ShareMemory.CS.Rel[axis] - ShareMemory.CS.RelOffset[axis]);
                    }
                    break;
                case 2:     // Program & DistanceToGo
                    for (int axis = 0; axis < ShareMemory.CS.AxisNum; axis++)
                    {
                        this.AbsCoodValue[axis].Text = string.Format("{0:0.000}", ShareMemory.CS.Prog[axis]);
                        this.RelCoodValue[axis].Text = string.Format("{0:0.000}", ShareMemory.CS.DistToGo[axis]);
                    }
                    break;
                case 3:     // Program & Relative
                    for (int axis = 0; axis < ShareMemory.CS.AxisNum; axis++)
                    {
                        this.AbsCoodValue[axis].Text = string.Format("{0:0.000}", ShareMemory.CS.Prog[axis]);
                        this.RelCoodValue[axis].Text = string.Format("{0:0.000}", ShareMemory.CS.Rel[axis] - ShareMemory.CS.RelOffset[axis]);
                    }
                    break;
            }

            if ((ShareMemory.NcMode.value == ShareMemory.NcMode.MEM) || (ShareMemory.NcMode.value == ShareMemory.NcMode.MDI))
            {
                if (this.CMDGridView.RowCount > 0)
                {
                    int index = ShareMemory.ProgramLineNum;
                    this.lineNumLabel.Text = index.ToString();

                    if (ShareMemory.ProgramLineNum == 0)
                    {
                        this.CMDGridView.CurrentCell = this.CMDGridView[0, 0];
                    }
                    if (index > 0)
                    {
                        this.CMDGridView.CurrentCell = this.CMDGridView[0, index - 1];
                    }
                }
            }

            // T-code
            this.T_tCodeLabel.Text = ShareMemory.CurrentToolNum.ToString();
            this.H_tCodeLabel.Text = ShareMemory.CurrentHNum.ToString();
            this.D_tCodeLabel.Text = ShareMemory.CurrentDNum.ToString();
            this.Hvalue_tCodeLabel.Text = ShareMemory.CurrentHNumVal.ToString("#0.000");
            this.Dvalue_tCodeLabel.Text = ShareMemory.CurrentDNumVal.ToString("#0.000");
        }

        private void DataGridViewReadFile()
        {
            int row_index = 0;
            string[] readText;

            // 換行
            this.CMDGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            /////////////////////////////////////////////////////////
            if (ShareMemory.NcMode.MDI == ShareMemory.NcMode.value)
            {
                readText = File.ReadAllLines(ShareMemory.GetFilePath(ShareMemory.OperationMode.MDI));

                this.CMDGridView.Rows.Clear();

                this.CMDGridView.RowCount = readText.Count();
                foreach (string s in readText)
                {
                    this.CMDGridView[0, row_index].Value = s;
                    row_index++;
                }

                ShareMemory.currentPath = ShareMemory.GetFilePath(ShareMemory.OperationMode.MDI);
            }
            else
            {

                if (ShareMemory.currentPath != ShareMemory.GetFilePath(ShareMemory.OperationMode.MEM))
                {
                    // 檢查檔案存歿
                    if (true == File.Exists(ShareMemory.GetFilePath(ShareMemory.OperationMode.MEM)))
                    {
                        // 有
                        readText = File.ReadAllLines(ShareMemory.GetFilePath(ShareMemory.OperationMode.MEM));

                        this.CMDGridView.Rows.Clear();

                        this.CMDGridView.RowCount = readText.Count();
                        foreach (string s in readText)
                        {
                            this.CMDGridView[0, row_index].Value = s;
                            row_index++;
                        }
                    }
                    else
                    {
                        //沒有
                        this.CMDGridView.Rows.Clear();
                        ShareMemory.SetFilePath(@"", ShareMemory.OperationMode.MEM);
                    }

                    ShareMemory.currentPath = ShareMemory.GetFilePath(ShareMemory.OperationMode.MEM);
                }
            }
        }

        private void loadFileTimer_Tick(object sender, EventArgs e)
        {
            this.loadFileTimer.Stop();

            WarningMSG warningMSG = new WarningMSG("檔案讀取中!");
            warningMSG.Show();

            //Application.DoEvents();
            warningMSG.Refresh();
            System.Threading.Thread.Sleep(50);

            this.DataGridViewReadFile();
            if (0 < this.CMDGridView.RowCount)
                this.CMDGridView.CurrentCell = this.CMDGridView[0, 0];

            warningMSG.Close();
            warningMSG.Dispose();
        }

        private void MF_Mon_Mon_Paint(object sender, PaintEventArgs e)
        {
            if (ShareMemory.FileLoadOn)
            {
                ShareMemory.FileLoadOn = false;

                this.SetNCFileName(JCNCSettings.Default.AutoRunOpendFileName);
                this.loadFileTimer.Start();
            }
        }

        public void SetSPOveride(int percentage100)
        {
            this.iSPOveride = percentage100;
            JCNCSettings.Default.SPOverideValue = iSPOveride;
            this.SPOverideValue.Text = iSPOveride.ToString();
            JCNCSettings.Default.Save();
        }

        public int SetSPOveride(bool UpDown)
        {
            // Up : true; Down : false
            switch (UpDown)
            {
                case true:
                    if (iSPOveride < 110)
                        this.iSPOveride = iSPOveride + 10;
                    else
                        this.iSPOveride = 120;
                    break;
                case false:
                    if (iSPOveride > 20)
                        this.iSPOveride = iSPOveride - 10;
                    else
                        this.iSPOveride = 10;
                    break;
            }
            JCNCSettings.Default.SPOverideValue = iSPOveride;
            this.SPOverideValue.Text = iSPOveride.ToString();
            JCNCSettings.Default.Save();

            return iSPOveride;
        }
        
        public void SetFeedrateOveride100()
        {
            switch (NormalFTOrNot)
            {
                case true:
                    this.iFTOverride = 100;
                    ShareMemory.FeedRate.NormalPercentage = iFTOverride;
                    this.FTOverrideValue.Text = "100";
                    break;
                case false:
                    this.iRapidFTOverride = 100;
                    ShareMemory.FeedRate.RapidPercentage = iRapidFTOverride;
                    this.RapidFTOverrideValue.Text = "100";
                    break;
            }

        }

        public void SetNormalFeedrateOrNot(bool TON)
        {
            this.NormalFTOrNot = TON;
        }

        public void GetFTOveride(out int normal, out int rapid)
        {
            int value = 0;
            int.TryParse(this.FTOverrideValue.Text, out value);
            normal = value;
            int.TryParse(this.RapidFTOverrideValue.Text, out value);
            rapid = value;
        }

        public void SetFTOveride(bool UpDown)
        {
            // Up : true; Down : false
            switch (this.NormalFTOrNot)
            {
                case true:
                    switch (UpDown)
                    {
                        case true:
                            if (this.iFTOverride < 140)
                                this.iFTOverride = this.iFTOverride + 10;
                            else
                                this.iFTOverride = 150;
                            break;
                        case false:
                            if (this.iFTOverride > 10)
                                this.iFTOverride = this.iFTOverride - 10;
                            else
                                this.iFTOverride = 0;
                            break;
                    }
                    this.FTOverrideValue.Text = this.iFTOverride.ToString();
                    ShareMemory.FeedRate.NormalPercentage = iFTOverride;

                    break;
                case false:
                    switch (UpDown)
                    {
                        case true:
                            if (this.iRapidFTOverride < 75)
                                this.iRapidFTOverride = this.iRapidFTOverride + 25;
                            else
                                this.iRapidFTOverride = 100;
                            break;
                        case false:
                            if (this.iRapidFTOverride > 25)
                                this.iRapidFTOverride = this.iRapidFTOverride - 25;
                            else
                                this.iRapidFTOverride = 0;
                            break;
                    }
                    this.RapidFTOverrideValue.Text = this.iRapidFTOverride.ToString();
                    ShareMemory.FeedRate.RapidPercentage = this.iRapidFTOverride;

                    break;
            }
        }

        int sw = 1;
        public void CSSwitch()
        {
            ShareMemory.CS.Swich = sw;
            for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
            {
                this.ProgCoodLabel[axis].BackColor = System.Drawing.SystemColors.ActiveCaption;
            }

            switch (sw)
            {
                case 0:
                    this.MacCood.Text = "機械座標";
                    this.ProgCood.Text = "程式座標";
                    this.RelProgOn = false;
                    sw = 1;
                    break;
                case 1:
                    this.MacCood.Text = "機械座標";
                    this.ProgCood.Text = "相對座標";
                    for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
                    {
                        this.ProgCoodLabel[axis].BackColor = Color.LightGreen; ;
                    }
                    this.RelProgOn = true;
                    sw = 2;
                    break;
                case 2:
                    this.MacCood.Text = "程式座標";
                    this.ProgCood.Text = "殘餘指令";
                    this.RelProgOn = false;
                    sw = 3;
                    break;
                case 3:
                    this.MacCood.Text = "程式座標";
                    this.ProgCood.Text = "相對座標";
                    for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
                    {
                        this.ProgCoodLabel[axis].BackColor = Color.LightGreen; ;
                    }
                    this.RelProgOn = true;
                    sw = 0;
                    break;
            }
        }

        private void ProgCood_MouseDown(object sender, MouseEventArgs e)
        {
            if (RelProgOn)
            {
                int current_axis = -1;
                for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
                {
                    if ((Label)sender == this.ProgCoodLabel[axis])
                    {
                        current_axis = axis;
                        axis = ShareMemory.AxisNum;
                    }
                }

                ShareMemory.CS.RelOffset[current_axis] = ShareMemory.CS.Rel[current_axis];
                this.ProgCoodLabel[current_axis].BackColor = Color.LightPink;
            }
        }

        private void ProgCood_MouseUp(object sender, MouseEventArgs e)
        {
            if (RelProgOn)
            {
                int current_axis = -1;
                for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
                {
                    if ((Label)sender == this.ProgCoodLabel[axis])
                    {
                        current_axis = axis;
                        axis = ShareMemory.AxisNum;
                    }
                }

                this.ProgCoodLabel[current_axis].BackColor = Color.LightGreen;
            }
        }

        private void getSystemTimerData_Tick(object sender, EventArgs e)
        {
            TimeSpan autoRun = ShareMemory.systemTimeAutoRun;
            TimeSpan autoOperate = ShareMemory.systemTimeAutoOperate;
            int machiningNum = ShareMemory.systemTimeMachiningNum;

            this.autoRunTimeLabel.Text = ((int)autoRun.TotalHours).ToString("#00") + ":" +
                                        autoRun.Minutes.ToString("#00") + ":" +
                                        autoRun.Seconds.ToString("#00");

            this.autoOperateTimeLabel.Text = ((int)autoOperate.TotalHours).ToString("#00") + ":" +
                                         autoOperate.Minutes.ToString("#00") + ":" +
                                         autoOperate.Seconds.ToString("#00");

            this.machiningNumLabel.Text = machiningNum.ToString();
        }

        public void SetRealFeedrateValue(double feedrate_value)
        {
            feedrate_value = Math.Round(feedrate_value, 0);
            if (10 > feedrate_value)
            {
                feedrate_value = 0;
            }
            this.FeedVal.Text = feedrate_value.ToString("#0");
        }

        public void ShowCurrentCoordinateSystem()
        {
            string main_coordinate_display, sub_coordinate_display;
            if (false == Connection.CNCtoDT.GetCurrentCoordinateSystem(out main_coordinate_display, out sub_coordinate_display))
            {
                // // Console.WriteLine("Error: Connection.CNCtoDT.GetCurrentCoordinateSystem(out main_coordinate_display, out sub_coordinate_display)");
            }
            else
            {
                this.mainCoordinateLabel.Text = main_coordinate_display;
                this.subCoordinateLabel.Text = sub_coordinate_display;

                if (".000" == sub_coordinate_display)
                {
                    this.subCoordinateLabel.Visible = false;
                }
                else
                {
                    this.subCoordinateLabel.Visible = true;
                }
            }
        }

        public void ReloadFeedRateValue()
        {
            int a;
            ShareMemory.LoadMaxFeedRate(out a);

            this.MaxFT.Text = ShareMemory.MaxFeedRateVal.ToString();
            this.FTOverrideValue.Text = ShareMemory.FeedRate.NormalPercentage.ToString();
            this.RapidFTOverrideValue.Text = ShareMemory.FeedRate.RapidPercentage.ToString();
        }

        private void showSpindleSpeedTimer_Tick(object sender, EventArgs e)
        {
            //MaxFT.Text = ShareMemory.MaxFeedRateVal.ToString();
            if (ShareMemory.SpindleSpeed >= ShareMemory.SpindleMaxSpeed)
            {
                this.SPSpeedVal.Text = ShareMemory.SpindleMaxSpeed.ToString();
            }
            else if (ShareMemory.SpindleSpeed <= -(ShareMemory.SpindleMaxSpeed))
            {
                this.SPSpeedVal.Text = "-" + ShareMemory.SpindleMaxSpeed.ToString();
            }
            else
            {
                this.SPSpeedVal.Text = ShareMemory.SpindleSpeed.ToString();
            }

            this.SPMaxSpeedVal.Text = ShareMemory.SpindleMaxSpeed.ToString();
        }

        private void cmdVScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.CMDGridView.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        public void SetNCFileName(string file_name)
        {
            this.ncFileName.Text = file_name;
        }

        public void SetCmdGridViewToTheFirstLine()
        {
            if (this.CMDGridView.RowCount > 0)
            {
                this.CMDGridView.CurrentCell = this.CMDGridView[0, 0];
            }
        }
    }
}
