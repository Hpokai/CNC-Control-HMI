using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JCNCShareMemory;

namespace WorkpieceMeasurement
{
    enum dir { TOP, BOTTOM, RIGHT, LEFT };
    enum type { FOUR, THREE, TWO };

    public partial class WMeas : Form
    {
        private Panel[] wmCenterPointPanel;
        private Button[] wmSetButton, wmResetButton;
        private ComboBox[] wmPointComboBox;
        private TextBox[] X_CenterPointTextBox, Y_CenterPointTextBox;

        private Button[] m4PointButton, m3PointButton, m2PointButton;
        private Panel[][] wmPointPanel;
        private Panel[] m4PointPanel, m3PointPanel, m2PointPanel;
        private TextBox[] X_m4PointTextBox, X_m3PointTextBox, X_m2PointTextBox;
        private TextBox[] Y_m4PointTextBox, Y_m3PointTextBox, Y_m2PointTextBox;
        private TextBox[][] X_PointTextBox, Y_PointTextBox;

        private CheckBox[] xyDirectionCheckBox;

        private const int max_type_num = 3, max_dir_num = 4;

        public WMeas()
        {
            InitializeComponent();

            this.InitializeObjectArray();
            this.InitializeComboBoxItem();
            this.InitializeTabControl();
            this.InitializeCenterPoint();

            this.is2PointXPositive = true; 
            this.is2PointYPositive = true;
        }

        private void InitializeObjectArray()
        {
            this.wmCenterPointPanel = new Panel[3] { this.m4CenterPointPanel, this.m3CenterPointPanel, this.m2SidePointPanel };

            this.wmSetButton = new Button[3] { this.m4PointSetButton, this.m3PointSetButton, this.m2PointSetButton };
            this.wmResetButton = new Button[3] { this.m4PointResetButton, this.m3PointResetButton, this.m2PointResetButton };

            this.wmPointComboBox = new ComboBox[3] { this.m4PointComboBox, this.m3PointComboBox, this.m2PointComboBox };
            this.X_CenterPointTextBox = new TextBox[3] { this.X_m4CenterPointTextBox, this.X_m3CenterPointTextBox, this.X_m2SidePointTextBox };
            this.Y_CenterPointTextBox = new TextBox[3] { this.Y_m4CenterPointTextBox, this.Y_m3CenterPointTextBox, this.Y_m2SidePointTextBox };

            this.m4PointButton = new Button[4] { this.m4TopPointButton, this.m4BottomPointButton, this.m4RightPointButton, this.m4LeftPointButton };
            this.m3PointButton = new Button[4] { this.m3TopPointButton, new Button(), this.m3RightPointButton, this.m3LeftPointButton };
            this.m2PointButton = new Button[4] { new Button(), this.m2BottomPointButton, new Button(), this.m2LeftPointButton };

            this.m4PointPanel = new Panel[4] { this.m4TopPointPanel, this.m4BottomPointPanel, this.m4RightPointPanel, this.m4LeftPointPanel };
            this.m3PointPanel = new Panel[4] { this.m3TopPointPanel, new Panel(), this.m3RightPointPanel, this.m3LeftPointPanel };
            this.m2PointPanel = new Panel[4] { new Panel(), this.m2BottomPointPanel, new Panel(), this.m2LeftPointPanel };
            this.wmPointPanel = new Panel[3][] { this.m4PointPanel, this.m3PointPanel, this.m2PointPanel };

            this.X_m4PointTextBox = new TextBox[4] { this.X_m4TopPointTextBox, this.X_m4BottomPointTextBox, this.X_m4RightPointTextBox, this.X_m4LeftPointTextBox };
            this.X_m3PointTextBox = new TextBox[4] { this.X_m3TopPointTextBox, new TextBox(), this.X_m3RightPointTextBox, this.X_m3LeftPointTextBox };
            this.X_m2PointTextBox = new TextBox[4] { new TextBox(), this.X_m2BottomPointTextBox, new TextBox(), this.X_m2LeftPointTextBox };
            this.X_PointTextBox = new TextBox[3][] { this.X_m4PointTextBox, this.X_m3PointTextBox, this.X_m2PointTextBox };

            this.Y_m4PointTextBox = new TextBox[4] { this.Y_m4TopPointTextBox, this.Y_m4BottomPointTextBox, this.Y_m4RightPointTextBox, this.Y_m4LeftPointTextBox };
            this.Y_m3PointTextBox = new TextBox[4] { this.Y_m3TopPointTextBox, new TextBox(), this.Y_m3RightPointTextBox, this.Y_m3LeftPointTextBox };
            this.Y_m2PointTextBox = new TextBox[4] { new TextBox(), this.Y_m2BottomPointTextBox, new TextBox(), this.Y_m2LeftPointTextBox };
            this.Y_PointTextBox = new TextBox[3][] { this.Y_m4PointTextBox, this.Y_m3PointTextBox, this.Y_m2PointTextBox };

            this.xyDirectionCheckBox = new CheckBox[4] { this.LeftTopCheckBox, this.RightTopCheckBox, this.RightBottomCheckBox, this.LeftBottomCheckBox };
        }

        private void InitializeComboBoxItem()
        {
            string[] item_content = new string[] { "G54", "G55", "G56", "G57", "G58", "G59",
                                                    "G54.1P1", "G54.1P2", "G54.1P3", "G54.1P4", "G54.1P5",
                                                    "G54.1P6", "G54.1P7", "G54.1P8", "G54.1P9", "G54.1P10", 
                                                    "G54.1P11", "G54.1P12", "G54.1P13", "G54.1P14", "G54.1P15"};
            for (int i = 0; i < max_type_num; i++)
            {
                this.wmPointComboBox[i].Items.Clear();
                this.wmPointComboBox[i].Items.AddRange(item_content);
                this.wmPointComboBox[i].SelectedIndex = 0;
            }
        }

        private void InitializeTabControl()
        {
            for (int i = 0; i < max_dir_num; i++)
            {
                this.m4PointPanel[i].Visible = false;
                this.m3PointPanel[i].Visible = false;
                this.m2PointPanel[i].Visible = false;

                this.X_m4PointTextBox[i].Text = "0.000";
                this.X_m3PointTextBox[i].Text = "0.000";
                this.X_m2PointTextBox[i].Text = "0.000";

                this.Y_m4PointTextBox[i].Text = "0.000";
                this.Y_m3PointTextBox[i].Text = "0.000";
                this.Y_m2PointTextBox[i].Text = "0.000";
            }

            this.wmTabControl.SelectedIndex = 0;
        }

        private void InitializeCenterPoint()
        {
            for (int i = 0; i < max_type_num; i++)
            {
                this.X_CenterPointTextBox[i].Text = "0.000";
                this.Y_CenterPointTextBox[i].Text = "0.000";

                if (this.wmTabControl.SelectedIndex == i)
                    this.wmCenterPointPanel[i].Visible = true;
                else
                    this.wmCenterPointPanel[i].Visible = false;
            }
        }

        private void wmTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((TabControl)sender).SelectedIndex;
            for (int i = 0; i < max_type_num; i++)
            {
                if (index == i)
                    this.wmCenterPointPanel[i].Visible = true;
                else
                    this.wmCenterPointPanel[i].Visible = false;
            }
        }

        private void m4PointToCenterPoint()
        {
            double x_left, x_right, y_top, y_bottom, x_center, y_center;
            double value = 0.0;

            if ((true == m4PointPanel[(int)dir.TOP].Visible) && (true == m4PointPanel[(int)dir.BOTTOM].Visible) &&
                (true == m4PointPanel[(int)dir.RIGHT].Visible) && (true == m4PointPanel[(int)dir.LEFT].Visible))
            {
                double.TryParse(this.X_m4PointTextBox[(int)dir.LEFT].Text, out value);
                x_left = value;
                double.TryParse(this.X_m4PointTextBox[(int)dir.RIGHT].Text, out value);
                x_right = value;
                double.TryParse(this.Y_m4PointTextBox[(int)dir.TOP].Text, out value);
                y_top = value;
                double.TryParse(this.Y_m4PointTextBox[(int)dir.BOTTOM].Text, out value);
                y_bottom = value;

                x_center = 0.5 * (x_left + x_right);
                y_center = 0.5 * (y_top + y_bottom);

                this.X_CenterPointTextBox[(int)type.FOUR].Text = x_center.ToString("#0.000");
                this.Y_CenterPointTextBox[(int)type.FOUR].Text = y_center.ToString("#0.000");
            }
            else
            {
                this.X_CenterPointTextBox[(int)type.FOUR].Text = "0.000";
                this.Y_CenterPointTextBox[(int)type.FOUR].Text = "0.000";
            }
        }

        private bool CircleCenter(double x1, double y1, double x2, double y2, double x3, double y3, out double x_center, out double y_center)
        {
            double m_12 = 0.0, m_23 = 0.0;
            double temp = 0.0;
            double c12x = 0.0, c12y = 0.0, c23x = 0.0, c23y = 0.0;
            int error = 0;

            // case: y1 = y2
            if (y1 == y2)
            {
                error++;
                temp = x2;
                x2 = x3;
                x3 = temp;
                temp = y2;
                y2 = y3;
                y3 = temp;
            }

            // case: y2 = y3
            if (y2 == y3)
            {
                error++;
                temp = x1;
                x1 = x2;
                x2 = temp;
                temp = y1;
                y1 = y2;
                y2 = temp;
            }

            if (2 <= error)
            {
                x_center = 0;
                y_center = 0;
                return false;
            }
            else
            {
                m_12 = -(x2 - x1) / (y2 - y1);
                m_23 = -(x3 - x2) / (y3 - y2);

                c12x = (x1 + x2) / 2;
                c12y = (y1 + y2) / 2;
                c23x = (x2 + x3) / 2;
                c23y = (y2 + y3) / 2;

                x_center = (c23y - c12y - m_23 * c23x + m_12 * c12x) / (m_12 - m_23);
                y_center = m_12 * (x_center - c12x) + c12y;
                return true;
            }
        }

        private void m3PointToCenterPoint()
        {
            double x1, y1, x2, y2, x3, y3, x_center, y_center;
            double value = 0.0;

            if ((true == m3PointPanel[(int)dir.TOP].Visible) &&
                (true == m3PointPanel[(int)dir.RIGHT].Visible) && (true == m3PointPanel[(int)dir.LEFT].Visible))
            {
                double.TryParse(this.X_m3PointTextBox[(int)dir.TOP].Text, out value);
                x1 = value;
                double.TryParse(this.Y_m3PointTextBox[(int)dir.TOP].Text, out value);
                y1 = value;
                double.TryParse(this.X_m3PointTextBox[(int)dir.RIGHT].Text, out value);
                x2 = value;
                double.TryParse(this.Y_m3PointTextBox[(int)dir.RIGHT].Text, out value);
                y2 = value;
                double.TryParse(this.X_m3PointTextBox[(int)dir.LEFT].Text, out value);
                x3 = value;
                double.TryParse(this.Y_m3PointTextBox[(int)dir.LEFT].Text, out value);
                y3 = value;

                bool ret = this.CircleCenter(x1, y1, x2, y2, x3, y3, out x_center, out y_center);

                if (true == ret)
                {
                    this.X_CenterPointTextBox[(int)type.THREE].Text = x_center.ToString("#0.000");
                    this.Y_CenterPointTextBox[(int)type.THREE].Text = y_center.ToString("#0.000");
                }
            }
            else
            {
                this.X_CenterPointTextBox[(int)type.THREE].Text = "0.000";
                this.Y_CenterPointTextBox[(int)type.THREE].Text = "0.000";
            }
        }

        private void m2PointToSidePoint()
        {
            double x_position, y_position, x_side, y_side;
            double value = 0.0;

            if ((true == m2PointPanel[(int)dir.BOTTOM].Visible) && (true == m2PointPanel[(int)dir.LEFT].Visible))
            {
                double.TryParse(this.X_m2PointTextBox[(int)dir.LEFT].Text, out value);
                x_position = value;
                double.TryParse(this.Y_m2PointTextBox[(int)dir.BOTTOM].Text, out value);
                y_position = value;

                if (true == this.is2PointXPositive)
                {
                    double.TryParse(this.toolDiameterTextBox.Text, out value);
                    x_side = x_position + value;
                }
                else
                {
                    double.TryParse(this.toolDiameterTextBox.Text, out value);
                    x_side = x_position - value;
                }
                if (true == this.is2PointYPositive)
                {
                    double.TryParse(this.toolDiameterTextBox.Text, out value);
                    y_side = y_position + value;
                }
                else
                {
                    double.TryParse(this.toolDiameterTextBox.Text, out value);
                    y_side = y_position - value;
                }

                this.X_CenterPointTextBox[(int)type.TWO].Text = x_side.ToString("#0.000");
                this.Y_CenterPointTextBox[(int)type.TWO].Text = y_side.ToString("#0.000");
            }
            else
            {
                this.X_CenterPointTextBox[(int)type.TWO].Text = "0.000";
                this.Y_CenterPointTextBox[(int)type.TWO].Text = "0.000";
            }
        }

        private void wmResetButton_Click(object sender, EventArgs e)
        {
            int type_index = -1;
            for (int i = 0; i < max_type_num; i++)
            {
                if (this.wmResetButton[i] == sender)
                {
                    type_index = i;
                    i = max_type_num;
                }
            }

            for (int i = 0; i < max_dir_num; i++)
            {
                this.wmPointPanel[type_index][i].Visible = false;
                this.X_PointTextBox[type_index][i].Text = "0.000";
                this.Y_PointTextBox[type_index][i].Text = "0.000";
                this.X_CenterPointTextBox[type_index].Text = "0.000";
                this.Y_CenterPointTextBox[type_index].Text = "0.000";
            }

            if ((int)type.TWO == type_index)
            {
                this.toolDiameterTextBox.Text = "0.000";
                for (int i = 0; i < max_dir_num; i++)
                {
                    if (true == this.xyDirectionCheckBox[i].Checked)
                    {
                        this.xyDirectionCheckBox[i].Checked = false;

                        i = max_dir_num;
                    }
                }
            }
        }

        private void setPointResult(int G_index, double x, double y)
        {
            if (false == ShareMemory.isUpdatePointResult)
            {
                ShareMemory.G_index = G_index;
                ShareMemory.wmPointResult[0] = x;
                ShareMemory.wmPointResult[1] = y;
                ShareMemory.isUpdatePointResult = true;
            }
        }

        private void wmSetButton_Click(object sender, EventArgs e)
        {
            int type_index = -1;
            double x = 0.0, y = 0.0;
            int GXX_index = -1;

            for (int i = 0; i < max_type_num; i++)
            {
                if (this.wmSetButton[i] == sender)
                {
                    type_index = i;
                    i = max_dir_num;
                }
            }

            if (-1 != type_index)
            {
                double value = 0.0;
                double.TryParse(this.X_CenterPointTextBox[type_index].Text, out value);
                x = value;
                double.TryParse(this.Y_CenterPointTextBox[type_index].Text, out value);
                y = value;
                GXX_index = this.wmPointComboBox[type_index].SelectedIndex;

                this.setPointResult(GXX_index, x, y);
            }
        }

        private void m4PointButton_Click(object sender, EventArgs e)
        {
            int dir_index = -1;
            for (int i = 0; i < max_dir_num; i++)
            {
                if (this.m4PointButton[i] == sender)
                {
                    dir_index = i;
                    i = max_dir_num;
                }
            }

            if (-1 != dir_index)
            {
                this.X_m4PointTextBox[dir_index].Text = ShareMemory.CS.Machine[ShareMemory.X].ToString("#0.000");
                this.Y_m4PointTextBox[dir_index].Text = ShareMemory.CS.Machine[ShareMemory.Y].ToString("#0.000");

                this.m4PointPanel[dir_index].Visible = true;

                this.m4PointToCenterPoint();
            }
        }

        private void m3PointButton_Click(object sender, EventArgs e)
        {
            int dir_index = -1;
            for (int i = 0; i < max_dir_num; i++)
            {
                if (this.m3PointButton[i] == sender)
                {
                    dir_index = i;
                    i = max_dir_num;
                }
            }

            if (-1 != dir_index)
            {
                this.X_m3PointTextBox[dir_index].Text = ShareMemory.CS.Machine[ShareMemory.X].ToString("#0.000");
                this.Y_m3PointTextBox[dir_index].Text = ShareMemory.CS.Machine[ShareMemory.Y].ToString("#0.000");

                this.m3PointPanel[dir_index].Visible = true;

                this.m3PointToCenterPoint();
            }
        }

        private void m2PointButton_Click(object sender, EventArgs e)
        {
            int dir_index = -1;
            for (int i = 0; i < max_dir_num; i++)
            {
                if (this.m2PointButton[i] == sender)
                {
                    dir_index = i;
                    i = max_dir_num;
                }
            }

            if (-1 != dir_index)
            {
                this.X_m2PointTextBox[dir_index].Text = ShareMemory.CS.Machine[ShareMemory.X].ToString("#0.000");
                this.Y_m2PointTextBox[dir_index].Text = ShareMemory.CS.Machine[ShareMemory.Y].ToString("#0.000");

                this.m2PointPanel[dir_index].Visible = true;

                this.m2PointToSidePoint();
            }
        }

        private bool is2PointXPositive, is2PointYPositive;
        enum xydir { LeftTop, RightTop, RightBottom, LeftBottom };
        private void xyDirectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int xydir_index = -1;            

            for (int i = 0; i < max_dir_num; i++)
            {
                if (this.xyDirectionCheckBox[i] == sender)
                {
                    xydir_index = i;
                }
                else
                {
                    this.xyDirectionCheckBox[i].Visible = !((CheckBox)sender).Checked;
                }
            }

            if (-1 != xydir_index)
            {
                if (true == ((CheckBox)sender).Checked)
                {
                    switch (xydir_index)
                    {
                        case (int)xydir.LeftTop:
                            this.move2PointObjectPosition(xydir.LeftTop);
                            this.is2PointXPositive = true;
                            this.is2PointYPositive = false;
                            break;
                        case (int)xydir.RightTop:
                            this.move2PointObjectPosition(xydir.RightTop);
                            this.is2PointXPositive = false;
                            this.is2PointYPositive = false;
                            break;
                        case (int)xydir.RightBottom:
                            this.move2PointObjectPosition(xydir.RightBottom);
                            this.is2PointXPositive = false;
                            this.is2PointYPositive = true;
                            break;
                        case (int)xydir.LeftBottom:
                            this.move2PointObjectPosition(xydir.LeftBottom);
                            this.is2PointXPositive = true;
                            this.is2PointYPositive = true;
                            break;
                        default:
                            break;
                    }

                    ((CheckBox)sender).BackColor = Color.Red;

                    this.wmPointPanel[(int)type.TWO][(int)dir.LEFT].Visible = false;
                    this.wmPointPanel[(int)type.TWO][(int)dir.BOTTOM].Visible = false;
                    this.X_PointTextBox[(int)type.TWO][(int)dir.LEFT].Text = "0.000";
                    this.Y_PointTextBox[(int)type.TWO][(int)dir.LEFT].Text = "0.000";
                    this.X_PointTextBox[(int)type.TWO][(int)dir.BOTTOM].Text = "0.000";
                    this.Y_PointTextBox[(int)type.TWO][(int)dir.BOTTOM].Text = "0.000";
                    this.X_CenterPointTextBox[(int)type.TWO].Text = "0.000";
                    this.Y_CenterPointTextBox[(int)type.TWO].Text = "0.000";
                }
                else
                {
                    ((CheckBox)sender).BackColor = Color.PapayaWhip;
                }
            }
        }

        private void move2PointObjectPosition(xydir xydir_index)
        {
            switch (xydir_index)
            {
                case xydir.LeftTop:
                    this.m2LeftPointButton.Location = new Point(74,178);
                    this.m2LeftPointPanel.Location = new Point(28, 256);
                    this.m2BottomPointButton.Location = new Point(174, 78);
                    this.m2BottomPointPanel.Location = new Point(252, 89);
                    this.workPiecePictureBox.Location = new Point(174, 178);
                    this.LeftTopCheckBox.Location = new Point(183, 185);
                    this.LeftBottomCheckBox.Location = new Point(183, 284);
                    this.RightTopCheckBox.Location = new Point(337, 185);
                    this.RightBottomCheckBox.Location = new Point(337, 284);

                    this.m2LeftPointButton.BackgroundImage = WorkpieceMeasurement.Properties.Resources.ArrowRight;
                    this.m2BottomPointButton.BackgroundImage = WorkpieceMeasurement.Properties.Resources.ArrowDown;
                    break;
                case xydir.RightTop:
                    this.m2LeftPointButton.Location = new Point(278,178);
                    this.m2LeftPointPanel.Location = new Point(278, 256);
                    this.m2BottomPointButton.Location = new Point(200, 78);
                    this.m2BottomPointPanel.Location = new Point(54, 89);
                    this.workPiecePictureBox.Location = new Point(28, 178);
                    this.LeftTopCheckBox.Location = new Point(37, 185);
                    this.LeftBottomCheckBox.Location = new Point(37, 284);
                    this.RightTopCheckBox.Location = new Point(191, 185);
                    this.RightBottomCheckBox.Location = new Point(191, 284);

                    this.m2LeftPointButton.BackgroundImage = WorkpieceMeasurement.Properties.Resources.ArrowLeft;
                    this.m2BottomPointButton.BackgroundImage = WorkpieceMeasurement.Properties.Resources.ArrowDown;
                    break;
                case xydir.RightBottom:
                    this.m2LeftPointButton.Location = new Point(278, 171);
                    this.m2LeftPointPanel.Location = new Point(278, 80);
                    this.m2BottomPointButton.Location = new Point(200, 249);
                    this.m2BottomPointPanel.Location = new Point(54, 249);
                    this.workPiecePictureBox.Location = new Point(28, 78);
                    this.LeftTopCheckBox.Location = new Point(37, 85);
                    this.LeftBottomCheckBox.Location = new Point(37, 184);
                    this.RightTopCheckBox.Location = new Point(191, 85);
                    this.RightBottomCheckBox.Location = new Point(191, 184);

                    this.m2LeftPointButton.BackgroundImage = WorkpieceMeasurement.Properties.Resources.ArrowLeft;
                    this.m2BottomPointButton.BackgroundImage = WorkpieceMeasurement.Properties.Resources.ArrowUp;
                    break;
                case xydir.LeftBottom:
                    this.m2LeftPointButton.Location = new Point(74, 171);
                    this.m2LeftPointPanel.Location = new Point(28, 80);
                    this.m2BottomPointButton.Location = new Point(174, 249);
                    this.m2BottomPointPanel.Location = new Point(252, 249);
                    this.workPiecePictureBox.Location = new Point(174, 78);
                    this.LeftTopCheckBox.Location = new Point(183, 85);
                    this.LeftBottomCheckBox.Location = new Point(183, 184);
                    this.RightTopCheckBox.Location = new Point(337, 85);
                    this.RightBottomCheckBox.Location = new Point(337, 184);

                    this.m2LeftPointButton.BackgroundImage = WorkpieceMeasurement.Properties.Resources.ArrowRight;
                    this.m2BottomPointButton.BackgroundImage = WorkpieceMeasurement.Properties.Resources.ArrowUp;
                    break;
                default:
                    break;
            }
        }

        private void toolDiameterTextBox_Click(object sender, EventArgs e)
        {
            double value = 0.0;
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
