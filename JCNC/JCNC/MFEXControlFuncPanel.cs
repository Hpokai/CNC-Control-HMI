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

namespace JCNC
{
    public partial class MFEXControlFuncDlg : Form
    {
        bool FCP_CLNT_AUTO_ON;
        bool FCP_CLNT_MAN_ON;
        bool FCP_M01_ON;
        bool FCP_AIRBLOW_ON;
        bool FCP_CHIPCVY_ON;
        bool FCP_DRYRUN_ON;
        bool FCP_BDT_ON;
        bool FCP_MST_ON;
        bool FCP_ZLOCK_ON;
        bool FCP_WORKLIGHT_ON;
        bool FCP_WASHDOWN_ON;
        bool FCP_KNIFECLAMPING_ON;
        bool FCP_MLK_ON;
        
        public MFEXControlFuncDlg()
        {
            InitializeComponent();
        }

        private void MFEXControlFuncDlg_Load(object sender, EventArgs e)
        {
            RefreshDlg();
        }

        private void RefreshDlg()
        {

            FCP_CLNT_AUTO_ON = JCNCSettings.Default.FCP_CLNT_AUTO;
            FCP_CLNT_MAN_ON = JCNCSettings.Default.FCP_CLNT_MAN;
            FCP_M01_ON = JCNCSettings.Default.FCP_CLNT_M01;
            FCP_AIRBLOW_ON = JCNCSettings.Default.FCP_AIRBLOW;
            FCP_CHIPCVY_ON = JCNCSettings.Default.FCP_CHIPCVY;
            FCP_DRYRUN_ON = JCNCSettings.Default.FCP_DRYRUN;
            FCP_BDT_ON = JCNCSettings.Default.FCP_BDT;
            FCP_MST_ON = JCNCSettings.Default.FCP_MST;
            FCP_ZLOCK_ON = JCNCSettings.Default.FCP_ZLOCK;
            FCP_WORKLIGHT_ON = JCNCSettings.Default.FCP_WORKLIGHT;
            FCP_WASHDOWN_ON = JCNCSettings.Default.FCP_WASHDOWN_ON;
            FCP_KNIFECLAMPING_ON = JCNCSettings.Default.FCP_KNIFECLAMPING_ON;
            FCP_MLK_ON = JCNCSettings.Default.FCP_MLK_ON;

            if (FCP_CLNT_AUTO_ON == true)
            {
                FCP_CLNT_AUTO.BackColor = Color.Yellow;
            }
            else if (FCP_CLNT_AUTO_ON == false)
            {
                FCP_CLNT_AUTO.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_CLNT_MAN_ON == true)
            {
                FCP_CLNT_MAN.BackColor = Color.Yellow;
            }
            else if (FCP_CLNT_MAN_ON == false)
            {
                FCP_CLNT_MAN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_M01_ON == true)
            {
                FCP_CLNT_M01.BackColor = Color.Yellow;
            }
            else if (FCP_M01_ON == false)
            {
                FCP_CLNT_M01.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_AIRBLOW_ON == true)
            {
                FCP_AIRBLOW.BackColor = Color.Yellow;
            }
            else
            {
                FCP_AIRBLOW.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_CHIPCVY_ON == true)
            {
                FCP_CHIPCVY.BackColor = Color.Yellow;
            }
            else
            {
                FCP_CHIPCVY.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_DRYRUN_ON == true)
            {
                FCP_DRYRUN.BackColor = Color.Yellow;
            }
            else
            {
                FCP_DRYRUN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_BDT_ON == true)
            {
                FCP_BDT.BackColor = Color.Yellow;
            }
            else
            {
                FCP_BDT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_MST_ON == true)
            {
                FCP_MSTLock.BackColor = Color.Yellow;
            }
            else
            {
                FCP_MSTLock.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_ZLOCK_ON == true)
            {
                FCP_ZLOCK.BackColor = Color.Yellow;
            }
            else
            {
                FCP_ZLOCK.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_WORKLIGHT_ON == true)
            {
                FCP_WORKLIGHT.BackColor = Color.Yellow;
            }
            else
            {
                FCP_WORKLIGHT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
            if (FCP_MLK_ON == true)
            {
                FCP_MACHINELOCK.BackColor = Color.Yellow;
            }
            else
            {
                FCP_MACHINELOCK.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
        }

        private void FCP_CLNT_AUTO_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("CLNT\nAUTO", new Font("Times New Roman", 16f), Brushes.Black, new PointF(24, 5));
            if (FCP_CLNT_AUTO_ON == true)
            {
                g.DrawString("CLNT\nAUTO", new Font("Times New Roman", 16f), Brushes.Red, new PointF(24, 5));
            }
        }

        private void FCP_CLNT_MAN_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("CLNT\nMAN", new Font("Times New Roman", 16f), Brushes.Black, new PointF(24, 5));
            if (FCP_CLNT_MAN_ON == true)
            {
                g.DrawString("CLNT\nMAN", new Font("Times New Roman", 16f), Brushes.Red, new PointF(24, 5));
            }
        }

        private void FCP_CLNT_M01_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("M01", new Font("Times New Roman", 16f), Brushes.Black, new PointF(32, 16));
            if (FCP_M01_ON == true)
            {
                g.DrawString("M01", new Font("Times New Roman", 16f), Brushes.Red, new PointF(32, 16));
            }
        }

        private void FCP_AIRBLOW_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("  AIR\nBLOW", new Font("Times New Roman", 16f), Brushes.Black, new PointF(24, 4));
            if (FCP_AIRBLOW_ON == true)
            {
                g.DrawString("  AIR\nBLOW", new Font("Times New Roman", 16f), Brushes.Red, new PointF(24, 4));
            }

        }

        private void FCP_OTREL_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("O.T.\nREL.", new Font("Times New Roman", 16f), Brushes.Black, new PointF(34, 4));

        }

        private void FCP_DRYRUN_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("DRY\nRUN", new Font("Times New Roman", 16f), Brushes.Black, new PointF(30, 4));
            if (FCP_DRYRUN_ON == true)
            {
                g.DrawString("DRY\nRUN", new Font("Times New Roman", 16f), Brushes.Red, new PointF(30, 4));
            }

        }

        private void FCP_BDT_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("B.D.T.", new Font("Times New Roman", 16f), Brushes.Black, new PointF(27, 17));
            if (FCP_BDT_ON == true)
            {
                g.DrawString("B.D.T.", new Font("Times New Roman", 16f), Brushes.Red, new PointF(27, 17));
            }

        }

        private void FCP_MSTLock_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString(" MST\nLOCK", new Font("Times New Roman", 16f), Brushes.Black, new PointF(27, 5));
            if (FCP_MST_ON == true)
            {
                g.DrawString(" MST\nLOCK", new Font("Times New Roman", 16f), Brushes.Red, new PointF(27, 5));
            }

        }

        private void FCP_ZLOCK_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("Z LOCK", new Font("Times New Roman", 16f), Brushes.Black, new PointF(18, 16));
            if (FCP_ZLOCK_ON == true)
            {
                g.DrawString("Z LOCK", new Font("Times New Roman", 16f), Brushes.Red, new PointF(18, 16));
            }
        }

        private void FCP_WORKLIGHT_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("  WK\nLIGHT", new Font("Times New Roman", 16f), Brushes.Black, new PointF(24, 5));
            if (FCP_ZLOCK_ON == true)
            {
                g.DrawString("WK\nLIGHT", new Font("Times New Roman", 16f), Brushes.Red, new PointF(24, 5));
            }

        }

        private void FCP_CLNT_FUN11_Paint(object sender, PaintEventArgs e)
        {

        }

        enum ESTOP
        {
            none,
            msg = 1,
            latch = 2,
            tool_abnormal = 4,
            tool_remove_abnormal = 8,
            recover_panel = 16,
            recover_panel_finish = 32
        };
        private void FCP_CLNT_FUN12_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            if (true == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawString("Error\nRemoved", new Font("Times New Roman", 16f), Brushes.Black,
                        new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2),
                        new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                ((Control)sender).BackColor = Color.Red;
            }
            else
            {
                g.DrawString("No\nError", new Font("Times New Roman", 16f), Brushes.Black,
                        new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2),
                        new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                ((Control)sender).BackColor = System.Drawing.SystemColors.AppWorkspace;
            }

        }

        private void FCP_CLNT_FUN12_Click(object sender, EventArgs e)
        {
            if (true == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal] = false;
                ShareMemory.EStopStatus[(int)ESTOP.tool_remove_abnormal] = true;
            }
            this.FCP_CLNT_FUN12.Refresh();
        }

        private void FCP_CLNT_AUTO_MouseDown(object sender, MouseEventArgs e)
        {
            if (FCP_CLNT_MAN_ON == false)
            {
                if (FCP_CLNT_AUTO_ON == false)
                {
                    FCP_CLNT_AUTO_ON = true;
                    ShareMemory.System.CurrentClntAuto = FCP_CLNT_AUTO_ON;
                    ShareMemory.System.ClntAutoChange = ShareMemory.Switch.On;
                    FCP_CLNT_AUTO.BackColor = Color.Yellow;
                }
                else if (FCP_CLNT_AUTO_ON == true)
                {
                    FCP_CLNT_AUTO_ON = false;
                    ShareMemory.System.CurrentClntAuto = FCP_CLNT_AUTO_ON;
                    ShareMemory.System.ClntAutoChange = ShareMemory.Switch.On;
                    FCP_CLNT_AUTO.BackColor = System.Drawing.SystemColors.AppWorkspace;
                }
            }
        }

        private void FCP_CLNT_MAN_MouseDown(object sender, MouseEventArgs e)
        {
            if (FCP_CLNT_AUTO_ON == false)
            {
                if (FCP_CLNT_MAN_ON == false)
                {
                    FCP_CLNT_MAN_ON = true;
                    ShareMemory.System.CurrentClntManual = FCP_CLNT_MAN_ON;
                    ShareMemory.System.ClntManualChange = ShareMemory.Switch.On;
                    FCP_CLNT_MAN.BackColor = Color.Yellow;
                }
                else if (FCP_CLNT_MAN_ON == true)
                {
                    FCP_CLNT_MAN_ON = false;
                    ShareMemory.System.CurrentClntManual = FCP_CLNT_MAN_ON;
                    ShareMemory.System.ClntManualChange = ShareMemory.Switch.On;
                    FCP_CLNT_MAN.BackColor = System.Drawing.SystemColors.AppWorkspace;
                }
            }
        }

        private void FCP_CLNT_M01_MouseDown(object sender, MouseEventArgs e)
        {
            if (FCP_M01_ON == false)
            {
                FCP_M01_ON = true;
                ShareMemory.System.CurrentM01 = FCP_M01_ON;
                ShareMemory.System.M01Change = ShareMemory.Switch.On;
                FCP_CLNT_M01.BackColor = Color.Yellow;
            }
            else if (FCP_M01_ON == true)
            {
                FCP_M01_ON = false;
                ShareMemory.System.CurrentM01 = FCP_M01_ON;
                ShareMemory.System.M01Change = ShareMemory.Switch.On;
                FCP_CLNT_M01.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
        }

        private void FCP_AIRBLOW_MouseDown(object sender, MouseEventArgs e)
        {
            if (FCP_AIRBLOW_ON == false)
            {
                FCP_AIRBLOW_ON = true;
                ShareMemory.System.CurrentAirBlow = FCP_AIRBLOW_ON;
                ShareMemory.System.AirBlowChange = ShareMemory.Switch.On;
                FCP_AIRBLOW.BackColor = Color.Yellow;
            }
            else
            {
                FCP_AIRBLOW_ON = false;
                ShareMemory.System.CurrentAirBlow = FCP_AIRBLOW_ON;
                ShareMemory.System.AirBlowChange = ShareMemory.Switch.On;
                FCP_AIRBLOW.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }

            //if (false == Connection.CNCtoDT.SetAirBlowState(FCP_AIRBLOW_ON))
            //{
            //    MessageBox.Show("Error: Connection.CNCtoDT.SetAirBlowState(FCP_AIRBLOW_ON)");
            //}
        }
       

        private void FCP_DRYRUN_MouseDown(object sender, MouseEventArgs e)
        {
            if (FCP_DRYRUN_ON == false)
            {
                FCP_DRYRUN.BackColor = Color.Yellow;
                FCP_DRYRUN_ON = true;
            }
            else
            {
                FCP_DRYRUN.BackColor = System.Drawing.SystemColors.AppWorkspace;
                FCP_DRYRUN_ON = false;
            }
        }

        private void FCP_BDT_MouseDown(object sender, MouseEventArgs e)
        {
            if (FCP_BDT_ON == false)
            {
                FCP_BDT_ON = true;
                ShareMemory.System.CurrentBDT = !FCP_BDT_ON;  // logic inverse
                ShareMemory.System.BDTChange = ShareMemory.Switch.On;
                FCP_BDT.BackColor = Color.Yellow;
            }
            else
            {
                FCP_BDT_ON = false;
                ShareMemory.System.CurrentBDT = !FCP_BDT_ON;    // logic inverse
                ShareMemory.System.BDTChange = ShareMemory.Switch.On;
                FCP_BDT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            }
        }

        private void FCP_MSTLock_MouseDown(object sender, MouseEventArgs e)
        {
            if (FCP_MST_ON == false)
            {
                FCP_MSTLock.BackColor = Color.Yellow;
                FCP_MST_ON = true;

                if (false == Connection.CNCtoDT.SetMSTLock(FCP_MST_ON))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.SetMSTLock(FCP_MST_ON)");
                }
            }
            else
            {
                FCP_MSTLock.BackColor = System.Drawing.SystemColors.AppWorkspace;
                FCP_MST_ON = false;

                if (false == Connection.CNCtoDT.SetMSTLock(FCP_MST_ON))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.SetMSTLock(FCP_MST_ON)");
                }
            }
        }

        private void FCP_ZLOCK_MouseDown(object sender, MouseEventArgs e)
        {
            if (FCP_ZLOCK_ON == false)
            {
                FCP_ZLOCK.BackColor = Color.Yellow;
                FCP_ZLOCK_ON = true;

                this.SelectAxisToLock("ZLK", FCP_ZLOCK_ON);
            }
            else
            {
                FCP_ZLOCK.BackColor = System.Drawing.SystemColors.AppWorkspace;
                FCP_ZLOCK_ON = false;

                this.SelectAxisToLock("ZLK", FCP_ZLOCK_ON);
                MessageBox.Show("請執行復歸!");
                ShareMemory.Home.HaveToGoHome = true;
            }
        }

        private void MFEXControlFuncDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            JCNCSettings.Default.FCP_CLNT_AUTO = FCP_CLNT_AUTO_ON;
            JCNCSettings.Default.FCP_CLNT_MAN = FCP_CLNT_MAN_ON;
            JCNCSettings.Default.FCP_CLNT_M01 = FCP_M01_ON;
            JCNCSettings.Default.FCP_AIRBLOW = FCP_AIRBLOW_ON;
            JCNCSettings.Default.FCP_CHIPCVY = FCP_CHIPCVY_ON;
            JCNCSettings.Default.FCP_DRYRUN = FCP_DRYRUN_ON;
            JCNCSettings.Default.FCP_BDT = FCP_BDT_ON;
            JCNCSettings.Default.FCP_MST = FCP_MST_ON;
            JCNCSettings.Default.FCP_ZLOCK = FCP_ZLOCK_ON;
            JCNCSettings.Default.FCP_WORKLIGHT = FCP_WORKLIGHT_ON;
            JCNCSettings.Default.FCP_KNIFECLAMPING_ON = FCP_KNIFECLAMPING_ON;
            JCNCSettings.Default.FCP_WASHDOWN_ON = FCP_WASHDOWN_ON;
             JCNCSettings.Default.FCP_MLK_ON = FCP_MLK_ON;

            JCNCSettings.Default.Save();
        }

        private void FCP_WORKLIGHT_Click(object sender, EventArgs e)
        {

        }

        private void FCP_WORKLIGHT_MouseDown(object sender, MouseEventArgs e)
        {           
                if (FCP_WORKLIGHT_ON == false)
                {
                    if (false == Connection.CNCtoDT.WorkLight(true))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.WorkLight(true)");
                    }
                    else
                    {
                        FCP_WORKLIGHT.BackColor = Color.Yellow;
                        FCP_WORKLIGHT_ON = true;
                    }
                }
                else
                {
                    if (false == Connection.CNCtoDT.WorkLight(false))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.WorkLight(false)");
                    }
                    else
                    {
                        FCP_WORKLIGHT.BackColor = System.Drawing.SystemColors.AppWorkspace;
                        FCP_WORKLIGHT_ON = false;
                    }
                }
    
        }

        private void FCP_KNIFECLAMPING_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("    TOOL\nUNCLAMP", new Font("Times New Roman", 16f), Brushes.Black, new PointF(2, 5));
            if (FCP_ZLOCK_ON == true)
            {
                g.DrawString("    TOOL\nUNCLAMP", new Font("Times New Roman", 16f), Brushes.Red, new PointF(2, 5));
            }
        }

        private void FCP_KNIFECLAMPING_MouseDown(object sender, MouseEventArgs e)
        {
            bool run = true;
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.ZRN:
                case ShareMemory.NcMode.MDI:
                case ShareMemory.NcMode.MEM:
                    MessageBox.Show("目前操作模式不可執行此項功能。");
                    run = false;
                    break;
            }

            if (true == run)
            {

                if (FCP_KNIFECLAMPING_ON == false)
                {
                    if (false == Connection.CNCtoDT.KnifeUnClamping(true))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.KnifeUnClamping(true)");
                    }
                    else
                    {
                        FCP_KNIFECLAMPING.BackColor = Color.Yellow;
                        FCP_KNIFECLAMPING_ON = true;
                        ShareMemory.ToolClampON = false;
                    }
                }
                else
                {
                    if (false == Connection.CNCtoDT.KnifeUnClamping(false))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.KnifeUnClamping(true)");
                    }
                    else
                    {
                        FCP_KNIFECLAMPING.BackColor = System.Drawing.SystemColors.AppWorkspace;
                        FCP_KNIFECLAMPING_ON = false;
                        ShareMemory.ToolClampON = true;
                    }
                }
            }
        }

        private void FCP_CHIPCVY_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
        }

        private void FCP_MAGCW_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
        }

        private void FCP_MACHINELOCK_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("MLK", new Font("Times New Roman", 16f), Brushes.Black,
                                        new Rectangle(0, 0, this.FCP_MACHINELOCK.Width - 2, this.FCP_MACHINELOCK.Height - 2),
                                        new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            if (FCP_MLK_ON == true)
            {
                g.DrawString("MLK", new Font("Times New Roman", 16f), Brushes.Red,
                                   new Rectangle(0, 0, this.FCP_MACHINELOCK.Width - 2, this.FCP_MACHINELOCK.Height - 2),
                                   new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectAxisToLock(string option, bool state)
        {
            Connection.CNCtoDT.SetAxisLocked(option, state);

            switch (option)
            {
                case "MLK":
                    ShareMemory.isAxisLocked[0] = state;        // x-axis
                    ShareMemory.isAxisLocked[1] = state;        // y-axis
                    ShareMemory.isAxisLocked[2] = state;        // z-axis
                    break;
                case "ZLK":
                    ShareMemory.isAxisLocked[2] = state;        // z-axis
                    break;
            }
        }

        private void FCP_MACHINELOCK_MouseDown(object sender, MouseEventArgs e)
        {
            if (FCP_MLK_ON == false)
            {
                FCP_MACHINELOCK.BackColor = Color.Yellow;
                FCP_MLK_ON = true;

                this.SelectAxisToLock("MLK", FCP_MLK_ON);
            }
            else
            {
                FCP_MACHINELOCK.BackColor = System.Drawing.SystemColors.AppWorkspace;
                FCP_MLK_ON = false;

                this.SelectAxisToLock("MLK", FCP_MLK_ON);
                MessageBox.Show("請執行復歸!");
                ShareMemory.Home.HaveToGoHome = true;
            }
        }


    }
}
