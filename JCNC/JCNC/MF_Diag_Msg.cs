using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JCNCShareMemory;

namespace JCNC
{
    public partial class FORM_Diag_AlarmMessage : Form
    {
        public FORM_Diag_AlarmMessage()
        {
            InitializeComponent();
            ShareMemory.PageInitFinshed = true;

        }

        private void SystemMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
