using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCNCShareMemory
{
    public enum PROCESS { None, Connect, Disconnect, Initial, Normal }

    public partial class ShareMemory
    {        
        public const int AxisNum = 4;

        public const int X = 0;
        public const int Y = 1;
        public const int Z = 2;
        public const int C = 3;

        public static int[] LogNum = new int[AxisNum] { 0, 1, 2, 3 };
        public static int[] PhyNum = new int[AxisNum] { 1, 2, 3, 4 };
        
        public struct Switch
        {
            public const int On = 1;
            public const int Off = 0;
        }

        public struct NcMode
        {
            public const int Auto = 0;
            public const int Manual = 1;
            public const int MEM = 2;
            public const int MDI = 3;
            public const int ZRN = 4;
            public const int MPG = 5;
            public const int JOG = 6;
            public const int INCJOG = 7;
            public static int value = ZRN;
            public const int num = 8;
        }

        public struct Compensate
        {
            public const int Num = 0;
            public const int Height = 1;
            public const int HWaste = 2;
            public const int Diameter = 3;
            public const int DWaste = 4;
        }

        public struct _Parameter
        {
            public int Enable;
            public int Axis;
            public int Command;
            public double Value;                                                                                                                                                                                                                                                              
            public void Set(int enable, int axis, int command, double value)
            {
                this.Axis = axis;
                this.Command = command;
                this.Value = value;
                this.Enable = enable;
            }
        }

        public class Parameter
        {
            public static _Parameter Homing;
            public static _Parameter WorkAreaLimit;
            public static _Parameter Servo;
        }

        public class System
        {
            public const int ProgramIdle = 0;      // 程式執行, 等待情況
            public const int ProgramRunning = 1;   // 程式執行, 程式執行中
            public const int ProgramFeedHold = 2;  // 程式執行, 程式暫停
            public const int ProgramDone = 3;      // 程式執行, 程式完成
            public const int ProgramSingleStep = 4;// 程式執行, 單步執行

            public static int CurrentProgramStep = 0;

            public static int CycleStartTrigger = 0;
            public static int FeedHoldTrigger = 0;

            public static int Reset = 0;

            public static int UploadMDIFile = 0;

            public static int InitComplete = 0;
            public static int EmgLatch = 1;

            public static int ProcessStateChange = 0;
            public static PROCESS ProcessState = PROCESS.None;

            public static int SingleBlockChange = 0;
            public static bool CurrentSingleBlock = false;

            public static int M01Change = 0;
            public static bool CurrentM01 = false;

            public static int ClntAutoChange = 0;
            public static bool CurrentClntAuto = false;

            public static int ClntManualChange = 0;
            public static bool CurrentClntManual = false;
            
            public static int AirBlowChange = 0;
            public static bool CurrentAirBlow = false;

            public static int BDTChange = 0;
            public static bool CurrentBDT = false;
                         
        }

        public class FeedRate
        {
            public static int RapidModeChange = 0;
            public static int CurrentRapidMode = 0;

            public static int NormalPercentage = 0;
            public static int RapidPercentage = 0;
        }

        public class Spindle
        {
            public const int Plus = 1;
            public const int Stop = 0;
            public const int Minus = -1;

            public static int DirChange = 0;
            public static int CurrentDir = 0;

            public static int SpeedPercentageChange = 0;
            public static int CurrentSpeedPercentage = 100;
        }

        public class IncJog
        {
            public const int AxisNum = 3;

            public static int[] Finish = new int[AxisNum] { 0, 0, 0 };
        }

        public class Jog
        {
            public const int AxisNum = 3;

            public const int Plus = 1;
            public const int Stop = 0;
            public const int Minus = -1;
            
            public static int RapidModeChange = 0;
            public static int CurrentRapidMode = 0;

            public static int[] DirChange = new int[AxisNum] { 0, 0, 0 };
            public static int[] CurrentDir = new int[AxisNum] { 0, 0, 0 };
        }

        public class ToolPos
        {
            public const int AxisNum = 3;
            public const int MaxToolNum = 10;

            public static int current_tool_num = 0, current_coordinate = 0;
            
            public static int UploadCoordinate = 0;
            public static string[] xCoordiante = new string[MaxToolNum] { "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000" };
            public static string[] yCoordiante = new string[MaxToolNum] { "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000" };
            public static string[] zCoordiante = new string[MaxToolNum] { "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000", "0.000" };
            public static string[][] Coordiante = new string[AxisNum][] { xCoordiante, yCoordiante, zCoordiante };

            public static int UploadInitialData = 0;

            public static string CurrentToolHeightSensor = "0.000";
            public static int ToolHeightSensorChange = 0;
        }

        public class Home
        {
            public const int AxisNum = 3;

            public static int[] Start = new int[AxisNum] { 0, 0, 0 };
            public static int[] Finish = new int[AxisNum] { 0, 0, 0 };

            public static bool OnTheWay = false;
            public static bool Arrival = false;
            public static bool NotFirstTimeGo = false;

            public static bool All = false;
            public static bool Single = false;

            public static bool ZFirst = false;

            public static bool HaveToGoHome = true;
        }

        public class CS
        {
            public const int AxisNum = 3;

            public static double[] Machine = new double[AxisNum] { 0.0, 0.0, 0.0 };
            public static double[] Prog = new double[AxisNum] { 0.0, 0.0, 0.0 };
            public static double[] Rel = new double[AxisNum] { 0.0, 0.0, 0.0 };
            public static double[] RelOffset = new double[AxisNum] { 0.0, 0.0, 0.0 };
            public static double[] DistToGo = new double[AxisNum] { 0.0, 0.0, 0.0 };

            public static int Swich = 0;
        }

        public static double FeedrateValue;
     
        public static class SoftLimit
        {
            public const int AxisNum = 3;

            public static double[] MaxValue = new double[AxisNum] { 0.0, 0.0, 0.0 };
            public static double[] MinValue = new double[AxisNum] { 0.0, 0.0, 0.0 };

            public static bool[] isMaxON = new bool[AxisNum] { false, false, false };
            public static bool[] isMinON = new bool[AxisNum] { false, false, false };
        }

        //private static int _MDICmdTotalNum;
        //public static int MDICmdTotalNum
        //{
        //    get { return _MDICmdTotalNum; }
        //    set { _MDICmdTotalNum = value; }
        //}

        //private static int _MEMCmdTotalNum;
        //public static int MEMCmdTotalNum
        //{
        //    get { return _MEMCmdTotalNum; }
        //    set { _MEMCmdTotalNum = value; }
        //}
        
        public static double ElectricalGearRatio;

        public static double SpindleMaxSpeed;
        public static int SpindleSpeed; // rev/min
        public static int CurrentFeedRate; // rev/min

        public static int CurrentToolNum;
        public static double CurrentToolCompValue;

        public static int CurrentHNum;
        public static int CurrentDNum;
        public static double CurrentHNumVal;
        public static double CurrentDNumVal;

        public static int AutoCompStatus;

        public static double JogSpeed;

        public static int ProgramLineNum;
        
        public static int EmgStopState;
        
        // Define Motor Class
        public class COffset
        {
            public COffset()
            {
            }
            public const int G54_num = 16;
            public static string[] G54_name = new string[G54_num] { "G54000", "G54101", "G54102", "G54103", "G54104", "G54105",
                                                                    "G54106", "G54107", "G54108", "G54109", "G54110", "G54111",
                                                                    "G54112", "G54113", "G54114", "G54115"};
            public static double[] G54000Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54101Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54102Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54103Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54104Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54105Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54106Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54107Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54108Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54109Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54110Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54111Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54112Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54113Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54114Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G54115Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[][] Value_G54 = new double[][]
            {
                G54000Value, G54101Value, G54102Value, G54103Value, G54104Value, G54105Value, G54106Value, G54107Value, 
                G54108Value, G54109Value, G54110Value, G54111Value, G54112Value, G54113Value, G54114Value, G54115Value
            };

            public const int G5X_num = 6;
            public const int G54 = 0, G55 = 1, G56 = 2, G57 = 3, G58 = 4, G59 = 5;
            public static string[] G5X_name = new string[G5X_num] { "G54000", "G55000", "G56000", "G57000", "G58000", "G59000" };
            public static double[] G55000Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G56000Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G57000Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G58000Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[] G59000Value = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            public static double[][] Value_G5X = new double[][] {G54000Value, G55000Value, G56000Value, G57000Value, G58000Value, G59000Value };

            public static string EXT_name = "EXT";
            public static double[] EXTValue = new double[AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        }

    }
}
