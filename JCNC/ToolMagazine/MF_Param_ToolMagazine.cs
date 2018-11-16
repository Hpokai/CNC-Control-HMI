using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using JCNCShareMemory;

namespace ToolMagazine
{
    public partial class FORM_Param_ToolMagazine : Form
    {
        private const int MaxToolNum = 10;
        private INumPad iNumPad = new CNumPad(false);
        private NumPad numPad = null;

        private string tool_file_path = @"Parameter\ToolMagazine\tool.txt";
        private string axis0_file_path = @"Parameter\ToolMagazine\axis0.txt";
        private string axis1_file_path = @"Parameter\ToolMagazine\axis1.txt";
        private string axis2_file_path = @"Parameter\ToolMagazine\axis2.txt";
        private string axis3_file_path = @"Parameter\ToolMagazine\axis3.txt";
        private string axis4_file_path = @"Parameter\ToolMagazine\axis4.txt";
        private string axis5_file_path = @"Parameter\ToolMagazine\axis5.txt";
        private string[] file_path = null;


        public FORM_Param_ToolMagazine()
        {
            InitializeComponent();

            this.iNumPad.PadValueChangedHandler += new EventHandler<NumPadEventArgs>(iNumPad_PadValueChangedHandler);

            this.numPad = new NumPad(this.iNumPad);
            this.numPad.TopLevel = false;
            this.numPadPanel.Controls.Add(this.numPad);
            this.numPad.Location = new Point(0, 0);
            this.numPad.Show();
            this.file_path = new string[6] { axis0_file_path, axis1_file_path, axis2_file_path, axis3_file_path, axis4_file_path, axis5_file_path };
            
            this.SetLineNumber();
            this.GetDataFromPC();

            this.toolMagazineDataGridView.CurrentCell = this.toolMagazineDataGridView[1, 0];
            this.toolMagazineDataGridView.Click += new System.EventHandler(this.toolMagazineDataGridView_Click);
            this.toolHeightSensorTextBox.Click += new System.EventHandler(this.toolHeightSensorTextBox_Click);
        }

        void iNumPad_PadValueChangedHandler(object sender, NumPadEventArgs e)
        {
            double value = 0;
            if (e.isToolHeightSensor == false)
            {
                if (true == double.TryParse(e.Value, out value))
                {
                    this.toolMagazineDataGridView.CurrentCell.Value = value.ToString("#0.000");
                }
            }
            else
            {
                if (true == double.TryParse(e.Value, out value))
                {
                    this.toolHeightSensorTextBox.Text = value.ToString("#0.000");
                }
            }
        }

        private void SetLineNumber()
        {  
            this.toolMagazineDataGridView.Rows.Clear();
            this.toolMagazineDataGridView.RowCount = MaxToolNum;
            for (int index = 0; index < MaxToolNum; index++)
            {
                this.toolMagazineDataGridView[0, index].Value = (index + 1).ToString().PadLeft(2, '0') + " ";
            }
        }

        private void FillZeroData(string axis)
        {
            int axis_index = 1 + int.Parse(axis.Substring(axis.Length - 5, 1));

            for (int index = 0; index < MaxToolNum; index++)
            {
                this.toolMagazineDataGridView[axis_index, index].Value = (0).ToString("#0.000");
            }
        }

        private bool GetDataFromPC()
        {
            bool result = false;

            // for each axis
            foreach (var path in this.file_path)
            {
                if (false == File.Exists(path))
                {
                    this.FillZeroData(path);
                }
                else
                {
                    string[] readText = File.ReadAllLines(path);
                    int index = 0;
                    foreach (string s in readText)
                    {
                        this.toolMagazineDataGridView[(1 + int.Parse(path.Substring(path.Length - 5, 1))), index].Value = s;
                        ShareMemory.ToolPos.Coordiante[int.Parse(path.Substring(path.Length - 5, 1))][index] = s;
           
                        index++;
                    }
                }
            }

            // for tool height sensor
            if (false == File.Exists(this.tool_file_path))
            {
                this.toolHeightSensorTextBox.Text = "0.000";
            }
            else
            {
                string[] readText = File.ReadAllLines(this.tool_file_path);
                foreach (string s in readText)
                {
                    this.toolHeightSensorTextBox.Text = s;
                }
            }

            return result;
        }

        // 要分成開機全部傳  和修改參數時  更新有修改的
        private bool SetDataToPC(int tool_num, int coordinate)
        {
            bool result = false;

            ShareMemory.ToolPos.Coordiante[coordinate][tool_num] = this.toolMagazineDataGridView.Rows[tool_num].Cells[coordinate].Value != null ? this.toolMagazineDataGridView.Rows[tool_num].Cells[coordinate].Value.ToString() : "0.000";
            File.WriteAllLines(this.file_path[coordinate], ShareMemory.ToolPos.Coordiante[coordinate]);

            ShareMemory.ToolPos.current_tool_num = tool_num;
            ShareMemory.ToolPos.current_coordinate = coordinate;
            ShareMemory.ToolPos.UploadCoordinate = ShareMemory.Switch.On;
            return result;
            //int i = 0;
            //foreach (DataGridViewRow row in this.toolMagazineDataGridView.Rows)
            //{
            //ShareMemory.ToolPos.yCoordiante[i] = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "0.000";
            //ShareMemory.ToolPos.zCoordiante[i] = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "0.000";
            //i++;
            //{
        }

        private void toolMagazineDataGridView_Click(object sender, EventArgs e)
        {
            if (0 == ((DataGridView)sender).CurrentCell.ColumnIndex)
            {
                ((DataGridView)sender).CurrentCell = ((DataGridView)sender)[1, ((DataGridView)sender).CurrentCell.RowIndex];
            }
            else
            {
                NumPadEventArgs numPadEventArgs = new NumPadEventArgs(this.toolMagazineDataGridView.CurrentCell.Value.ToString(),false);
                this.iNumPad.OnDataValueChanged(numPadEventArgs);
            }
        }

        private void toolHeightSensorTextBox_Click(object sender, EventArgs e)
        {
            NumPadEventArgs numPadEventArgs = new NumPadEventArgs(this.toolHeightSensorTextBox.Text, true);
            this.iNumPad.OnDataValueChanged(numPadEventArgs);
        }

        private void toolHeightSensorTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] temp_string = new string[] { this.toolHeightSensorTextBox.Text };
            File.WriteAllLines(this.tool_file_path, temp_string);

            ShareMemory.ToolPos.CurrentToolHeightSensor = this.toolHeightSensorTextBox.Text;
            ShareMemory.ToolPos.ToolHeightSensorChange = ShareMemory.Switch.On;
        }
    }
}
