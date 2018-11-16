using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JCNCShareMemory;

namespace PureCoordinate
{
    public partial class FORM_Mon_PureCoordinate : Form
    {
        private enum coord {MACHINE, PROGRAM, RELATIVE, DISTTOGO };
        private RadioButton[] coordinate;
        private Label[] axis_label;
        private Label[] axis_value;
        private coord selected_coord;
        
        public FORM_Mon_PureCoordinate()
        {
            InitializeComponent();
            this.InitObjectArray();

            this.RadioButton_CheckedChanged(this.coordinate[(int)coord.MACHINE], null);

            for (int axis_num = 0; axis_num < ShareMemory.AxisNum; axis_num++)
            {
                this.axis_value[axis_num].Text = "0.000";
            }

            this.mainTimer.Interval = 100;
            this.mainTimer.Start();

            ShareMemory.PageInitFinshed = true;
        }

        private void InitObjectArray()
        {
            this.coordinate = new RadioButton[ShareMemory.AxisNum] {this.machineCoordinateRadioButton, this.programCoordinateRadioButton,
                                                                    this.relativeCoordinateRadioButton,this.distanceToGoRadioButton};
            this.axis_value = new Label[ShareMemory.AxisNum] { this.xValueLabel, this.yValueLabel, this.zValueLabel, this.cValueLabel };
            this.axis_label = new Label[ShareMemory.AxisNum] { this.xLabel, this.yLabel, this.zLabel, this.cLabel };
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            switch (this.selected_coord)
            {
                case coord.MACHINE:
                    for (int axis_num = 0; axis_num < ShareMemory.CS.AxisNum; axis_num++)
                    {
                        this.axis_value[axis_num].Text = string.Format("{0:0.000}", ShareMemory.CS.Machine[axis_num]);
                    }
                    break;
                case coord.PROGRAM:
                    for (int axis_num = 0; axis_num < ShareMemory.CS.AxisNum; axis_num++)
                    {
                        this.axis_value[axis_num].Text = string.Format("{0:0.000}", ShareMemory.CS.Prog[axis_num]);
                    }
                    break;
                case coord.RELATIVE: 
                    for (int axis_num = 0; axis_num < ShareMemory.CS.AxisNum; axis_num++)
                    {
                        this.axis_value[axis_num].Text = string.Format("{0:0.000}", ShareMemory.CS.Rel[axis_num] - ShareMemory.CS.RelOffset[axis_num]);
                    }
                    break;
                case coord.DISTTOGO:
                    for (int axis_num = 0; axis_num < ShareMemory.CS.AxisNum; axis_num++)
                    {
                        this.axis_value[axis_num].Text = string.Format("{0:0.000}", ShareMemory.CS.DistToGo[axis_num]);
                    }
                    break;
                default:
                    // error!
                    break;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.coordinate[(int)coord.MACHINE] == sender)
            {
                this.selected_coord = coord.MACHINE;
                this.coordinateLabel.Text = "機械座標";
                this.LabelColor(false);
            }
            else if (this.coordinate[(int)coord.PROGRAM] == sender)
            {
                this.selected_coord = coord.PROGRAM;
                this.coordinateLabel.Text = "程式座標";
                this.LabelColor(false);
            }
            else if (this.coordinate[(int)coord.RELATIVE] == sender)
            {
                this.selected_coord = coord.RELATIVE;
                this.coordinateLabel.Text = "相對座標";
                this.LabelColor(true);
            }
            else        // coord.DISTTOGO
            {
                this.selected_coord = coord.DISTTOGO;
                this.coordinateLabel.Text = "殘餘指令";
                this.LabelColor(false);
            }
        }

        private void LabelColor(bool isRelative)
        {
            if (true == isRelative)
            {
                this.axis_label[ShareMemory.X].BackColor = Color.LightGreen;
            }
            else
            {
                this.axis_label[ShareMemory.X].BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
            this.axis_label[ShareMemory.Y].BackColor = this.axis_label[ShareMemory.X].BackColor;
            this.axis_label[ShareMemory.Z].BackColor = this.axis_label[ShareMemory.X].BackColor;
            this.axis_label[ShareMemory.C].BackColor = this.axis_label[ShareMemory.X].BackColor;
        }

        private void axisLabel_Click(object sender, EventArgs e)
        {
            if (coord.RELATIVE == this.selected_coord)
            {
                if (this.axis_label[ShareMemory.X] == sender)
                {
                    ShareMemory.CS.RelOffset[ShareMemory.X] = ShareMemory.CS.Rel[ShareMemory.X];
                }
                else if (this.axis_label[ShareMemory.Y] == sender)
                {
                    ShareMemory.CS.RelOffset[ShareMemory.Y] = ShareMemory.CS.Rel[ShareMemory.Y];
                }
                else if (this.axis_label[ShareMemory.Z] == sender)
                {
                    ShareMemory.CS.RelOffset[ShareMemory.Z] = ShareMemory.CS.Rel[ShareMemory.Z];
                }
                else  //(this.axis_label[(int)axis.C] == sender)
                {
                    ShareMemory.CS.RelOffset[ShareMemory.C] = ShareMemory.CS.Rel[ShareMemory.C];
                }
            }
        }
    }
}
