using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDStatus
{
    public partial class MsgDlg : Form
    {
        FORM_Main_IdStatus m_MF_Main_IDStatus = new FORM_Main_IdStatus();

        public MsgDlg()
        {
            InitializeComponent();
        }

        private void MsgDlg_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            FORM_Main_IdStatus m_MF_Main_IDStatus = new FORM_Main_IdStatus();
            m_MF_Main_IDStatus.InputPsw(Input.Text);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
