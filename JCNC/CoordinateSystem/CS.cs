using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JCNCDTCONECT;
using JCNCShareMemory;
using System.IO;

namespace CoordinateSystem
{
    public partial class CS : Form
    {
        private const int MaxGroupNum = 7;
        private const int MaxColumnNum = 3;
        private int CurrentOffsetGroup;

        MsgDlg m_MsgDlg = new MsgDlg();
        private Label[] CS_label;
        private string[,] CS_label_text;
        private Label[,] CS_show_G5X_value;
        private Label[] CS_show_EXT_value;
        private Button[] CleanColumn;

        private double[] G54101Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54102Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54103Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54104Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54105Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54106Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54107Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54108Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54109Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54110Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54111Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54112Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54113Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54114Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G54115Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[][] Value_G54 = new double[ShareMemory.COffset.G54_num][];
        private double[] G54000Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G55000Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G56000Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G57000Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G58000Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[] G59000Value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
        private double[][] Value_G5X = new double[ShareMemory.COffset.G5X_num][];
        private double[] EXTValue = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };

        // [7][3][x, y, z, c] seven conbination, each combination has three element.
        private double[,][] OffsetGroup_localValue = new double[MaxGroupNum, MaxColumnNum][];
        private double[,][] OffsetGroup_globalValue = new double[MaxGroupNum, MaxColumnNum][];
        private string[,] OffsetGroup_name;

        public CS()
        {
            //--- hpokai 2013.12.10
            InitializeComponent();

            this.CurrentOffsetGroup = 0;

            this.ObjectArray();

            // Load CS value
            double[] value = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            for (int index = 0; index < ShareMemory.COffset.G54_num; index++)
            {
                this.LoadFile(@"Offset\" + ShareMemory.COffset.G54_name[index] + ".txt", out value);
                for (int i = 0; i < ShareMemory.AxisNum; i++)
                {
                    this.Value_G54[index][i] = value[i];
                }
            }
            for (int index = 0; index < ShareMemory.COffset.G5X_num; index++)
            {
                this.LoadFile(@"Offset\" + ShareMemory.COffset.G5X_name[index] + ".txt", out value);
                for (int i = 0; i < ShareMemory.AxisNum; i++)
                {
                    this.Value_G5X[index][i] = value[i];
                }
            }
            this.LoadFile(@"Offset\" + ShareMemory.COffset.EXT_name + ".txt", out this.EXTValue);

            // Set current CS Group value & EXT value
            this.OffsetGroupSwitch(this.CurrentOffsetGroup);
            for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
            {
                this.CS_show_EXT_value[axis].Text = this.EXTValue[axis].ToString();
            }

            // Set value to share memory
            ShareMemory.COffset.Value_G54 = this.Value_G54;
            ShareMemory.COffset.Value_G5X = this.Value_G5X;
            ShareMemory.COffset.EXTValue = this.EXTValue;

            // start timer
            this.updateWMPointResultTimer.Start();
        }

        //----------------------------------
        // sub-functions
        //----------------------------------
        private void LoadFile(string path, out  double[] array)
        {
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string[] createText = { "0.0", "0.0", "0.0", "0.0" };
                File.WriteAllLines(path, createText);
            }
            // Open the file to read from.
            string[] readText = File.ReadAllLines(path);
            double value = 0.0;
            array = new double[ShareMemory.AxisNum];
            int index = 0;
            foreach (string s in readText)
            {
                double.TryParse(s, out value);
                array[index] = value;
                index++;
            }
        }

        private void SaveFile(string path, double[] array)
        {
            string[] value = array.Select(x => x.ToString()).ToArray();

            File.WriteAllLines(path, value);
        }

        private void ObjectArray()
        {
            this.CS_label = new Label[MaxColumnNum] { CS1, CS2, CS3 };
            this.CS_show_G5X_value = new Label[MaxColumnNum, ShareMemory.AxisNum] { { this.CS1_X, this.CS1_Y, this.CS1_Z, this.CS1_C }, 
                                                                                    { this.CS2_X, this.CS2_Y, this.CS2_Z, this.CS2_C },  
                                                                                    { this.CS3_X, this.CS3_Y, this.CS3_Z, this.CS3_C }  };
         
            this.CS_show_EXT_value = new Label[ShareMemory.AxisNum] { this.EXT_X, this.EXT_Y, this.EXT_Z, this.EXT_C };

            this.CS_label_text = new string[MaxGroupNum, MaxColumnNum]{ {"G54", "G55", "G56"},
                                                                          {"G57", "G58", "G59"},
                                                                          {"G54.101", "G54.102", "G54.103"},
                                                                          {"G54.104", "G54.105", "G54.106"},
                                                                          {"G54.107", "G54.108", "G54.109"},
                                                                          {"G54.110", "G54.111", "G54.112"},
                                                                          {"G54.113", "G54.114", "G54.115"} };

            this.CleanColumn = new Button[] { this.cleanColumn1Button, this.cleanColumn2Button, this.cleanColumn3Button };

            //--- hpokai 2013.12.10
            this.Value_G54 = new double[16][] { this.G54000Value, this.G54101Value, this.G54102Value, this.G54103Value, this.G54104Value, 
                                                this.G54105Value, this.G54106Value, this.G54107Value, this.G54108Value, this.G54109Value , 
                                                this.G54110Value, this.G54111Value, this.G54112Value, this.G54113Value, this.G54114Value, this.G54115Value };
            this.Value_G5X = new double[6][] { this.G54000Value, this.G55000Value, this.G56000Value, this.G57000Value, this.G58000Value, this.G59000Value };

            this.OffsetGroup_localValue = new double[MaxGroupNum, MaxColumnNum][] { {this.G54000Value, this.G55000Value, this.G56000Value}, {this.G57000Value, this.G58000Value, this.G59000Value},
                                                                                      {this.G54101Value, this.G54102Value, this.G54103Value}, {this.G54104Value, this.G54105Value, this.G54106Value},
                                                                                      {this.G54107Value, this.G54108Value, this.G54109Value}, {this.G54110Value, this.G54111Value, this.G54112Value},
                                                                                      {this.G54113Value, this.G54114Value, this.G54115Value} };

            this.OffsetGroup_globalValue = new double[MaxGroupNum, MaxColumnNum][] { {this.G54000Value, this.G55000Value, this.G56000Value}, 
                                                                                       {this.G57000Value, this.G58000Value, this.G59000Value},
                                                                                       {this.G54101Value, this.G54102Value, this.G54103Value},
                                                                                       {this.G54104Value, this.G54105Value, this.G54106Value},
                                                                                       {this.G54107Value, this.G54108Value, this.G54109Value},
                                                                                       {this.G54110Value, this.G54111Value, this.G54112Value},
                                                                                       {this.G54113Value, this.G54114Value, this.G54115Value} };
            this.OffsetGroup_name = new string[MaxGroupNum, MaxColumnNum] { { ShareMemory.COffset.G5X_name[0], ShareMemory.COffset.G5X_name[1], ShareMemory.COffset.G5X_name[2] },
                                                                              { ShareMemory.COffset.G5X_name[3], ShareMemory.COffset.G5X_name[4], ShareMemory.COffset.G5X_name[5] },
                                                                              { ShareMemory.COffset.G54_name[1], ShareMemory.COffset.G54_name[2], ShareMemory.COffset.G54_name[3] },
                                                                              { ShareMemory.COffset.G54_name[4], ShareMemory.COffset.G54_name[5], ShareMemory.COffset.G54_name[6] },
                                                                              { ShareMemory.COffset.G54_name[7], ShareMemory.COffset.G54_name[8], ShareMemory.COffset.G54_name[9] },
                                                                              { ShareMemory.COffset.G54_name[10], ShareMemory.COffset.G54_name[11], ShareMemory.COffset.G54_name[12] },
                                                                              { ShareMemory.COffset.G54_name[13], ShareMemory.COffset.G54_name[14], ShareMemory.COffset.G54_name[15] } };

        }

        private void OffsetGroupSwitch(int GroupNum)
        {
            for (int column = 0; column < MaxColumnNum; column++)
            {
                this.CS_label[column].Text = this.CS_label_text[GroupNum, column];

                for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
                {
                    this.CS_show_G5X_value[column, axis].Text = this.OffsetGroup_localValue[GroupNum, column][axis].ToString();
                }
            }
        }

        private void save_settings(int offset_group, int colunm, int axis)
        {
            string cmd = string.Empty;

            this.OffsetGroup_globalValue[offset_group, colunm][axis] = this.OffsetGroup_localValue[offset_group, colunm][axis];
            this.SaveFile(@"Offset\" + this.OffsetGroup_name[offset_group, colunm] + ".txt", this.OffsetGroup_localValue[offset_group, colunm]);

            cmd = "HC_" + this.OffsetGroup_name[offset_group, colunm] + "Value(" + axis.ToString() + ")";
            if (false == Connection.CNCtoDT.CSDownLoadToPPMAC(cmd, this.OffsetGroup_localValue[offset_group, colunm][axis]))
            {
                MessageBox.Show("Error: Connection.CNCtoDT.CSDownLoadToPPMAC(cmd, offset_value)");
            }
        }

        //----------------------------------
        // event
        //----------------------------------
        private void CS_Prev_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.CurrentOffsetGroup > 0)
            {
                CurrentOffsetGroup--;
                OffsetGroupSwitch(CurrentOffsetGroup);
            }
        }

        private void CS_Next_MouseDown(object sender, MouseEventArgs e)
        {
            if (CurrentOffsetGroup < MaxGroupNum - 1)
            {
                CurrentOffsetGroup++;
                OffsetGroupSwitch(CurrentOffsetGroup);
            }
        }

        private void CS_Click(object sender, EventArgs e)
        {
            int column = 0, axis = 0;
            int current_column = 0, current_axis = 0;
            double value = 0.0;

            for (column = 0; column < 3; column++)
            {
                for (axis = 0; axis < 4; axis++)
                {
                    if ((Label)sender == this.CS_show_G5X_value[column, axis])
                    {
                        current_axis = axis;
                        current_column = column;
                        column = 3;
                        axis = 4;
                    }
                }
            }

            double.TryParse(this.CS_show_G5X_value[current_column, current_axis].Text, out value);
            this.m_MsgDlg.current_settting_value = value;
            this.m_MsgDlg.current_machine_value = ShareMemory.CS.Machine[current_axis];

            if (DialogResult.OK == this.m_MsgDlg.ShowDialog())
            {
                this.CS_show_G5X_value[current_column, current_axis].Text = this.m_MsgDlg.ReturnCurrentSettingValue().ToString();
                this.OffsetGroup_localValue[CurrentOffsetGroup, current_column][current_axis] = this.m_MsgDlg.ReturnCurrentSettingValue();

                this.save_settings(CurrentOffsetGroup, current_column, current_axis);
            }
        }

        private void EXT_Click(object sender, EventArgs e)
        {
            int axis = 0, current_axis = 0;
            double value = 0.0;
            string cmd = string.Empty;

            for (axis = 0; axis < 4; axis++)
            {
                if ((Label)sender == this.CS_show_EXT_value[axis])
                {
                    current_axis = axis;
                    axis = 4;
                }
            }

            double.TryParse(this.CS_show_EXT_value[current_axis].Text, out value);
            this.m_MsgDlg.current_settting_value = value;
            this.m_MsgDlg.current_machine_value = ShareMemory.CS.Machine[current_axis];
            if (m_MsgDlg.ShowDialog() == DialogResult.OK)
            {
                this.CS_show_EXT_value[current_axis].Text = this.m_MsgDlg.ReturnCurrentSettingValue().ToString();
                this.EXTValue[current_axis] = this.m_MsgDlg.ReturnCurrentSettingValue();
                ShareMemory.COffset.EXTValue[current_axis] = this.EXTValue[current_axis];
                this.SaveFile(@"Offset\" + ShareMemory.COffset.EXT_name + ".txt", this.EXTValue);

                cmd = "HC_" + ShareMemory.COffset.EXT_name + "Value(" + current_axis.ToString() + ")";
                if (false == Connection.CNCtoDT.CSDownLoadToPPMAC(cmd, this.EXTValue[current_axis]))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.CSDownLoadToPPMAC(" + cmd + ", offset_value)");
                }
            }
        }

        private void updateWMPointResultTimer_Tick(object sender, EventArgs e)
        {
            if (true == ShareMemory.isUpdatePointResult)
            {
                int current_offset_group = ShareMemory.G_index / 3;
                int current_column = ShareMemory.G_index % 3;

                this.OffsetGroup_localValue[current_offset_group, current_column][ShareMemory.X] = ShareMemory.wmPointResult[ShareMemory.X];
                this.OffsetGroup_localValue[current_offset_group, current_column][ShareMemory.Y] = ShareMemory.wmPointResult[ShareMemory.Y];

                this.save_settings(current_offset_group, current_column, ShareMemory.X);
                this.save_settings(current_offset_group, current_column, ShareMemory.Y);

                if (this.CurrentOffsetGroup == current_offset_group)
                {
                    this.CS_show_G5X_value[current_column, ShareMemory.X].Text = this.OffsetGroup_localValue[current_offset_group, current_column][ShareMemory.X].ToString();
                    this.CS_show_G5X_value[current_column, ShareMemory.Y].Text = this.OffsetGroup_localValue[current_offset_group, current_column][ShareMemory.Y].ToString();
                }

                ShareMemory.isUpdatePointResult = false;
            }
        }

        private void cleanColumnButton_Click(object sender, EventArgs e)
        {
            int column = -1;
            for (int index = 0; index < MaxColumnNum; index++)
            {
                if ((Button)sender == this.CleanColumn[index])
                {
                    column = index;
                    index = MaxColumnNum;
                }
            }
            if (-1 != column)
            {
                for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
                {
                    this.CS_show_G5X_value[column, axis].Text = "0";
                    this.OffsetGroup_localValue[CurrentOffsetGroup, column][axis] = 0;
                    this.save_settings(CurrentOffsetGroup, column, axis);
                }
            }
        }

        private void cleanEXTButton_Click(object sender, EventArgs e)
        {
            string cmd = string.Empty;

            for (int axis = 0; axis < ShareMemory.AxisNum; axis++)
            {
                this.CS_show_EXT_value[axis].Text = "0";
                this.EXTValue[axis] = 0;
                ShareMemory.COffset.EXTValue[axis] = this.EXTValue[axis];
                this.SaveFile(@"Offset\" + ShareMemory.COffset.EXT_name + ".txt", this.EXTValue);

                cmd = "HC_" + ShareMemory.COffset.EXT_name + "Value(" + axis.ToString() + ")";
                if (false == Connection.CNCtoDT.CSDownLoadToPPMAC(cmd, this.EXTValue[axis]))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.CSDownLoadToPPMAC(" + cmd + ", offset_value)");
                }
            }
        }
    }
}
