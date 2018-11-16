using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compensation
{
    public partial class MsgDlg : Form
    {
        private double coordinateValue;
        public double CoordinateValue { get { return coordinateValue; } }

        private Button[] NumberButton;
        private string[] NumberText;

        public double current_settting_value;
        public double current_machine_value;

        public MsgDlg(bool needTransfer, bool isOnlyNumber)
        {
            InitializeComponent();
            
            this.coordinateValue = 0.0;
            this.current_settting_value = 0.0;
            this.current_machine_value = 0.0;
            
            this.transferButton.Enabled = needTransfer;

            this.minusButton.Enabled = !isOnlyNumber;
            this.plusButton.Enabled = !isOnlyNumber;
            this.dotButton.Enabled = !isOnlyNumber;           

            this.ObjectArray();
        }

        public double ReturnCurrentSettingValue()
        {
            return this.current_settting_value;
        }

        private void MsgDlg_Load(object sender, EventArgs e)
        {
            this.valueLabel.Text = this.current_settting_value.ToString();
        }

        private void ObjectArray()
        {
            this.NumberButton = new Button[10]{
                number_0_Button, number_1_Button, number_2_Button, number_3_Button, number_4_Button,
                number_5_Button, number_6_Button, number_7_Button, number_8_Button, number_9_Button};

            this.NumberText = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        }

        private void number_Click(object sender, EventArgs e)
        {
            string temp_string = "";
            for (int index = 0; index < 10; index++)
            {
                if (sender == this.NumberButton[index])
                {
                    temp_string = this.valueLabel.Text;

                    if ("0" == temp_string)
                    {
                        this.valueLabel.Text = this.NumberText[index];
                    }
                    else
                    {
                        this.valueLabel.Text = temp_string + this.NumberText[index];
                    }

                    index = 10;
                }
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            this.valueLabel.Text = "0";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int length = this.valueLabel.Text.Length;
            if (1 < length)
            {
                this.valueLabel.Text = this.valueLabel.Text.Remove((length - 1));
            }
            else
            {
                this.valueLabel.Text = "0";
            }
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            string temp_string = this.valueLabel.Text;

            if (-1 != this.valueLabel.Text.IndexOf("."))
            {
                this.valueLabel.Text = temp_string;
            }
            else
            {
                this.valueLabel.Text = temp_string + ".";
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            string temp_string = this.valueLabel.Text;

            if ("0" == temp_string)
            {
                this.valueLabel.Text = temp_string;
            }
            else
            {
                if (-1 != this.valueLabel.Text.IndexOf("-"))
                {
                    this.valueLabel.Text = temp_string;
                }
                else
                {
                    this.valueLabel.Text = "-" + temp_string;
                }
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            double temp_value = System.Convert.ToDouble(this.valueLabel.Text);

            this.current_settting_value += temp_value;
            this.valueLabel.Text = this.current_settting_value.ToString();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            this.valueLabel.Text = this.current_machine_value.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.current_settting_value = System.Convert.ToDouble(this.valueLabel.Text);
        }

    }
}
