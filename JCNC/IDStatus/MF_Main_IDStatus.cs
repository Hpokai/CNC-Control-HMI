using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagesAuthority;
using JCNCShareMemory;

namespace IDStatus
{
    public partial class FORM_Main_IdStatus : Form
    {
        static string Password;
        int CheckedItem;
        int LastCheckedItem;

        private static int _IDLevel;
        public static int IDLevel
        {
            get { return _IDLevel; }
            set { _IDLevel = value; }
        }

        public FORM_Main_IdStatus()
        {
            InitializeComponent();
            
            CheckedItem = IDSettings.Default.InitIDSet;
            LastCheckedItem = IDSettings.Default.InitIDSet;
            IDLevel = CheckedItem;
            SetCKBox(CheckedItem);
            ShareMemory.PageInitFinshed = true;

        }

        private void CKBox1_Click(object sender, EventArgs e)
        {
            CheckedItem = 1;
            SetCKBox(CheckedItem);
        }

        private void CKBox2_Click(object sender, EventArgs e)
        {
            CheckedItem = 2;
            SetCKBox(CheckedItem);
        }

        private void CKBox3_Click(object sender, EventArgs e)
        {
            CheckedItem = 3;
            SetCKBox(CheckedItem);
        }

        private void CKBox4_Click(object sender, EventArgs e)
        {
            CheckedItem = 4;
            SetCKBox(CheckedItem);
        }

        private void CKBox5_Click(object sender, EventArgs e)
        {
            CheckedItem = 5;
            SetCKBox(CheckedItem);
        }

        private void CKBox6_Click(object sender, EventArgs e)
        {
            CheckedItem = 6;
            SetCKBox(CheckedItem);
        }

        public void InputPsw(string psw) {
            Password = psw;
        }

        private bool ChkPsw(int index)
        {
            bool Status = false;
            switch (index)
            {
                case 1:
                    if (Password == "1")
                    {
                        Status = true;
                    }
                    break;
                case 2:
                    if (Password == "2")
                    {
                        Status = true;
                    }
                    break;
                case 3:
                    if (Password == "3")
                    {
                        Status = true;
                    }
                    break;
                case 4:
                    if (Password == "4")
                    {
                        Status = true;
                    }
                    break;
                case 5:
                    if (Password == "5")
                    {
                        Status = true;
                    }
                    break;
                case 6:
                    if (Password == "6")
                    {
                        Status = true;
                    }
                    break;  
            }
            return Status;
        }

        private void SetCKBox(int index) {
            switch (index) { 
                case 1:
                    CKBox1.Checked = true;
                    CKBox2.Checked = false;
                    CKBox3.Checked = false;
                    CKBox4.Checked = false;
                    CKBox5.Checked = false;
                    CKBox6.Checked = false;
                    break;
                case 2:
                    CKBox1.Checked = false;
                    CKBox2.Checked = true;
                    CKBox3.Checked = false;
                    CKBox4.Checked = false;
                    CKBox5.Checked = false;
                    CKBox6.Checked = false;
                    break;
                case 3:
                    CKBox1.Checked = false;
                    CKBox2.Checked = false;
                    CKBox3.Checked = true;
                    CKBox4.Checked = false;
                    CKBox5.Checked = false;
                    CKBox6.Checked = false;
                    break;
                case 4:
                    CKBox1.Checked = false;
                    CKBox2.Checked = false;
                    CKBox3.Checked = false;
                    CKBox4.Checked = true;
                    CKBox5.Checked = false;
                    CKBox6.Checked = false;
                    break;
                case 5:
                    CKBox1.Checked = false;
                    CKBox2.Checked = false;
                    CKBox3.Checked = false;
                    CKBox4.Checked = false;
                    CKBox5.Checked = true;
                    CKBox6.Checked = false;
                    break;
                case 6:
                    CKBox1.Checked = false;
                    CKBox2.Checked = false;
                    CKBox3.Checked = false;
                    CKBox4.Checked = false;
                    CKBox5.Checked = false;
                    CKBox6.Checked = true;
                    break;

            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            SetCKBox(LastCheckedItem);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            MsgDlg m_MsgDlg = new MsgDlg();
            switch (m_MsgDlg.ShowDialog()) { 
                case DialogResult.OK:
                    if (ChkPsw(CheckedItem))
                    {
                        LastCheckedItem = CheckedItem;
                        IDLevel = CheckedItem;
                        IDSettings.Default.InitIDSet = LastCheckedItem;
                        IDSettings.Default.Save();
                    }
                    else{
                        SetCKBox(LastCheckedItem);
                    }
                    break;
                case DialogResult.Cancel:
                    SetCKBox(LastCheckedItem);
                    break;
            }
        }

        private void MF_Main_IDStatus_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'iDDatabaseDataSet.IDData' 資料表。您可以視需要進行移動或移除。
        }
    }
}
