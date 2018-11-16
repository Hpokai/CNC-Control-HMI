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
    public partial class Functions : Form
    {
        FuncSelPage m_FuncSelPage = new FuncSelPage();

        public Functions()
        {
            m_FuncSelPage.TopLevel = false;
            InitializeComponent();
        }

        private void Functions_Load(object sender, EventArgs e)
        {
            tabLevel1.Controls.Add(m_FuncSelPage);
            m_FuncSelPage.Show();
        }

        private void tabLevel_Selecting(object sender, TabControlCancelEventArgs e)
        {
            RemovePage();

            switch (tabLevel.SelectedIndex)
            {
                case 0:
                    tabLevel1.Controls.Add(m_FuncSelPage);
                    FuncSelPage.SetAuthorityLevel(JCNCShareMemory.ShareMemory.Level.Lev1);
                    break;
                case 1:
                    tabLevel2.Controls.Add(m_FuncSelPage);
                    FuncSelPage.SetAuthorityLevel(JCNCShareMemory.ShareMemory.Level.Lev2);
                    break;
                case 2:
                    tabLevel3.Controls.Add(m_FuncSelPage);
                    FuncSelPage.SetAuthorityLevel(JCNCShareMemory.ShareMemory.Level.Lev3);
                   break;
                case 3:
                    tabLevel4.Controls.Add(m_FuncSelPage);
                    FuncSelPage.SetAuthorityLevel(JCNCShareMemory.ShareMemory.Level.Lev4);
                 break;
                case 4:
                    tabLevel5.Controls.Add(m_FuncSelPage);
                    FuncSelPage.SetAuthorityLevel(JCNCShareMemory.ShareMemory.Level.Lev5);
                 break;
                case 5:
                    tabLevel6.Controls.Add(m_FuncSelPage);
                    FuncSelPage.SetAuthorityLevel(JCNCShareMemory.ShareMemory.Level.Lev6);
                  break;
            }
        }

        private void RemovePage()
        {
            tabLevel1.Controls.Remove(m_FuncSelPage);
            tabLevel2.Controls.Remove(m_FuncSelPage);
            tabLevel3.Controls.Remove(m_FuncSelPage);
            tabLevel4.Controls.Remove(m_FuncSelPage);
            tabLevel5.Controls.Remove(m_FuncSelPage);
            tabLevel6.Controls.Remove(m_FuncSelPage);
        }

    }
}
