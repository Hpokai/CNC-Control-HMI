using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace JCNCShareMemory
{
    public enum MCT_Flag { JOG = 0, INCJOG = 1, ZRN = 2, MPG = 3, MDI = 4, MEM = 5 };

    public partial class ShareMemory
    {
        public ShareMemory()
        {
        }

        public static bool[, ,] LevSubFFunc = new bool[6, 25, 6]; //[Lev, subfunc, mainfunc]

        private static string autofullfilepath = "";
        private static string mdifullfilepath = "";

        public enum OperationMode { JOG = 0, INCJOG = 1, ZRN = 2, MPG = 3, MDI = 4, MEM = 5 };
        public enum MFC_Flag { MON = 0, PROG = 1, OFF = 2, DIA = 3, MAIN = 4, PARAM = 5 };
        public enum Level { Lev1 = 0, Lev2 = 1, Lev3 = 2, Lev4 = 3, Lev5 = 4, Lev6 = 5 };

        public static bool isConnectDTSuccessful;

        private static bool _FileLoadOn = false;
        public static bool FileLoadOn
        {
            get { return _FileLoadOn; }
            set { _FileLoadOn = value; }
        }
        
        private static bool _FeedHoldON = false;
        public static bool FeedHoldON
        {
            get { return _FeedHoldON; }
            set { _FeedHoldON = value; }
        }
        
        private static bool _ToolClampON = true;
        public static bool ToolClampON
        {
            get { return _ToolClampON; }
            set { _ToolClampON = value; }
        }

        public static void SetElectricalGearRatio()
        {
            ElectricalGearRatio = ShareMemorySet.Default.ElectricalGearRatio;
        }

        public static void SetFilePath(string path, OperationMode m_opmode)
        {
            switch (m_opmode)
            {
                case OperationMode.MEM:
                    autofullfilepath = path;
                    break;
                case OperationMode.MDI:
                    mdifullfilepath = path;
                    break;
            }
        }

        public static string GetFilePath(OperationMode m_opmode)
        {
            string path = "";
            switch (m_opmode)
            {
                case OperationMode.MEM:
                    path = autofullfilepath;
                    break;
                case OperationMode.MDI:
                    path = mdifullfilepath;
                    break;
            }
            return path;
        }

        public static DateTime GetSysTime()
        {
            return ShareMemorySet.Default.SystDateTime;
        }

        public static DateTime GetPowerOnTime()
        {
            return ShareMemorySet.Default.PowerOnTime;
        }

        public static void SetPowerOnTime(DateTime now)
        {
            ShareMemorySet.Default.PowerOnTime = now;
            ShareMemorySet.Default.Save();
        }

        public static TimeSpan GetAutoOperateTimeSpan()
        {
            return ShareMemorySet.Default.AutoOperateTimeSpan;
        }

        public static void SetAutoOperateTimeSpan(TimeSpan spent)
        {
            ShareMemorySet.Default.AutoOperateTimeSpan = spent;
            ShareMemorySet.Default.Save();
        }

        public static bool isShutDown = false;
        public static BitVector32 EStopStatus = new BitVector32(0);     // EStopStatusLatch = 0x0010,  EStopWarningMsg = 0x0001;
        public static bool isResetPush;
        public static string currentPath = string.Empty;
        public static bool isUpdatePointResult = false;
        public static double[] wmPointResult = new double[2] { 0.0, 0.0 };
        public static int G_index = -1;
        public static TimeSpan systemTimeAutoRun;
        public static TimeSpan systemTimeAutoOperate;
        public static int systemTimeMachiningNum;

        public static bool isUpdateHeight;
        public static int tmToolNum;
        public static double tmToolHeight;

        public static bool[] isAxisLocked = new bool[AxisNum] { false, false, false, false };

        public static int TestAbnormal = -100;

        public static int MaxFeedRateVal;
        public static void SaveMaxFeedRate(int maxFeedRate)
        {
            MaxFeedRateVal = maxFeedRate;
            ShareMemorySet.Default.MaxFeedRate = maxFeedRate;
            ShareMemorySet.Default.Save();
        }
        public static void LoadMaxFeedRate(out int maxFeedRate)
        {
            maxFeedRate = ShareMemorySet.Default.MaxFeedRate;
            MaxFeedRateVal = maxFeedRate;
        }
        
        public static void LoadCurrentCoordinateSystem(out double currentCoordinateSystem)
        {
            currentCoordinateSystem = ShareMemorySet.Default.CurrentCoordinateSystem;
        }
        public static void SaveCurrentCoordinateSystem(double currentCoordinateSystem)
        {
            ShareMemorySet.Default.CurrentCoordinateSystem = currentCoordinateSystem;
            ShareMemorySet.Default.Save();
        }
    }
}

 