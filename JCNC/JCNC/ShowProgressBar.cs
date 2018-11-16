using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCNC
{
    public partial class ShowProgressBar : Form
    {
        private int progress_value;

        public ShowProgressBar()
        {
            InitializeComponent();

            this.progress_value = 0;
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if ((this.progress_value >= 0) && (this.progress_value < 200))
            {
                this.progress_value+=10;
            }
            else if ((this.progress_value >=200) &&(this.progress_value<400))
            {
                this.progress_value+=8;
            }
            else if ((this.progress_value >= 400) && (this.progress_value < 600))
            {
                this.progress_value += 5;
            }
            else if ((this.progress_value >= 600) && (this.progress_value < 800))
            {
                this.progress_value += 2;
            }
            else if ((this.progress_value >= 600) && (this.progress_value < 980))
            {
                this.progress_value += 1;
            }
            else
            {
                this.progress_value += 0;
            }

            this.progressBar.Value = this.progress_value;
            this.label1.Text = this.progress_value.ToString();
        }

        public void StartProgressTimer()
        {
            this.progress_value = 0;
            this.progressTimer.Interval = 100;
            this.progressTimer.Start();
        }

        public void StopProgressTimer()
        {
            this.progressTimer.Stop();
            this.progressBar.Value = this.progressBar.Maximum;
        }
    }
}
