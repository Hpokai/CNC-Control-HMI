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

namespace JOGSetUpUI
{
    public partial class FORM_Param_Jog : Form
    {

        public FORM_Param_Jog()
        {
            InitializeComponent();

            GFunc.SelectedIndex = 0;
            JogMode.SelectedIndex = 0;

            JogFeedrate.Text = JOGSet.Default.JogFeedrate.ToString();
            IncJOG.Text = JOGSet.Default.IncJog.ToString();
            SpindleSpeed.Text = JOGSet.Default.SpindleSpeed.ToString();
            ShareMemory.SpindleMaxSpeed = JOGSet.Default.SpindleSpeed;
            ShareMemory.JogSpeed = JOGSet.Default.JogFeedrate;
            ShareMemory.PageInitFinshed = true;

        }

        private void JogFeedrate_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            NumPad numPad_dlg = new NumPad(true);
            double.TryParse(((Label)sender).Text,out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double val = numPad_dlg.ReturnCurrentSettingValue();

                JOGSet.Default.JogFeedrate = val;
                this.JogFeedrate.Text = val.ToString();
                ShareMemory.JogSpeed = val;
                Connection.CNCtoDT.SetJOGSpeed(val);

                JOGSet.Default.Save();
            }
        }

        private void IncJOG_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            NumPad numPad_dlg = new NumPad(true);
            double.TryParse(((Label)sender).Text, out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double val = numPad_dlg.ReturnCurrentSettingValue();

                JOGSet.Default.IncJog = val;
                IncJOG.Text = val.ToString();
                JOGSet.Default.Save();
            }
        }

        private void SpindleSpeed_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            NumPad numPad_dlg = new NumPad(true);
            double.TryParse(((Label)sender).Text, out value);
            numPad_dlg.current_settting_value = value;
            DialogResult ret = numPad_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                double val = numPad_dlg.ReturnCurrentSettingValue();

                JOGSet.Default.SpindleSpeed = val;
                SpindleSpeed.Text = val.ToString();
                ShareMemory.SpindleMaxSpeed = val;
                if (false == Connection.CNCtoDT.SetSpindleMaxSpeed(val))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.SetSpindleMaxSpeed(val)");
                }

                JOGSet.Default.Save();
            }
        }

        private void DescGFunc_Click(object sender, EventArgs e)
        {
            JOG.Default.DescType = 0;
            JOG.Default.Save();
            Desc m_Desc = new Desc();
            m_Desc.ShowDialog();
        }

        private void DescJOGCont_Click(object sender, EventArgs e)
        {
            JOG.Default.DescType = 1;
            JOG.Default.Save();
            Desc m_Desc = new Desc();
            m_Desc.ShowDialog();
        }


    }
}
