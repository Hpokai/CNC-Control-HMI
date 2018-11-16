using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JCNCShareMemory;

namespace ToolMeasurement
{
    public partial class TMeas : Form
    {
        public TMeas()
        {
            InitializeComponent();

            this.InitializeComboBox();
            this.resetButton_Click(null, null);
        }

        private void InitializeComboBox()
        {
            this.toolNumComboBox.Items.Clear();

            this.toolNumComboBox.IntegralHeight = false;
            this.toolNumComboBox.MaxDropDownItems = 15;
            for (int i = 1; i <= 100; i++)
            {
                this.toolNumComboBox.Items.Add(i.ToString());
            }
            this.toolNumComboBox.SelectedIndex = 0;
        }

        private void plus10Button_Click(object sender, EventArgs e)
        {
            int current_index = this.toolNumComboBox.SelectedIndex;

            if (89 < current_index)     // 0 ~ 99
            {
                this.toolNumComboBox.SelectedIndex = this.toolNumComboBox.Items.Count - 1;
            }
            else
            {
                this.toolNumComboBox.SelectedIndex = current_index + 10;
            }
        }

        private void minus10Button_Click(object sender, EventArgs e)
        {
            int current_index = this.toolNumComboBox.SelectedIndex;

            if (10 > current_index)     // 0 ~ 99
            {
                this.toolNumComboBox.SelectedIndex = 0;
            }
            else
            {
                this.toolNumComboBox.SelectedIndex = current_index - 10;
            }
        }
        
        private double old_z, new_z;
        private void showDownDirTimer_Tick(object sender, EventArgs e)
        {
            this.new_z = ShareMemory.CS.Machine[ShareMemory.Z];
            this.new_z = Math.Round(this.new_z, 3);

            if (new_z > old_z)
            {
                this.downDirectionPictureBox.Image = Properties.Resources.down;
                this.downDirectionPictureBox.Visible = true;

                if ((this.downDirectionPictureBox.Location.Y  + this.downDirectionPictureBox.Height+ 10) >
                    (this.spindlePictureBox.Height + 15))
                {
                    this.downDirectionPictureBox.Location = new Point(this.downDirectionPictureBox.Location.X, 0);
                }
                else
                {
                    this.downDirectionPictureBox.Location =
                        new Point(this.downDirectionPictureBox.Location.X, this.downDirectionPictureBox.Location.Y + 10);
                }
                
                old_z = new_z;
            }
            else if (new_z < old_z)
            {
                this.downDirectionPictureBox.Image = Properties.Resources.up;
                this.downDirectionPictureBox.Visible = true;

                if ((this.downDirectionPictureBox.Location.Y - 10) < (-15))
                {
                    this.downDirectionPictureBox.Location = new Point(this.downDirectionPictureBox.Location.X, 
                                                                      this.spindlePictureBox.Height + 15 - this.downDirectionPictureBox.Height);
                }
                else
                {
                    this.downDirectionPictureBox.Location =
                        new Point(this.downDirectionPictureBox.Location.X, this.downDirectionPictureBox.Location.Y - 10);
                }

                old_z = new_z;
            }
            else
            {
                this.downDirectionPictureBox.Visible = false;
                this.downDirectionPictureBox.Location = new Point(this.downDirectionPictureBox.Location.X, 0);
            }
        }

        public void setDownDirTimer(bool isStart)
        {
            //  ShareMemory.CSSystem.MachineCSZ
            if (true == isStart)
            {
                this.showDownDirTimer.Start();
            }
            else
            {
                this.showDownDirTimer.Stop();
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            double value_double = 0;
            double.TryParse(this.measuringDeviceValueTextBox.Text, out value_double);
            double current_machine_z = ShareMemory.CS.Machine[ShareMemory.Z];
            double current_measuring_device_value = value_double;
            double current_tool_height_value = current_machine_z - current_measuring_device_value;

            this.zTextBox.Text = current_machine_z.ToString("#0.000");
            this.toolHeightValueTextBox.Text = current_tool_height_value.ToString("#0.000");

            int value_int = 0;
            int.TryParse((this.toolNumComboBox.SelectedIndex + 1).ToString(), out value_int);
            ShareMemory.tmToolNum = value_int;
            ShareMemory.tmToolHeight = current_tool_height_value;
            ShareMemory.isUpdateHeight = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.toolNumComboBox.SelectedIndex = 0;

            this.toolHeightValueTextBox.Text = "0.000";
            this.zTextBox.Text = "0.000";
            this.measuringDeviceValueTextBox.Text = "0.000";
        }

        private void measuringDeviceValueTextBox_Click(object sender, EventArgs e)
        {
            double value = 0;
            NumPad numPad_dlg = new NumPad(false);
            double.TryParse(((TextBox)sender).Text, out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double val = numPad_dlg.ReturnCurrentSettingValue();
                ((TextBox)sender).Text = val.ToString("#0.000");
            }
        }


    }
}
