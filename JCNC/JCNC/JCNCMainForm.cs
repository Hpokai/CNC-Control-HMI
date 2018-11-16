using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using SignalMonitorForm;
using System.IO;
using IDStatus;
using Offset;
using MDIOP;
using WorkAreaLimit;
using JOGSetUpUI;
using JCNCShareMemory;
using JCNCSystemTime;
using PagesAuthority;
using CoordinateSystem;
using NCFormatFile;
using FileTransfer;
using Compensation;
using FeedrateSetupUI;
using HomingSetupUI;
using PureCoordinate;
using JCNCDTCONECT;
using ServoSetupUI;
using ToolMagazine;

enum FUNCTION { MON = 0, PROG = 1, OFF = 2, DIA = 3, MAIN = 4, PARAM = 5 };

namespace JCNC
{
    public partial class jcncMainForm : Form
    {
        // Golobal Initialization
        private int[] tabIndex = new int[6] { 1, 1, 1, 1, 0, 0 };
        private static int TagNum = 10;
        public static int templableout = 1;
        private TabPage[] TabTags = new TabPage[10];
        private FUNCTION function = FUNCTION.MON;
        private bool MFT_RAPID_ON = false;
        private int feed_hold = ShareMemory.Switch.Off;
        private int cycle_start = ShareMemory.Switch.Off;
        private bool MC_SBK_ON = false;

        private string[,] TabTagItem = new string[6, 10]
        {
         {"單一座標","  監視","座標轉換","訊號監視","","","","D I/O訊號","",""},
         {" MDI","程式編輯","檔案管理","","","","","","",""},
         {"","刀具補正","","刀長量測","工件量測","座標系","","","",""},
         {"","異警履歷","","","","","","","",""},
         {"用戶參數","","身份變更","","頁面權限","日期時間","版本資訊","","",""},
         {"刀庫座標","伺服","機電","輸入訊號","工作區間","JOG","Feedrate","Homing","",""}
        };
        
        //-- Mon
        private FORM_Mon_Monitor form_Mon_Monitor;
        private FORM_Mon_PureCoordinate form_Mon_PureCoordinate;
        private FORM_Mon_DioStatus form_Mon_DioStatus;
        private FORM_Mon_Signal form_Mon_Signal;
        //-- Prog
        private FORM_Prog_MemFileEdit form_Prog_MemFileEdit;
        private FORM_Prog_MdiFileEdit form_Prog_MdiFileEdit;
        private FORM_Prog_FileTransfer form_Prog_FileTransfer;
        //-- Off
        private FORM_Off_CoordinateSystem form_Off_CoordinateSystem;
        //-- Diag
        private FORM_Diag_AlarmMessage form_Diag_AlarmMessage;
        //-- Main
        private FORM_Main_IdStatus form_Main_IdStatus;
        private FORM_Main_SystemTime form_Main_SystemTime;
        private FORM_Main_Priority form_Main_Priority;
        //-- Param
        private FORM_Param_WorkAreaLimit form_Param_WorkAreaLimit;
        private FORM_Param_Jog form_Param_Jog;
        private FORM_Param_Feedrate form_Param_Feedrate;
        private FORM_Param_Homing form_Param_Homing;
        private FROM_Param_Servo form_Param_Servo;
        private FORM_Param_ToolMagazine form_Param_ToolMagazine;


        private WarningMSG warningMSG = new WarningMSG("警告 : 緊急開關已啟動");

        //private JCNCDTCOMM m_JCNCDTCOMM = new JCNCDTCOMM();        

        private int PreSelIndex = 1;
        private bool ResetFlag = false;
        private bool ResetPush = false;
        
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
        public bool EStopStatusLatch = false;
        public bool EStopWarningMsg = false;

        private bool InitFuncDlgstate = false;

        private int TempCurrentToolNum = 0;
        private double TempCurrentToolCompValue = 0;

        private ThreadRoutineRW threadRoutine;
        private Thread runRoutineThread;

        private CMessageFilter cmfMouse = new CMessageFilter();

        private bool check_m01 = false;
        private bool check_single_block = false;

        private bool isFirstTimeResetDone = false;

        private void TASK_Initialize()
        {
            //Task可以代替TheadPool.QueueUserWorkItem使用
            var task_ui = Task.Factory.StartNew(() =>
            {
                this.PaintColorMF();
                this.PaintColorMCT();
                this.InitTabTags();

                this.function = FUNCTION.MON;

                this.formMonitorPanel.BackColor = Color.Yellow;
                this.ncModeZrnPanel.BackColor = Color.Yellow;
            });
            var task_connect = Task.Factory.StartNew(() =>
            {

                System.Threading.Thread.Sleep(3000);
                ShareMemory.System.ProcessState = PROCESS.Connect;
                ShareMemory.System.ProcessStateChange = ShareMemory.Switch.On;

                //if (false == Connection.CNCtoDT.InitCommBtwnCNCDT())
                //{
                //    MessageBox.Show("Error: Connection.CNCtoDT.InitCommBtwnCNCDT()");
                //}
                //while ((false == ShareMemory.PPMACLink)&&(ShareMemory.Switch.Off == this.init_complete))
                //{                   
                //    this.connectToDTCNC();
                //    System.Threading.Thread.Sleep(1500);
                //}

            });

            var task_thread = Task.Factory.StartNew(() =>
            {
                // Thread: Tool Change
                this.threadRoutine = new ThreadRoutineRW();
                this.runRoutineThread = new Thread(threadRoutine.RunThread);
                this.runRoutineThread.Name = "Thread: Routine RW!";
                this.runRoutineThread.Priority = ThreadPriority.Normal;
                this.runRoutineThread.IsBackground = true;
                this.runRoutineThread.Start();
            });

            var task_time = Task.Factory.StartNew(() =>
            {
                while (false == ShareMemory.isShutDown)
                {
                    this.systemTimeToolStripStatusLabel.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm");
                    Thread.Sleep(15000);
                }                
            });
        }

        private void TASK_Parameter()
        {
            var task = Task.Factory.StartNew(() =>
            {
                // set servo parameter
                this.form_Param_Servo.ReadAllParameter();

                // set homing parameter
                this.form_Param_Homing.ReadAllParameter();

                // set soft limit parameter
                this.form_Param_WorkAreaLimit.ReadAllParameter();


                // tool offset
                double Val = 0;
                for (int i = 1; i <= 100; i++)
                {
                    this.form_Off_CoordinateSystem.m_Tool.GetOffsetData(i, "HEIGHT", out Val);
                    if (false == Connection.CNCtoDT.CompensationDownLoadToPPMAC(ShareMemory.Compensate.Height, i - 1, Val))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.CompensationDownLoadToPPMAC(ShareMemory.CompensatType.HEIGHT, i - 1, Val))");
                    }
                    this.form_Off_CoordinateSystem.m_Tool.GetOffsetData(i, "HWASTE", out Val);
                    if (false == Connection.CNCtoDT.CompensationDownLoadToPPMAC(ShareMemory.Compensate.HWaste, i - 1, Val))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.CompensationDownLoadToPPMAC(ShareMemory.CompensatType.HWASTE, i - 1, Val");
                    }
                    this.form_Off_CoordinateSystem.m_Tool.GetOffsetData(i, "DIAMETER", out Val);
                    if (false == Connection.CNCtoDT.CompensationDownLoadToPPMAC(ShareMemory.Compensate.Diameter, i - 1, Val))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.CompensationDownLoadToPPMAC(sharhareMemory.CompensatType.DIAMETER, i - 1, Val))");
                    }
                    this.form_Off_CoordinateSystem.m_Tool.GetOffsetData(i, "DWASTE", out Val);
                    if (false == Connection.CNCtoDT.CompensationDownLoadToPPMAC(ShareMemory.Compensate.DWaste, i - 1, Val))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.CompensationDownLoadToPPMAC(ShareMemory.CompensatType.DWASTE, i - 1, Val)");
                    }
                }
            });
        }

        public jcncMainForm()
        {
            this.InitializeComponent();

            this.cmfMouse.DisableMouse();

            this.ObjectArray();
            this.InitShareMemory();

            this.TASK_Initialize();

            Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();

            this.InitFuncDlg();
            this.RefreshGUI();

            System.Threading.Thread.Sleep(300);


            //// set servo parameter
            //this.dlg_MF_Param_Servo.ReadAllParameter();

            //// set homing parameter
            //this.dlg_MF_Param_Homing.ReadAllParameter();

            //// set soft limit parameter
            //this.dlg_MF_Param_WorkAreaLimit.ReadAllParameter();

            this.systemStatusTimer.Start();
            this.toolAbnormalTimer.Start();   

        }

     


        private void JCNCMain_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            this.Show();
            SplashScreen.CloseSplashScreen();
            this.Activate();
            string file = string.Empty;
            file = "pfiles\\" + JCNCSettings.Default.AutoRunOpendFileName;
            ShareMemory.SetFilePath(file, ShareMemory.OperationMode.MEM);
            ShareMemory.SetFilePath(@"tmp\MDICmd.NC", ShareMemory.OperationMode.MDI);
            ShareMemory.FileLoadOn = true;

            this.form_Mon_Monitor.SetNCFileName(JCNCSettings.Default.AutoRunOpendFileName);

            this.systemTimeToolStripStatusLabel.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm");


            // wait controller CH_SystemInitComplete signal  
            this.initialMSG = new WarningMSG("控制器初始化中\n\n請按下 Servo On！", true);
            this.initialMSG.ShowDialog();            
        }        
        WarningMSG initialMSG;


        private bool SetCoordinateSystemValue()
        {
            bool ret = true;
            string cmd = string.Empty;

            for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
            {
                for (int cs_index = 0; cs_index < ShareMemory.COffset.G54_num; cs_index++)
                {
                    cmd = "HC_" + ShareMemory.COffset.G54_name[cs_index] + "Value(" + axis.ToString() + ")";
                    if (false == Connection.CNCtoDT.CSDownLoadToPPMAC(cmd, ShareMemory.COffset.Value_G54[cs_index][axis]))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.CSDownLoadToPPMAC(" + cmd + ")");
                        ret = false;
                    }
                }
                for (int cs_index = 1; cs_index < ShareMemory.COffset.G5X_num; cs_index++)
                {
                    cmd = "HC_" + ShareMemory.COffset.G5X_name[cs_index] + "Value(" + axis.ToString() + ")";
                    if (false == Connection.CNCtoDT.CSDownLoadToPPMAC(cmd, ShareMemory.COffset.Value_G5X[cs_index][axis]))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.CSDownLoadToPPMAC(" + cmd + ")");
                        ret = false;
                    }
                }
                cmd = "HC_" + ShareMemory.COffset.EXT_name + "Value(" + axis.ToString() + ")";
                if (false == Connection.CNCtoDT.CSDownLoadToPPMAC(cmd, ShareMemory.COffset.EXTValue[axis]))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.CSDownLoadToPPMAC(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        private void connectToDTCNC()
        {          
            if (false == Connection.CNCtoDT.JCNCDTComm())
            {
                MessageBox.Show("Error: Connection.CNCtoDT.JCNCDTComm()");
            }

            if (false == Connection.CNCtoDT.InitPPMACEnv())
            {
                MessageBox.Show("Error: Connection.CNCtoDT.InitPPMACEnv()");
            }

            //for (int axis_index = 0; axis_index < ShareMemory.AxisNum; axis_index++)
            //{
            //    if (false == Connection.CNCtoDT.SetSoftLimitMaxStatus(axis_index, ShareMemory.SoftLimit.isMaxON[axis_index]))
            //    {
            //        MessageBox.Show("Error: Connection.CNCtoDT.SetSoftLimitMaxStatus(FBAxis.XAxis, ShareMemory.SoftLimit.XSoftLimitMaxON)");
            //    }
            //    if (false == Connection.CNCtoDT.SetSoftLimitMinStatus(axis_index, ShareMemory.SoftLimit.isMinON[axis_index]))
            //    {
            //        MessageBox.Show("Error: Connection.CNCtoDT.SetSoftLimitMinStatus(FBAxis.XAxis, ShareMemory.SoftLimit.XSoftLimitMinON)");
            //    }
            //}
            //if (false == Connection.CNCtoDT.CSEXTSetPmatch())
            //{
            //    MessageBox.Show("Error: Connection.CNCtoDT.CSEXTSetPmatch()");
            //}
        }

        private bool InitFuncDlg()
        {
            //try
            //{
            this.form_Main_Priority = new FORM_Main_Priority();
            this.form_Main_Priority.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch 
            //{
            //    MessageBox.Show("MF_Main_Authority");
            //};

            try
            {
                this.form_Off_CoordinateSystem = new FORM_Off_CoordinateSystem();
                this.form_Off_CoordinateSystem.TopLevel = false;
                while (!ShareMemory.PageInitFinshed)
                {
                    Thread.Sleep(30);
                }
                ShareMemory.PageInitFinshed = false;
            }
            catch
            {
                MessageBox.Show("MF_Offset_CS");
            };

            //try
            //{
            this.form_Mon_Monitor = new FORM_Mon_Monitor();
            this.form_Mon_Monitor.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Mon_Mon");
            //};

            //try
            //{
            this.form_Param_WorkAreaLimit = new FORM_Param_WorkAreaLimit();
            this.form_Param_WorkAreaLimit.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Param_WorkAreaLimit");
            //};

            //try
            //{
            this.form_Prog_MemFileEdit = new FORM_Prog_MemFileEdit();
            this.form_Prog_MemFileEdit.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Prog_FilePath");
            //};

            //try
            //{
            this.form_Mon_DioStatus = new FORM_Mon_DioStatus();
            this.form_Mon_DioStatus.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Mon_DIOStatus");
            //};

            //try
            //{
            this.form_Diag_AlarmMessage = new FORM_Diag_AlarmMessage();
            this.form_Diag_AlarmMessage.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Diag_Msg");
            //};

            //try
            //{
            this.form_Mon_Signal = new FORM_Mon_Signal();
            this.form_Mon_Signal.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Mon_SigMon");
            //};

            //try
            //{
            this.form_Main_IdStatus = new FORM_Main_IdStatus();
            this.form_Main_IdStatus.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Main_IDStatus");
            //};

            //try
            //{
            this.form_Prog_MdiFileEdit = new FORM_Prog_MdiFileEdit();
            this.form_Prog_MdiFileEdit.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Prog_MDI");
            //};

            //try
            //{
            this.form_Param_Jog = new FORM_Param_Jog();
            this.form_Param_Jog.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Param_JOG");
            //};

            //try
            //{
            this.form_Main_SystemTime = new FORM_Main_SystemTime();
            this.form_Main_SystemTime.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Main_SystemTime");
            //};

            //try                         ////////// hpokai
            //{
            this.form_Prog_FileTransfer = new FORM_Prog_FileTransfer();
            this.form_Prog_FileTransfer.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_File_Transfer");
            //};

            //try                         ////////// hpokai
            //{
            this.form_Param_Feedrate = new FORM_Param_Feedrate();
            this.form_Param_Feedrate.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(30);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Param_Feedrate");
            //};

            //try                         ////////// hpokai
            //{
            this.form_Param_Homing = new FORM_Param_Homing();
            this.form_Param_Homing.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(10);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_Param_Homing");
            //};

            //try                         ////////// hpokai
            //{
            this.form_Mon_PureCoordinate = new FORM_Mon_PureCoordinate();
            this.form_Mon_PureCoordinate.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(10);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_PureCoordinate");
            //};

            //try                         ////////// hpokai
            //{
            this.form_Param_Servo = new FROM_Param_Servo();
            this.form_Param_Servo.TopLevel = false;
            //    while (!ShareMemory.PageInitFinshed)
            //    {
            //        Thread.Sleep(10);
            //    }
            //    ShareMemory.PageInitFinshed = false;
            //}
            //catch
            //{
            //    MessageBox.Show("MF_PureCoordinate");
            //};
            this.form_Param_ToolMagazine = new FORM_Param_ToolMagazine();
            this.form_Param_ToolMagazine.TopLevel = false;

            this.InitFuncDlgstate = true;
            return this.InitFuncDlgstate;
        }

        private void InitShareMemory()
        {
            ShareMemory.isShutDown = false;

            ShareMemory.isConnectDTSuccessful = false;

            ShareMemory.PPMACLink = JCNCSettings.Default.PPMACLink;

            ShareMemory.SetElectricalGearRatio();

            //ShareMemory.OPMode = ShareMemory.OperationMode.ZRN;
            ShareMemory.NcMode.value = ShareMemory.NcMode.ZRN;

            ShareMemory.System.CurrentSingleBlock = false;
            ShareMemory.System.SingleBlockChange = ShareMemory.Switch.On;
            //ShareMemory.CSSystem.HomeComplete = false;

            for (int axis_num = 0; axis_num < ShareMemory.CS.AxisNum; axis_num++)
            {
                ShareMemory.CS.RelOffset[axis_num] = 0.0;
            }
        }

        private void PaintColorMF()
        {
            this.formMonitorPanel.BackColor = Color.MistyRose;
            this.formProgramPanel.BackColor = Color.MistyRose;
            this.formOffsetPanel.BackColor = Color.MistyRose;
            this.formDiagnosisPanel.BackColor = Color.MistyRose;
            this.formMaintenPanel.BackColor = Color.MistyRose;
            this.formParameterPanel.BackColor = Color.MistyRose;
        }

        private void PaintColorMCT()
        {
            this.ncModeJogPanel.BackColor = Color.LightBlue;
            this.ncModeIncJogPanel.BackColor = Color.LightBlue;
            this.ncModeZrnPanel.BackColor = Color.LightBlue;
            this.ncModeMpgPanel.BackColor = Color.LightBlue;
            this.ncModeMdiPanel.BackColor = Color.LightBlue;
            this.ncModeMemPanel.BackColor = Color.LightBlue;
        }

        private void InitTabTags()
        {
            for (int i = 0; i < TagNum; i++)
            {
                this.TabTags[i] = new TabPage() { Name = " " };
                this.formTabControl.TabPages.Add(TabTags[i]);
                this.TabTags[i].Text = TabTagItem[0, i];
            }
        }

        // HMI Functions: Paint & Click
        private void formMonitorPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            SolidBrush brush;

            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));

            if (FUNCTION.MON == this.function)
            {
                brush = new SolidBrush(Color.Blue);
                for (int i = 0; i < TagNum; i++)
                {
                    TabTags[i].Text = TabTagItem[(int)this.function, i];
                }
            }
            else
            {
                brush = new SolidBrush(Color.Black);
            }
            panelGraphics.DrawString("MONITOR", new Font(FontFamily.GenericSerif, 16f), brush,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            
            brush = null;
            panelGraphics.Dispose();
        }

        private void formMonitorPanel_Click(object sender, EventArgs e)
        {
            function = FUNCTION.MON;
            this.PaintColorMF();
            this.formMonitorPanel.BackColor = Color.Yellow;
            ShareMemory.FileLoadOn = true;
            this.RefreshGUI();
        }

        private void formProgramPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            SolidBrush brush;

            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));

            if (FUNCTION.PROG == this.function)
            {
                brush = new SolidBrush(Color.Blue);
                for (int i = 0; i < TagNum; i++)
                {
                    TabTags[i].Text = TabTagItem[(int)this.function, i];
                }
            }
            else
            {
                brush = new SolidBrush(Color.Black);
            }
            panelGraphics.DrawString("PROGRAM", new Font(FontFamily.GenericSerif, 16f), brush,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
           
            brush = null;
            panelGraphics.Dispose();
        }

        private void formProgramPanel_Click(object sender, EventArgs e)
        {
            this.function = FUNCTION.PROG;
            this.PaintColorMF();
            this.formProgramPanel.BackColor = Color.Yellow;
            this.RefreshGUI();
        }

        private void formOffsetPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            SolidBrush brush;

            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));

            if (FUNCTION.OFF == this.function)
            {
                brush = new SolidBrush(Color.Blue);
                for (int i = 0; i < TagNum; i++)
                {
                    TabTags[i].Text = TabTagItem[(int)this.function, i];
                }
            }
            else
            {
                brush = new SolidBrush(Color.Black);
            }
            panelGraphics.DrawString("OFFSET", new Font(FontFamily.GenericSerif, 16f), brush,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            brush = null;
            panelGraphics.Dispose();
        }

        private void formOffsetPanel_Click(object sender, EventArgs e)
        {
            this.function = FUNCTION.OFF;
            this.PaintColorMF();
            this.formOffsetPanel.BackColor = Color.Yellow;
            this.RefreshGUI();
        }

        private void formDiagnosisPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            SolidBrush brush;

            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));

            if (FUNCTION.DIA == this.function)
            {
                brush = new SolidBrush(Color.Blue);
                for (int i = 0; i < TagNum; i++)
                {
                    TabTags[i].Text = TabTagItem[(int)this.function, i];
                }
            }
            else
            {
                brush = new SolidBrush(Color.Black);
            }
            panelGraphics.DrawString("DIAGNOSIS", new Font(FontFamily.GenericSerif, 16f), brush,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            brush = null;
            panelGraphics.Dispose();
        }

        private void formDiagnosisPanel_Click(object sender, EventArgs e)
        {
            this.function = FUNCTION.DIA;
            this.PaintColorMF();
            this.formDiagnosisPanel.BackColor = Color.Yellow;
            this.RefreshGUI();
        }

        private void formMaintenPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            SolidBrush brush;

            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));

            if (FUNCTION.MAIN == this.function)
            {
                brush = new SolidBrush(Color.Blue);
                for (int i = 0; i < TagNum; i++)
                {
                    TabTags[i].Text = TabTagItem[(int)this.function, i];
                }
            }
            else
            {
                brush = new SolidBrush(Color.Black);
            }
            panelGraphics.DrawString("MAINTEN", new Font(FontFamily.GenericSerif, 16f), brush,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            brush = null;
            panelGraphics.Dispose();
        }

        private void formMaintenPanel_Click(object sender, EventArgs e)
        {
            this.function = FUNCTION.MAIN;
            this.PaintColorMF();
            this.formMaintenPanel.BackColor = Color.Yellow;
            this.RefreshGUI();
        }

        private void formParameterPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            SolidBrush brush;

            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));

            if (FUNCTION.PARAM == this.function)
            {
                brush = new SolidBrush(Color.Blue);
                for (int i = 0; i < TagNum; i++)
                {
                    TabTags[i].Text = TabTagItem[(int)this.function, i];
                }
            }
            else
            {
                brush = new SolidBrush(Color.Black);
            }
            panelGraphics.DrawString("PARAMETER", new Font(FontFamily.GenericSerif, 16f), brush,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            brush = null;
            panelGraphics.Dispose();
        }

        private void formParameterPanel_Click(object sender, EventArgs e)
        {
            this.function = FUNCTION.PARAM;
            this.PaintColorMF();
            this.formParameterPanel.BackColor = Color.Yellow;
            this.RefreshGUI();
        }

        // Remove Tab
        private void RemoveTabDlg()
        {
            this.RemoveTabGroup0();
            this.RemoveTabGroup1();
            this.RemoveTabGroup2();
            this.RemoveTabGroup3();
            this.RemoveTabGroup4();
            this.RemoveTabGroup5();
            this.RemoveTabGroup6();
            this.RemoveTabGroup7();
        }

        private void RemoveTabGroup0()
        {
            this.TabTags[0].Controls.Remove(this.form_Mon_PureCoordinate);
            this.TabTags[0].Controls.Remove(this.form_Prog_MdiFileEdit);
            this.TabTags[0].Controls.Remove(this.form_Param_ToolMagazine);
        }                                   
        private void RemoveTabGroup1()
        {
            this.TabTags[1].Controls.Remove(this.form_Prog_MemFileEdit);
            this.TabTags[1].Controls.Remove(this.form_Diag_AlarmMessage);
            this.TabTags[1].Controls.Remove(this.form_Mon_Monitor);
            this.TabTags[1].Controls.Remove(this.form_Off_CoordinateSystem);
            this.TabTags[1].Controls.Remove(this.form_Param_Servo);
        }
        private void RemoveTabGroup2()
        {
            this.TabTags[2].Controls.Remove(this.form_Main_IdStatus);
            this.TabTags[2].Controls.Remove(this.form_Prog_FileTransfer);
        }
        private void RemoveTabGroup3()
        {
            this.TabTags[3].Controls.Remove(this.form_Mon_Signal);
            this.TabTags[3].Controls.Remove(this.form_Off_CoordinateSystem);
        }
        private void RemoveTabGroup4()
        {
            this.TabTags[4].Controls.Remove(this.form_Param_WorkAreaLimit);
            this.TabTags[4].Controls.Remove(this.form_Off_CoordinateSystem);
            this.TabTags[4].Controls.Remove(this.form_Main_Priority);
        }
        private void RemoveTabGroup5()
        {
            this.TabTags[5].Controls.Remove(form_Param_Jog);
            this.TabTags[5].Controls.Remove(form_Off_CoordinateSystem);
            this.TabTags[5].Controls.Remove(form_Main_SystemTime);
        }
        private void RemoveTabGroup6()
        {
            this.TabTags[6].Controls.Remove(form_Param_Feedrate);
        }
        private void RemoveTabGroup7()
        {
            this.TabTags[7].Controls.Remove(form_Mon_DioStatus);
            this.TabTags[7].Controls.Remove(form_Param_Homing);
        }

        private void RefreshGUI()
        {
            this.formTabControl.SelectedIndex = tabIndex[(int)function];       

            this.RemoveTabDlg();
            switch (tabIndex[(int)function])
            {
                case 0:
                    switch (this.function)
                    {
                        case FUNCTION.MON:
                            this.TabTags[0].Controls.Add(this.form_Mon_PureCoordinate);
                            this.form_Mon_PureCoordinate.Show();
                            break;
                        case FUNCTION.PROG:
                            this.TabTags[0].Controls.Add(this.form_Prog_MdiFileEdit);
                            this.form_Prog_MdiFileEdit.Show();
                            break;
                        case FUNCTION.OFF:
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            break;
                        case FUNCTION.PARAM:
                            this.TabTags[0].Controls.Add(this.form_Param_ToolMagazine);
                            this.form_Param_ToolMagazine.Show();
                            break;
                    }
                    break;
                case 1:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            this.TabTags[1].Controls.Add(this.form_Mon_Monitor);
                            this.form_Mon_Monitor.Show();
                            break;
                        case FUNCTION.PROG:
                            this.TabTags[1].Controls.Add(this.form_Prog_MemFileEdit);
                            this.form_Prog_MemFileEdit.InitFilePathDlg();
                            this.form_Prog_MemFileEdit.Show();
                            break;
                        case FUNCTION.OFF:
                            this.TabTags[1].Controls.Add(this.form_Off_CoordinateSystem);
                            this.form_Off_CoordinateSystem.Show();
                            this.form_Off_CoordinateSystem.FuncToolCompLoad();
                            break;
                        case FUNCTION.DIA:
                            this.TabTags[1].Controls.Add(this.form_Diag_AlarmMessage);
                            this.form_Diag_AlarmMessage.Show();
                            break;
                        case FUNCTION.MAIN:
                            break;
                        case FUNCTION.PARAM:
                            this.TabTags[1].Controls.Add(this.form_Param_Servo);
                            this.form_Param_Servo.Show();
                            break;
                    }
                    break;
                case 2:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            break;
                        case FUNCTION.PROG:
                            this.TabTags[2].Controls.Add(this.form_Prog_FileTransfer);
                            this.form_Prog_FileTransfer.Show();
                            break;
                        case FUNCTION.OFF:
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            this.TabTags[2].Controls.Add(this.form_Main_IdStatus);
                            this.form_Main_IdStatus.Show();
                            break;
                        case FUNCTION.PARAM:
                            break;
                    }
                    break;
                case 3:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            this.TabTags[3].Controls.Add(this.form_Mon_Signal);
                            this.form_Mon_Signal.Show();
                            break;
                        case FUNCTION.PROG:
                            break;
                        case FUNCTION.OFF:
                            this.TabTags[3].Controls.Add(this.form_Off_CoordinateSystem);
                            this.form_Off_CoordinateSystem.Show();
                            this.form_Off_CoordinateSystem.FuncTMeas();
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            break;
                        case FUNCTION.PARAM:
                            break;
                    }
                    break;
                case 4:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            break;
                        case FUNCTION.PROG:
                            break;
                        case FUNCTION.OFF:
                            this.TabTags[4].Controls.Add(this.form_Off_CoordinateSystem);
                            this.form_Off_CoordinateSystem.Show();
                            this.form_Off_CoordinateSystem.FuncWMeas();
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            this.TabTags[4].Controls.Add(this.form_Main_Priority);
                            this.form_Main_Priority.Show();
                            break;
                        case FUNCTION.PARAM:
                            this.TabTags[4].Controls.Add(this.form_Param_WorkAreaLimit);
                            this.form_Param_WorkAreaLimit.Show();
                            break;
                    }
                    break;
                case 5:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            break;
                        case FUNCTION.PROG:
                            break;
                        case FUNCTION.OFF:
                            this.TabTags[5].Controls.Add(this.form_Off_CoordinateSystem);
                            this.form_Off_CoordinateSystem.Show();
                            this.form_Off_CoordinateSystem.FuncCS();
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            this.TabTags[5].Controls.Add(this.form_Main_SystemTime);
                            this.form_Main_SystemTime.Show();
                            break;
                        case FUNCTION.PARAM:
                            this.TabTags[5].Controls.Add(form_Param_Jog);
                            this.form_Param_Jog.Show();
                            break;
                    }
                    break;
                case 6:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            break;
                        case FUNCTION.PROG:
                            break;
                        case FUNCTION.OFF:
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            break;
                        case FUNCTION.PARAM:
                            this.TabTags[6].Controls.Add(this.form_Param_Feedrate);
                            this.form_Param_Feedrate.Show();
                            break;
                    }
                    break;
                case 7:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            this.TabTags[7].Controls.Add(this.form_Mon_DioStatus);
                            this.form_Mon_DioStatus.Show();
                            break;
                        case FUNCTION.PROG:
                            break;
                        case FUNCTION.OFF:
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            break;
                        case FUNCTION.PARAM:
                            this.TabTags[7].Controls.Add(this.form_Param_Homing);
                            this.form_Param_Homing.Show();
                            break;
                    }
                    break;
                case 8:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            break;
                        case FUNCTION.PROG:
                            break;
                        case FUNCTION.OFF:
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            break;
                        case FUNCTION.PARAM:
                            break;
                    }
                    break;
                case 9:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            break;
                        case FUNCTION.PROG:
                            break;
                        case FUNCTION.OFF:
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            break;
                        case FUNCTION.PARAM:
                            break;
                    }
                    break;
                case 10:
                    switch (function)
                    {
                        case FUNCTION.MON:
                            break;
                        case FUNCTION.PROG:
                            break;
                        case FUNCTION.OFF:
                            break;
                        case FUNCTION.DIA:
                            break;
                        case FUNCTION.MAIN:
                            break;
                        case FUNCTION.PARAM:
                            break;
                    }
                    break;
            }
        }

        private void formTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((function == FUNCTION.MON) && (formTabControl.SelectedIndex == 2))
            {
                this.form_Mon_Monitor.CSSwitch();
                this.formTabControl.SelectedIndex = PreSelIndex;
            }
            else
            {
                this.tabIndex[(int)function] = formTabControl.SelectedIndex;
                this.PreSelIndex = formTabControl.SelectedIndex;
                this.RefreshGUI();
            }

            if ((FUNCTION.OFF == function) && (3 == ((TabControl)sender).SelectedIndex))
            {
                this.form_Off_CoordinateSystem.m_TMeas.setDownDirTimer(true);
            }
            else
            {
                this.form_Off_CoordinateSystem.m_TMeas.setDownDirTimer(false);
            }

            if ((FUNCTION.PARAM == function) && (6 == ((TabControl)sender).SelectedIndex))
            {
                this.feedrateTypePanel.Enabled = false;
                this.feedratePercentUp.Enabled = false;
                this.feedratePercentDown.Enabled = false;
                this.feedratePercent100.Enabled = false;

                this.form_Param_Feedrate.ReloadValue();
            }
            else
            {
                this.feedrateTypePanel.Enabled = true;
                this.feedratePercentUp.Enabled = true;
                this.feedratePercentDown.Enabled = true;
                this.feedratePercent100.Enabled = true;
            }

            if ((FUNCTION.MON == function) && (1 == ((TabControl)sender).SelectedIndex))
            {
                this.form_Mon_Monitor.ReloadFeedRateValue();
            }

            if ((FUNCTION.PROG == function) && (0 == ((TabControl)sender).SelectedIndex))
            {
                this.MDIisSelected = true;
            }
            else
            {
                if (true == this.MDIisSelected)
                {
                    ShareMemory.System.UploadMDIFile = ShareMemory.Switch.On;
                    this.MDIisSelected = false;
                }
            }
        }

        private bool MDIisSelected = false;
                     
        private void spindlePercent100_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("100%", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(28, 18));
            }
            else
            {
                g.DrawString("100%", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(28, 18));
            }
        }

        private void spindlePercentUp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("UP", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(38, 18));
            }
            else
            {
                g.DrawString("UP", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(38, 18));
            }
        }

        private void spindlePercentDown_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("DOWN", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(20, 18));
            }
            else
            {
                g.DrawString("DOWN", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(20, 18));
            }
        }

        private void jogRapidPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("RAPID", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(20, 18));
            if (ShareMemory.Switch.On == ShareMemory.Jog.CurrentRapidMode)
            {
                g.DrawString("RAPID", new Font(FontFamily.GenericSerif, 16f), Brushes.Blue, new PointF(20, 18));
            }
        }

        private void jogRapidPanel_Click(object sender, EventArgs e)
        {
            if (ShareMemory.Switch.Off == ShareMemory.Jog.CurrentRapidMode)
            {
                jogRapidPanel.BackColor = Color.Yellow;
                ShareMemory.Jog.RapidModeChange = ShareMemory.Switch.On;
                ShareMemory.Jog.CurrentRapidMode = ShareMemory.Switch.On;
            }
            else if (ShareMemory.Switch.On == ShareMemory.Jog.CurrentRapidMode)
            {
                jogRapidPanel.BackColor = Color.PapayaWhip;
                ShareMemory.Jog.RapidModeChange = ShareMemory.Switch.On;
                ShareMemory.Jog.CurrentRapidMode = ShareMemory.Switch.Off;
            }
        }

     
        private void HomeReset()
        {
            for (int axis = 0; axis < ShareMemory.Home.AxisNum; axis++)
            {
                this.jog_plus_panel[axis].BackColor = Color.PapayaWhip;
                this.jog_minus_panel[axis].BackColor = Color.PapayaWhip;

                ShareMemory.Home.Start[axis] = ShareMemory.Switch.Off;
                ShareMemory.Home.Finish[axis] = ShareMemory.Switch.Off;
            }            
            ShareMemory.Home.OnTheWay = false;
            ShareMemory.Home.Arrival = false;
        }

        private Panel[] nc_mode;
        private Panel[] home_panel;
        private Panel[] jog_plus_panel;
        private Panel[] jog_minus_panel;
        private Panel[] limit_panel;
        private Panel[] form_panel;
        private const int FormNum = 6;
        private void ObjectArray()
        {
            this.home_panel = new Panel[ShareMemory.Home.AxisNum] { this.xHomeLightPanel, this.yHomeLightPanel, this.zHomeLightPanel };
            this.jog_plus_panel = new Panel[ShareMemory.Home.AxisNum] { this.xJogPlusPanel, this.yJogPlusPanel, this.zJogPlusPanel};
            this.jog_minus_panel = new Panel[ShareMemory.Home.AxisNum] { this.xJogMinusPanel, this.yJogMinusPanel, this.zJogMinusPanel };
            this.limit_panel = new Panel[ShareMemory.SoftLimit.AxisNum] { this.xLimitLightPanel, this.yLimitLightPanel, this.zLimitLightPanel };
            this.form_panel = new Panel[FormNum] { this.formMonitorPanel, this.formProgramPanel, this.formOffsetPanel, this.formDiagnosisPanel, this.formMaintenPanel, this.formParameterPanel };
            this.nc_mode = new Panel[ShareMemory.NcMode.num] { null, null, this.ncModeMemPanel, this.ncModeMdiPanel, this.ncModeZrnPanel, this.ncModeMpgPanel, this.ncModeJogPanel, this.ncModeIncJogPanel };
        }
        
        private void singleBlockPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {

                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("SBK", new Font(FontFamily.GenericSerif, 18f), Brushes.Black, new PointF(14, 32));
            }
            else
            {
                g.DrawString("SBK", new Font(FontFamily.GenericSerif, 18f), Brushes.Gray, new PointF(14, 32));
            }
        }

        private void controlFunctionPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("CFP", new Font(FontFamily.GenericSerif, 18f), Brushes.Black, new PointF(14, 32));
        }

        private void singleBlockPanel_Click(object sender, EventArgs e)
        {
            if (MC_SBK_ON == false)
            {
                MC_SBK_ON = true;
                ShareMemory.System.CurrentSingleBlock = MC_SBK_ON;
                ShareMemory.System.SingleBlockChange = ShareMemory.Switch.On;
                singleBlockPanel.BackColor = Color.Orange;
            }
            else if (MC_SBK_ON == true)
            {
                MC_SBK_ON = false;
                ShareMemory.System.CurrentSingleBlock = MC_SBK_ON;
                ShareMemory.System.SingleBlockChange = ShareMemory.Switch.On;
                singleBlockPanel.BackColor = Color.LightSteelBlue;
            }
        }

        private void feedrateTypePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                if (MFT_RAPID_ON == false)
                {
                    g.DrawString("NORMAL", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(37, 18));
                }
                else if (MFT_RAPID_ON == true)
                {
                    g.DrawString("RAPID", new Font(FontFamily.GenericSerif, 16f), Brushes.Blue, new PointF(50, 18));
                }
            }
            else
            {
                if (MFT_RAPID_ON == false)
                {
                    g.DrawString("NORMAL", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(37, 18));
                }
                else if (MFT_RAPID_ON == true)
                {
                    g.DrawString("RAPID", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(50, 18));
                }
            }
        }

        private void feedratePercent100_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {

                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("100%", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(11, 48));
            }
            else
            {
                g.DrawString("100%", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(11, 48));
            }
        }

        private void feedratePercentUp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {

                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("UP", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(26, 18));
            }
            else
            {
                g.DrawString("UP", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(26, 18));
            }
        }

        private void feedratePercentDown_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {

                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("DOWN", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(8, 18));
            }
            else
            {
                g.DrawString("DOWN", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(8, 18));
            }
        }


        private void resetPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            if (!ResetFlag)
                g.DrawString("RESET", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(40, 5));
            else
                g.DrawString("RESET", new Font(FontFamily.GenericSerif, 16f), Brushes.White, new PointF(40, 5));
        }

        private void resetPanel_MouseDown(object sender, MouseEventArgs e)
        {
            resetPanel.BackColor = Color.Red;
            ResetFlag = true;

            // 
            this.isFirstTimeResetDone = true;

            // for tool abnormal
            ShareMemory.isResetPush = true;

            // for single home
            this.HomeReset();

            // for reseting Gcode line to the first line.
            this.form_Mon_Monitor.SetCmdGridViewToTheFirstLine();

            // for Spindel CW/CCW stop
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.JOG:
                case ShareMemory.NcMode.INCJOG:
                case ShareMemory.NcMode.MPG:
                    this.spindleOffPanel_Click(this.spindleOffPanel, new EventArgs());
                    break;
                case ShareMemory.NcMode.ZRN:
                case ShareMemory.NcMode.MDI:
                case ShareMemory.NcMode.MEM:
                default:
                    break;
            }
        }

        private void resetPanel_MouseUp(object sender, MouseEventArgs e)
        {
            resetPanel.BackColor = Color.DarkGray;
            ResetFlag = false;
            if (EStopWarningMsg && EStopStatusLatch)
            {
                ResetPush = true;
                if (false == Connection.CNCtoDT.Reset())
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.Reset()");
                }
               
                ShareMemory.EStopStatus[(int)ESTOP.msg] = EStopWarningMsg;
            }
            else if ((!EStopWarningMsg) && (!EStopStatusLatch))
            {
                ResetPush = true;
                if (false == Connection.CNCtoDT.Reset())
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.Reset()");
                }
            }

            homeStateTimer.Stop();
            this.cycle_start = ShareMemory.Switch.Off;
            cycleStartTimer.Stop();
            cycleStartPanel.BackColor = Color.Thistle;

            this.feed_hold = ShareMemory.Switch.Off;
            this.feedHoldPanel.BackColor = Color.LightSteelBlue;

            ShareMemory.System.Reset = ShareMemory.Switch.On;
        }

        private void controlFunctionPanel_Click(object sender, EventArgs e)
        {
            MFEXControlFuncDlg m_MFEXControlFuncDlg = new MFEXControlFuncDlg();
            m_MFEXControlFuncDlg.ShowDialog();
        }

        private void SetParametersAfterDTInitial()
        {
            System.Threading.Thread.Sleep(200);

            Connection.CNCtoDT.ParameterSetting();

            if (false == this.SetCoordinateSystemValue())
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetCoordinateSystemValue()");
            }

            if (false == Connection.CNCtoDT.SetDOState(4, false))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetDOState(4, false)");
            }
            if (false == Connection.CNCtoDT.SetSpindleMaxSpeed(ShareMemory.SpindleMaxSpeed))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetSpindleMaxSpeed(ShareMemory.SpindleMaxSpeed)");
            }
            if (false == Connection.CNCtoDT.SetJOGSpeed(ShareMemory.JogSpeed))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetJOGSpeed(ShareMemory.JogSpeed)");
            }


            this.form_Mon_Monitor.SetNormalFeedrateOrNot(true);

            // set Max FeedRate
            this.form_Mon_Monitor.ReloadFeedRateValue();

            this.TASK_Parameter();


            this.initialMSG.SetSystemInitComplete(ShareMemory.System.InitComplete);
            
            System.Threading.Thread.Sleep(200);
            this.mouseTimer.Start();
        }

        private void mouseTimer_Tick(object sender, EventArgs e)
        {
            this.mouseTimer.Stop();
            this.cmfMouse.EnableMouse();
        }

        private int init_complete = ShareMemory.Switch.Off;
               
        private void SYSTSTATUSTIMER_Tick(object sender, EventArgs e)
        {
            if (ShareMemory.Switch.Off == this.init_complete)
            {
                this.initialMSG.SetPowerPMacConnectState(ShareMemory.PPMACLink);
                if (ShareMemory.Switch.On == ShareMemory.System.InitComplete)
                {
                    this.SetParametersAfterDTInitial();
                    this.init_complete = ShareMemory.System.InitComplete;
                }
                else
                {
                    if (true == this.initialMSG.isInitialFail)
                    {
                        this.init_complete = ShareMemory.Switch.On;
                        this.mouseTimer.Start();
                    }
                }
            }

            if (ShareMemory.Switch.Off == this.init_complete)
            {
                if (0 == ShareMemory.System.EmgLatch) // 壓下去
                {
                    if (false == EStopWarningMsg)
                    {
                        this.warningMSG.SetText("請立即鬆開緊停開關，執行控制器初始化!");
                        warningMSG.Show();
                        EStopWarningMsg = true;
                    }
                }
                else if (1 == ShareMemory.System.EmgLatch)
                {
                    if (true == EStopWarningMsg)
                    {
                        warningMSG.Hide();
                        EStopWarningMsg = false;
                    }
                }
            }
            else
            {
                this.warningMSG.SetText("警告 : 緊急開關已啟動");
                if (ShareMemory.Switch.On == ShareMemory.EmgStopState)
                {
                    emgStopLightPanel.BackColor = Color.Red;
                    if (!EStopStatusLatch)
                    {
                        EStopStatusLatch = true;
                        ShareMemory.EStopStatus[(int)ESTOP.latch] = EStopStatusLatch;

                        warningMSG.Show();
                        EStopWarningMsg = true;
                        ShareMemory.EStopStatus[(int)ESTOP.msg] = EStopWarningMsg;
                    }
                }
                else
                {
                    if (EStopStatusLatch && (!EStopWarningMsg))
                    {
                        emgStopLightPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;

                        EStopStatusLatch = false;
                        ShareMemory.EStopStatus[(int)ESTOP.latch] = EStopStatusLatch;
                    }

                    warningMSG.Hide();
                    EStopWarningMsg = false;
                }
            }

            if ((ShareMemory.CurrentToolNum != TempCurrentToolNum) && (ShareMemory.CurrentToolCompValue != TempCurrentToolCompValue) && (ShareMemory.AutoCompStatus == 1))
            {
                if (false == Connection.CNCtoDT.ResetAutoCompStatus())
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.ResetAutoCompStatus()");
                }
                TempCurrentToolNum = ShareMemory.CurrentToolNum;
                TempCurrentToolCompValue = ShareMemory.CurrentToolCompValue;
                form_Off_CoordinateSystem.m_Tool.SetOffsetData(ShareMemory.CurrentToolNum, ShareMemory.CurrentToolCompValue);
            }


            // T-code value: H and D
            form_Off_CoordinateSystem.m_Tool.GetOffsetData(ShareMemory.CurrentHNum, "HEIGHT", out ShareMemory.CurrentHNumVal);
            form_Off_CoordinateSystem.m_Tool.GetOffsetData(ShareMemory.CurrentDNum, "DIAMETER", out ShareMemory.CurrentDNumVal);

            // show current coordinate system
            this.form_Mon_Monitor.ShowCurrentCoordinateSystem();

            // show feedrate
            this.form_Mon_Monitor.SetRealFeedrateValue(ShareMemory.FeedrateValue);



            // NcMode
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.JOG:
                    break;
                case ShareMemory.NcMode.INCJOG:
                    {
                        // reset incjog state
                        for (int axis = 0; axis < ShareMemory.IncJog.AxisNum; axis++)
                        {
                            if (ShareMemory.Switch.On == ShareMemory.IncJog.Finish[axis])
                            {
                                this.jog_plus_panel[axis].BackColor = Color.PapayaWhip;
                                this.jog_minus_panel[axis].BackColor = Color.PapayaWhip;
                                ShareMemory.IncJog.Finish[axis] = ShareMemory.Switch.Off;

                                ShareMemory.Jog.DirChange[axis] = ShareMemory.Switch.On;
                                ShareMemory.Jog.CurrentDir[axis] = ShareMemory.Jog.Stop;
                            }
                        }
                        break;
                    }
                default:
                    break;
            }


            // You have to go home first!
            if (true == ShareMemory.Home.HaveToGoHome)
            {
                switch (this.HaveToGoHome_Step)
                {
                    case HAVETOGOHOME_STEP.INIT:
                        if (ShareMemory.NcMode.value != ShareMemory.NcMode.ZRN)
                        {
                            this.ncModeZrnPanel_Click(this.nc_mode[ShareMemory.NcMode.ZRN], new EventArgs());
                        }

                        this.have_been_home = new bool[ShareMemory.Home.AxisNum] { false, false, false };
                        ShareMemory.Home.Finish = new int[ShareMemory.Home.AxisNum] { 0, 0, 0 };

                        this.HaveToGoHome_Step = HAVETOGOHOME_STEP.RECEIVE;
                        break;
                    case HAVETOGOHOME_STEP.RECEIVE:
                        for (int index = 0; index < ShareMemory.Home.AxisNum; index++)
                        {
                            if (ShareMemory.Switch.On == ShareMemory.Home.Finish[index])
                            {
                                this.have_been_home[index] = true;
                            }
                        }

                        int check = 0;
                        for (int index = 0; index < ShareMemory.Home.AxisNum; index++)
                        {
                            if (false == this.have_been_home[index])
                            {
                                check--;
                            }
                        }

                        if (check >= 0)
                        {
                            this.HaveToGoHome_Step = HAVETOGOHOME_STEP.FINISH;
                        }
                        break;
                    case HAVETOGOHOME_STEP.FINISH:
                        ShareMemory.Home.HaveToGoHome = false;
                        this.HaveToGoHome_Step = HAVETOGOHOME_STEP.INIT;
                        break;
                    default:
                        this.HaveToGoHome_Step = HAVETOGOHOME_STEP.INIT;
                        break;
                }
            }

        }
        private enum HAVETOGOHOME_STEP { INIT, RECEIVE, FINISH };
        private HAVETOGOHOME_STEP HaveToGoHome_Step = HAVETOGOHOME_STEP.INIT;
        private bool[] have_been_home;



        private Panel[] SPEED_Panel;
        private Panel[] SPINDLE_Panel;
        private Panel[] MOTION_Func_Panel;
        private Panel[] CNC_OP_Panel;
        private void SetFunctionStateWhenToolAbnormal(bool state)
        {
            this.feedrateTypePanel.Enabled = state;
            this.cycleStartPanel.Enabled = state;

            this.SPEED_Panel = new Panel[3] { this.feedratePercent100, this.feedratePercentUp, this.feedratePercentDown };
            this.SPINDLE_Panel = new Panel[6] { this.spindlePercentUp, this.spindlePercent100, this.spindlePercentDown, 
                                                this.spindleCwPanel, this.spindleOffPanel, this.spindleCcwPanel };
            this.MOTION_Func_Panel = new Panel[3] { /*this.MCT_JOG,*/ /*this.MCT_INCJOG,*/ this.ncModeZrnPanel, 
                                                    /*this.MCT_MPG,*/ this.ncModeMdiPanel, this.ncModeMemPanel };
            this.CNC_OP_Panel = new Panel[2] { /*this.MC_M01,*/ this.singleBlockPanel, this.feedHoldPanel };

            for (int i = 0; i < 6; i++)
            {
                if (i < 3) this.SPEED_Panel[i].Enabled = state;
                this.SPINDLE_Panel[i].Enabled = state;
                if (i < 3) this.MOTION_Func_Panel[i].Enabled = state;
                if (i < 2) this.CNC_OP_Panel[i].Enabled = state;
            }
        }

        private void JCNCMainFormClosing(object sender, FormClosingEventArgs e)
        {
            double CS_value;
            if (false == Connection.CNCtoDT.GetCurrentCoordinateSystem(out CS_value))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetDOState(index, true)");
            }
            else
            {
                ShareMemory.SaveCurrentCoordinateSystem(CS_value);
            }

            if (false == Connection.CNCtoDT.ExitPPMACEnv())
            {
                MessageBox.Show("Connection.CNCtoDT.ExitPPMACEnv()");
            }
        }

        private void shutDownToolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {
            this.form_Mon_Monitor.Close();
            this.form_Prog_MemFileEdit.Close();
            this.form_Mon_DioStatus.Close();
            this.form_Diag_AlarmMessage.Close();
            this.form_Mon_Signal.Close();
            this.form_Main_IdStatus.Close();
            this.form_Off_CoordinateSystem.Close();
            this.form_Prog_MdiFileEdit.Close();
            this.form_Param_WorkAreaLimit.Close();
            this.form_Param_Jog.Close();
            this.form_Main_SystemTime.Close();
            this.form_Main_Priority.Close();
            this.form_Prog_FileTransfer.Close();

            this.form_Mon_Monitor = null;
            this.form_Prog_MemFileEdit = null;
            this.form_Mon_DioStatus = null;
            this.form_Diag_AlarmMessage = null;
            this.form_Mon_Signal = null;
            this.form_Main_IdStatus = null;
            this.form_Off_CoordinateSystem = null;
            this.form_Prog_MdiFileEdit = null;
            this.form_Param_WorkAreaLimit = null;
            this.form_Param_Jog = null;
            this.form_Main_SystemTime = null;
            this.form_Main_Priority = null;
            this.form_Prog_FileTransfer = null;

            ShareMemory.isShutDown = true;

            System.Threading.Thread.Sleep(100);
            this.Close();
            
        }

        private void updateStatusBartimer_Tick(object sender, EventArgs e)
        {
            this.systemTimeToolStripStatusLabel.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm");
        }
     
        private bool isToolWarningMSGOpen = false;
        ToolWarningMSG toolWarningMSG;
        private void ToolAbnormalTimer_Tick(object sender, EventArgs e)
        {
            if (true == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                if (false == this.isToolWarningMSGOpen)
                {
                    this.SetFunctionStateWhenToolAbnormal(false);

                    toolWarningMSG = new ToolWarningMSG();
                    this.toolWarningMSG.Show();
                    this.isToolWarningMSGOpen = true;

                    this.ncModeJogPanel_Click(this.ncModeJogPanel, e);
                }
            }
            if (true == ShareMemory.EStopStatus[(int)ESTOP.recover_panel])
            //else
            {
                if (true == this.isToolWarningMSGOpen)
                {
                    this.SetFunctionStateWhenToolAbnormal(true);
                    ShareMemory.EStopStatus[(int)ESTOP.recover_panel] = false;
                    ShareMemory.EStopStatus[(int)ESTOP.recover_panel_finish] = true;

                    this.toolWarningMSG.Close();
                    this.toolWarningMSG.Dispose();
                    this.isToolWarningMSGOpen = false;
                }
            }

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.label1.Text = this.isSingleHomeRunning[(int)SingleHome.X].ToString();
            //this.label2.Text = this.isSingleHomeRunning[(int)SingleHome.Y].ToString();
            //this.label3.Text = this.isSingleHomeRunning[(int)SingleHome.Z].ToString();

            //this.label1.Text = ShareMemory.FeedrateValue.X_read.ToString("#0.00");
            //this.label2.Text = ShareMemory.FeedrateValue.Y_read.ToString("#0.00");
            //this.label3.Text = ShareMemory.FeedrateValue.calculate.ToString();

            //label1.Text = ShareMemory.thread.ToString();
            //label2.Text = ShareMemory.thread2.ToString();
            
           // label2.Text = ShareMemory.System.InitComplete.ToString();
            label2.Text = ShareMemory.System.ProcessState.ToString();
            label3.Text = ShareMemory.System.CurrentProgramStep.ToString();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-s -t 0");
        }



     

        //====================================================
        // Jog Direction Button
        //====================================================
        //-- X Jog Plus Panel
        private void xJogPlusPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            Panel panel = (Panel)sender;
            panelGraphics = panel.CreateGraphics();
            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, panel.Width - 2, panel.Height - 2));
            panelGraphics.DrawString("+X", new Font(FontFamily.GenericSerif, 18f), Brushes.Black,
                                     new Rectangle(0, 0, panel.Width - 2, panel.Height - 2),
                                     new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            panelGraphics.Dispose();
        }

        private void xJogPlusPanel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    xJogPlusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.X] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.X] = ShareMemory.Jog.Plus;
                    break;
                case ShareMemory.NcMode.JOG:
                    xJogPlusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.X] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.X] = ShareMemory.Jog.Plus;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    this.SingleHome(ShareMemory.X);
                    break;
            }
        }

        private void xJogPlusPanel_MouseUp(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    break;
                case ShareMemory.NcMode.JOG:
                    xJogPlusPanel.BackColor = Color.PapayaWhip;
                    ShareMemory.Jog.DirChange[ShareMemory.X] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.X] = ShareMemory.Jog.Stop;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
            }
        }

        //-- Y Jog Plus Panel
        private void yJogPlusPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            Panel panel = (Panel)sender;
            panelGraphics = panel.CreateGraphics();
            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, panel.Width - 2, panel.Height - 2));
            panelGraphics.DrawString("+Y", new Font(FontFamily.GenericSerif, 18f), Brushes.Black,
                                     new Rectangle(0, 0, panel.Width - 2, panel.Height - 2),
                                     new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            panelGraphics.Dispose();
        }

        private void yJogPlusPanel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    yJogPlusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.Y] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Y] = ShareMemory.Jog.Plus;
                    break;
                case ShareMemory.NcMode.JOG:
                    yJogPlusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.Y] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Y] = ShareMemory.Jog.Plus;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    this.SingleHome(ShareMemory.Y);
                    break;
            }
        }

        private void yJogPlusPanel_MouseUp(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    break;
                case ShareMemory.NcMode.JOG:
                    yJogPlusPanel.BackColor = Color.PapayaWhip;
                    //if (false == Connection.CNCtoDT.JOGExit(ShareMemory.PhyNum[ShareMemory.Y]))
                    //{
                    //    MessageBox.Show("Error: Connection.CNCtoDT.JOGExit(ShareMemory.Y)");
                    //}
                    ShareMemory.Jog.DirChange[ShareMemory.Y] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Y] = ShareMemory.Jog.Stop;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
            }
        }

        //-- Z Jog Plus Panel
        private void zJogPlusPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            Panel panel = (Panel)sender;
            panelGraphics = panel.CreateGraphics();
            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, panel.Width - 2, panel.Height - 2));
            panelGraphics.DrawString("+Z", new Font(FontFamily.GenericSerif, 18f), Brushes.Black,
                                     new Rectangle(0, 0, panel.Width - 2, panel.Height - 2),
                                     new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            panelGraphics.Dispose();
        } 

        private void zJogPlusPanel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    zJogPlusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.Z] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Z] = ShareMemory.Jog.Plus;
                    break;
                case ShareMemory.NcMode.JOG:
                    zJogPlusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.Z] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Z] = ShareMemory.Jog.Plus;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    this.SingleHome(ShareMemory.Z);
                    break;
            }
        }

        private void zJogPlusPanel_MouseUp(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    break;
                case ShareMemory.NcMode.JOG:
                    zJogPlusPanel.BackColor = Color.PapayaWhip;
                    //if (false == Connection.CNCtoDT.JOGExit(ShareMemory.PhyNum[ShareMemory.Z]))
                    //{
                    //    MessageBox.Show("Error: Connection.CNCtoDT.JOGExit(ShareMemory.Z)");
                    //}                    
                    ShareMemory.Jog.DirChange[ShareMemory.Z] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Z] = ShareMemory.Jog.Stop;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
            }
        }

        //-- A Jog Plus Panel
        private void aJogPlusPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            Panel panel = (Panel)sender;
            panelGraphics = panel.CreateGraphics();
            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, panel.Width - 2, panel.Height - 2));
            panelGraphics.DrawString("+4", new Font(FontFamily.GenericSerif, 18f), Brushes.Black,
                                     new Rectangle(0, 0, panel.Width - 2, panel.Height - 2),
                                     new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            panelGraphics.Dispose();
        }

        private void aJogPlusPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void aJogPlusPanel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        //-- X Jog Minus Panel
        private void xJogMinusPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            Panel panel = (Panel)sender;
            panelGraphics = panel.CreateGraphics();
            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, panel.Width - 2, panel.Height - 2));
            panelGraphics.DrawString("-X", new Font(FontFamily.GenericSerif, 18f), Brushes.Black,
                                     new Rectangle(0, 0, panel.Width - 2, panel.Height - 2),
                                     new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            panelGraphics.Dispose();
        }

        private void xJogMinusPanel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    xJogMinusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.X] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.X] = ShareMemory.Jog.Minus;
                    break;
                case ShareMemory.NcMode.JOG:
                    xJogMinusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.X] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.X] = ShareMemory.Jog.Minus;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    this.SingleHome(ShareMemory.X);
                    break;
            }
        }

        private void xJogMinusPanel_MouseUp(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    break;
                case ShareMemory.NcMode.JOG:
                    xJogMinusPanel.BackColor = Color.PapayaWhip;
                    //if (false == Connection.CNCtoDT.JOGExit(ShareMemory.PhyNum[ShareMemory.X]))
                    //{
                    //    MessageBox.Show("Error: Connection.CNCtoDT.JOGExit(ShareMemory.X)");
                    //}
                    ShareMemory.Jog.DirChange[ShareMemory.X] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.X] = ShareMemory.Jog.Stop;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
            }
        }

        //-- Y Jog Minus Panel
        private void yJogMinusPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            Panel panel = (Panel)sender;
            panelGraphics = panel.CreateGraphics();
            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, panel.Width - 2, panel.Height - 2));
            panelGraphics.DrawString("-Y", new Font(FontFamily.GenericSerif, 18f), Brushes.Black,
                                     new Rectangle(0, 0, panel.Width - 2, panel.Height - 2),
                                     new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            panelGraphics.Dispose();
        }

        private void yJogMinusPanel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    yJogMinusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.Y] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Y] = ShareMemory.Jog.Minus;
                    break;
                case ShareMemory.NcMode.JOG:
                    yJogMinusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.Y] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Y] = ShareMemory.Jog.Minus;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    this.SingleHome(ShareMemory.Y);
                    break;
            }
        }

        private void yJogMinusPanel_MouseUp(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    break;
                case ShareMemory.NcMode.JOG:
                    yJogMinusPanel.BackColor = Color.PapayaWhip;
                    ShareMemory.Jog.DirChange[ShareMemory.Y] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Y] = ShareMemory.Jog.Stop;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
            }
        }

        //-- Z Jog Minus Panel
        private void zJogMinusPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            Panel panel = (Panel)sender;
            panelGraphics = panel.CreateGraphics();
            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, panel.Width - 2, panel.Height - 2));
            panelGraphics.DrawString("-Z", new Font(FontFamily.GenericSerif, 18f), Brushes.Black,
                                     new Rectangle(0, 0, panel.Width - 2, panel.Height - 2),
                                     new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            panelGraphics.Dispose();
        }

        private void zJogMinusPanel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    zJogMinusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.Z] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Z] = ShareMemory.Jog.Minus;
                    break;
                case ShareMemory.NcMode.JOG:
                    zJogMinusPanel.BackColor = Color.DarkRed;
                    ShareMemory.Jog.DirChange[ShareMemory.Z] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Z] = ShareMemory.Jog.Minus;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    this.SingleHome(ShareMemory.Z);
                    break;
            }
        }

        private void zJogMinusPanel_MouseUp(object sender, MouseEventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.INCJOG:
                    break;
                case ShareMemory.NcMode.JOG:
                    zJogMinusPanel.BackColor = Color.PapayaWhip;
                    ShareMemory.Jog.DirChange[ShareMemory.Z] = ShareMemory.Switch.On;
                    ShareMemory.Jog.CurrentDir[ShareMemory.Z] = ShareMemory.Jog.Stop;

                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
            }
        }

        //-- A Jog Minus Panel
        private void aJogMinusPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            Panel panel = (Panel)sender;
            panelGraphics = panel.CreateGraphics();
            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, panel.Width - 2, panel.Height - 2));
            panelGraphics.DrawString("-4", new Font(FontFamily.GenericSerif, 18f), Brushes.Black,
                                     new Rectangle(0, 0, panel.Width - 2, panel.Height - 2),
                                     new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            panelGraphics.Dispose();
        }

        private void aJogMinusPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void aJogMinusPanel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        //====================================================
        // Single Axis Home
        //====================================================
        //-- X, Y, Z
        private void SingleHome(int axis)
        {
            if (false == ShareMemory.Home.All)
            {
                if (ShareMemory.Switch.Off == ShareMemory.Home.Start[axis])
                {
                    ShareMemory.Home.Single = true;

                    this.jog_plus_panel[axis].BackColor = Color.DarkRed;
                    this.jog_minus_panel[axis].BackColor = Color.DarkRed;

                    ShareMemory.Home.Start[axis] = ShareMemory.Switch.On;

                    if (false == homeStateTimer.Enabled)
                    {
                        homeStateTimer.Interval = 300;
                        homeStateTimer.Start();
                    }
                }
                else
                {
                    MessageBox.Show("請等待復歸動作完成！");
                }
            }

            else
            {
                MessageBox.Show("請等待復歸動作完成！");
            }
        }

        //====================================================
        // Home State Check Timer
        //====================================================
        private void homeStateTimer_Tick(object sender, EventArgs e)
        {
            if (true == ShareMemory.Home.Arrival)
            {
                this.cycle_start = ShareMemory.Switch.Off;
                this.homeStateTimer.Stop();
                if (true == ShareMemory.Home.All)
                {
                    this.cycleStartPanel.BackColor = Color.Thistle;
                    ShareMemory.Home.All = false;
                }
                else
                {
                    if (true == ShareMemory.Home.Single)
                    {
                        for (int axis = 0; axis < ShareMemory.Home.AxisNum; axis++)
                        {
                            this.jog_plus_panel[axis].BackColor = Color.PapayaWhip;
                            this.jog_minus_panel[axis].BackColor = Color.PapayaWhip;
                        }
                        ShareMemory.Home.Single = false;
                    }
                }
                ShareMemory.Home.Arrival = false;
            }
            if (false == ShareMemory.Home.NotFirstTimeGo)
            {
                int axis = 0, home_num = 0;
                foreach (Panel panel in this.home_panel)
                {
                    if (ShareMemory.Switch.On == ShareMemory.Home.Finish[axis])
                    {
                        panel.BackColor = Color.Yellow;
                        home_num++;
                    }
                    if (ShareMemory.Home.AxisNum == home_num)
                    {
                        ShareMemory.Home.NotFirstTimeGo = true;
                    }
                    axis++;
                }
            }
        }

        //====================================================
        // Spindle CW, CCW & OFF Button
        //====================================================
        //-- OFF Panel
        private void spindleOffPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));

                g.DrawString("OFF", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(33, 18));

            }
            else
            {
                g.DrawString("OFF", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(33, 18));
            }
        }

        private void spindleOffPanel_Click(object sender, EventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.JOG:
                case ShareMemory.NcMode.INCJOG:
                case ShareMemory.NcMode.MPG:
                    if (ShareMemory.Spindle.Stop != ShareMemory.Spindle.CurrentDir)
                    {
                        ((Panel)sender).BackColor = Color.Yellow;

                        ShareMemory.Spindle.DirChange = ShareMemory.Switch.On;
                        ShareMemory.Spindle.CurrentDir = ShareMemory.Spindle.Stop;

                        this.spindleCcwPanel.BackColor = System.Drawing.SystemColors.Info;
                        this.spindleCwPanel.BackColor = System.Drawing.SystemColors.Info;

                        ((Panel)sender).BackColor = System.Drawing.SystemColors.Info;
                    }

                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                default:
                    break;
            }
        }
        

        //-- CW Panel
        private void spindleCwPanel_Click(object sender, EventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.JOG:
                case ShareMemory.NcMode.INCJOG:
                case ShareMemory.NcMode.MPG:
                    if (ShareMemory.Spindle.Stop == ShareMemory.Spindle.CurrentDir)
                    {
                        ShareMemory.Spindle.DirChange = ShareMemory.Switch.On;
                        ShareMemory.Spindle.CurrentDir = ShareMemory.Spindle.Plus;

                        ((Panel)sender).BackColor = Color.DarkRed;
                        spindleCcwPanel.BackColor = System.Drawing.SystemColors.Info;
                    }

                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                default:
                    break;
            }
        }
        
        private void spindleCwPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("CW", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(35, 18));
            }
            else
            {
                g.DrawString("CW", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(35, 18));
            }
        }

        //-- CCW Panel
        private void spindleCcwPanel_Click(object sender, EventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.JOG:
                case ShareMemory.NcMode.INCJOG:
                case ShareMemory.NcMode.MPG:
                    if (ShareMemory.Spindle.Stop == ShareMemory.Spindle.CurrentDir)
                    {
                        ShareMemory.Spindle.DirChange = ShareMemory.Switch.On;
                        ShareMemory.Spindle.CurrentDir = ShareMemory.Spindle.Minus;

                        ((Panel)sender).BackColor = Color.DarkRed;
                        spindleCwPanel.BackColor = System.Drawing.SystemColors.Info;
                    }
                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
                case ShareMemory.NcMode.MDI:
                    break;
                case ShareMemory.NcMode.MEM:
                    break;
                default:
                    break;
            }
        }

        private void spindleCcwPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("CCW", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(30, 18));
            }
            else
            {
                g.DrawString("CCW", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(30, 18));
            }
        }

        //-- Speed Up Panel
        private void spindlePercentUp_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.DarkRed;
            ShareMemory.Spindle.CurrentSpeedPercentage = this.form_Mon_Monitor.SetSPOveride(true);     // set UP or DOWN
            ShareMemory.Spindle.SpeedPercentageChange = ShareMemory.Switch.On;
        }

        private void spindlePercentUp_MouseUp(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = System.Drawing.SystemColors.Info;
        }

        //-- Speed Down Panel
        private void spindlePercentDown_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.DarkRed;
            ShareMemory.Spindle.CurrentSpeedPercentage = this.form_Mon_Monitor.SetSPOveride(false);     // set UP or DOWN
            ShareMemory.Spindle.SpeedPercentageChange = ShareMemory.Switch.On;
        }

        private void spindlePercentDown_MouseUp(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = System.Drawing.SystemColors.Info;
        }

        //-- Speed 100% Panel
        private void spindlePercent100_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.DarkRed;
            ShareMemory.Spindle.CurrentSpeedPercentage = 100;
            this.form_Mon_Monitor.SetSPOveride(ShareMemory.Spindle.CurrentSpeedPercentage);     // set 100%
            ShareMemory.Spindle.SpeedPercentageChange = ShareMemory.Switch.On;
        }

        private void spindlePercent100_MouseUp(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = System.Drawing.SystemColors.Info;
        }

        //====================================================
        // NC Mode Button
        //====================================================
        //-- Jog Panel
        private void ncModeJogPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            if (ShareMemory.NcMode.JOG == ShareMemory.NcMode.value)
            {
                g.DrawString("JOG", new Font(FontFamily.GenericSerif, 16f), Brushes.Blue, new PointF(35, 18));
            }
            else
            {
                g.DrawString("JOG", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(35, 18));
            }

        }

        private void ncModeJogPanel_Click(object sender, EventArgs e)
        {
            if ((ShareMemory.Switch.On == this.cycle_start) || (true == ShareMemory.Home.HaveToGoHome))
            {
                return;
            }

            ShareMemory.NcMode.value = ShareMemory.NcMode.JOG;

            if (false == Connection.CNCtoDT.SetNcMode(ShareMemory.NcMode.value))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetOPMode(false)");
            }

            this.PaintColorMCT();
            this.ncModeJogPanel.BackColor = Color.Yellow;

            if (false == Connection.CNCtoDT.ToolChangeable(true))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.ToolChangeable(true)");
            }
        }

        //-- IncJog Panel
        private void ncModeIncJogPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));

            if (ShareMemory.NcMode.INCJOG == ShareMemory.NcMode.value)
            {
                g.DrawString("INCJOG", new Font(FontFamily.GenericSerif, 16f), Brushes.Blue, new PointF(17, 18));
            }
            else
            {
                g.DrawString("INCJOG", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(17, 18));
            }
        }

        private void ncModeIncJogPanel_Click(object sender, EventArgs e)
        {
            if ((ShareMemory.Switch.On == this.cycle_start) || (true == ShareMemory.Home.HaveToGoHome))
            {
                return;
            }

            ShareMemory.NcMode.value = ShareMemory.NcMode.INCJOG;

            if (false == Connection.CNCtoDT.SetNcMode(ShareMemory.NcMode.value))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetOPMode(false)");
            }

            this.PaintColorMCT();
            this.ncModeIncJogPanel.BackColor = Color.Yellow;

            //ShareMemory.OPMode = ShareMemory.OperationMode.INCJOG;


            if (false == Connection.CNCtoDT.ToolChangeable(true))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.ToolChangeable(true)");
            }
        }
    
        //-- MPG Panel
        private void ncModeMpgPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            if (ShareMemory.NcMode.MPG == ShareMemory.NcMode.value)
            {
                g.DrawString("MPG", new Font(FontFamily.GenericSerif, 16f), Brushes.Blue, new PointF(30, 18));
            }
            else
            {
                g.DrawString("MPG", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(30, 18));
            }
        }

        private void ncModeMpgPanel_Click(object sender, EventArgs e)
        {
            if ((ShareMemory.Switch.On == this.cycle_start) || (true == ShareMemory.Home.HaveToGoHome))
            {
                return;
            }

            ShareMemory.NcMode.value = ShareMemory.NcMode.MPG;

            if (false == Connection.CNCtoDT.SetNcMode(ShareMemory.NcMode.value))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetOPMode(false)");
            }

            this.PaintColorMCT();
            this.ncModeMpgPanel.BackColor = Color.Yellow;

            if (false == Connection.CNCtoDT.ToolChangeable(true))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.ToolChangeable(true)");
            }
        }
    
        //-- ZRN Panel
        private void ncModeZrnPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                if (ShareMemory.NcMode.ZRN == ShareMemory.NcMode.value)
                {
                    g.DrawString("ZRN", new Font(FontFamily.GenericSerif, 16f), Brushes.Blue, new PointF(35, 18));
                }
                else
                {
                    g.DrawString("ZRN", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(35, 18));
                }
            }
            else
            {
                g.DrawString("ZRN", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(35, 18));
            }
        }

        private void ncModeZrnPanel_Click(object sender, EventArgs e)
        {
            if (ShareMemory.Switch.Off == this.cycle_start)
            {
                if (ShareMemory.Spindle.Stop != ShareMemory.Spindle.CurrentDir)
                {
                    ShareMemory.Spindle.CurrentDir = ShareMemory.Spindle.Stop;
                    ShareMemory.Spindle.DirChange = ShareMemory.Switch.On;

                    this.spindleCcwPanel.BackColor = System.Drawing.SystemColors.Info;
                    this.spindleCwPanel.BackColor = System.Drawing.SystemColors.Info;
                }

                if (false == ShareMemory.ToolClampON)
                {
                    MessageBox.Show("目前為鬆刀狀態，不可執行此模式。");
                }
                else
                {
                    // contorller setup
                    ShareMemory.NcMode.value = ShareMemory.NcMode.ZRN;

                    if (false == Connection.CNCtoDT.SetNcMode(ShareMemory.NcMode.value))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.SetOPMode(false)");
                    }
                    if (false == Connection.CNCtoDT.ToolChangeable(false))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.ToolChangeable(false)");
                    }

                    // paint this block
                    this.PaintColorMCT();
                    this.ncModeZrnPanel.BackColor = Color.Yellow;
                }
            }
        }
        
        //-- MDI Panel
        private void ncModeMdiPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                if (ShareMemory.NcMode.MDI == ShareMemory.NcMode.value)
                {
                    g.DrawString("MDI", new Font(FontFamily.GenericSerif, 16f), Brushes.Blue, new PointF(35, 18));
                }
                else
                {
                    g.DrawString("MDI", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(35, 18));
                }
            }
            else
            {
                g.DrawString("MDI", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(35, 18));
            }
        }

        private void ncModeMdiPanel_Click(object sender, EventArgs e)
        {
            if ((ShareMemory.Switch.On == this.cycle_start) || (true == ShareMemory.Home.HaveToGoHome))
            {
                return;
            }

            ShareMemory.NcMode.value = ShareMemory.NcMode.MDI;
            if (false == Connection.CNCtoDT.SetNcMode(ShareMemory.NcMode.value))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetOPMode(true)");
            }
            if (false == Connection.CNCtoDT.GetProgramStep(out ShareMemory.System.CurrentProgramStep))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.GetProgramStep(out ShareMemory.System.CurrentProgramStep)");
            }

            ShareMemory.System.UploadMDIFile = ShareMemory.Switch.On;

            if (ShareMemory.Spindle.Stop != ShareMemory.Spindle.CurrentDir)
            {
                ShareMemory.Spindle.CurrentDir = ShareMemory.Spindle.Stop;
                ShareMemory.Spindle.DirChange = ShareMemory.Switch.On;

                this.spindleCcwPanel.BackColor = System.Drawing.SystemColors.Info;
                this.spindleCwPanel.BackColor = System.Drawing.SystemColors.Info;
            }

            if (!ShareMemory.ToolClampON)
            {
                MessageBox.Show("目前為鬆刀狀態，不可執行此模式。");
                return;
            }

            if (ShareMemory.Spindle.Stop != ShareMemory.Spindle.CurrentDir)
            {
                this.spindleOffPanel_Click(this.spindleOffPanel, null);
            }          

            this.PaintColorMCT();
            this.ncModeMdiPanel.BackColor = Color.Yellow;

            ShareMemory.FileLoadOn = true;
            this.form_Mon_Monitor.Refresh();

            if (false == Connection.CNCtoDT.ToolChangeable(false))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.ToolChangeable(false)");
            }
        }

        //-- MEM Panel
        private void ncModeMemPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                if (ShareMemory.NcMode.MEM == ShareMemory.NcMode.value)
                {
                    g.DrawString("MEM", new Font(FontFamily.GenericSerif, 16f), Brushes.Blue, new PointF(28, 18));
                }
                else
                {
                    g.DrawString("MEM", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(28, 18));
                }
            }
            else
            {
                g.DrawString("MEM", new Font(FontFamily.GenericSerif, 16f), Brushes.Gray, new PointF(28, 18));
            }
        }

        private void ncModeMemPanel_Click(object sender, EventArgs e)
        {
            if ((ShareMemory.Switch.On == this.cycle_start) || (true == ShareMemory.Home.HaveToGoHome))
            {
                return;
            }

            if (ShareMemory.Spindle.Stop != ShareMemory.Spindle.CurrentDir)
            {
                ShareMemory.Spindle.CurrentDir = ShareMemory.Spindle.Stop;
                ShareMemory.Spindle.DirChange = ShareMemory.Switch.On;

                this.spindleCcwPanel.BackColor = System.Drawing.SystemColors.Info;
                this.spindleCwPanel.BackColor = System.Drawing.SystemColors.Info;
            }

            if (!ShareMemory.ToolClampON)
            {
                MessageBox.Show("目前為鬆刀狀態，不可執行此模式。");
                return;
            }

            ShareMemory.NcMode.value = ShareMemory.NcMode.MEM;
            if (ShareMemory.Spindle.Stop != ShareMemory.Spindle.CurrentDir)
            {
                this.spindleOffPanel_Click(this.spindleOffPanel, null);
            }

            if (false == Connection.CNCtoDT.SetNcMode(ShareMemory.NcMode.value))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.SetOPMode(true)");
            }

            this.PaintColorMCT();
            ncModeMemPanel.BackColor = Color.Yellow;

            ShareMemory.FileLoadOn = true;
            this.form_Mon_Monitor.Refresh();

            if (false == Connection.CNCtoDT.ToolChangeable(false))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.ToolChangeable(false)");
            }
        }
        
        //====================================================
        // System Button
        //====================================================
        //-- Cycle Start Panel
        private void cycleStartPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {
                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
                g.DrawString("CYCLE START", new Font(FontFamily.GenericSerif, 18f), Brushes.Black, new PointF(-2, 78));
            }
            else
            {
                g.DrawString("CYCLE START", new Font(FontFamily.GenericSerif, 18f), Brushes.Gray, new PointF(-2, 78));
            }
        }

        private void cycleStartPanel_Click(object sender, EventArgs e)
        {
            if (ShareMemory.PPMACLink == false)
            {
                return;
            }
            if (false == this.isFirstTimeResetDone)
            {
                MessageBox.Show("Error: Please press \"resetPanel\" first!");
                return;
            }
            if (false == Connection.CNCtoDT.CSResetG43Ofs())
            {
                MessageBox.Show("Error: Connection.CNCtoDT.CSResetG43Ofs()");
            }

            //if (ShareMemory.Switch.Off == this.cycle_start)

            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.JOG:
                case ShareMemory.NcMode.INCJOG:
                case ShareMemory.NcMode.MPG:
                    MessageBox.Show("模式錯誤！");
                    break;
                case ShareMemory.NcMode.ZRN:
                    if (false == ShareMemory.Home.OnTheWay)
                    {
                        this.cycle_start = ShareMemory.Switch.On;

                        ShareMemory.Home.All = true;
                        ShareMemory.Home.Arrival = false;

                        cycleStartPanel.BackColor = Color.Green;

                        ShareMemory.Home.Start[ShareMemory.Z] = ShareMemory.Switch.On;
                        ShareMemory.Home.Start[ShareMemory.X] = ShareMemory.Switch.On;
                        ShareMemory.Home.Start[ShareMemory.Y] = ShareMemory.Switch.On;

                        homeStateTimer.Interval = 300;
                        homeStateTimer.Start();
                    }
                    break;
                case ShareMemory.NcMode.MDI:
                    //if (ShareMemory.System.ProgramRunning != ShareMemory.System.CurrentProgramStep)
                    //{
                    //    if (ShareMemory.Switch.On == feed_hold)
                    //    {
                    //        this.feed_hold = ShareMemory.Switch.Off;
                    //        feedHoldPanel.BackColor = Color.LightSteelBlue;
                    //    }

                    //    this.cycle_start = ShareMemory.Switch.On;
                    //    ShareMemory.System.CycleStartTrigger = this.cycle_start;
                    //    cycleStartPanel.BackColor = Color.Green;

                    //    cycleStartTimer.Interval = 500;
                    //    cycleStartTimer.Start();
                    //}
                    //break;
                case ShareMemory.NcMode.MEM:
                    if (ShareMemory.System.ProgramRunning != ShareMemory.System.CurrentProgramStep)
                    {
                        if (ShareMemory.Switch.On == feed_hold)
                        {
                            this.feed_hold = ShareMemory.Switch.Off;
                            feedHoldPanel.BackColor = Color.LightSteelBlue;
                        }
                        this.cycle_start = ShareMemory.Switch.On;
                        ShareMemory.System.CycleStartTrigger = this.cycle_start;
                        this.cycleStartPanel.BackColor = Color.Green;

                        this.TASK_Delay();

                        if (false == cycleStartTimer.Enabled)
                        {
                            cycleStartTimer.Interval = 500;
                            cycleStartTimer.Start();
                        }
                    }
                    break;
            }
        }

        private void TASK_Delay()
        {
            var task = Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(500);
                this.check_single_block = true;
                this.check_m01 = true;
            });
        }

        private void cycleStartTimer_Tick(object sender, EventArgs e)
        {
            if (ShareMemory.System.ProgramDone == ShareMemory.System.CurrentProgramStep)
            {
                this.cycleStartTimer.Stop();
                this.cycle_start = ShareMemory.Switch.Off;
                this.cycleStartPanel.BackColor = Color.Thistle;
            }
            if ((true == this.check_m01) && (true == ShareMemory.System.CurrentM01) && (ShareMemory.System.ProgramFeedHold == ShareMemory.System.CurrentProgramStep))
            {
                this.check_m01 = false;
                this.cycleStartPanel.BackColor = Color.Thistle;
            }
            if ((true == this.check_single_block) && (true == ShareMemory.System.CurrentSingleBlock) && (ShareMemory.System.ProgramSingleStep == ShareMemory.System.CurrentProgramStep))
            {
                this.check_single_block = false;
                this.cycleStartPanel.BackColor = Color.Thistle;
            }
        }

        //-- Feed Hold Panel
        private void feedHoldPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (false == ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal])
            {

                g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));
                g.DrawString("FEED HOLD", new Font(FontFamily.GenericSerif, 18f), Brushes.Black, new PointF(12, 32));
            }
            else
            {
                g.DrawString("FEED HOLD", new Font(FontFamily.GenericSerif, 18f), Brushes.Gray, new PointF(12, 32));
            }
        }

        private void feedHoldPanel_Click(object sender, EventArgs e)
        {
            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.JOG:
                    break;
                case ShareMemory.NcMode.INCJOG:
                    break;
                case ShareMemory.NcMode.ZRN:
                    break;
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.MDI:
                case ShareMemory.NcMode.MEM:
                    if (ShareMemory.Switch.Off == this.feed_hold)
                    {
                        cycleStartPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
                        ((Panel)sender).BackColor = Color.Orange;
                        this.feed_hold = ShareMemory.Switch.On;
                        ShareMemory.System.FeedHoldTrigger = this.feed_hold;

                    }
                    //else if (MC_FeedHold_ON == true)
                    //{
                    //    this.feed_hold = ShareMemory.Switch.Off;
                    //    feedHoldPanel.BackColor = Color.LightSteelBlue;
                    //    return;
                    //}
                    break;
            }
        }

        //====================================================
        // Feedrade Override Button
        //====================================================
        //-- Speed Mode
        private void feedrateTypePanel_Click(object sender, EventArgs e)
        {
            if (MFT_RAPID_ON == false)
            {
                ((Panel)sender).BackColor = Color.Yellow;
                MFT_RAPID_ON = true;

                ShareMemory.FeedRate.CurrentRapidMode = ShareMemory.Switch.On;
                ShareMemory.FeedRate.RapidModeChange = ShareMemory.Switch.On;

            }
            else if (MFT_RAPID_ON == true)
            {
                ((Panel)sender).BackColor = Color.PaleTurquoise;
                MFT_RAPID_ON = false;

                ShareMemory.FeedRate.CurrentRapidMode = ShareMemory.Switch.Off;
                ShareMemory.FeedRate.RapidModeChange = ShareMemory.Switch.On;
            }
            form_Mon_Monitor.SetNormalFeedrateOrNot(!MFT_RAPID_ON);

            Connection.CNCtoDT.SetFeedrateType(ShareMemory.FeedRate.CurrentRapidMode);
        }

        //-- Set 100% Feedrate
        private void feedratePercent100_MouseDown(object sender, MouseEventArgs e)
        {
            int normalFeedRatePercentage = 0, rapidFeedRatePercentage = 0;

            ((Panel)sender).BackColor = Color.DarkRed;
            form_Mon_Monitor.SetFeedrateOveride100();
            form_Mon_Monitor.GetFTOveride(out normalFeedRatePercentage, out rapidFeedRatePercentage);

            Connection.CNCtoDT.SetFeedratePercentage(normalFeedRatePercentage, rapidFeedRatePercentage);
        }

        private void feedratePercent100_MouseUp(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.PaleTurquoise;
        }

        //-- Set Feedrate Up
        private void feedratePercentUp_MouseDown(object sender, MouseEventArgs e)
        {
            int normalFeedRatePercentage = 0, rapidFeedRatePercentage = 0;

            ((Panel)sender).BackColor = Color.DarkRed;
            form_Mon_Monitor.SetFTOveride(true);
            form_Mon_Monitor.GetFTOveride(out normalFeedRatePercentage, out rapidFeedRatePercentage);

            Connection.CNCtoDT.SetFeedratePercentage(normalFeedRatePercentage, rapidFeedRatePercentage);
        }

        private void feedratePercentUp_MouseUp(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.PaleTurquoise;
        }

        //-- Set Feedrate Down
        private void feedratePercentDown_MouseDown(object sender, MouseEventArgs e)
        {
            int normalFeedRatePercentage = 0, rapidFeedRatePercentage = 0;

            ((Panel)sender).BackColor = Color.DarkRed;
            form_Mon_Monitor.SetFTOveride(false);
            form_Mon_Monitor.GetFTOveride(out normalFeedRatePercentage, out rapidFeedRatePercentage);

            Connection.CNCtoDT.SetFeedratePercentage(normalFeedRatePercentage, rapidFeedRatePercentage);
        }

        private void feedratePercentDown_MouseUp(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.PaleTurquoise;
        }
        
        //====================================================
        // Home Light Panel
        //====================================================
        private void HomeLightPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);

            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));

            string axis = ((Panel)sender).Name.Substring(0, 1);
            axis = Convert.ToChar(Convert.ToInt32(axis[0]) - 32).ToString();

            panelGraphics.DrawString(axis, new Font(FontFamily.GenericSerif, 12f), brush,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }

        //====================================================
        // Limit Light Panel
        //====================================================
        private void LimitLightPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);

            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));

            string axis = ((Panel)sender).Name.Substring(0, 1);
            axis = Convert.ToChar(Convert.ToInt32(axis[0]) - 32).ToString();

            panelGraphics.DrawString(axis, new Font(FontFamily.GenericSerif, 12f), brush,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }

        //====================================================
        // EMG Stop Light Panel
        //====================================================
        private void emgStopLightPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = e.Graphics;
            panelGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2));

            if (ShareMemory.Switch.On == ShareMemory.EmgStopState)
            {
                emgStopLightPanel.BackColor = Color.Red;
                panelGraphics.DrawString("E-Stop", new Font(FontFamily.GenericSerif, 16f), Brushes.White,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
            else
            {
                if (!EStopWarningMsg)
                {
                    emgStopLightPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    panelGraphics.DrawString("Ready", new Font(FontFamily.GenericSerif, 16f), Brushes.Blue,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
                else
                {
                    emgStopLightPanel.BackColor = Color.Red;
                    panelGraphics.DrawString("E-Stop", new Font(FontFamily.GenericSerif, 16f), Brushes.White,
                                  new Rectangle(0, 0, ((Panel)sender).Width - 2, ((Panel)sender).Height - 2),
                                  new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
            }
        }



        public class CMessageFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == 0x201 || m.Msg == 0x202 || m.Msg == 0x203) return true;
                if (m.Msg == 0x204 || m.Msg == 0x205 || m.Msg == 0x206) return true;
                return false;
            }

            Rectangle BoundRect;
            Rectangle OldRect = Rectangle.Empty;

            public void EnableMouse()
            {
                Cursor.Clip = OldRect;
                Cursor.Show();
                Application.RemoveMessageFilter(this);
            }
            public void DisableMouse()
            {
                OldRect = Cursor.Clip;
                // Arbitrary location.
                BoundRect = new Rectangle(50, 50, 1, 1);
                Cursor.Clip = BoundRect;
                Cursor.Hide();
                Application.AddMessageFilter(this);
            }  
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ShareMemory.System.ProcessStateChange == ShareMemory.Switch.Off)
            {
                if (PROCESS.None == ShareMemory.System.ProcessState)
                {
                    ShareMemory.System.ProcessState = PROCESS.Connect;
                    ShareMemory.System.ProcessStateChange = ShareMemory.Switch.On;
                }
                else
                {
                    ShareMemory.System.ProcessState = PROCESS.Disconnect;
                    ShareMemory.System.ProcessStateChange = ShareMemory.Switch.On;

                    this.SetInitialState();
                }
            }
        }

        private void SetInitialState()
        {
            ShareMemory.Home.NotFirstTimeGo = false;

            foreach (Panel panel in this.home_panel)
            {
                panel.BackColor = Color.FromName("AppWorkspace");
            }

            ShareMemory.Home.HaveToGoHome = true;
            this.ncModeZrnPanel_Click(this.ncModeZrnPanel, new EventArgs());
        }
        

     
    }
}
