using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JCNCShareMemory;
using JCNCDTCONECT;
using System.Threading.Tasks;
using System.Threading;

namespace HomingSetupUI
{
    public partial class FORM_Param_Homing : Form
    {
        private const int AxisNum = 6;
        private const int ParameterNum = 4;

        private Label[] home_1st_Speed_Label, home_2nd_Speed_Label, home_rapid_speed_label, home_offset_label;
        private Label[][] value_label;

        public FORM_Param_Homing()
        {
            InitializeComponent();

            //this.ChangeLocation();

            this.ObjectArray();

            this.AddEvent();

            ShareMemory.PageInitFinshed = true;
        }

        private void ChangeLocation()
        {
            // Location x of a = 527, of b = 631, of c = 735, of unit = 841
            Label[] a_group = new Label[FORM_Param_Homing.ParameterNum + 1] { this.label_A, this.home1stSpeedLabel_A, this.home2ndSpeedLabel_A, this.homeRapidSpeedLabel_A,this.homeOffsetLabel_A };
            Label[] b_group = new Label[FORM_Param_Homing.ParameterNum + 1] { this.label_B, this.home1stSpeedLabel_B, this.home2ndSpeedLabel_B, this.homeRapidSpeedLabel_B, this.homeOffsetLabel_A };
            Label[] c_group = new Label[FORM_Param_Homing.ParameterNum + 1] { this.label_C, this.home1stSpeedLabel_C, this.home2ndSpeedLabel_C, this.homeRapidSpeedLabel_C, this.homeOffsetLabel_A };
            Label[] unit_group = new Label[FORM_Param_Homing.ParameterNum + 1] { this.label_Unit, this.home1stSpeedLabel_Unit, this.home2ndSpeedLabel_Unit, this.homeRapidSpeedLabel_Unit, this.homeOffsetLabel_Unit };

            foreach (Label label in unit_group)
            {
                label.Location = new Point(527, label.Location.Y);
            }
        }

        private void ObjectArray()
        {
            this.home_1st_Speed_Label = new Label[FORM_Param_Homing.AxisNum] { this.home1stSpeedLabel_X, this.home1stSpeedLabel_Y, this.home1stSpeedLabel_Z, this.home1stSpeedLabel_A, this.home1stSpeedLabel_B, this.home1stSpeedLabel_C };
            this.home_2nd_Speed_Label = new Label[FORM_Param_Homing.AxisNum] { this.home2ndSpeedLabel_X, this.home2ndSpeedLabel_Y, this.home2ndSpeedLabel_Z, this.home2ndSpeedLabel_A, this.home2ndSpeedLabel_B, this.home2ndSpeedLabel_C };
            this.home_rapid_speed_label = new Label[FORM_Param_Homing.AxisNum] { this.homeRapidSpeedLabel_X, this.homeRapidSpeedLabel_Y, this.homeRapidSpeedLabel_Z, this.homeRapidSpeedLabel_A, this.homeRapidSpeedLabel_B, this.homeOffsetLabel_C };
            this.home_offset_label = new Label[FORM_Param_Homing.AxisNum] { this.homeOffsetLabel_X, this.homeOffsetLabel_Y, this.homeOffsetLabel_Z, this.homeRapidSpeedLabel_A, this.homeRapidSpeedLabel_B, this.homeRapidSpeedLabel_C };
            this.value_label = new Label[FORM_Param_Homing.ParameterNum][] { this.home_1st_Speed_Label, this.home_2nd_Speed_Label, this.home_rapid_speed_label,this.home_offset_label };
        }

        private void AddEvent()
        {
            foreach (Label[] label_array in this.value_label)
            {
                foreach (Label label in label_array)
                {
                    label.Click += new System.EventHandler(this.valueChange_Click);
                }
            }
        }

        private void valueChange_Click(object sender, EventArgs e)
        {
            int index = 0, save_index = -1;
            int current_parameter = -1, current_axis = -1;

            foreach (Label[] label_array in this.value_label)
            {
                foreach (Label label in label_array)
                {
                    label.BackColor = Color.FromName("Desktop");
                    if (true == label.Equals(sender))
                    {
                        label.BackColor = Color.White;
                        save_index = index;
                    }
                    index++;
                }
            }

            if (-1 != save_index)
            {
                current_parameter = save_index / FORM_Param_Homing.AxisNum;
                current_axis = save_index % FORM_Param_Homing.AxisNum;

                double value = 0.0;
                NumPad numPad_dlg = new NumPad(false);
                double.TryParse(((Label)sender).Text, out value);
                numPad_dlg.current_settting_value = value;
                DialogResult ret = numPad_dlg.ShowDialog();
                if (DialogResult.OK == ret)
                {
                    ((Label)sender).Text = numPad_dlg.ReturnCurrentSettingValue().ToString("#0.00");                    
                    ShareMemory.Parameter.Homing.Set(ShareMemory.Switch.On, current_axis, current_parameter, numPad_dlg.ReturnCurrentSettingValue());
                }
                ((Label)sender).BackColor = Color.FromName("Desktop");
                this.WriteAllParameter();

            }
        }

        private void TASK_UploadParameters()
        {
            double value = 0;
            Task.Factory.StartNew(() =>
            {
                for (int parameter_num = 0; parameter_num < ParameterNum; parameter_num++)
                {
                    for (int axis = 0; axis < ShareMemory.Home.AxisNum; axis++)
                    {
                        double.TryParse(this.value_label[parameter_num][axis].Text, out value);
                        ShareMemory.Parameter.Homing.Set(ShareMemory.Switch.On, axis, parameter_num, value);
                        while (ShareMemory.Switch.On == ShareMemory.Parameter.Homing.Enable)
                        {
                            Thread.Sleep(50);
                        }
                    }
                }

            });
        }

        public void ReadAllParameter()
        {  
            //int index = 0;        
  
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"Parameter\homing.txt"))
            {
                foreach (Label[] label_array in this.value_label)
                {
                    foreach (Label label in label_array)
                    {
                        label.Text = file.ReadLine();
                        //if (ShareMemory.AxisNum > (index % MF_Param_Homing.AxisNum))
                        //{
                        //    Connection.CNCtoDT.SetParameterHomingGroup(index / MF_Param_Homing.AxisNum, index % MF_Param_Homing.AxisNum, label.Text);
                        //}
                        //index++;
                    }
                }

                bool flag;
                if (true == bool.TryParse(file.ReadLine(), out flag))
                {
                    this.zHomeFirstCheckBox.Checked = flag;
                    ShareMemory.Home.ZFirst = flag;

                    // adding event after reading all parameter, or the file operation would be error
                    this.zHomeFirstCheckBox.CheckedChanged += new System.EventHandler(this.zHomeFirstCheckBox_CheckedChanged);
                }
            }

            this.TASK_UploadParameters();
        }

        private void WriteAllParameter()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Parameter\homing.txt"))
            {
                foreach (Label[] label_array in this.value_label)
                {
                    foreach (Label label in label_array)
                    {
                        file.WriteLine(label.Text);
                    }
                }

                file.WriteLine(this.zHomeFirstCheckBox.Checked.ToString());
            }
        }

        private void zHomeFirstCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShareMemory.Home.ZFirst = ((CheckBox)sender).Checked;
            ShareMemory.Parameter.Homing.Enable = ShareMemory.Switch.On;
            this.WriteAllParameter();
        }





    }
}
