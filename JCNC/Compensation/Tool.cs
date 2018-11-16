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

namespace Compensation
{
    public partial class Tool : Form
    {
        enum offset_column { NUM, HEIGHT, HWASTE, DIAMETER, DWASTE };
        
        private string CopyRowBuffer;

        private int recover_row, recover_column;
        private double recover_value;

        private bool DataBootLoad;
        private bool is_show_text;

        public Tool()
        {
            InitializeComponent();

            this.CopyRowBuffer = string.Empty;
            this.DataBootLoad = true;
            this.is_show_text = false;

            // Copy database to dir when database doesn't exist.
            this.SetupDatabase();

            // TODO: 這行程式碼會將資料載入 'toolDBDataSet.Offset' 資料表。您可以視需要進行移動或移除。
            this.offsetTableAdapter.Fill(this.toolDBDataSet.Offset);
            
            // Add content to database
            if (0 == this.toolDataGridView.RowCount)
            {
                for (int index = 0; index < 100; index++)
                {
                    this.toolDBDataSet.Offset.AddOffsetRow(0.000, 0.000, 0.000, 0.000);
                    Application.DoEvents();
                }
                this.offsetTableAdapter.Update(this.toolDBDataSet.Offset);
            }

            this.SetFont();

            DataBootLoad = false;
            this.updateHeightTimer.Start();
        }

        //----------------------------------
        // access functions for control
        //----------------------------------
        public bool SetOffsetData(int tool_num, double tool_height )     // 自動探刀給值
        {
            if ((1 <= tool_num) && (100 >= tool_num))
            {
                int row = tool_num - 1;
                int column = (int)offset_column.HEIGHT;

                this.toolDBDataSet.Offset.Rows[row][column] = tool_height;
                this.offsetTableAdapter.Update(this.toolDBDataSet.Offset);

                return true;
            }
            else
            {
                return false;
            }
        }

        // HEIGHT, HWASTE, DIAMETER, DWASTE
        public bool GetOffsetData(int tool_num, string selected_data, out double OffsetData)     // 回傳補正資訊
        {
            if ((1 <= tool_num) && (100 >= tool_num))
            {
                int row = tool_num - 1;
                int column = -1;

                switch (selected_data)
                {
                    case "HEIGHT":
                        column = (int)offset_column.HEIGHT;
                        break;
                    case "HWASTE":
                        column = (int)offset_column.HWASTE;
                        break;
                    case "DIAMETER":
                        column = (int)offset_column.DIAMETER;
                        break;
                    case "DWASTE":
                        column = (int)offset_column.DWASTE;
                        break;
                    default:
                        break;
                }

                if (-1 != column)
                {
                    OffsetData = System.Convert.ToDouble(this.toolDBDataSet.Offset[row][column]);
                    return true;
                }
                else
                {
                    OffsetData = 0;
                    return false;
                }
            }
            else
            {
                OffsetData = 0;
                return false;
            }
        }


        //----------------------------------
        // sub-functions
        //----------------------------------
        private void SetFont()
        {
            this.toolDataGridView.Columns[(int)offset_column.HEIGHT].DefaultCellStyle.Font = new Font("Times New Roman", 18f, FontStyle.Bold);
            this.toolDataGridView.Columns[(int)offset_column.HWASTE].DefaultCellStyle.Font = new Font("Times New Roman", 18f, FontStyle.Bold);
            this.toolDataGridView.Columns[(int)offset_column.DIAMETER].DefaultCellStyle.Font = new Font("Times New Roman", 18f, FontStyle.Bold);
            this.toolDataGridView.Columns[(int)offset_column.DWASTE].DefaultCellStyle.Font = new Font("Times New Roman", 18f, FontStyle.Bold);
            
            this.inputButton.Font = new Font("Times New Roman", 16f, FontStyle.Regular);
            this.inputTextBox.Font = new Font("Times New Roman", 18f, FontStyle.Bold);

            this.relativeInputButton.Font = new Font("Times New Roman", 16f, FontStyle.Regular);

            this.searchTextBox.Font = new Font("Times New Roman", 18f, FontStyle.Bold);
            this.searchButton.Font = new Font("標楷體", 16f, FontStyle.Regular);
            this.copyButton.Font = new Font("標楷體", 16f, FontStyle.Regular);
            this.pasteButton.Font = new Font("標楷體", 16f, FontStyle.Regular);
            this.clearButton.Font = new Font("標楷體", 16f, FontStyle.Regular);
            this.recoverButton.Font = new Font("標楷體", 16f, FontStyle.Regular);

            this.toolDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("標楷體", 16f, FontStyle.Regular);

            this.valueLabel.Font = new Font("標楷體", 12f, FontStyle.Bold);                       
        }

        private void SetTextBoxFocus()
        {
            // set focus
            this.inputTextBox.Focus();
            this.inputTextBox.Select(this.inputTextBox.Text.Length, 0);
        }

        private void SetRecoverData(int row, int column, double value)
        {
            this.recover_row = row;
            this.recover_column = column;
            this.recover_value = value;
        }

        private void GetRecoverData(object sender, EventArgs e)
        {
            if ((-1 != this.recover_row) || (-1 != this.recover_column))
            {
                this.toolDataGridView.CurrentCell = this.toolDataGridView[this.recover_column, this.recover_row];
                this.inputTextBox.Text = this.recover_value.ToString();

                this.inputButton.PerformClick();
            }
        }

        private void SetupDatabase()
        {
            string fileName_mdf = "ToolDB.mdf";
            string fileName_ldf = "ToolDB_log.ldf";
            string sourcePath = @".\database";
            string targetPath = @".\";

            // Use Path class to manipulate file and directory paths.
            string sourceFile_mdf = System.IO.Path.Combine(sourcePath, fileName_mdf);
            string sourceFile_ldf = System.IO.Path.Combine(sourcePath, fileName_ldf);
            string destFile_mdf = System.IO.Path.Combine(targetPath, fileName_mdf);
            string destFile_ldf = System.IO.Path.Combine(targetPath, fileName_ldf);
            
            // mdf file
            if (false == System.IO.File.Exists(destFile_mdf))
            {
                // file didn't exists, then copy file to destination (overwrite)
                System.IO.File.Copy(sourceFile_mdf, destFile_mdf, true);
            }

            // ldf file
            if (false == System.IO.File.Exists(destFile_ldf))
            {
                // file didn't exists, then copy file to destination (overwrite)
                System.IO.File.Copy(sourceFile_ldf, destFile_ldf, true);
            }            
        }

        //----------------------------------
        // event
        //----------------------------------
        private void Tool_Load(object sender, EventArgs e)
        {
            this.recover_row = -1;
            this.recover_column = -1;

            this.toolDataGridView.CurrentCell = toolDataGridView[(int)offset_column.HEIGHT, 0];
            this.inputTextBox.Text = this.toolDataGridView[(int)offset_column.HEIGHT, 0].FormattedValue.ToString();
            this.is_show_text = true;
        }

        private void toolDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int row = this.toolDataGridView.CurrentCell.RowIndex;
            int column = this.toolDataGridView.CurrentCell.ColumnIndex;

            if ((int)offset_column.NUM == column)
            {
                this.toolDataGridView.CurrentCell = toolDataGridView[(int)offset_column.HEIGHT, row];
            }
            else
            {
                if (true == this.is_show_text)
                {
                    string selected_text = this.toolDataGridView[column, row].FormattedValue.ToString();
                    this.inputTextBox.Text = selected_text;

                    this.SetTextBoxFocus();
                    this.inputTextBox_Click(this.inputTextBox, e);
                }
            }
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            int row = this.toolDataGridView.CurrentCell.RowIndex;
            int column = this.toolDataGridView.CurrentCell.ColumnIndex;

            string temp_string = this.inputTextBox.Text;
            int position = temp_string.IndexOf("-");

            if (position > 0)
            {
                MessageBox.Show("Error data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.inputTextBox.Text = temp_string.Remove(position, 1);
            }
            else
            {
                if (!DataBootLoad)
                {
                    double current_value = System.Convert.ToDouble(this.toolDBDataSet.Offset[row][column]);
                    this.SetRecoverData(row, column, current_value);            // for recover

                    this.toolDBDataSet.Offset.Rows[row][column] = System.Convert.ToDouble(this.inputTextBox.Text);

                    this.offsetTableAdapter.Update(this.toolDBDataSet.Offset);
                    this.SetTextBoxFocus();

                    double value = 0.0;
                    double.TryParse(this.inputTextBox.Text, out value);
                    if (false == Connection.CNCtoDT.CompensationDownLoadToPPMAC(column, row, value))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.CompensationDownLoadToPPMAC((ShareMemory.CompensatType)column, row, value))");
                    }
                }
            }
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyValue = (int)e.KeyChar;

            // 0~10 or backspace  or delete. 
            if (((keyValue >= 48) && (keyValue <= 57)) || (keyValue == 8) || (keyValue == 127))
            {
                e.Handled = false;
            }
            else if (keyValue == 45)        // minus
            {
                string text = this.inputTextBox.Text;
                if (-1 == text.IndexOf("-"))    // no minus
                {
                    e.Handled = false;
                }
                else                            // minus
                {
                    e.Handled = true;
                }
            }
            else if (keyValue == 46)        // dot
            {
                string text = this.inputTextBox.Text;
                if (-1 == text.IndexOf("."))    // no dot
                {
                    e.Handled = false;
                }
                else                            // dot
                {
                    e.Handled = true;
                }
            }
            else if (keyValue == 13)        // enter
            {
                e.Handled = false;
                this.inputButton.PerformClick();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyValue = (int)e.KeyChar;

            // 0~10 or backspace or delete. 
            if (((keyValue >= 48) && (keyValue <= 57)) || (keyValue == 8) || (keyValue == 127))
            {
                e.Handled = false;
            }
            else if (keyValue == 13)        // enter
            {
                e.Handled = false;
                this.searchButton.PerformClick();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(this.searchTextBox.Text,out value);
            int tool_num_index = value - 1;

            if ((tool_num_index >= 0) && (tool_num_index < 100))
            {
                this.is_show_text = false;
                this.toolDataGridView.CurrentCell = this.toolDataGridView[(int)offset_column.HEIGHT, tool_num_index];
                this.is_show_text = true;

                int.TryParse(this.searchTextBox.Text, out value);
                this.toolVScrollBar.Value = value;
            }
            else
            {
                MessageBox.Show("請輸入1~100的刀號值！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.searchTextBox.Text = "1";
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string temp_string = this.inputTextBox.Text;
            this.CopyRowBuffer = temp_string;

            this.SetTextBoxFocus();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            if ("" != this.CopyRowBuffer)
            {
                this.inputTextBox.Text = this.CopyRowBuffer;
                this.inputButton.PerformClick();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //this.inputTextBox.Text = "0.000";
            //this.inputButton.PerformClick();

            // clear all
            if (DialogResult.Yes == MessageBox.Show("是否要執行全部資料清除，清除後不可復原!", "Clear All", MessageBoxButtons.YesNo))
            {
                for (int row = 0; row < 100; row++)
                {
                    for (int column = 1; column < 5; column++)
                    {
                        this.toolDBDataSet.Offset.Rows[row][column] = 0.000;
                    }
                }
                this.offsetTableAdapter.Update(this.toolDBDataSet.Offset);
            }
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            this.GetRecoverData(sender, e);
        }

        private void relativeInputButton_Click(object sender, EventArgs e)
        {            
            int row = this.toolDataGridView.CurrentCell.RowIndex;
            int column = this.toolDataGridView.CurrentCell.ColumnIndex;

            double current_value = System.Convert.ToDouble(this.toolDBDataSet.Offset[row][column]);
            double relative_value = System.Convert.ToDouble(this.inputTextBox.Text);
            double sum = current_value + relative_value;

            this.inputTextBox.Text = sum.ToString("#0.000");
            this.inputButton.PerformClick();
        }

        private void inputTextBox_Click(object sender, EventArgs e)
        {
            int row = this.toolDataGridView.CurrentCell.RowIndex;
            int column = this.toolDataGridView.CurrentCell.ColumnIndex;
            bool need_transfer = false, is_only_number = false;

            if ((int)offset_column.HEIGHT == column)    need_transfer = true;

            MsgDlg m_MsgDlg = new MsgDlg(need_transfer, is_only_number);
            m_MsgDlg.current_settting_value = System.Convert.ToDouble(this.inputTextBox.Text);
            m_MsgDlg.current_machine_value = ShareMemory.CS.Machine[ShareMemory.Z];
            if (DialogResult.OK == m_MsgDlg.ShowDialog())
            {
                this.inputTextBox.Text = m_MsgDlg.ReturnCurrentSettingValue().ToString();
                this.inputButton.PerformClick();
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            bool need_transfer = false, is_only_number = true;

            MsgDlg m_MsgDlg = new MsgDlg(need_transfer, is_only_number);
            m_MsgDlg.current_settting_value = System.Convert.ToDouble(this.searchTextBox.Text);
            m_MsgDlg.current_machine_value = 0;
            if (DialogResult.OK == m_MsgDlg.ShowDialog())
            {
                this.searchTextBox.Text = m_MsgDlg.ReturnCurrentSettingValue().ToString();
            }
        }

        private void updateHeightTimer_Tick(object sender, EventArgs e)
        {
            if (true == ShareMemory.isUpdateHeight)
            {
                this.SetOffsetData(ShareMemory.tmToolNum, ShareMemory.tmToolHeight);
                ShareMemory.isUpdateHeight = false;
            }
        }

        private void toolVScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.toolDataGridView.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

    }
}
