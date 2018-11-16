using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIOP
{
    public partial class SearchLine : Form
    {
        private int line_number;
        public int Line_number
        {
            get
            {
                return this.line_number;
            }
        }

        public SearchLine()
        {
            InitializeComponent();
            this.line_number = -1;

            this.lineNumberTextBox.KeyPress -= new KeyPressEventHandler(lineNumberTextBox_KeyPress);
            this.lineNumberTextBox.KeyPress += new KeyPressEventHandler(lineNumberTextBox_KeyPress);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int out_result = 0;
            if (true == int.TryParse(this.lineNumberTextBox.Text, out out_result))
            {
                this.line_number = out_result - 1;
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lineNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int  keyValue = ( int )e.KeyChar;
            if (((keyValue >= 48) && (keyValue <= 57)) || (keyValue == 8) )     // 0~10 & backspace
            {
                e.Handled = false;
                
            }
            else if (keyValue == 13)        // enter
            {
                e.Handled = false;
                this.searchButton_Click(sender, e);
            }
            else
            {
                e.Handled = true;
            }
        }

        private void SearchLine_Shown(object sender, EventArgs e)
        {
            this.lineNumberTextBox.Focus();
            this.lineNumberTextBox.Select(this.lineNumberTextBox.Text.Length, 0);
        }

        private void SearchLine_Load(object sender, EventArgs e)
        {
            this.lineNumberTextBox.Text = "";
        }

        private void lineNumberTextBox_Click(object sender, EventArgs e)
        {
            NumPad numPad_dlg = new NumPad(true);
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                int value = (int)numPad_dlg.ReturnCurrentSettingValue();
                this.lineNumberTextBox.Text = value.ToString();
            }
        }
    
    }
}
