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

namespace WorkAreaLimit
{
    public partial class FORM_Param_WorkAreaLimit : Form
    {
        private const int AxisNum = 6;
        private const int ParameterNum = 2;

        private Label[] max_soft_limit_label, min_soft_limit_label;
        private Label[][] value_label;

        public FORM_Param_WorkAreaLimit()
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
            Label[] a_group = new Label[FORM_Param_WorkAreaLimit.ParameterNum + 1] { this.label_A, this.maxSoftLimitLabel_A, this.minSoftLimitLabel_A };
            Label[] b_group = new Label[FORM_Param_WorkAreaLimit.ParameterNum + 1] { this.label_B, this.maxSoftLimitLabel_B, this.minSoftLimitLabel_B };
            Label[] c_group = new Label[FORM_Param_WorkAreaLimit.ParameterNum + 1] { this.label_C, this.maxSoftLimitLabel_C, this.minSoftLimitLabel_C };
            Label[] unit_group = new Label[FORM_Param_WorkAreaLimit.ParameterNum + 1] { this.label_Unit, this.maxSoftLimitLabel_Unit, this.minSoftLimitLabel_Unit };

            foreach (Label label in unit_group)
            {
                label.Location = new Point(527, label.Location.Y);
            }
        }

        private void ObjectArray()
        {
            this.max_soft_limit_label = new Label[FORM_Param_WorkAreaLimit.AxisNum] { this.maxSoftLimitLabel_X, this.maxSoftLimitLabel_Y, this.maxSoftLimitLabel_Z, this.maxSoftLimitLabel_A, this.maxSoftLimitLabel_B, this.maxSoftLimitLabel_C };
            this.min_soft_limit_label = new Label[FORM_Param_WorkAreaLimit.AxisNum] { this.minSoftLimitLabel_X, this.minSoftLimitLabel_Y, this.minSoftLimitLabel_Z, this.minSoftLimitLabel_A, this.minSoftLimitLabel_B, this.minSoftLimitLabel_C };
            this.value_label = new Label[FORM_Param_WorkAreaLimit.ParameterNum][] { this.max_soft_limit_label, this.min_soft_limit_label };  
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
                current_parameter = save_index / FORM_Param_WorkAreaLimit.AxisNum;
                current_axis = save_index % FORM_Param_WorkAreaLimit.AxisNum;

                double value = 0.0;
                NumPad numPad_dlg = new NumPad(false);
                double.TryParse(((Label)sender).Text, out value);
                numPad_dlg.current_settting_value = value;
                DialogResult ret = numPad_dlg.ShowDialog();
                if (DialogResult.OK == ret)
                {
                    if (99999.999 < numPad_dlg.ReturnCurrentSettingValue())
                    {
                        value = 99999.999;
                    }
                    else if (-99999.999 > numPad_dlg.ReturnCurrentSettingValue())
                    {
                        value = -99999.999;
                    }
                    else
                    {
                        value = numPad_dlg.ReturnCurrentSettingValue();
                    }
                    this.value_label[current_parameter][current_axis].Text = value.ToString("#0.000");
                    ShareMemory.Parameter.WorkAreaLimit.Set(ShareMemory.Switch.On, current_axis, current_parameter, value);
                }
                this.value_label[current_parameter][current_axis].BackColor = Color.FromName("Desktop");
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
                    for (int axis = 0; axis < ShareMemory.SoftLimit.AxisNum; axis++)
                    {
                        double.TryParse(this.value_label[parameter_num][axis].Text, out value);
                        ShareMemory.Parameter.WorkAreaLimit.Set(ShareMemory.Switch.On, axis, parameter_num, value);
                        while (ShareMemory.Switch.On == ShareMemory.Parameter.WorkAreaLimit.Enable)
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
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"Parameter\soft_limit.txt"))
            {
                foreach (Label[] label_array in this.value_label)
                {
                    foreach (Label label in label_array)
                    {
                        label.Text = file.ReadLine();
                        //if (ShareMemory.SoftLimit.AxisNum > (index % MF_Param_WorkAreaLimit.AxisNum))
                        //{
                        //    Connection.CNCtoDT.SetParameterSoftLimitGroup(index / MF_Param_WorkAreaLimit.AxisNum, index % MF_Param_WorkAreaLimit.AxisNum, label.Text);
                        //}
                        //index++;
                    }
                }
            }

            this.TASK_UploadParameters();
        }

        private void WriteAllParameter()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Parameter\soft_limit.txt"))
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


    }
}