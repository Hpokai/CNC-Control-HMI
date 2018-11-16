using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolMagazine
{
    public partial class NumPad : Form
    {
        private Button[] NumberButton;
        private string[] NumberText;

        public double current_settting_value;

        private INumPad iNumPad;
        
        public NumPad(INumPad INP)
        {
            InitializeComponent();

            this.iNumPad = INP;
            this.iNumPad.DataValueChangedHandler += new EventHandler<NumPadEventArgs>(iNumPad_DataValueChangedHandler);

            this.minusButton.Enabled = !this.iNumPad.NP_OnlyPositiveInteger;
            this.dotButton.Enabled = !this.iNumPad.NP_OnlyPositiveInteger;

            this.ObjectArray();
        }

        private bool isToolHeightSensor = false;
        void iNumPad_DataValueChangedHandler(object sender, NumPadEventArgs e)
        {
            double value = 0;
            this.isToolHeightSensor = e.isToolHeightSensor;
            if (true == double.TryParse(e.Value, out value))
            {
                this.valueLabel.Text = value.ToString();
            }
        }
        
        private void NumPad_Load(object sender, EventArgs e)
        {
            this.valueLabel.Text = "0";
        }

        private void ObjectArray()
        {
            this.NumberButton = new Button[10]
            {
                number_0_Button, number_1_Button, number_2_Button, number_3_Button, number_4_Button,
                number_5_Button, number_6_Button, number_7_Button, number_8_Button, number_9_Button
            };

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
        
        private void okButton_Click(object sender, EventArgs e)
        {
            NumPadEventArgs numPadEventArgs = new NumPadEventArgs(this.valueLabel.Text, this.isToolHeightSensor);
            this.iNumPad.OnPadValueChanged(numPadEventArgs);
        }

    }





    public interface INumPad
    {
        // NumPad = NP
        bool NP_OnlyPositiveInteger { get; set; }

        // event
        event EventHandler<NumPadEventArgs> PadValueChangedHandler;
        void OnPadValueChanged(NumPadEventArgs e);
        event EventHandler<NumPadEventArgs> DataValueChangedHandler;
        void OnDataValueChanged(NumPadEventArgs e);
    }

    public class NumPadEventArgs : EventArgs
    {
        public string Value { get; private set; }
        public bool isToolHeightSensor { get; private set; }
        public NumPadEventArgs(string value, bool is_tool_height_sensor)
        {
            this.Value = value;
            this.isToolHeightSensor = is_tool_height_sensor;
        }
    }

    public class CNumPad : INumPad
    {
        // NumPad = NP

        private bool np_OnlyPositiveInteger = false;
        bool INumPad.NP_OnlyPositiveInteger { get { return np_OnlyPositiveInteger; } set { np_OnlyPositiveInteger = value; } }

        // Constructor
        public CNumPad()
        {

        }

        public CNumPad(bool only_positive_integer)
        {
            this.np_OnlyPositiveInteger = only_positive_integer;
        }

        // event
        public event EventHandler<NumPadEventArgs> PadValueChangedHandler;
        public void OnPadValueChanged(NumPadEventArgs e)
        {
            EventHandler<NumPadEventArgs> padValueChanged = PadValueChangedHandler;
            if (padValueChanged != null)
            {
                padValueChanged(this, e);
            }
        }

        public event EventHandler<NumPadEventArgs> DataValueChangedHandler;
        public void OnDataValueChanged(NumPadEventArgs e)
        {
            EventHandler<NumPadEventArgs> dataValueChanged = DataValueChangedHandler;
            if (dataValueChanged != null)
            {
                dataValueChanged(this, e);
            }
        }
    }
}
