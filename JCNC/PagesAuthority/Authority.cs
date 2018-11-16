using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JCNCShareMemory;

namespace PagesAuthority
{
    public partial class FORM_Main_Priority : Form
    {
        Functions m_Functions = new Functions();

        public FORM_Main_Priority()
        {
//            MessageBox.Show("Qtwert");
            ShareMemory.PageInitFinshed = false;
            m_Functions.TopLevel = false;
            InitializeComponent();
            ShareMemory.PageInitFinshed = true;
            //            JCNCShareMemory.ShareMemory.LevSubFFunc[1, 1, 1] = true;
        }

        private void AuthorityTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (AuthorityTabControl.SelectedIndex) { 
                case 0:
                    tabMonitor.Controls.Add(m_Functions);
                    FuncSelPage.SetMFCFlag(JCNCShareMemory.ShareMemory.MFC_Flag.MON);
                    break;
                case 1:
                    tabProgram.Controls.Add(m_Functions);
                     FuncSelPage.SetMFCFlag(JCNCShareMemory.ShareMemory.MFC_Flag.PROG);
                break;
                case 2:
                    tabOffset.Controls.Add(m_Functions);
                    FuncSelPage.SetMFCFlag(JCNCShareMemory.ShareMemory.MFC_Flag.OFF);
                    break;
                case 3:
                    tabDiagnosis.Controls.Add(m_Functions);
                     FuncSelPage.SetMFCFlag(JCNCShareMemory.ShareMemory.MFC_Flag.DIA);
                   break;
                case 4:
                    tabMain.Controls.Add(m_Functions);
                     FuncSelPage.SetMFCFlag(JCNCShareMemory.ShareMemory.MFC_Flag.MAIN);
                   break;
                case 5:
                    tabParameter.Controls.Add(m_Functions);
                     FuncSelPage.SetMFCFlag(JCNCShareMemory.ShareMemory.MFC_Flag.PARAM);
                   break;
            }
        }

        private void MF_Main_Authority_Load(object sender, EventArgs e)
        {
            tabMonitor.Controls.Add(m_Functions);
            m_Functions.Show();
        }

        private void RemovePage() {
            tabMonitor.Controls.Remove(m_Functions);
            tabProgram.Controls.Remove(m_Functions);
            tabOffset.Controls.Remove(m_Functions);
            tabDiagnosis.Controls.Remove(m_Functions);
            tabMain.Controls.Remove(m_Functions);
            tabParameter.Controls.Remove(m_Functions);
        
        }

        private void FuncSelPageInit() {
//            JCNCShareMemory.ShareMemory.LevSubFFunc[1, 1, 1] = true;
        }
    }
}
