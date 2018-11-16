using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using JCNCShareMemory;
using JCNCDTCONECT;

namespace JCNC
{
    class ThreadRoutineRW
    {
        private AutoResetEvent autoEventOnRoutine;
        private bool isShutDown, isResetPush;
        private int tool_change_status;
        
        enum toolOP { read, write };
        enum TOOL { normal, changing, finish, remove_abnormal, abnormal };
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
        private bool EStop_msg, EStop_latch, EStop_abnormal, EStop_remove_abnormal, EStop_recover_panel_finish;

        public ThreadRoutineRW()
        {
            this.autoEventOnRoutine = new AutoResetEvent(true);
            this.isShutDown = false;
            this.tool_change_status = -3;
            this.EStop_abnormal = false;
            this.EStop_recover_panel_finish = false;
        }

        private bool running = false;
        public void RunThread()
        {
            //Console.WriteLine(Thread.CurrentThread.Name);
            if (false == Connection.CNCtoDT.InitCommBtwnCNCDT())
            {
                //Console.WriteLine("Error: Connection.CNCtoDT.InitCommBtwnCNCDT()");
            }

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            while (!this.isShutDown)
            {
                this.autoEventOnRoutine.WaitOne(100);  

                sw.Stop();//碼錶停止
                Console.WriteLine("{0}", sw.Elapsed.TotalMilliseconds);//印出所花費的總豪秒數

                sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
                sw.Reset();//碼表歸零
                sw.Start();//碼表開始計時
                
                ///////////////////////////////////////////////////////////////////////////////
                // start to work            ///////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////// 
                if (false == this.running)
                {
                    this.running = true;

                    this.GetInput();
                    this.RunProcess();
                    this.SetOutput();
                                        
                    this.running = false;
                }       
            }

            Console.WriteLine("Routine Thread: terminating gracefully.");
        }

        private void GetInput()
        {
            this.isShutDown = ShareMemory.isShutDown;

            if (false == Connection.CNCtoDT.ToolChangeState((int)toolOP.read, 0, out this.tool_change_status))
            {
                Console.WriteLine("Error: Connection.CNCtoDT.ToolChangeState(int)toolOP.read, 0, out this.tool_change_status)");
            }
            else
            {
                ShareMemory.TestAbnormal = tool_change_status;
            }

            this.EStop_msg = ShareMemory.EStopStatus[(int)ESTOP.msg];
            this.EStop_latch = ShareMemory.EStopStatus[(int)ESTOP.latch];
            this.EStop_remove_abnormal = ShareMemory.EStopStatus[(int)ESTOP.tool_remove_abnormal];
            this.EStop_recover_panel_finish = ShareMemory.EStopStatus[(int)ESTOP.recover_panel_finish];

            if (true == ShareMemory.isResetPush)
            {
                this.isResetPush = ShareMemory.isResetPush;
                ShareMemory.isResetPush = false;
            }

            for (int axis = 0; axis < ShareMemory.Home.AxisNum; axis++)
			{
                if (ShareMemory.Switch.On == ShareMemory.Home.Start[axis])
                {
                    this.home_start[axis] = ShareMemory.Home.Start[axis];
                    ShareMemory.Home.Start[axis] = ShareMemory.Switch.Off;
                    this.home_on_the_way = true;
                    this.home_step = HOME_STEP.SEND;
                }
			}

            if (ShareMemory.Switch.On == ShareMemory.Spindle.DirChange)
            {
                this.spindle_dir_change = ShareMemory.Spindle.DirChange;
                this.spindle_current_dir = ShareMemory.Spindle.CurrentDir;
                ShareMemory.Spindle.DirChange = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.System.CycleStartTrigger)
            {
                this.system_cycle_start_trigger = ShareMemory.System.CycleStartTrigger;
                this.system_get_program_step = true;
                ShareMemory.System.CycleStartTrigger = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.System.FeedHoldTrigger)
            {
                this.system_feed_hole_trigger = ShareMemory.System.FeedHoldTrigger;
                ShareMemory.System.FeedHoldTrigger = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.System.Reset)
            {
                this.system_reset = ShareMemory.System.Reset;
                ShareMemory.System.Reset = ShareMemory.Switch.Off;
            }

            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.MPG:
                    break;
                case ShareMemory.NcMode.JOG:
                    {
                        if (ShareMemory.Switch.On == ShareMemory.Jog.RapidModeChange)
                        {
                            this.jog_rapid_mode_change = ShareMemory.Jog.RapidModeChange;
                            this.jog_current_rapid_mode = ShareMemory.Jog.CurrentRapidMode;
                            ShareMemory.Jog.RapidModeChange = ShareMemory.Switch.Off;
                        }

                        for (int axis = 0; axis < ShareMemory.Jog.AxisNum; axis++)
                        {
                            if (ShareMemory.Switch.On == ShareMemory.Jog.DirChange[axis])
                            {
                                this.jog_dir_change[axis] = ShareMemory.Jog.DirChange[axis];
                                this.jog_current_dir[axis] = ShareMemory.Jog.CurrentDir[axis];
                                ShareMemory.Jog.DirChange[axis] = ShareMemory.Switch.Off;
                            }
                        }
                        break;
                    }
                case ShareMemory.NcMode.INCJOG:
                    {
                        for (int axis = 0; axis < ShareMemory.IncJog.AxisNum; axis++)
                        {
                            if (ShareMemory.Switch.On == ShareMemory.Jog.DirChange[axis])
                            {
                                // for incjog process
                                if (ShareMemory.Jog.Stop != ShareMemory.Jog.CurrentDir[axis])
                                {
                                    this.incjog_start[axis] = ShareMemory.Switch.On;
                                    this.incjog_finish[axis] = ShareMemory.Switch.Off;
                                }

                                // use jog method
                                this.jog_dir_change[axis] = ShareMemory.Jog.DirChange[axis];
                                this.jog_current_dir[axis] = ShareMemory.Jog.CurrentDir[axis];
                                ShareMemory.Jog.DirChange[axis] = ShareMemory.Switch.Off;
                            }
                        }
                        break;
                    }
                default:
                    break;
            }

            if (ShareMemory.Switch.On == ShareMemory.Spindle.SpeedPercentageChange)
            {
                this.spindle_speed_percentage_change = ShareMemory.Spindle.SpeedPercentageChange;
                this.spindle_current_speed_percentage = ShareMemory.Spindle.CurrentSpeedPercentage;
                ShareMemory.Spindle.SpeedPercentageChange = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.Parameter.Homing.Enable)
            {               
                this.parameter_homing = ShareMemory.Parameter.Homing;
                this.parameter_homing_z_first = ShareMemory.Home.ZFirst;
                ShareMemory.Parameter.Homing.Enable = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.Parameter.WorkAreaLimit.Enable)
            {
                this.parameter_work_area_limit = ShareMemory.Parameter.WorkAreaLimit;
                ShareMemory.Parameter.WorkAreaLimit.Enable = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.Parameter.Servo.Enable)
            {
                this.parameter_servo = ShareMemory.Parameter.Servo;
                ShareMemory.Parameter.Servo.Enable = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.System.UploadMDIFile)
            {
                this.upload_MDI_file = ShareMemory.System.UploadMDIFile;
                ShareMemory.System.UploadMDIFile = ShareMemory.Switch.Off;
            }
            
            if (ShareMemory.Switch.On == ShareMemory.ToolPos.UploadCoordinate)
            {
                this.tool_pos_upload_coordinate = ShareMemory.ToolPos.UploadCoordinate;
                this.tool_pos_current_tool_num = ShareMemory.ToolPos.current_tool_num;
                this.tool_pos_current_coordinate = ShareMemory.ToolPos.current_coordinate;
                ShareMemory.ToolPos.UploadCoordinate = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.System.ProcessStateChange)
            {
                this.process_state = ShareMemory.System.ProcessState;
                ShareMemory.System.ProcessStateChange = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.System.SingleBlockChange)
            {
                this.single_block_change = ShareMemory.System.SingleBlockChange;
                this.current_single_block = ShareMemory.System.CurrentSingleBlock;
                ShareMemory.System.SingleBlockChange = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.System.M01Change)
            {
                this.m01_change = ShareMemory.System.M01Change;
                this.current_m01 = ShareMemory.System.CurrentM01;
                ShareMemory.System.M01Change = ShareMemory.Switch.Off;
            }
            
            if (ShareMemory.Switch.On == ShareMemory.System.ClntAutoChange)
            {
                this.clnt_auto_change = ShareMemory.System.ClntAutoChange;
                this.current_clnt_auto = ShareMemory.System.CurrentClntAuto;
                ShareMemory.System.ClntAutoChange = ShareMemory.Switch.Off;
            }
            
            if (ShareMemory.Switch.On == ShareMemory.System.ClntManualChange)
            {
                this.clnt_manual_change = ShareMemory.System.ClntManualChange;
                this.current_clnt_manual = ShareMemory.System.CurrentClntManual;
                ShareMemory.System.ClntManualChange = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.System.AirBlowChange)
            {
                this.air_blow_change = ShareMemory.System.AirBlowChange;
                this.current_air_blow = ShareMemory.System.CurrentAirBlow;
                ShareMemory.System.AirBlowChange = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.System.BDTChange)
            {
                this.bdt_change = ShareMemory.System.BDTChange;
                this.current_bdt = ShareMemory.System.CurrentBDT;
                ShareMemory.System.BDTChange = ShareMemory.Switch.Off;
            }

            if (ShareMemory.Switch.On == ShareMemory.ToolPos.ToolHeightSensorChange)
            {
                this.tool_height_sensor_change = ShareMemory.ToolPos.ToolHeightSensorChange;
                this.current_tool_height_sensor = ShareMemory.ToolPos.CurrentToolHeightSensor;
                ShareMemory.ToolPos.ToolHeightSensorChange = ShareMemory.Switch.Off;
            }
        }

        private void RunProcess()
        {
            switch (this.process_state)
            {
                case PROCESS.Connect:   // connect
                    if (false == Connection.CNCtoDT.JCNCDTComm())
                    {
                        Console.WriteLine("Error: Connection.CNCtoDT.JCNCDTComm()");
                    }
                    else
                    {
                        this.process_state = PROCESS.Initial;
                        this.process_state_change = ShareMemory.Switch.On;
                    }                   
                    break;
                case PROCESS.Disconnect:                    
                    Connection.CNCtoDT.JCNCDTCommClose();  
                    
                    this.process_state = PROCESS.None;
                    this.process_state_change = ShareMemory.Switch.On;
                    
                    break;
                case PROCESS.Initial:   // initial
                    if (false == Connection.CNCtoDT.InitPPMACEnv())
                    {
                        Console.WriteLine("Error: Connection.CNCtoDT.InitPPMACEnv()");
                        this.process_state = PROCESS.None;
                        this.process_state_change = ShareMemory.Switch.On;
                    }
                    else
                    {
                        this.process_state = PROCESS.Normal;
                        this.process_state_change = ShareMemory.Switch.On;
                    }
                    break;
                case PROCESS.Normal:   // normal
                    Process();
                    break;
                default:
                    break;
            }
        }
        private void Process()
        {
            string[] AxisName = new string[] { "X", "Y", "Z", "C" };

            #region Parameter
            //====================================================
            // Parameter
            //====================================================
            /*- Set Homing Parameter -*/
            if (ShareMemory.Switch.On == this.parameter_homing.Enable)
            {
                Connection.CNCtoDT.SetParameterHomingGroup(this.parameter_homing.Command,
                                                           this.parameter_homing.Axis, this.parameter_homing.Value);
                Connection.CNCtoDT.SetParameterHomingZFirst(this.parameter_homing_z_first);
                this.parameter_homing.Enable = ShareMemory.Switch.Off;
            }
            /*- Set Work Area Limit Parameter -*/
            if (ShareMemory.Switch.On == this.parameter_work_area_limit.Enable)
            {
                Connection.CNCtoDT.SetParameterSoftLimitGroup(this.parameter_work_area_limit.Command,
                                                              this.parameter_work_area_limit.Axis, this.parameter_work_area_limit.Value);
                this.parameter_work_area_limit.Enable = ShareMemory.Switch.Off;
            }
            /*- Set Servo Parameter -*/
            if (ShareMemory.Switch.On == this.parameter_servo.Enable)
            {
                Connection.CNCtoDT.SetParameterServoGroup(this.parameter_servo.Command,
                                                              this.parameter_servo.Axis, this.parameter_servo.Value);
                this.parameter_servo.Enable = ShareMemory.Switch.Off;
            }
            /*- Set Tool Position Parameter -*/
            if (ShareMemory.Switch.On == this.tool_pos_upload_coordinate)
            {
                Connection.CNCtoDT.UploadSingleToolPosData(this.tool_pos_current_tool_num, this.tool_pos_current_coordinate);
                this.tool_pos_upload_coordinate = ShareMemory.Switch.Off;
            }
            #endregion

            #region System 
            //====================================================
            // System MDI
            //====================================================
            /*- Upload MDI File -*/
            if (ShareMemory.Switch.On == this.upload_MDI_file)
            {
                string input_file_path = @".\tmp\MDICmd.NC";
                string file_source = "MDI";
                NCFormatFile.NcFormat ncFormat = new NCFormatFile.NcFormat(input_file_path, file_source);
                bool ret = ncFormat.FormatFile();
                if (false == Connection.CNCtoDT.FileUploadToPPMAC("NCFile\\", "MDI.NC"))
                {
                    Console.WriteLine("Error: Connection.CNCtoDT.FileUploadToPPMAC(MDI.NC)");
                }

                this.upload_MDI_file = ShareMemory.Switch.Off;
            }

            //====================================================
            // System Reset
            //====================================================
            /*- Set Reset Process -*/
            if (ShareMemory.Switch.On == this.system_reset)
            {
                Connection.CNCtoDT.SetCycleStart(ShareMemory.Switch.Off);
                Connection.CNCtoDT.SetFeedHold(ShareMemory.Switch.Off);
                this.system_reset = ShareMemory.Switch.Off;
            }

            //====================================================
            // System Cycle Start
            //====================================================
            /*- Get Program Step -*/
            if (true == this.system_get_program_step)
            {
                Connection.CNCtoDT.GetProgramStep(out this.system_current_program_step);           
            }
            /*- Cycle Start Trigger -*/
            if (ShareMemory.Switch.On == this.system_cycle_start_trigger)
            {
                switch (this.system_current_program_step)
                {   
                    case ShareMemory.System.ProgramIdle:
                        Connection.CNCtoDT.SetCycleStart(this.system_cycle_start_trigger);
                        break;
                    case ShareMemory.System.ProgramRunning:
                        this.system_cycle_start_trigger = ShareMemory.Switch.Off;
                        Connection.CNCtoDT.SetCycleStart(this.system_cycle_start_trigger);
                        break;
                    case ShareMemory.System.ProgramFeedHold:
                        Connection.CNCtoDT.SetCycleStart(this.system_cycle_start_trigger);
                        break;
                    case ShareMemory.System.ProgramDone:
                        break;
                    case ShareMemory.System.ProgramSingleStep:
                        Connection.CNCtoDT.SetCycleStart(this.system_cycle_start_trigger);
                        break;
                    default:
                        break;
                }
            }
            /*- Program Step Reset -*/
            if (true == this.system_reset_program_step)
            {
                Connection.CNCtoDT.SetProgramIdle();
                this.system_reset_program_step = false;
            }
            /*- Feed Holde Trigger -*/
            if (ShareMemory.Switch.On == this.system_feed_hole_trigger)
            {
                switch (this.system_current_program_step)
                {
                    case ShareMemory.System.ProgramIdle:                        
                        break;
                    case ShareMemory.System.ProgramRunning:
                        Connection.CNCtoDT.SetFeedHold(this.system_feed_hole_trigger);
                        break;
                    case ShareMemory.System.ProgramFeedHold:
                        this.system_feed_hole_trigger = ShareMemory.Switch.Off;
                        Connection.CNCtoDT.SetFeedHold(this.system_feed_hole_trigger);
                        break;
                    case ShareMemory.System.ProgramDone:
                        break;
                    case ShareMemory.System.ProgramSingleStep:
                        break;
                    default:
                        break;
                }
            }
            /*- Single Block -*/
            if (ShareMemory.Switch.On == this.single_block_change)
            {
                Connection.CNCtoDT.SetSingleBlock(this.current_single_block);
                this.single_block_change = ShareMemory.Switch.Off;
            }

            /*- M01 -*/
            if (ShareMemory.Switch.On == this.m01_change)
            {
                Connection.CNCtoDT.SetM01(this.current_m01);
                this.m01_change = ShareMemory.Switch.Off;
            }
            
            /*- CLNT Auto -*/
            bool isAuto = true;
            if (ShareMemory.Switch.On == this.clnt_auto_change)
            {
                Connection.CNCtoDT.SetWashDownMotorState(isAuto, this.current_clnt_auto);
                this.clnt_auto_change = ShareMemory.Switch.Off;
            }

            /*- CLNT Manual -*/
            isAuto = false;
            if (ShareMemory.Switch.On == this.clnt_manual_change)
            {
                Connection.CNCtoDT.SetWashDownMotorState(isAuto, this.current_clnt_manual);
                this.clnt_manual_change = ShareMemory.Switch.Off;
            }

            /*- Air Blow -*/
            if (ShareMemory.Switch.On == this.air_blow_change)
            {
                Connection.CNCtoDT.SetAirBlowState(this.current_air_blow);
                this.air_blow_change = ShareMemory.Switch.Off;
            }

            /*- BDT -*/
            if (ShareMemory.Switch.On == this.bdt_change)
            {
                Connection.CNCtoDT.SetBDTState(this.current_bdt);
                this.bdt_change = ShareMemory.Switch.Off;
            }
            #endregion

            

            #region Home
            //====================================================
            // Homing Check Routine
            //====================================================
            /*- Single Home Check -*/
            if (true == this.home_on_the_way)
            {
                switch (this.home_step)
                {
                    case HOME_STEP.SEND:
                        for (int axis = 0; axis < ShareMemory.Home.AxisNum; axis++)
                        {
                            if (ShareMemory.Switch.On == this.home_start[axis])
                            {
                                Connection.CNCtoDT.SetSingleHomeStatus(axis);
                            }
                        }
                        this.home_step = HOME_STEP.RECEIVE;
                        break;
                    case HOME_STEP.RECEIVE:
                        int match_num = 0;
                        for (int axis = 0; axis < ShareMemory.Home.AxisNum; axis++)
                        {
                            if (ShareMemory.Switch.On == this.home_start[axis])
                            {
                                if (false == Connection.CNCtoDT.GetSingleHomeStatus(axis, out this.home_finish[axis]))
                                {
                                    Console.WriteLine("Error: GetSingleHomeStatus(" + axis.ToString() + " )");
                                }
                            }
                            if (this.home_start[axis] == this.home_finish[axis])
                            {
                                match_num++;
                            }
                        }

                        if (ShareMemory.Home.AxisNum == match_num)
                        {
                            this.home_on_the_way = false;
                            this.home_arrival = true;
                        }
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region Tool
            //====================================================
            // Tool Height Sensor
            //====================================================
            if (ShareMemory.Switch.On == this.tool_height_sensor_change)
            {
                Connection.CNCtoDT.SetToolHeightSensor(this.current_tool_height_sensor);
                this.tool_height_sensor_change = ShareMemory.Switch.Off;
            }


            #endregion

            #region Jog
            //====================================================
            // Jog Mode
            //====================================================
            /*- Set Current Jog Rapid Mode -*/
            if (ShareMemory.Switch.On == this.jog_rapid_mode_change)
            {
                Connection.CNCtoDT.SetJogRapidMode(this.jog_current_rapid_mode);
                this.jog_rapid_mode_change = ShareMemory.Switch.Off;
            }
            /*- Set Current Jog Direction -*/
            for (int axis = 0; axis < ShareMemory.Jog.AxisNum; axis++)
            {
                if (ShareMemory.Switch.On == this.jog_dir_change[axis])
                {
                    Connection.CNCtoDT.SetJogDirection(axis, this.jog_current_dir[axis]);
                    this.jog_dir_change[axis] = ShareMemory.Switch.Off;
                }
            }
            #endregion

            #region IncJog
            //====================================================
            // IncJog Mode
            //====================================================
            /*- Start to get finish signal -*/
            for (int axis = 0; axis < ShareMemory.IncJog.AxisNum; axis++)
            {
                if (ShareMemory.Switch.On == this.incjog_start[axis])
                {
                    Connection.CNCtoDT.GetIncJogFinish(axis, out this.incjog_finish[axis]);
                }
            }
            #endregion

            #region Spindle
            //====================================================
            // Spindle CW & CCW
            //====================================================
            /*- Set Current Spindle Direction -*/
            if (ShareMemory.Switch.On == this.spindle_dir_change)
            {
                Connection.CNCtoDT.SetSpindleManualDirection(this.spindle_current_dir);
                this.spindle_dir_change = ShareMemory.Switch.Off;
            }
            /*- Set Current Spindle Speed Percentage -*/
            if (ShareMemory.Switch.On == this.spindle_speed_percentage_change)
            {
                Connection.CNCtoDT.SetSpindleSpeedPercentage(this.spindle_current_speed_percentage);
                this.spindle_speed_percentage_change = ShareMemory.Switch.Off;
            }
            #endregion

            #region System Routine
            //====================================================
            // System Routine
            //====================================================
            /*- Controller Initial Complete -*/
            if (ShareMemory.Switch.Off == this.init_complete)
            {
                if (false == Connection.CNCtoDT.GetControllerInitComplete(out this.init_complete))
                {
                    Console.WriteLine("Error: GetControllerInitComplete(this.init_complete)");
                }
            }

            /*- EMG Stop State -*/
            if (ShareMemory.Switch.Off == this.init_complete)
            {
                if (false == Connection.CNCtoDT.GetEmgLatch(out this.emg_latch))
                {
                    Console.WriteLine("Error: GetEmgStopState(this.emg_latch)");
                }
                //   CH_Input(17)
            }
            else
            {
                if (false == Connection.CNCtoDT.GetEmgStopState(out this.emg_stop_state))
                {
                    Console.WriteLine("Error: GetEmgStopState(this.emg_stop_state)");
                }
            }
            #endregion

            #region Coordinate System Routine
            //====================================================
            // Coordinate System Routine
            //====================================================
    
            for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
            {        
                /*- Machine Coordinate -*/
                if (false == Connection.CNCtoDT.GetMachineCoordinate(axis, out this.machine_coordinate[axis]))
                {
                    Console.WriteLine("Error: GetMachineCoordinate(" + AxisName[axis] + ")");
                }  
                /*- Program Coordinate -*/
                if (false == Connection.CNCtoDT.GetProgramCoordinate(axis, out this.program_coordinate[axis]))
                {
                    Console.WriteLine("Error: GetProgramCoordinate(X, Y, Z)");
                }
                /*- Distance to Go -*/
                if (false == Connection.CNCtoDT.GetDistanceToGo(axis, out this.distance_togo[axis]))
                {
                    Console.WriteLine("Error: GetDistanceToGo(X, Y, Z)");
                }
            }          
            /*- Program Line Number -*/
            if (false == Connection.CNCtoDT.GetProgLineNum(out this.program_line_num))
            {
                Console.WriteLine("Error: GetProgLineNum(this.program_line_num)");
            }
            #endregion

            #region Motor Status Routine
            //====================================================
            // Motor Status Routine
            //====================================================
            /*- Spindle Speed -*/
            if (false == Connection.CNCtoDT.CurrentSpindleSpeed(out this.spindle_speed))
            {
                Console.WriteLine("Error: CurrentSpindleSpeed(this.spindle_speed)");
            }

            /*- Feed Rate -*/
            if (false == Connection.CNCtoDT.CurrentFeedRate(out this.feedrate))
            {
                Console.WriteLine("Error: CurrentFeedRate(this.feedrate)");
            }

            /*- Auto Compensation Status -*/
            if (false == Connection.CNCtoDT.GetAutoCompStatus(out this.auto_compensation_status))
            {
                Console.WriteLine("Error: GetAutoCompStatus(this.auto_compensation_status)");
            }

            /*- Tool Num -*/
            if (false == Connection.CNCtoDT.CurrentToolNum(out this.tool_num, out this.tool_compensation_value))
            {
                Console.WriteLine("Error: CurrentToolNum(this.tool_num, this.tool_compensation_value)");
            }

            /*- Compensation Num -*/
            if (false == Connection.CNCtoDT.CurrentCompensationNum(out this.H_num, out this.D_num))
            {
                Console.WriteLine("Error: CurrentCompensationNum()");
            }
            #endregion

            #region Feedrate RW Routine
            //====================================================
            // Feedrate RW Routine
            //====================================================
            /*- Get Feedrate Value -*/
            if (false == Connection.CNCtoDT.GetFeedrateValue())
            {
                // Console.WriteLine("Error: Connection.CNCtoDT.GetFeedrateValue()");
            }
            #endregion

            #region Tool Change RW Routine
            //====================================================
            // Tool Chagne RW Routine
            //====================================================
            /*- Get Feedrate Value -*/
            switch (this.tool_change_status)
            {
                case (int)TOOL.changing:
                    if (((true == this.EStop_msg) && (true == this.EStop_latch)) || (true == this.isResetPush))
                    {
                        if (true == this.isResetPush)
                        {
                            this.isResetPush = false;
                        }

                        this.EStop_abnormal = true;
                    }
                    break;

                case (int)TOOL.abnormal:
                    if (true == this.EStop_remove_abnormal)
                    {
                        this.tool_change_status = (int)TOOL.remove_abnormal;
                    }
                    break;
                case (int)TOOL.finish:
                case (int)TOOL.normal:
                default:
                    this.isResetPush = false;
                    break;
            }
            #endregion
        }

        #region VARIABLE
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////                     ＶＡＲＩＡＢＬＥ                                                 ///////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        private int tool_pos_upload_coordinate = -1, tool_pos_current_tool_num = -1, tool_pos_current_coordinate = -1;

        private double[] machine_coordinate = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] program_coordinate = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] distance_togo = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private int program_line_num = 0;

        private int spindle_speed = 0, feedrate = 0, auto_compensation_status = 0;
        private int tool_num = -1;
        private double tool_compensation_value = 0.0;
        private int H_num = -1, D_num = -1;

        private enum HOME_STEP { NONE, SEND, RECEIVE };
        private HOME_STEP home_step = HOME_STEP.NONE;
        private int[] home_start = new int[ShareMemory.Home.AxisNum] { 0, 0, 0 };
        private int[] home_finish = new int[ShareMemory.Home.AxisNum] { 0, 0, 0 };
        private bool home_on_the_way = false;
        private bool home_arrival = false;

        private int jog_rapid_mode_change = 0;
        private int jog_current_rapid_mode = 0;
        private int[] jog_dir_change = new int[ShareMemory.Jog.AxisNum] { 0, 0, 0 };
        private int[] jog_current_dir = new int[ShareMemory.Jog.AxisNum] { 0, 0, 0 };

        private int[] incjog_start = new int[ShareMemory.Jog.AxisNum] { 0, 0, 0 };
        private int[] incjog_finish = new int[ShareMemory.Jog.AxisNum] { 0, 0, 0 };

        private int spindle_dir_change = 0;
        private int spindle_current_dir = 0;////////////////////////
        private int spindle_speed_percentage_change = 0;
        private int spindle_current_speed_percentage = 0;

        private int emg_stop_state = 0;
        private int init_complete = 0;
        private int emg_latch = 1;

        private int system_cycle_start_trigger = 0;
        private int system_current_program_step = 0;
        private bool system_get_program_step = false;
        private bool system_reset_program_step = false;
        
        private int system_feed_hole_trigger = 0;

        private int system_reset = 0;

        private ShareMemory._Parameter parameter_homing;
        private ShareMemory._Parameter parameter_work_area_limit;
        private ShareMemory._Parameter parameter_servo;

        private bool parameter_homing_z_first = false;
        private bool system_init_complete = false;

        NCFormatFile.NcFormat ncFormat = new NCFormatFile.NcFormat();
        private int upload_MDI_file = 0;

        private PROCESS process_state = PROCESS.None;
        private int process_state_change = 0;

        private int single_block_change = 0;
        private bool current_single_block = false;
        
        private int m01_change = 0;
        private bool current_m01 = false;
        
        private int clnt_auto_change = 0;
        private bool current_clnt_auto = false;

        private int clnt_manual_change = 0;
        private bool current_clnt_manual = false;
        
        private int air_blow_change = 0;
        private bool current_air_blow = false;

        private int bdt_change = 0;
        private bool current_bdt = false;
        
        private int tool_height_sensor_change = 0;
        private string current_tool_height_sensor = string.Empty;

        #endregion

        private void SetOutput()
        {
            if (ShareMemory.Switch.On == this.process_state_change)
            {
                ShareMemory.System.ProcessState = this.process_state;
                ShareMemory.System.ProcessStateChange = this.process_state_change;
                this.process_state_change = ShareMemory.Switch.Off;
            }

            // EMG Stop State 
            ShareMemory.EmgStopState = this.emg_stop_state;
            ShareMemory.System.EmgLatch = this.emg_latch;

            // Controller Init Complete
            ShareMemory.System.InitComplete = this.init_complete;

            //
            for (int axis_num = 0; axis_num < ShareMemory.CS.AxisNum; axis_num++)
            {
                // Machine Coordinate
                ShareMemory.CS.Machine[axis_num] = this.machine_coordinate[axis_num];
                // Program Coordinate
                ShareMemory.CS.Prog[axis_num] = this.program_coordinate[axis_num];
                // Distance to Go
                ShareMemory.CS.DistToGo[axis_num] = this.distance_togo[axis_num];
            }
            // Command Block Index
            ShareMemory.ProgramLineNum = this.program_line_num;
            
            // Current Spindle Speed
            ShareMemory.SpindleSpeed = this.spindle_speed;
            
            // Auto Compensation Status
            ShareMemory.AutoCompStatus = this.auto_compensation_status;

            // Current Tool Num
            ShareMemory.CurrentToolNum = this.tool_num;
            ShareMemory.CurrentToolCompValue = this.tool_compensation_value;

            // Current Compensation Num
            ShareMemory.CurrentHNum = this.H_num;
            ShareMemory.CurrentDNum = this.D_num;

            // axis homing
            if (true == this.home_on_the_way)
            {
                for (int axis = 0; axis < ShareMemory.Home.AxisNum; axis++)
                {
                    ShareMemory.Home.Finish[axis] = this.home_finish[axis];
                }
            }
            if (true == this.home_arrival)
            {
                for (int axis = 0; axis < ShareMemory.Home.AxisNum; axis++)
                {
                    ShareMemory.Home.Finish[axis] = this.home_finish[axis];

                    this.home_start[axis] = ShareMemory.Switch.Off;
                    this.home_finish[axis] = ShareMemory.Switch.Off;
                }
                
                ShareMemory.Home.OnTheWay = this.home_on_the_way;
                ShareMemory.Home.Arrival = this.home_arrival;
                this.home_arrival = false;
            }

            // system cycle start
            if (true == this.system_get_program_step)
            {
                ShareMemory.System.CurrentProgramStep = this.system_current_program_step;
                if (ShareMemory.System.ProgramDone == this.system_current_program_step)
                {
                    this.system_get_program_step = false;
                    this.system_reset_program_step = true;
                }
            }

            
            // tool change
            int temp = 0;
            if (true == this.EStop_remove_abnormal)
            {
                this.EStop_remove_abnormal = false;
                ShareMemory.EStopStatus[(int)ESTOP.tool_remove_abnormal] = this.EStop_remove_abnormal;

                if (false == Connection.CNCtoDT.ToolChangeState((int)toolOP.write, (int)TOOL.remove_abnormal, out temp))
                {
                    Console.WriteLine("Error: Connection.CNCtoDT.ToolChangeState((int)toolOP.read, 0, out this.(int)TOOL.(int)TOOL.reove_abnormal)");
                }

                ShareMemory.EStopStatus[(int)ESTOP.recover_panel] = true;
            }
            if (true == this.EStop_recover_panel_finish)
            {
                this.EStop_recover_panel_finish = false;
                ShareMemory.EStopStatus[(int)ESTOP.recover_panel_finish] = this.EStop_recover_panel_finish;
            }
            if (true == this.EStop_abnormal)
            {
                if (false == Connection.CNCtoDT.ToolChangeState((int)toolOP.write, (int)TOOL.remove_abnormal, out temp))
                {
                    Console.WriteLine("Error: Connection.CNCtoDT.ToolChangeState((int)toolOP.write, (int)TOOL.remove_abnormal, out temp)");
                }
                ShareMemory.EStopStatus[(int)ESTOP.tool_abnormal] = this.EStop_abnormal;

                this.EStop_abnormal = false;
            }

            switch (ShareMemory.NcMode.value)
            {
                case ShareMemory.NcMode.JOG:
                    break;
                case ShareMemory.NcMode.INCJOG:
                    {
                        for (int axis = 0; axis < ShareMemory.IncJog.AxisNum; axis++)
                        {
                            if ((ShareMemory.Switch.On == this.incjog_start[axis])&&(ShareMemory.Switch.On ==this.incjog_finish[axis]))
                            {
                                ShareMemory.IncJog.Finish[axis] = ShareMemory.Switch.On;
                                this.incjog_start[axis] = ShareMemory.Switch.Off;
                                this.incjog_finish[axis] = ShareMemory.Switch.Off;
                            }
                        }
                        break;
                    }
                default:
                    break;
            }

        }

        
    }
}
