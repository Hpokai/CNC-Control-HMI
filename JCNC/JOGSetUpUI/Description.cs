using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JOGSetUpUI
{
    public partial class Desc : Form
    {
        public Desc()
        {
            InitializeComponent();
            if (JOG.Default.DescType == 0)
            {
                this.ClientSize = new System.Drawing.Size(484, 142);
                this.Desc3.Visible = false;
                this.Desc4.Visible = false;
                this.Desc5.Visible = false;
                Desc1.Text = "G94 : feedrate in mm (inch)/min";
                Desc2.Text = "G95 : Rotational feedrate in mm (inch)/U";
            }
            else if (JOG.Default.DescType == 1)
            {
                this.ClientSize = new System.Drawing.Size(684, 242);
                this.Desc3.Visible = true;
                this.Desc4.Visible = true;
                this.Desc5.Visible = true;
                Desc1.Text = "Continuous : The axis moves as long as the key is pressed.";
                Desc2.Text = "Momentary-tigger mode : ";
                Desc3.Text = "G94 : ";
                Desc4.Text = "G95 : ";
                Desc5.Text = "G95 : ";
            }
        }
    }
}
