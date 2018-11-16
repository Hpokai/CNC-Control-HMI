using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PowerPmacComLib;
using JCNCShareMemory;
using System.Windows.Forms;

namespace JCNCDTDLL
{

    public partial class JCNCDTCOMM
    {
        public static double tempspindlespeed = 0;

        public bool SetSpindleMaxSpeed(double val)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            ShareMemory.SpindleMaxSpeed = val;
            
            if (ShareMemory.PPMACLink)  
            {
                cmd = "HC_SpindleMaxRPM=" + val.ToString();
                if (Status.Ok != this.communicationASCII.GetResponse(cmd, out response))
                {
                    MessageBox.Show("Error: GetResponse(" + cmd + ")");
                    ret = false;
                }
            }
            return ret;
        }

        public bool SetNcMode(int nc_mode)
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            cmd = "HC_NCMode=" + nc_mode.ToString();
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
        
    }
}
