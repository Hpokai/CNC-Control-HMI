using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeyBoard;

namespace JCNC
{
    enum OP_TYPE { RENAME, SAVEAS, NEWFILE };

    public partial class MsgDlg : Form
    {
        private string fileName;
        public string FileName { get { return this.fileName; } }

        private string oldFileName;
        private int op_type;

        public MsgDlg(int type)
        {
            InitializeComponent();

            this.fileName = string.Empty;
            this.oldFileName = string.Empty;
            this.op_type = type;
            switch (this.op_type)
            {
                case (int)OP_TYPE.RENAME:
                    this.Text = "檔名更新";
                    break;
                case (int)OP_TYPE.SAVEAS:
                    this.Text = "另存新檔";
                    break;
                case (int)OP_TYPE.NEWFILE:
                    this.Text = "新增檔案";
                    break;
            }

            this.inputTextBox.Focus();
            this.inputTextBox.Select(this.inputTextBox.Text.Length, 0);
        }

        //----------------------------------
        // sub-functions
        //----------------------------------
        public void SetOldFileName(string old_file_name)
        {
            this.oldFileName = old_file_name;
        }

        //----------------------------------
        // event
        //----------------------------------
        private void MsgDlg_Load(object sender, EventArgs e)
        {
            if ((int)OP_TYPE.RENAME == this.op_type)
            {
                this.inputTextBox.Text = this.oldFileName;
            }
            else
            {
                this.inputTextBox.Text = "";
            }

            // set focus
            this.inputTextBox.Focus();
            this.inputTextBox.Select(this.inputTextBox.Text.Length, 0);

            this.OK.Enabled = false;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.fileName = inputTextBox.Text;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if ("" == this.inputTextBox.Text)
            {
                this.OK.Enabled = false;
            }
            else
            {
                this.OK.Enabled = true;
            }
        }

        private void inputTextBox_Click(object sender, EventArgs e)
        {
            CNCKeys cncKeys_dlg = new CNCKeys(true);
            cncKeys_dlg.SetOldSentence(this.inputTextBox.Text);
            DialogResult ret = cncKeys_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                this.inputTextBox.Text = cncKeys_dlg.ReturnCurrentSentence();
            }
        }
        
    }

}