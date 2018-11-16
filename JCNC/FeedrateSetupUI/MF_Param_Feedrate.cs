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

namespace FeedrateSetupUI
{
    public partial class FORM_Param_Feedrate : Form
    {
        public FORM_Param_Feedrate()
        {
            InitializeComponent();

            this.ObjectArray();

            ShareMemory.PageInitFinshed = true;
        }

        private RadioButton[] rapidPercentage;
        private void ObjectArray()
        {
            this.rapidPercentage = new RadioButton[5] { this.RapidPercentage_0, this.RapidPercentage_25, this.RapidPercentage_50, this.RapidPercentage_75, this.RapidPercentage_100 };
        }

        private int rapidFeedRatePercentage;
        private void RapidPercentage_CheckedChanged(object sender, EventArgs e)
        {
            int value = 0;
            for (int i = 0; i < 5; i++)
            {
                if (this.rapidPercentage[i].Checked == true)
                {
                    this.rapidPercentage[i].BackColor = Color.Crimson;

                    this.rapidFeedRatePercentage = i * 25;
                    int.TryParse(this.normalFeedRatePercentageLabel.Text, out value);
                    Connection.CNCtoDT.SetFeedratePercentage(value, this.rapidFeedRatePercentage);

                    ShareMemory.FeedRate.NormalPercentage = value;
                    ShareMemory.FeedRate.RapidPercentage = this.rapidFeedRatePercentage;
                }
                else
                {
                    this.rapidPercentage[i].BackColor = Color.Black;
                }
            }

        }

        private void normalFeedRatePercentageLabel_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            NumPad numPad_dlg = new NumPad(true);
            double.TryParse(((Label)sender).Text, out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double temp_value = numPad_dlg.ReturnCurrentSettingValue();
                int val = Convert.ToInt32(Math.Round(temp_value, 0));

                if (120 < val)
                {
                    val = 120;
                }
                else if (0 > val)
                {
                    val = 0;
                }
                else
                {
                    double round = val / 10;
                    round = Math.Round(round, 0);
                    val = Convert.ToInt32(round * 10);
                }
                
                ((Label)sender).Text = val.ToString();

                Connection.CNCtoDT.SetFeedratePercentage(val, this.rapidFeedRatePercentage);
                ShareMemory.FeedRate.NormalPercentage = val;
                ShareMemory.FeedRate.RapidPercentage = this.rapidFeedRatePercentage;
            }
        }

        public void ReloadValue()
        {
            this.maxFeedrateLabel.Text = ShareMemory.MaxFeedRateVal.ToString();

            this.normalFeedRatePercentageLabel.Text = ShareMemory.FeedRate.NormalPercentage.ToString();

            int index = ShareMemory.FeedRate.RapidPercentage / 25;
            this.rapidPercentage[index].PerformClick();
        }

        private void xMaxSpeedLabel_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            NumPad numPad_dlg = new NumPad(true);
            double.TryParse(((Label)sender).Text, out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double temp_value = numPad_dlg.ReturnCurrentSettingValue();
                int val = Convert.ToInt32(Math.Round(temp_value, 0));
                ((Label)sender).Text = val.ToString();

                //ShareMemory.SaveMaxFeedRate(value);
                //JCNCDTCOMM.SetMaxFeedradeValue(ShareMemory.MaxFeedRateVal);
                if (false == Connection.CNCtoDT.SetMotorSpeed(ShareMemory.PhyNum[ShareMemory.X], value))
                {
                    MessageBox.Show("Connection.CNCtoDT.SetMotorSpeed(1)");
                }
            }
        }

        private void yMaxSpeedLabel_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            NumPad numPad_dlg = new NumPad(true);
            double.TryParse(((Label)sender).Text, out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double temp_value = numPad_dlg.ReturnCurrentSettingValue();
                int val = Convert.ToInt32(Math.Round(temp_value, 0));
                ((Label)sender).Text = val.ToString();

                //ShareMemory.SaveMaxFeedRate(value);
                //JCNCDTCOMM.SetMaxFeedradeValue(ShareMemory.MaxFeedRateVal);
                if (false == Connection.CNCtoDT.SetMotorSpeed(ShareMemory.PhyNum[ShareMemory.Y], value))
                {
                    MessageBox.Show("Connection.CNCtoDT.SetMotorSpeed(2)");
                }
            }
        }

        private void zMaxSpeedLabel_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            NumPad numPad_dlg = new NumPad(true);
            double.TryParse(((Label)sender).Text, out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double temp_value = numPad_dlg.ReturnCurrentSettingValue();
                int val = Convert.ToInt32(Math.Round(temp_value, 0));
                ((Label)sender).Text = val.ToString();

                //ShareMemory.SaveMaxFeedRate(value);
                //JCNCDTCOMM.SetMaxFeedradeValue(ShareMemory.MaxFeedRateVal);
                if (false == Connection.CNCtoDT.SetMotorSpeed(ShareMemory.PhyNum[ShareMemory.Z], value))
                {
                    MessageBox.Show("Connection.CNCtoDT.SetMotorSpeed(3)");
                }
            }
        }

        private void cMaxSpeedLabel_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            NumPad numPad_dlg = new NumPad(true);
            double.TryParse(((Label)sender).Text, out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double temp_value = numPad_dlg.ReturnCurrentSettingValue();
                int val = Convert.ToInt32(Math.Round(temp_value, 0));
                ((Label)sender).Text = val.ToString();

                //ShareMemory.SaveMaxFeedRate(value);
                //JCNCDTCOMM.SetMaxFeedradeValue(ShareMemory.MaxFeedRateVal);
                if (false == Connection.CNCtoDT.SetMotorSpeed(ShareMemory.PhyNum[ShareMemory.C], value))
                {
                    MessageBox.Show("Connection.CNCtoDT.SetMotorSpeed(3)");
                }
            }
        }

        private void maxFeedrateLabel_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            NumPad numPad_dlg = new NumPad(true);
            double.TryParse(((Label)sender).Text, out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double temp_value = numPad_dlg.ReturnCurrentSettingValue();
                int val = Convert.ToInt32(Math.Round(temp_value, 0));
                ((Label)sender).Text = val.ToString();

                ShareMemory.SaveMaxFeedRate(val);
                if (false == Connection.CNCtoDT.SetMaxFeedradeValue(ShareMemory.MaxFeedRateVal))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.SetMaxFeedradeValue(ShareMemory.MaxFeedRateVal)");
                }
            }
        }

    
    }
}
