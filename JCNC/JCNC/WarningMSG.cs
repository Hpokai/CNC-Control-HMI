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
    public partial class WarningMSG : Form
    {
        public WarningMSG(string word)
        {
            InitializeComponent();

            this.WMsg.Text = word;
        }

        public void SetText(string word)
        {
            this.WMsg.Text = word;
        }

        private string shown_word = string.Empty;
        public WarningMSG(string word, bool set_timer)
        {
            InitializeComponent();

            this.WMsg.Text = "與控制器連線中!";
            this.shown_word = word;

            this.closeTimer.Interval = 100;
            this.closeTimer.Start();
        }

        private bool isClose = false;
        private int count = 0, count_connect = 0;
        public bool isInitialFail = false;
        private void closeTimer_Tick(object sender, EventArgs e)
        {
            if (true == isClose)
            {
                this.closeTimer.Stop();
                this.Close();
            }
         
            if (true == this.PPMACLink)
            {
                if (5 >= count)
                {
                    this.WMsg.Text = this.shown_word;
                    this.Refresh();
                }
                 if (900 <= count)       // over 1 minute, it would be wrong.
               //  if (6 <= count)
                {
                    this.closeTimer.Stop();
                    this.isInitialFail = true;

                    this.WMsg.Text = "初始化失敗，請重新開機！";
                    this.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    this.Close();
                }
                count++;
            }
            else
            {
               if (900 <= count_connect)       // over 1 minute, it would be wrong.
               //    if (6 <= count_connect)
                {
                    this.closeTimer.Stop();
                    this.isInitialFail = true;

                    this.WMsg.Text = "連線失敗，請檢查網路及控制器是否正常啟動！";
                    this.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    this.Close();
                }

                count_connect++;
                count = 0;
            }
        }

        private bool PPMACLink = false;
        public void SetPowerPMacConnectState(bool PPMACLink)
        {
            this.PPMACLink = PPMACLink;
        }

        public void SetSystemInitComplete(int isComplete)
        {
            if (1 == isComplete)
            {
                this.WMsg.Text = "初始化完成！";
                this.Refresh();
                System.Threading.Thread.Sleep(1500);
                this.isClose = true;
            }
        }
       
    }
}
