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

namespace ServoSetupUI
{
    public partial class FROM_Param_Servo : Form
    {
        private const int AxisNum = 6;
        private const int ParameterNum = 5;

        private Label[] max_speed_label, max_acc_label, max_dec_label, max_jerk_label, max_follow_error_label;
        private Label[][] value_label;

        public FROM_Param_Servo()
        {
            InitializeComponent();

            this.ChangeLocation();

            this.ObjectArray();

            this.AddEvent();

            //this.ReadAllParameter();
            
            ShareMemory.PageInitFinshed = true;
        }

        private void ObjectArray()
        {
            this.max_speed_label = new Label[FROM_Param_Servo.AxisNum] { this.maxSpeedLabel_X, this.maxSpeedLabel_Y, this.maxSpeedLabel_Z, this.maxSpeedLabel_A, this.maxSpeedLabel_B, this.maxSpeedLabel_C };
            this.max_acc_label = new Label[FROM_Param_Servo.AxisNum] { this.maxAccLabel_X, this.maxAccLabel_Y, this.maxAccLabel_Z, this.maxAccLabel_A, this.maxAccLabel_B, this.maxAccLabel_C };
            this.max_dec_label = new Label[FROM_Param_Servo.AxisNum] { this.maxDecLabel_X, this.maxDecLabel_Y, this.maxDecLabel_Z, this.maxDecLabel_A, this.maxDecLabel_B, this.maxDecLabel_C };
            this.max_jerk_label = new Label[FROM_Param_Servo.AxisNum] { this.maxJerkLabel_X, this.maxJerkLabel_Y, this.maxJerkLabel_Z, this.maxJerkLabel_A, this.maxJerkLabel_B, this.maxJerkLabel_C };
            this.max_follow_error_label = new Label[FROM_Param_Servo.AxisNum] { this.maxFollowErrLabel_X, this.maxFollowErrLabel_Y, this.maxFollowErrLabel_Z, this.maxFollowErrLabel_A, this.maxFollowErrLabel_B, this.maxFollowErrLabel_C };
            this.value_label = new Label[FROM_Param_Servo.ParameterNum][] { this.max_speed_label, this.max_acc_label, this.max_dec_label, this.max_jerk_label, this.max_follow_error_label };
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

        private void ChangeLocation()
        {
            // Location x of a = 527, of b = 631, of c = 735, of unit = 841
            Label[] a_group = new Label[FROM_Param_Servo.ParameterNum + 1] { this.label_A, this.maxSpeedLabel_A, this.maxAccLabel_A, this.maxDecLabel_A, this.maxJerkLabel_A, this.maxFollowErrLabel_A };
            Label[] b_group = new Label[FROM_Param_Servo.ParameterNum + 1] { this.label_B, this.maxSpeedLabel_B, this.maxAccLabel_B, this.maxDecLabel_B, this.maxJerkLabel_B, this.maxFollowErrLabel_B };
            Label[] c_group = new Label[FROM_Param_Servo.ParameterNum + 1] { this.label_C, this.maxSpeedLabel_C, this.maxAccLabel_C, this.maxDecLabel_C, this.maxJerkLabel_C, this.maxFollowErrLabel_C };
            Label[] unit_group = new Label[FROM_Param_Servo.ParameterNum + 1] { this.label_Unit, this.maxSpeedLabel_Unit, this.maxAccLabel_Unit, this.maxDecLabel_Unit, this.maxJerkLabel_Unit, this.maxFollowErrLabel_Unit };

            foreach (Label label in unit_group)
            {
                label.Location = new Point(527, label.Location.Y);
            }
        }

        private void TASK_UploadParameters()
        {
            double value = 0;
            Task.Factory.StartNew(() =>
            {
                for (int parameter_num = 0; parameter_num < ParameterNum; parameter_num++)
                {
                    for (int axis = 0; axis < 3; axis++)
                    {
                        double.TryParse(this.value_label[parameter_num][axis].Text, out value);
                        ShareMemory.Parameter.Servo.Set(ShareMemory.Switch.On, axis, parameter_num, value);
                        while (ShareMemory.Switch.On == ShareMemory.Parameter.Servo.Enable)
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
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"Parameter\servo.txt"))
            {
                foreach (Label[] label_array in this.value_label)
                {
                    foreach (Label label in label_array)
                    {
                        label.Text = file.ReadLine();
                        //if (ShareMemory.AxisNum > (index % MF_Param_Servo.AxisNum))
                        //{
                        //    Connection.CNCtoDT.SetParameterServoGroup(index / MF_Param_Servo.AxisNum, index % MF_Param_Servo.AxisNum, label.Text);
                        //}
                        //index++;
                    }
                }
            }

            this.TASK_UploadParameters();
        }

        private void WriteAllParameter()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Parameter\servo.txt"))
            {
                foreach (Label[] label_array in this.value_label)
                {
                    foreach (Label label in label_array)
                    {
                        file.WriteLine(label.Text);
                    }
                }
            }
        }

        private void valueChange_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("1");
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
                current_parameter = save_index / FROM_Param_Servo.AxisNum;
                current_axis = save_index % FROM_Param_Servo.AxisNum;

                double value = 0.0;
                NumPad numPad_dlg = new NumPad(false);
                double.TryParse(((Label)sender).Text, out value);
                numPad_dlg.current_settting_value = value;
                DialogResult ret = numPad_dlg.ShowDialog();
                if (DialogResult.OK == ret)
                {
                    this.value_label[current_parameter][current_axis].Text = numPad_dlg.ReturnCurrentSettingValue().ToString("#0.00");
                    ShareMemory.Parameter.Servo.Set(ShareMemory.Switch.On, current_axis, current_parameter, numPad_dlg.ReturnCurrentSettingValue());
                }
                this.value_label[current_parameter][current_axis].BackColor = Color.FromName("Desktop");
                this.WriteAllParameter();
            }
        }


    }
}
