using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PowerPmacComLib;
using System.Threading;
using JCNCShareMemory;
using System.Net.NetworkInformation;
using System.Net;

namespace JCNCDTDLL
{
    // CONTROLLER to HMI = CH_XxxXxx
    // HMI to CONTROLLER = HC_XxxXxx

    public partial class JCNCDTCOMM
    {
        private Status status;

        private deviceProperties currentDevProp = new deviceProperties();
        private ISyncGpasciiCommunicationInterface communicationASCII = null;
        private ISyncTerminalCommunicationInterface communicationTERMINAL = null;

        public JCNCDTCOMM()
        {
            //this.InitCommBtwnCNCDT();
            //this.JCNCDTComm();
        }

        private bool PingControllerFirst()
        {
            bool ret = true;
            // Ping's the local machine.
            Ping pingSender = new Ping();
            IPAddress address = IPAddress.Parse(this.currentDevProp.IPAddress);
            PingReply reply = pingSender.Send(address, 100);

            if (reply.Status != IPStatus.Success)
            {
                ret = false;
            }

            return ret;
        }

        public bool InitCommBtwnCNCDT()
        {
            currentDevProp.IPAddress = JCNCDTCommSettings.Default.defaultIPAddress;
            currentDevProp.Password = JCNCDTCommSettings.Default.defaultPassword;
            currentDevProp.PortNumber = Convert.ToInt16(JCNCDTCommSettings.Default.defaultPort);
            currentDevProp.User = JCNCDTCommSettings.Default.defaultUser;
            currentDevProp.Protocol = CommunicationGlobals.ConnectionTypes.SSH;

            return true;
        }

        public void JCNCDTCommClose()
        {
            ShareMemory.PPMACLink = false;
            if (null != this.communicationASCII)
            {
                this.communicationASCII.DisconnectGpascii();
            }
            if (null != this.communicationTERMINAL)
            {
                this.communicationTERMINAL.DisconnectTerminal();
            }
        }
        public bool JCNCDTComm()
        {
            bool ret_ascii = true, ret_terminal = true;

            if (true == this.PingControllerFirst())
            {
                this.JCNCDTCommClose();
                communicationASCII = Connect.CreateSyncGpascii(CommunicationGlobals.ConnectionTypes.SSH, null);
                if (false == communicationASCII.ConnectGpAscii("192.168.0.200", 22, "root", "deltatau"))
                {
                    MessageBox.Show("Error: communicationASCII.ConnectGpAscii");
                    ret_ascii = false;
                }

                communicationTERMINAL = Connect.CreateSyncTerminal(CommunicationGlobals.ConnectionTypes.SSH, null);
                if (false == communicationTERMINAL.ConnectTerminal("192.168.0.200", 22, "root", "deltatau"))
                {
                    MessageBox.Show("Error: communicationASCII.ConnectTerminal");
                    ret_terminal = false;
                }
                ShareMemory.PPMACLink = true;
            }
            else
            {
                //MessageBox.Show("Error: Can't ping controller");
                ShareMemory.PPMACLink = false;
                if (this.communicationASCII != null)
                {
                    if (true == this.communicationASCII.GpAsciiConnected)
                    {
                        this.communicationASCII.DisconnectGpascii();
                    }
                }
            }
            return (ret_ascii && ret_terminal && ShareMemory.PPMACLink);
        }

        private bool SendCommandASCII(string cmd, out string response)
        {
            bool ret = true;

            response = "";
            if (ShareMemory.PPMACLink)
            {
                if (true == this.PingControllerFirst())
                {
                    if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                    {
                        MessageBox.Show("Error: GetResponse(" + cmd + ")");
                        ret = false;
                    }
                }
                else
                {
                    ShareMemory.PPMACLink = false;
                }
            }
            return ret;
        }

        public bool InitPPMACEnv()
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (false == this.SetHMIRestart())
            {
                MessageBox.Show("Error: SetHMIRestart()");
                ret = false;
            }

            if (false == this.SetNcMode(ShareMemory.NcMode.value))
            {
                MessageBox.Show("Error: SetNcMode(ZRN)");
                ret = false;
            }

            if (ShareMemory.PPMACLink)
            {
                cmd = "echo3";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                System.Threading.Thread.Sleep(50);

                //cmd = "MtrsInitialized=0";
                //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                //{
                //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                //    ret = false;
                //}
                //System.Threading.Thread.Sleep(50);

                cmd = "HC_SystemReset=1";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                System.Threading.Thread.Sleep(50);

                //cmd = "MtrsInit=1";
                //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                //{
                //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                //    ret = false;
                //}
                //System.Threading.Thread.Sleep(50);

                //cmd = "coord[1].Nsync=0";
                //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                //{
                //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                //    ret = false;
                //}
                //System.Threading.Thread.Sleep(50);

                //cmd = "Output12=0";
                //if (Status.Ok != this.communicationASCI   I.GetResponse(cmd, out response))
                //{
                //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                //    ret = false;
                //}
                //System.Threading.Thread.Sleep(50);

                //cmd = "AbnormalStatus=0";
                //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                //{
                //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                //    ret = false;
                //}
            }

            //if (false == this.CSStatusTimerOpen())
            //{
            //    MessageBox.Show("Error: CSStatusTimerOpen()");
            //    ret = false;
            //}
            //if (false == this.MotorStatusTimerOpen())
            //{
            //    MessageBox.Show("Error: MotorStatusTimerOpen()");
            //    ret = false;
            //}

            return ret;
        }

        public void ParameterSetting()
        {
            if (false == this.SetFeedratePercentage(100, 25))
            {
                MessageBox.Show("Error: SetFeedratePercentage(100, 25)");
            }

            if (false == this.SetCurrentCoordinateSystem())
            {
                MessageBox.Show("Error: SetCurrentCoordinateSystem()");
            }

            if (false == this.InitMaxFeedRate())
            {
                MessageBox.Show("Error: InitMaxFeedRate()");
            }

            if (false == this.SetJOGSpeed(1000))  // set jog feedrate
            {
                MessageBox.Show("Error: SetJOGSpeed(1000)");
            }

            //if (false == this.UploadAllToolPosData())
            //{
            //    MessageBox.Show("Error: InitMaxFeedRate()");
            //}
        }

        private bool UploadAllToolPosData()
        {
            bool result = false;

            for (int tool_num = 0; tool_num < ShareMemory.ToolPos.MaxToolNum; tool_num++)
            {
                for (int coordinate = 0; coordinate < ShareMemory.ToolPos.AxisNum; coordinate++)
                {
                    this.UploadSingleToolPosData(tool_num, coordinate);                    
                }
            }

            return result;
        }

        public bool UploadSingleToolPosData(int tool_num, int coordinate)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                //    HC_ToolPos(10)(4)
                cmd = "HC_ToolPos(" + tool_num.ToString() + ")(" + coordinate.ToString() + "=" + ShareMemory.ToolPos.Coordiante[coordinate][tool_num];
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }


        public bool ExitPPMACEnv()
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_SystemReset=1";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool SetJOGSpeed(double speed)
        {
            string response = string.Empty;
            string cmd = string.Empty;
            bool[] ret = new bool[] { true, true, true };

            //speed = ((speed / 1000) / 60) * 104857.6;  改用乘法
            speed = (speed * 0.001) * (0.01666666666666666666666666666666666667) * ShareMemory.ElectricalGearRatio;

            if (ShareMemory.PPMACLink)
            {
                cmd = "Motor[1].JogSpeed=" + speed.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret[0] = false;
                }

                cmd = "Motor[2].JogSpeed=" + speed.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret[1] = false;
                }

                cmd = "Motor[3].JogSpeed=" + speed.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret[2] = false;
                }
            }

            return (ret[0] && ret[1] && ret[2]);
        }

        public bool SetMotorSpeed(int index, double speed)
        {
            string response = string.Empty;
            string cmd = string.Empty;
            bool ret = true;

            //speed = ((speed / 1000) / 60) * 104857.6;  改用乘法
            speed = (speed * 0.001) * (0.01666666666666666666666666666666666667) * ShareMemory.ElectricalGearRatio;

            if (ShareMemory.PPMACLink)
            {
                cmd = "Motor[" + index.ToString() + "].MaxSpeed=" + speed.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool FileUploadToPPMAC(string FilePath, string FileName)
        {
            IFTPClientInterface ftp = null;
            string response = string.Empty, cmd = string.Empty;
            string ftpPath = "/var/ftp/usrflash/";
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                ftp = Connect.CreateFTPClient(CommunicationGlobals.FTPConnectionTypes.FTP, ftp);
                if (false == ftp.ConnectFTP("192.168.0.200", "root", "deltatau"))
                {
                    Console.WriteLine("Could not connect to ftp server : " + "192.168.0.200" + ". Please verfy the address");
                    ret = false;
                }
                else
                {
                    cmd = "rm -f " + ftpPath + FileName;        // remove file
                    if (Status.Ok != communicationTERMINAL.SendCommand(cmd, out response))
                    {
                        Console.WriteLine("Error: GetResponse(" + cmd + ")");
                        ret = false;
                    }
                    System.Threading.Thread.Sleep(10);

                    if (ftp.GetFileSize(ftpPath + FileName) > 0)
                    {
                        Console.WriteLine("Could not delete the file '" + FileName + "' from '/var/ftp/usrflash' folder");
                        ret = false;
                    }
                    else
                    {
                        if (true == ftp.DownloadFile(FilePath + FileName, ftpPath))
                        {
                            if (ftp.GetFileSize(ftpPath + FileName) <= 0)
                            {
                                Console.WriteLine("File could not be uploaded");
                                ret = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("File could not be uploaded");
                            ret = false;
                        }
                    }

                    cmd = "gpascii -i" + ftpPath + FileName;
                    if (Status.Ok != communicationTERMINAL.SendCommand(cmd, out response))
                    {
                        Console.WriteLine("Error: GetResponse(" + cmd + ")");
                        ret = false;
                    }

                    if (false == ftp.DisconnectFTP())
                    {
                        Console.WriteLine("Error: ftp.DisconnectFTP()");
                        ret = false;
                    }
                }
            }
            return ret;
        }

        // Homing Check Routine
        public bool SetSingleHomeStatus(int index)       // x = 0, y = 1, z = 2, c = 3
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            cmd = "HC_HomeStart(" + index.ToString() + ")=1";
            if (ShareMemory.PPMACLink)
            {
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool GetSingleHomeStatus(int index, out int value)  // x = 0, y = 1, z = 2, c = 3
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            cmd = "CH_HomeFinish(" + index.ToString() + ")";
            value = 0;
            if (true == ShareMemory.PPMACLink)
            {
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    Console.WriteLine("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    int result;
                    if (true == int.TryParse(response, out result))
                    {
                        value = result;
                    }
                }
            }
            return ret;
        }

        // Coordinate System Routine
        private bool GetCoordinate(string cmd, int axis, out double position)
        {
            string response = string.Empty;
            bool ret = true;

            position = 0.0;
            if (ShareMemory.PPMACLink)
            {
                // X=0 Y=1 Z=2      
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double.TryParse(response, out position);
                }
            }

            return ret;
        }

        public bool GetMachineCoordinate(int axis, out double position)
        {
            string cmd = "CH_Axis_MachPos(" + axis.ToString() + ")";
            return GetCoordinate(cmd, axis, out position);
        }

        public bool GetProgramCoordinate(int axis, out double position)
        {
            string cmd = "CH_Axis_ProgPos(" + axis.ToString() + ")";
            return GetCoordinate(cmd, axis, out position);
        }

        public bool GetDistanceToGo(int axis, out double position)
        {
            string cmd = "CH_Axis_DistToGo(" + axis.ToString() + ")";
            return GetCoordinate(cmd, axis, out position);
        }

        public bool GetProgLineNum(out int index)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            index = 0;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_ProgLineNum";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    index = 0;
                    ret = false;
                }
                else
                {
                    double value = 0.0;
                    double.TryParse(response, out value);
                    index = (int)value;
                    if (0 < index)
                    {
                        index--;
                    }
                }
            }

            return ret;
        }

        // Motor Status Routine
        public bool CurrentSpindleSpeed(out int spindle_speed)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            spindle_speed = 0;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_RelSpindleSpeed";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    //count/mm -> revolution/min, that is response*60*1000/2048
                    //ShareMemory.SpindleSpeed = (int)(double.tryParse(response) * (60 * 1000 * 0.00048828125)); 
                    double value = 0.0;
                    double.TryParse(response, out value);
                    spindle_speed = (int)value;
                }
            }
            return ret;
        }

        public bool CurrentFeedRate(out int feedrate)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            feedrate = 0;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_CurrentFeedRate";
                if (Status.Ok != communicationASCII.GetResponse(cmd, out response))
                {
                    Console.WriteLine("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double value = 0.0;
                    double.TryParse(response, out value);
                    feedrate = (int)value;
                }
            }
            return ret;
        }

        public bool GetAutoCompStatus(out int status)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            status = 0;
            if (ShareMemory.PPMACLink)
            {
                cmd = "AutoCompFinish";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    Console.WriteLine("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double value = 0.0;
                    double.TryParse(response, out value);
                    status = (int)value;
                }
            }
            return ret;
        }

        public bool CurrentToolNum(out int ToolNum, out double ToolCompValue)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;
            double Offset = 0, SensorToPlatformDist = 0;

            ToolNum = 0;
            ToolCompValue = 0.0;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_CS1ActiveTCode";
                if (Status.Ok != communicationASCII.GetResponse(cmd, out response))
                {
                    Console.WriteLine("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double value = 0.0;
                    double.TryParse(response, out value);
                    ToolNum = (int)Math.Round(value);
                }

                cmd = "CH_AxisG43Ofs(2)";
                if (Status.Ok != communicationASCII.GetResponse(cmd, out response))
                {
                    Console.WriteLine("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double value = 0.00;
                    double.TryParse(response, out value);
                    Offset = value;
                }

                cmd = "CH_SensorToPlatformDist";
                if (Status.Ok != communicationASCII.GetResponse(cmd, out response))
                {
                    Console.WriteLine("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double value = 0.0;
                    double.TryParse(response, out value);
                    SensorToPlatformDist = value;
                }

                ToolCompValue = Offset + SensorToPlatformDist;
            }
            return ret;
        }

        public bool CurrentCompensationNum(out int HNum, out int DNum)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            HNum = 0;
            DNum = 0;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_CS1ActiveHCode";
                if (Status.Ok != communicationASCII.GetResponse(cmd, out response))
                {
                    Console.WriteLine("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double value = 0.0;
                    double.TryParse(response, out    value);
                    HNum = (int)value;
                }

                cmd = "CH_CS1ActiveDCode";
                if (Status.Ok != communicationASCII.GetResponse(cmd, out response))
                {
                    Console.WriteLine("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double value = 0.0;
                    double.TryParse(response, out value);

                    DNum = (int)value;
                }
            }
            return ret;
        }

        //
        public bool ResetAutoCompStatus()
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            cmd = "AutoCompFinish=0";
            if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
            {
                Console.WriteLine("Error: GetResponse(" + cmd + ")");
                ret = false;
            }
            return ret;
        }

        //
        public bool CompensationDownLoadToPPMAC(int Type, int index, double val)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            switch (Type)
            {
                case ShareMemory.Compensate.Height:
                    cmd = "HD_H(" + index.ToString() + ")=" + val.ToString();
                    break;
                case ShareMemory.Compensate.HWaste:
                    cmd = "HD_HWaste(" + index.ToString() + ")=" + val.ToString();
                    break;
                case ShareMemory.Compensate.Diameter:
                    cmd = "HD_D(" + index.ToString() + ")=" + val.ToString();
                    break;
                case ShareMemory.Compensate.DWaste:
                    cmd = "HD_HWaste(" + index.ToString() + ")=" + val.ToString();
                    break;
            }

            if (ShareMemory.PPMACLink)
            {
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    Console.WriteLine("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool GetDIState(int ch, out bool state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            state = false;

            if (ShareMemory.PPMACLink)
            {
                cmd = "Input" + (ch + 1).ToString();
                //communicationASCII.GetResponse("Input16", out response);
                if (Status.Ok != communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    if (response == "1\n")
                    {
                        state = true;
                    }
                }
            }

            return ret;
        }

        public bool GetDOState(int ch, out bool state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            state = false;

            if (ShareMemory.PPMACLink)
            {
                cmd = "Output" + (ch + 1).ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    if (response == "1\n")
                    {
                        state = true;
                    }
                }
            }
            return ret;
        }

        public bool SetDOState(int ch, bool ON)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (true == ON)
            {
                cmd = "Output" + (ch + 1).ToString() + "=1";
            }
            else
            {
                cmd = "Output" + (ch + 1).ToString() + "=0";
            }

            if (ShareMemory.PPMACLink)
            {
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool Reset()
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_SystemReset=1";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool WorkLight(bool OnOff)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (true == OnOff)
            {
                cmd = "HC_Output(0)=1";      // O_WorkLight = Output2;   
            }
            else
            {
                cmd = "HC_Output(0)=0";      // O_WorkLight = Output2;   
            }

            if (ShareMemory.PPMACLink)
            {
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool KnifeUnClamping(bool OnOff)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (true == OnOff)
            {
                cmd = "HC_Output(7)=1";         // O_SpdToolChange = Output14;   
            }
            else
            {
                cmd = "HC_Output(7)=0";         // O_SpdToolChange = Output14;   
            }

            if (ShareMemory.PPMACLink)
            {
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool ToolChangeable(bool OnOff)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (true == OnOff)
            {
                cmd = "ToolChangeableMode=1";
            }
            else
            {
                cmd = "ToolChangeableMode=0";
            }
            if (ShareMemory.PPMACLink)
            {
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        enum toolOP { read, write };
        public bool ToolChangeState(int operate, int send, out int data)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            data = -2;

            if (ShareMemory.PPMACLink)
            {
                switch (operate)
                {
                    case (int)toolOP.read:
                        {
                            cmd = "AbnormalStatus";
                            if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            {
                                MessageBox.Show("Error: GetResponse(" + cmd + ")");
                                ret = false;
                            }
                            break;
                        }
                    case (int)toolOP.write:
                        {
                            cmd = "AbnormalStatus=" + send.ToString();
                            if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            {
                                MessageBox.Show("Error: GetResponse(" + cmd + ")");
                                ret = false;
                            }
                            data = -1;
                            break;
                        }
                    default:
                        ret = false;
                        break;
                }
            }
            return ret;
        }

        public bool MachiningPieceFinishedState(bool isSet, out int data)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;
            data = -2;

            if (ShareMemory.PPMACLink)
            {
                if (false == isSet)
                {
                    cmd = "MachiningIsFinishedOrNot";
                    if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                    {
                        MessageBox.Show("Error: GetResponse(" + cmd + ")");
                        ret = false;
                    }
                    else
                    {
                        int value = 0;
                        int.TryParse(response, out value);
                        data = value;
                    }
                }
                else
                {
                    cmd = "MachiningIsFinishedOrNot=2";
                    if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                    {
                        MessageBox.Show("Error: GetResponse(" + cmd + ")");
                        ret = false;
                    }
                    else
                    {
                        data = 2;
                    }
                }
            }
            return ret;
        }

        public bool GetFeedrateValue()
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;
            string temp_val = string.Empty, val = string.Empty;

            if (ShareMemory.PPMACLink)
            {
                if (Status.Ok != this.communicationASCII.GetResponse("CH_Coord_ActVel", out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double value = 0.0;
                    double.TryParse(response, out value);
                    ShareMemory.FeedrateValue = value;
                }
            }
            return ret;
        }

  

        public bool SetCurrentCoordinateSystem()
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;
            double CS_value;

            ShareMemory.LoadCurrentCoordinateSystem(out CS_value);

            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_CSSetupGCodeGroup=" + CS_value.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool GetCurrentCoordinateSystem(out double value)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;
            double mix_coordinate = 0.0;

            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_CSSetupGCodeGroup";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double val = 0.0;
                    double.TryParse(response, out val);
                    mix_coordinate = val;
                    mix_coordinate = Math.Round(mix_coordinate, 3);
                }
            }
            value = mix_coordinate;

            return ret;
        }

        public bool GetCurrentCoordinateSystem(out string main_coordinate_display, out string sub_coordinate_display)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;
            double mix_coordinate = 0.0;
            int main_coordinate = 0, sub_coordinate = 0;

            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_CSSetupGCodeGroup";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    double value = 0.0;
                    double.TryParse(response, out value);
                    mix_coordinate = value;
                    mix_coordinate = Math.Round(mix_coordinate, 3);

                    main_coordinate = Convert.ToInt32(Math.Floor(mix_coordinate));
                    sub_coordinate = Convert.ToInt32(1000 * (mix_coordinate - main_coordinate));
                }
            }

            main_coordinate_display = "G" + main_coordinate.ToString();
            if (0 == sub_coordinate)
            {
                sub_coordinate_display = ".000";
            }
            else
            {
                sub_coordinate_display = "." + sub_coordinate.ToString();
            }
            return ret;
        }

        public bool InitMaxFeedRate()
        {
            int maxFeedRate = -100;
            bool ret = true;

            ShareMemory.LoadMaxFeedRate(out maxFeedRate);
            ShareMemory.SaveMaxFeedRate(maxFeedRate);
            if (ShareMemory.PPMACLink)
            {
                if (false == this.SetMaxFeedradeValue(maxFeedRate))
                {
                    MessageBox.Show("Error: SetMaxFeedradeValue(maxFeedRate)");
                    ret = false;
                }
            }
            return ret;
        }

        public bool SetMaxFeedradeValue(int maxFeedrateValue)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret_max = true, ret_refmax = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "coord[1].MaxFeedRate=" + maxFeedrateValue.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret_max = false;
                }
                cmd = "HC_RefMaxFeedRate=" + maxFeedrateValue.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret_refmax = false;
                }
            }
            return (ret_max && ret_refmax);
        }
        
        public bool SetMSTLock(bool isOn)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (true == isOn)
            {
                cmd = "MSTLockOn=1";
            }
            else
            {
                cmd = "MSTLockOn=0";
            }

            if (ShareMemory.PPMACLink)
            {
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool SetAxisLocked(string option, bool state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                switch (option)
                {
                    case "MLK":
                        if (true == state)
                        {
                            //for (int axis = 0; axis <= ShareMemory.AxisNum; axis++)
                            //{
                            //    cmd = "Motor[" + ShareMemory.PhyNum[axis].ToString() + "].PreFilterEna=1";
                            //    if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))     // x-axis
                            //    {
                            //        MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //        ret = false;
                            //    }
                            //}
                            cmd = "HC_MachineLockOn=1";
                            if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            {
                                MessageBox.Show("Error: GetResponse(" + cmd + ")");
                                ret = false;
                            }
                        }
                        else
                        {
                            cmd = "HC_MachineLockOn=0";
                            if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            {
                                MessageBox.Show("Error: GetResponse(" + cmd + ")");
                                ret = false;
                            }
                            //cmd = "\\";
                            //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            //{
                            //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //    ret = false;
                            //}

                            //for (int axis = 0; axis <= ShareMemory.AxisNum; axis++)
                            //{
                            //    cmd = "Motor[" + ShareMemory.PhyNum[axis].ToString() + "].PreFilterEna=0";
                            //    if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))     // x-axis
                            //    {
                            //        MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //        ret = false;
                            //    }
                            //}

                            //cmd = "Pmatch";
                            //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            //{
                            //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //    ret = false;
                            //}

                            //cmd = "r";
                            //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            //{
                            //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //    ret = false;
                            //}
                        }
                        break;
                    case "ZLK":
                        if (true == state)
                        {
                            cmd = "HC_AxisLockOn(" + ShareMemory.Z.ToString() + ")=1";
                            if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            {
                                MessageBox.Show("Error: GetResponse(" + cmd + ")");
                                ret = false;
                            }

                            //cmd = "Motor[" + ShareMemory.PhyNum[ShareMemory.Z].ToString() + "].PreFilterEna=1";
                            //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))      // z-axis
                            //{
                            //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //    ret = false;
                            //}
                        }
                        else
                        {
                            cmd = "HC_AxisLockOn(" + ShareMemory.Z.ToString() + ")=0";
                            if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            {
                                MessageBox.Show("Error: GetResponse(" + cmd + ")");
                                ret = false;
                            }

                            //cmd = "\\";
                            //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            //{
                            //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //    ret = false;
                            //}

                            //cmd = "Motor[" + ShareMemory.PhyNum[ShareMemory.Z].ToString() + "].PreFilterEna=1";
                            //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))      // z-axis
                            //{
                            //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //    ret = false;
                            //}

                            //cmd = "Pmatch";
                            //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            //{
                            //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //    ret = false;
                            //}

                            //cmd = "r";
                            //if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                            //{
                            //    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                            //    ret = false;
                            //}
                        }
                        break;
                }
            }
            return ret;
        }

        public bool SetParameterServoGroup(int current_command, int current_axis, string current_value)
        {
            double value = 0.0;
            double.TryParse(current_value, out value);
            bool ret = SetParameterServoGroup(current_command, current_axis, value);
            return ret;
        }

        public bool SetParameterServoGroup(int current_command, int current_axis, double current_value)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            string[] temp_cmd = new string[5] { "HC_MaxSpeed(", "HC_MaxAcc(", "HC_MaxDec(", "HC_MaxJerk(", "HC_MaxFollowError(" };

            if (ShareMemory.PPMACLink)
            {
                cmd = temp_cmd[current_command] + current_axis.ToString() + ")=" + current_value.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool SetParameterHomingZFirst(bool state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                if (true == state)
                {
                    cmd = "HC_ZHomeFirstFlag=" + ShareMemory.Switch.On.ToString();
                }
                else
                {
                    cmd = "HC_ZHomeFirstFlag=" + ShareMemory.Switch.Off.ToString();
                }
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetParameterHomingGroup(int current_command, int current_axis, string current_value)
        {
            double value = 0.0;
            double.TryParse(current_value, out value);
            bool ret = SetParameterHomingGroup(current_command, current_axis, value);
            return ret;
        }

        public bool SetParameterHomingGroup(int current_command, int current_axis, double current_value)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            string[] temp_cmd = new string[4] { "HC_Home1stSpeed(", "HC_Home2ndSpeed(", "HC_HomeRapidSpeed(", "HC_HomeOffset(" };

            if (ShareMemory.PPMACLink)
            {
                cmd = temp_cmd[current_command] + current_axis.ToString() + ")=" + current_value.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetParameterSoftLimitGroup(int current_command, int current_axis, string current_value)
        {
            double value = 0.0;
            double.TryParse(current_value, out value);
            bool ret = SetParameterSoftLimitGroup(current_command, current_axis, value);
            return ret;
        }

        public bool SetParameterSoftLimitGroup(int current_command, int current_axis, double current_value)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            string[] temp_cmd = new string[2] { "HC_SoftLimitMax(", "HC_SoftLimitMin(" };

            if (ShareMemory.PPMACLink)
            {
                cmd = temp_cmd[current_command] + current_axis.ToString() + ")=" + current_value.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetJogRapidMode(int isRapid)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_JogMode=" + isRapid.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetJogDirection(int axis, int dir)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_JogDir(" + axis.ToString() + ")=" + dir.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool GetIncJogFinish(int axis, out int isFinish)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            isFinish = ShareMemory.Switch.Off;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_INCJogFinish(" + axis.ToString() + ")";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    int result = 0;
                    int.TryParse(response, out result);
                    if (ShareMemory.Switch.On == result)
                    {
                        isFinish = ShareMemory.Switch.On;
                    }
                }
            }

            return ret;
        }

        public bool SetSpindleManualDirection(int dir)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_ManualSpindleDir=" + dir.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetSpindleSpeedPercentage(int percentage)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_SpindlePercent=" + percentage.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool GetEmgStopState(out int emg_stop_state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            emg_stop_state = 0;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_EMGFlag";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    int result = 0;
                    int.TryParse(response, out result);
                    if (ShareMemory.Switch.On == result)
                    {
                        emg_stop_state = ShareMemory.Switch.On;
                    }
                }
            }

            return ret;
        }

        public bool GetEmgLatch(out int emg_latch)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            emg_latch = 1;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_Input(17)";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    int result = 0;
                    int.TryParse(response, out result);
                    if (ShareMemory.Switch.Off == result)
                    {
                        emg_latch = ShareMemory.Switch.Off;
                    }
                }
            }

            return ret;
        }
        
        public bool GetControllerInitComplete(out int init_complete)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            init_complete = 0;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_SystemInitComplete";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    int result = 0;
                    int.TryParse(response, out result);
                    if (ShareMemory.Switch.On == result)
                    {
                        init_complete = ShareMemory.Switch.On;
                    }
                }
            }

            return ret;
        }

        public bool SetCycleStart(int state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_CycleStart=" + state.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool GetProgramStep(out int program_step)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            program_step = 0;
            if (ShareMemory.PPMACLink)
            {
                cmd = "CH_ProgramStep";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
                else
                {
                    int result = 0;
                    int.TryParse(response, out result);
                    program_step = result;
                }
            }

            return ret;
        }

        public bool SetHMIRestart()
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_HMIRestart=1";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetProgramIdle()
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_ProgStepReset=1";
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetFeedHold(int state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_FeedHold=" + state.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetFeedratePercentage(int normalFeedRatePercentage, int rapidFeedRatePercentage)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret_normal = true, ret_rapid = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_NormalPercent=" + normalFeedRatePercentage.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret_normal = false;
                }

                cmd = "HC_RapidPercent=" + rapidFeedRatePercentage.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret_rapid = false;
                }
            }

            return (ret_normal && ret_rapid);
        }

        public bool SetFeedrateType(int state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_SpeedMode=" + state.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetSingleBlock(bool state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;
            
            if (ShareMemory.PPMACLink)
            {
                if (true == state)
                {
                    cmd = "HC_SBKON=1";
                }
                else
                {
                    cmd = "HC_SBKON=0";
                }
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetM01(bool state)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                if (true == state)
                {
                    cmd = "HC_M01FlagOn=1";
                }
                else
                {
                    cmd = "HC_M01FlagOn=0";
                }
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }

            return ret;
        }

        public bool SetWashDownMotorState(bool isAuto, bool isON)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                if (true == isAuto)
                {
                    if (true == isON)
                    {
                        cmd = "HC_AutoCuttingCoolant=1";
                    }
                    else
                    {
                        cmd = "HC_AutoCuttingCoolant=0";
                    }
                }
                else
                {
                    if (true == isON)
                    {
                        cmd = "HC_ManualCuttingCoolant=1";         
                    }
                    else
                    {
                        cmd = "HC_ManualCuttingCoolant=0";       
                    }
                }
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool SetAirBlowState(bool isON)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                if (true == isON)
                {
                    cmd = "HC_Output(1)=1";     // O_CuttingBlower = Output8;   
                }
                else    // false == isOn;
                {
                    cmd = "HC_Output(1)=0";     // O_CuttingBlower = Output8;   
                }
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }
        public bool SetBDTState(bool isON)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                if (true == isON)
                {
                    cmd = "HC_BDTOn=1";     // SBK;   
                }
                else    // false == isOn;
                {
                    cmd = "HC_BDTOn=0";     // O_CuttingBlower = Output8;   
                }
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool SetToolHeightSensor(string height)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (ShareMemory.PPMACLink)
            {
                cmd = "HC_SensorToPlatformDist=" + height;                 
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }
    
    }


}
