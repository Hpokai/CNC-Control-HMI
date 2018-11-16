using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JCNCShareMemory;
using JCNCDTCONECT;

namespace JCNCSystemTime
{
    public partial class FORM_Main_SystemTime : Form
    {
        private DateTime time_start;
        private DateTime PowerOnTime;
        private DateTime currentPowerOnTime;
        private TimeSpan powerOnTimeSpent;

        private TimeSpan tempTimeSpan = TimeSpan.Zero;
        private TimeSpan autoOperateTimeSpent = TimeSpan.Zero;
        private TimeSpan autoRunTimeSpent = TimeSpan.Zero;
        private DateTime autoRunStartTime = DateTime.MinValue;
        private DateTime autoRunStopTime = DateTime.MinValue;
        private bool isAutoOperateStop = true;

        private int current_machining_num;

        public FORM_Main_SystemTime()
        {
            InitializeComponent();

            this.time_start = DateTime.Now;
            this.PowerOnTime = DateTime.MinValue;
            this.currentPowerOnTime = DateTime.MinValue;
            this.powerOnTimeSpent = TimeSpan.Zero;

            try
            {
                this.PowerOnTime = ShareMemory.GetPowerOnTime();
            }
            catch
            {
                ShareMemory.SetPowerOnTime(DateTime.Now);
                this.PowerOnTime = DateTime.Now;
            }

            try
            {
                this.autoOperateTimeSpent = ShareMemory.GetAutoOperateTimeSpan();
            }
            catch
            {
                ShareMemory.SetAutoOperateTimeSpan(TimeSpan.Zero);
                this.autoOperateTimeSpent = TimeSpan.Zero;
                //throw;
            }

            this.STtimer.Interval = 1000;
            this.STtimer.Start();

            this.current_machining_num = SystemTimeSet.Default.MachiningNum;
            this.machiningNumLabel.Text = this.current_machining_num.ToString();
            this.getMachiningNumTimer.Interval = 100;
            this.getMachiningNumTimer.Start();

            this.returnDataTimer.Interval = 800;
            this.returnDataTimer.Start();

            ShareMemory.PageInitFinshed = true;
        }

        private void MF_Main_SystemTime_Load(object sender, EventArgs e)
        {
            this.autoRunTimeLabel.Text = TimeSpan.Zero.ToString();
            this.autoOperateTimeLabel.Text = ((int)ShareMemory.GetAutoOperateTimeSpan().TotalHours).ToString("#00") + ":" +
                                             ShareMemory.GetAutoOperateTimeSpan().Minutes.ToString("#00") + ":" +
                                             ShareMemory.GetAutoOperateTimeSpan().Seconds.ToString("#00");
        }

        private void STtimer_Tick(object sender, EventArgs e)
        {
            // current time
            this.globalDateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.globalTimeLabel.Text = DateTime.Now.ToString("hh:mm:ss");

            // from first power on to now
            this.currentPowerOnTime = DateTime.Now;
            this.powerOnTimeSpent = this.currentPowerOnTime - this.PowerOnTime;
            this.spanFirstPowerOnTimeLabel.Text = ((int)this.powerOnTimeSpent.TotalHours).ToString() + ":" +
                                                  this.powerOnTimeSpent.Minutes.ToString("#00") + ":" +
                                                  this.powerOnTimeSpent.Seconds.ToString("#00");

            // 
            if (ShareMemory.NcMode.value == ShareMemory.NcMode.MEM)
            {
                this.CountSpanTimeAboutAutoRun();
                this.CountSpanTimeAboutAutoOperate();

            }
            if (ShareMemory.NcMode.value == ShareMemory.NcMode.MDI)
            {
                this.CountSpanTimeAboutAutoRun();
            }
        }

        private void CountSpanTimeAboutAutoOperate()
        {
            if (ShareMemory.System.ProgramRunning == ShareMemory.System.CurrentProgramStep)
            {
                this.isAutoOperateStop = false;

                this.tempTimeSpan = this.autoOperateTimeSpent + this.autoRunTimeSpent;
                this.autoOperateTimeLabel.Text = ((int)this.tempTimeSpan.TotalHours).ToString("#00") + ":" +
                                             this.tempTimeSpan.Minutes.ToString("#00") + ":" +
                                             this.tempTimeSpan.Seconds.ToString("#00");
            }
            else
            {
                if (false == this.isAutoOperateStop)
                {
                    this.autoOperateTimeSpent = this.autoOperateTimeSpent + this.autoRunTimeSpent;
                    ShareMemory.SetAutoOperateTimeSpan(this.autoOperateTimeSpent);
                    this.autoOperateTimeLabel.Text = ((int)this.autoOperateTimeSpent.TotalHours).ToString("#00") + ":" +
                                                     this.autoOperateTimeSpent.Minutes.ToString("#00") + ":" +
                                                     this.autoOperateTimeSpent.Seconds.ToString("#00");

                    this.isAutoOperateStop = true;
                }
            }
        }
        private void CountSpanTimeAboutAutoRun()
        {
            if (ShareMemory.System.ProgramRunning == ShareMemory.System.CurrentProgramStep)
            {
                if (DateTime.MinValue == this.autoRunStartTime) this.autoRunStartTime = DateTime.Now;
                this.autoRunStopTime = DateTime.Now;

                this.autoRunTimeSpent = this.autoRunStopTime - this.autoRunStartTime;
                this.autoRunTimeLabel.Text = ((int)this.autoRunTimeSpent.TotalHours).ToString("#00") + ":" +
                                             this.autoRunTimeSpent.Minutes.ToString("#00") + ":" +
                                             this.autoRunTimeSpent.Seconds.ToString("#00");
            }
            else
            {
                if (DateTime.MinValue != this.autoRunStartTime)
                {
                    this.autoRunStopTime = DateTime.Now;

                    this.autoRunTimeSpent = this.autoRunStopTime - this.autoRunStartTime;
                    this.autoRunTimeLabel.Text = ((int)this.autoRunTimeSpent.TotalHours).ToString("#00") + ":" +
                                                 this.autoRunTimeSpent.Minutes.ToString("#00") + ":" +
                                                 this.autoRunTimeSpent.Seconds.ToString("#00");

                    this.autoRunStartTime = DateTime.MinValue;
                    this.autoRunStopTime = DateTime.MinValue;
                }
            }
        }

        private void MF_Main_SystemTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (false == this.isAutoOperateStop)
            {
                this.autoOperateTimeSpent = this.autoOperateTimeSpent + this.autoRunTimeSpent;
            }
            ShareMemory.SetAutoOperateTimeSpan(this.autoOperateTimeSpent);

            SystemTimeSet.Default.MachiningNum = this.current_machining_num;
            SystemTimeSet.Default.Save();
        }

        private void resetAutoOperateTimeButton_Click(object sender, EventArgs e)
        {
            if (false == this.isAutoOperateStop)
            {
                this.autoOperateTimeSpent = -this.autoRunTimeSpent;
            }
            else
            {
                this.autoOperateTimeSpent = TimeSpan.Zero;
            }
            this.autoOperateTimeLabel.Text = TimeSpan.Zero.ToString();
            ShareMemory.SetAutoOperateTimeSpan(TimeSpan.Zero);
        }

        private void resetMachiningNumLabelButton_Click(object sender, EventArgs e)
        {
            this.current_machining_num = 0;
            this.machiningNumLabel.Text = "0";
        }

        private void infoDisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawLine(Pens.Black, new Point(((Control)sender).Width / 2, 0),
                                   new Point(((Control)sender).Width / 2, ((Control)sender).Height - 2));
        }

        private void getMachiningNumTimer_Tick(object sender, EventArgs e)
        {
            bool Set = true, Get = false;
            int return_state = -2;

            if (ShareMemory.NcMode.value == ShareMemory.NcMode.MEM)  // && (true == ShareMemory.isCycleStart))
            {
                if (false == Connection.CNCtoDT.MachiningPieceFinishedState(Get, out return_state))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.MachiningPieceFinishedState(Get, out return_state)");
                }
                else
                {
                    if (1 == return_state)          // tri-state: 0, 1, 2. (normal, finish, wait)
                    {
                        this.current_machining_num++;
                        this.machiningNumLabel.Text = this.current_machining_num.ToString();
                        if (false == Connection.CNCtoDT.MachiningPieceFinishedState(Set, out return_state))
                        {
                            MessageBox.Show("Error: Connection.CNCtoDT.MachiningPieceFinishedState(Set, out return_state)");
                        }
                    }
                }
            }
        }

        private void returnDataTimer_Tick(object sender, EventArgs e)
        {
            ShareMemory.systemTimeAutoRun = this.autoRunTimeSpent;
            ShareMemory.systemTimeAutoOperate = this.autoOperateTimeSpent;
            ShareMemory.systemTimeMachiningNum = this.current_machining_num;
        }

    }
}
