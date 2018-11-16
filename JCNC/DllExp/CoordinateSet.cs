using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCNCDTDLL
{
    public partial class JCNCDTCOMM
    {
        public bool CSDownLoadToPPMAC(string command, double val)
        {  
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;
            double ValValue = val;

            cmd = command + "=" + ValValue.ToString();
            if (JCNCShareMemory.ShareMemory.PPMACLink)
            {
                if (PowerPmacComLib.Status.Ok != (this.status = communicationASCII.GetResponse(cmd, out response)))
                {
                    Console.WriteLine("error: CSDownLoadToPPMAC");
                    ret = false;
                }
            }
            return ret;
        }

        //public bool CSEXTSetPmatch()
        //{
        //    string response = string.Empty, cmd = string.Empty;
        //    bool ret = true;

        //    if (JCNCShareMemory.ShareMemory.PPMACLink)
        //    {
        //        cmd = "Pmatch";
        //        if (PowerPmacComLib.Status.Ok != (this.status = communicationASCII.GetResponse(cmd, out response)))
        //        {
        //            Console.WriteLine("error: CSEXTSetPmatch");
        //            ret = false;
        //        }
        //    }
        //    return ret;
        //}
        
        public bool CSResetG43Ofs()
        {
            string response = string.Empty, cmd = string.Empty;
            bool ret = true;

            if (JCNCShareMemory.ShareMemory.PPMACLink)
            {
                cmd = "HC_CS1WorkG43(" + JCNCShareMemory.ShareMemory.LogNum[JCNCShareMemory.ShareMemory.Z] + ")=0";
                if (PowerPmacComLib.Status.Ok != (this.status = communicationASCII.GetResponse(cmd, out response)))
                {
                    Console.WriteLine("error: CSResetG43Ofs");
                    ret = false;
                }
            }
            return ret;
        }


    }
}
