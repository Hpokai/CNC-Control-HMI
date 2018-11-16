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
using KeyBoard;

namespace MDIOP
{
    public partial class FORM_Prog_MdiFileEdit : Form
    {
        enum item { num, cmd };

        static int Indexi = 0;
        private string CopyRowBuffer;
        private bool is_show_text;


        //double XAxisFB, YAxisFB, ZAxisFB;//, CAxisFB, XDistGo, YDistGo, ZDistGo, CDistGo;
        private double[] AxisFB;//, CAxisFB, XDistGo, YDistGo, ZDistGo, CDistGo;
        private Label[] AbsCood_Value;
        private Label[] RelCood_Value;

        public FORM_Prog_MdiFileEdit()
        {
            InitializeComponent();

            this.CopyRowBuffer = string.Empty;

            this.mdiInputTextBox.Font = new Font("Times New Roman", 22f, FontStyle.Regular);
            this.mdiInputButton.Font = new Font("Times New Roman", 18f, FontStyle.Regular);
            this.MDIGridView.Columns[(int)item.num].DefaultCellStyle.BackColor = Color.Gray;
            this.MDIGridView.Columns[(int)item.num].DefaultCellStyle.Font = new Font("Times New Roman", 18f, FontStyle.Bold | FontStyle.Italic);
            this.MDIGridView.Columns[(int)item.cmd].DefaultCellStyle.Font = new Font("Times New Roman", 22f, FontStyle.Regular);

            this.AxisFB = new double[ShareMemory.AxisNum] { 0.0, 0.0, 0.0, 0.0 };
            this.AbsCood_Value = new Label[ShareMemory.AxisNum] { this.AbsCood_XValue, this.AbsCood_YValue, this.AbsCood_ZValue, this.AbsCood_CValue };
            this.RelCood_Value = new Label[ShareMemory.AxisNum] { this.RelCood_XValue, this.RelCood_YValue, this.RelCood_ZValue, this.RelCood_CValue };
            // 
            this.InitCoodinateInformation();

            ShareMemory.PageInitFinshed = true;

            CSTimer.Interval = 50;
            CSTimer.Start();
        }

        //----------------------------------
        // sub-functions
        //----------------------------------
        private void InitCoodinateInformation()
        {
            MacCood.Font = new Font("標楷體", 28f, FontStyle.Bold);
            ProgCood.Font = new Font("標楷體", 28f, FontStyle.Bold);
            MacCood_X.Font = new Font("Times New Roman", 36f, FontStyle.Bold);
            MacCood_Y.Font = new Font(FontFamily.GenericSerif, 36f, FontStyle.Bold);
            MacCood_Z.Font = new Font(FontFamily.GenericSerif, 36f, FontStyle.Bold);
            MacCood_C.Font = new Font(FontFamily.GenericSerif, 36f, FontStyle.Bold);
            ProgCood_X.Font = new Font("Times New Roman", 36f, FontStyle.Bold);
            ProgCood_Y.Font = new Font(FontFamily.GenericSerif, 36f, FontStyle.Bold);
            ProgCood_Z.Font = new Font(FontFamily.GenericSerif, 36f, FontStyle.Bold);
            ProgCood_C.Font = new Font(FontFamily.GenericSerif, 36f, FontStyle.Bold);
            MacCood.Text = "機械座標";
            ProgCood.Text = "相對座標";
            MacCood_X.Text = "X";
            MacCood_Y.Text = "Y";
            MacCood_Z.Text = "Z";
            MacCood_C.Text = "C";
            ProgCood_X.Text = "X";
            ProgCood_Y.Text = "Y";
            ProgCood_Z.Text = "Z";
            ProgCood_C.Text = "C";
            AbsCood_Value[ShareMemory.X].Text = "-1000.123";
        }

        private void RefreshLineNumber()
        {
            int total_row = this.MDIGridView.RowCount;

            for (int index = 0; index < total_row; index++)
            {
                this.MDIGridView[(int)item.num, index].Value = (index + 1).ToString().PadLeft(2, '0') + " ";
            }

            this.mdiVScrollBar.Maximum = this.MDIGridView.RowCount;
        }

        private void WriteFile(int last_row)
        {
            StreamWriter streamWriter = new StreamWriter(@"tmp\MDICmd.NC", false);
            int line_index = 0;
            for (line_index = 0; line_index <= last_row; line_index++)
            {
                streamWriter.WriteLine(this.MDIGridView[(int)item.cmd, line_index].Value.ToString());
            }
            streamWriter.Close();
        }

        private void SetTextBoxFocus()
        {
            // set focus
            this.mdiInputTextBox.Focus();
            this.mdiInputTextBox.Select(this.mdiInputTextBox.Text.Length, 0);
        }

        //----------------------------------
        // event
        //----------------------------------
        private void MF_Prog_MDI_Load(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            this.is_show_text = false;

            string[] readText = File.ReadAllLines(@"tmp\MDICmd.NC");

            this.MDIGridView.ColumnCount = 2;
            this.MDIGridView.RowCount = readText.Count();
            foreach (string s in readText)
            {
                this.MDIGridView[0, Indexi].Value = (Indexi + 1).ToString().PadLeft(2, '0') + " ";
                this.MDIGridView[1, Indexi].Value = s;
                Indexi++;
            }

            Indexi--;
            this.UseWaitCursor = false;

            this.MDIGridView.CurrentCell = MDIGridView[(int)item.cmd, Indexi];
            this.MDIGridView_SelectionChanged(sender, e);   // Get command string
            this.SetTextBoxFocus();

            this.is_show_text = true;

            this.mdiVScrollBar.Maximum = this.MDIGridView.RowCount;
            this.mdiVScrollBar.Value = this.mdiVScrollBar.Maximum;
        }

        private void mdiInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        this.mdiInputButton_Click(sender, e);
                    }
                    break;
                default:
                    break;
            }
        }

        private void MDIGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (true == this.is_show_text)
            {
                int row = this.MDIGridView.CurrentCell.RowIndex;
                int column = this.MDIGridView.CurrentCell.ColumnIndex;

                string selected_text = this.MDIGridView[1, row].Value.ToString();

                this.mdiInputTextBox.Text = selected_text;
                this.SetTextBoxFocus();

                this.mdiInputTextBox_Click(sender, e);
            }
        }

        private void mdiInputButton_Click(object sender, EventArgs e)
        {
            int current_row = this.MDIGridView.CurrentCell.RowIndex;
            int current_row_num = current_row + 1;
            int next_row_num = current_row_num + 1;
            int next_row = next_row_num - 1;
            int last_row = this.MDIGridView.RowCount - 1;

            this.MDIGridView[1, current_row].Value = this.mdiInputTextBox.Text;

            this.is_show_text = false;
            if (current_row == last_row)
            {
                this.MDIGridView.Rows.Add(next_row_num.ToString().PadLeft(2, '0') + " ", "");     //hpokai
                this.MDIGridView.Rows[next_row].Height = 35;
                this.MDIGridView.CurrentCell = MDIGridView[1, next_row];
                this.MDIGridView.Focus();
                this.MDIGridView_SelectionChanged(sender, e);
            }
            this.is_show_text = true;

            this.WriteFile(this.MDIGridView.RowCount - 1);
            this.SetTextBoxFocus();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (1 >= this.MDIGridView.RowCount)
            {
                this.MDIGridView[(int)item.cmd, 0].Value = string.Empty;
                //this.MDIGridView_SelectionChanged(sender, e);
            }
            else
            {
                this.is_show_text = false;
               // System.Collections.IEnumerator enumerator = this.MDIGridView.SelectedRows.GetEnumerator();
                int row = this.MDIGridView.SelectedRows[0].Index;
                int last_row = this.MDIGridView.RowCount - 1;

                if (row < last_row)
                {
                    this.MDIGridView.Rows.RemoveAt(row);
                    this.RefreshLineNumber();
                }
                this.is_show_text = true;
            }

            // write file
            this.WriteFile(this.MDIGridView.RowCount - 1);
        }

        private void copyLineButton_Click(object sender, EventArgs e)
        {
            string temp_string = this.mdiInputTextBox.Text;
            this.CopyRowBuffer = temp_string;

            this.SetTextBoxFocus();
        }

        private void pasteLineButton_Click(object sender, EventArgs e)
        {
            this.mdiInputTextBox.Text = this.CopyRowBuffer;
            this.mdiInputButton_Click(sender, e);
        }

        private void searchLineButton_Click(object sender, EventArgs e)
        {
            this.is_show_text = false;

            SearchLine searchLine = new SearchLine();
            searchLine.Owner = this;
            DialogResult result = searchLine.ShowDialog();

            if (DialogResult.OK == result)
            {
                if ((-1 < searchLine.Line_number) && (this.MDIGridView.RowCount > searchLine.Line_number))
                {
                    this.MDIGridView.CurrentCell = MDIGridView[(int)item.cmd, searchLine.Line_number];
                    //this.MDIGridView_SelectionChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("行號值超出範圍！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.mdiVScrollBar.Value = this.MDIGridView.CurrentRow.Index;
            }

            searchLine = null;

            this.is_show_text = true;
        }

        private void deleteAllLinesButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("刪除MDI檔案?", "警告",
                                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (answer == DialogResult.OK)
            {
                this.is_show_text = false;
                this.MDIGridView.Rows.Clear();
                this.MDIGridView.Rows.Add("01 ", "");     //hpokai
                this.MDIGridView.Rows[0].Height = 35;
                this.is_show_text = true;

                this.WriteFile(this.MDIGridView.RowCount - 1);
                this.SetTextBoxFocus();

                this.RefreshLineNumber();
            }
        }

        private void clearRowButton_Click(object sender, EventArgs e)
        {
            int current_row = this.MDIGridView.CurrentCell.RowIndex;
            int max_row_index = this.MDIGridView.Rows.Count - 1;

            this.mdiInputTextBox.Text = "";
            if (max_row_index > current_row)
            {
                this.mdiInputButton_Click(sender, e);
            }
        }

        private void insertRowButton_Click(object sender, EventArgs e)
        {
            int current_row = this.MDIGridView.CurrentCell.RowIndex;
            int next_row = current_row + 1;

            if (0 == current_row)
            {
                if (DialogResult.Yes == MessageBox.Show("插入行是否為上一行？", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    next_row = 0;
                    current_row = 1;
                }
            }

            this.MDIGridView.Rows.Insert(next_row, new DataGridView());
            this.MDIGridView[(int)item.num, next_row].Value = string.Empty;
            this.MDIGridView[(int)item.cmd, next_row].Value = string.Empty;
            //this.MDIGridView.Rows[next_row].Height = 35;

            this.mdiInputTextBox.Text = this.MDIGridView[1, current_row].Value.ToString();

            this.RefreshLineNumber();
            this.mdiInputButton_Click(sender, e);
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            string sourceFileName = "MDICmd.NC";
            string targetFileName = "MDIDefault.NC";
            string sourcePath = @".\tmp";
            string targetPath = @".\pfiles";
            
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, sourceFileName);
            string destFile = System.IO.Path.Combine(targetPath, targetFileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);

            MessageBox.Show("MDIDefault.NC file is saved, Please check it in the Programe Edit!");
        }

        private void CSTimer_Tick(object sender, EventArgs e)
        {
            for (int axis_num = 0; axis_num < ShareMemory.CS.AxisNum; axis_num++)
            {
                AxisFB[axis_num] = ShareMemory.CS.Machine[axis_num];
                if (System.Math.Abs(AxisFB[axis_num]) < 0.001)
                {
                    AxisFB[axis_num] = 0.0;
                    AbsCood_Value[axis_num].Text = "0.000";
                }
                else
                {
                    AbsCood_Value[axis_num].Text = string.Format("{0:0.000}", AxisFB[axis_num]);
                }

                // relative coordinate
                this.RelCood_Value[axis_num].Text = string.Format("{0:0.000}", ShareMemory.CS.Rel[axis_num] - ShareMemory.CS.RelOffset[axis_num]);
            }
        }

        private void mdiInputTextBox_Click(object sender, EventArgs e)
        {
            CNCKeys cncKeys_dlg = new CNCKeys(false);
            cncKeys_dlg.SetOldSentence(this.mdiInputTextBox.Text);
            DialogResult ret = cncKeys_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                this.mdiInputTextBox.Text = cncKeys_dlg.ReturnCurrentSentence();
                this.mdiInputButton.PerformClick();

                this.mdiVScrollBar.Maximum = this.MDIGridView.RowCount;
                this.mdiVScrollBar.Value = this.mdiVScrollBar.Maximum;
                if (this.MDIGridView.CurrentRow.Index == this.MDIGridView.RowCount - 1)
                {
                    this.MDIGridView_Click(sender, e);
                }

                ShareMemory.System.UploadMDIFile = ShareMemory.Switch.On;
            }
        }

        private void MDIGridView_Click(object sender, EventArgs e)
        {
            this.MDIGridView_SelectionChanged(sender, e);
        }

        private void mdiVScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.MDIGridView.FirstDisplayedScrollingRowIndex = e.NewValue;
        }
    }
}
