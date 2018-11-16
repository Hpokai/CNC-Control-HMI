using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCNCShareMemory
{
    public partial class ShareMemory
    {
        public static bool PPMACLink = false;

        private static bool _PageInitFinshed;
        public static bool PageInitFinshed
        {
            get { return _PageInitFinshed; }
            set { _PageInitFinshed = value; }
        }
    }
}
