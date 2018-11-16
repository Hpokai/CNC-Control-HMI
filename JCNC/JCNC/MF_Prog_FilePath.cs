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
using JCNCDTCONECT;

namespace JCNC
{
    public partial class FORM_Prog_MemFileEdit : Form
    {
        static string strPath = "";
        static string strFullPath = "";
        static string NewFilePath = "";
        static string NewSaveFileName = "";
        static string InsertProc = "";
        static string m_ModifiedCode = "";
        static string strFileNameWithExt;
        private string copyedString;
        private int copyedCount;
        private string connectSymbol;

        private bool is_show_text;

        private int start_index;
        private bool next_row;
        
        public FORM_Prog_MemFileEdit()
        {
            this.copyedString = "";
            this.copyedCount = 0;
            this.connectSymbol = "@*@";

            this.is_show_text = false;

            InitializeComponent();
            InitFilePathDlg();
            TotalFileScan(true);
            GetFullPath();
            ShareMemory.PageInitFinshed = true;
        }
        
        //----------------------------------
        // sub-functions
        //----------------------------------
        public void InitFilePathDlg()
        {
            PathFileName.Font = new Font("標楷體", 24f, FontStyle.Bold);
            FileContent.Font = new Font("標楷體", 24f, FontStyle.Bold);
            strPath = @"pfiles\";
        }

        public void TotalFileScan(bool SetOrg)
        {
            int Index = FilePathInfo.SelectedIndex;
            DirectoryInfo dir = new DirectoryInfo(strPath);
            //            MessageBox.Show(strPath);
            FileInfo[] file = dir.GetFiles("*.NC");

            FilePathInfo.Items.Clear();
            foreach (FileInfo f in file)
            {
                FilePathInfo.Items.Add(Path.GetFileNameWithoutExtension(f.ToString()));
            }

            if (0 < this.FilePathInfo.Items.Count)
            {
                if (SetOrg)
                {
                    FilePathInfo.SetSelected(0, true);
                }
                else
                {
                    FilePathInfo.SetSelected(Index, true);
                }
            }

            this.fileListVScrollBar.Maximum = this.FilePathInfo.Items.Count;
        }

        private void ButtonState(bool state)
        {
            this.memGridView.Enabled = state;
            this.isMultiLineCheckBox.Enabled = state;
            this.copyButton.Enabled = state;
            this.pasteButton.Enabled = state;
            this.deleteButton.Enabled = state;
            this.insertButton.Enabled = state;
            this.closeFileButton.Enabled = state;
            this.inputButton.Enabled = state;
            this.inputTextBox.Enabled = state;
            this.clearRowButton.Enabled = state;
            this.searchLineButton.Enabled = state;
            this.searchButton.Enabled = state;
            this.replaceButton.Enabled = state;
            this.saveFileButton.Enabled = state;
            this.saveAsFileButton.Enabled = state;

            this.NewFileOpen.Enabled = !state;
            this.FileDelete.Enabled = !state;
            this.ChangeFileName.Enabled = !state;

            this.memVScrollBar.Enabled = state;
            this.fileListVScrollBar.Enabled = !state;
        }
        
        private void RefreshFile(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                GetFullPath();
                ShareMemory.SetFilePath(strFullPath, ShareMemory.OperationMode.MEM);
                ShareMemory.currentPath = string.Empty;
                ShareMemory.FileLoadOn = true;

                this.UseWaitCursor = true;
                this.is_show_text = false;
                this.memGridView.Rows.Clear();
                string[] readText = File.ReadAllLines(strFullPath);

                this.memGridView.RowCount = readText.Count();
                foreach (string s in readText)
                {
                    this.memGridView[0, index].Value = s;
                    index++;
                }

                int last_row = this.memGridView.Rows.Count - 1;
                if ("" != this.memGridView[0, last_row].Value.ToString())
                {
                    this.memGridView.Rows.Add("");     //hpokai
                }

                this.is_show_text = true;
                this.UseWaitCursor = false;
                //this.memGridView_SelectionChanged(sender, e);

                this.memVScrollBar.Maximum = this.memGridView.Rows.Count;
            }
            catch
            {
                return;
            }
        }

        private void GetFullPath()
        {
            strFullPath = strPath + (string)FilePathInfo.SelectedItem + ".NC";
        }

        public string FileRename(string NewFileName)
        {
            return NewFilePath = Path.GetFullPath(strPath) + NewFileName + ".NC";
        }

        public void Modify(string m_Modify)
        {
            m_ModifiedCode = m_Modify;
        }

        public void NSFileName(string newfilename)
        {
            NewSaveFileName = newfilename;
        }

        public void InsertProcess(string Insert)
        {
            InsertProc = Insert;
        }

        private void SetTextBoxFocus()
        {
            // set focus
            this.inputTextBox.Focus();
            this.inputTextBox.Select(this.inputTextBox.Text.Length, 0);
        }

        private void EncodeString(string selected_string)
        {
            copyedString = selected_string + this.connectSymbol + copyedString;
        }

        private string DecodeString()
        {
            string decode_string = "";
            int end_of_index = -1;

            end_of_index = copyedString.IndexOf(connectSymbol);
            if (-1 != end_of_index)
            {
                decode_string = copyedString.Substring(0, end_of_index);
                copyedString = copyedString.Remove(0, end_of_index + 3);
            }

            return decode_string;
        }

        private void InsertRow(int current_index, string text)
        {
            this.memGridView.Rows.Insert(current_index + 1, new DataGridView());
            //this.memGridView.Rows[current_index + 1].Height = 35;
            this.memGridView[0, current_index + 1].Value = text;
        }

        private int SearchString(int count, int row, string target)
        {
            int string_index = -1;
            int search_result = -1;
            string current_row = "";

            if (true == next_row) row++;

            for (int index = row; index < count; index++)
            {
                current_row = this.memGridView[0, index].Value.ToString();
                search_result = current_row.IndexOf(target, start_index);
                if (-1 != search_result)
                {
                    string_index = index;
                    index = count;
                    if ((search_result + 1) == current_row.Length)
                    {
                        start_index = 0;
                        next_row = true;
                    }
                    else
                    {
                        start_index = search_result + 1;
                        next_row = false;
                    }
                }
                else
                {
                    start_index = 0;
                }
            }
            if (-1 == string_index)
            {
                for (int index = 0; index <= row; index++)
                {
                    current_row = this.memGridView[0, index].Value.ToString();
                    search_result = current_row.IndexOf(target);
                    if (-1 != search_result)
                    {
                        string_index = index;
                        index = count;
                    }
                }
            }
            return string_index;
        }

        private void WriteFile(string file_name)
        {
            int last_row = this.memGridView.RowCount - 1;

            StreamWriter streamWriter = new StreamWriter(file_name, false);
            int line_index = 0;
            for (line_index = 0; line_index <= last_row; line_index++)
            {
                streamWriter.WriteLine(this.memGridView[0, line_index].Value.ToString());
            }
            streamWriter.Close();
        }


        //----------------------------------
        // event
        //----------------------------------
        private void MF_Prog_FilePath_Load(object sender, EventArgs e)
        {
            this.ButtonState(false);
            this.unsaveLabel.Text = "";
            this.inputTextBox.Text = "";
            this.lineNumLabel.Text = "LN: 0";
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            WarningMSG warningMSG = new WarningMSG("檔案載入中");
            warningMSG.Show();
            Application.DoEvents();
            
            if (0 < this.FilePathInfo.Items.Count)
            {
                strFileNameWithExt = (string)FilePathInfo.SelectedItem + ".NC";
                RefreshFile(sender, e);

                this.ButtonState(true);

            }
            warningMSG.Close();
            warningMSG.Dispose();
        }

        private void FileUpload_Click(object sender, EventArgs e)
        {
            WarningMSG warningMSG = new WarningMSG("檔案讀取中!");
            warningMSG.Show();
            Application.DoEvents();

            if (0 < this.FilePathInfo.Items.Count)
            {
                strFileNameWithExt = FilePathInfo.SelectedItem.ToString() + ".NC";

                string input_file_path = strPath + "\\" + strFileNameWithExt;
                string file_source = "MEM";
                ShareMemory.SetFilePath(input_file_path, ShareMemory.OperationMode.MEM);

                NCFormatFile.NcFormat ncFormat = new NCFormatFile.NcFormat();
                ncFormat.Initialize(input_file_path, file_source);
                bool ret = ncFormat.FormatFile();

                JCNCSettings.Default.AutoRunOpendFileName = strFileNameWithExt;

                if (false == Connection.CNCtoDT.FileUploadToPPMAC("NCFile\\", "MEM.NC"))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.FileUploadToPPMAC(MEM.NC)");
                }

                JCNCSettings.Default.Save();
                ShareMemory.currentPath = string.Empty;
                ShareMemory.FileLoadOn = true;
            }

            warningMSG.Close();
            warningMSG.Dispose();
            //MessageBox.Show("檔案讀取完成！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeFileButton_Click(object sender, EventArgs e)
        {
            this.is_show_text = false;

            strFileNameWithExt = "";
            this.memGridView.Rows.Clear();
            this.ButtonState(false);
            this.inputTextBox.Text = "";
            this.lineNumLabel.Text = "LN: 0";
            this.FilePathInfo.Enabled = true;

            this.is_show_text = true;
        }

        private void ChangeFileName_Click(object sender, EventArgs e)
        {
            if (0 < this.FilePathInfo.Items.Count)
            {
                MsgDlg m_MsgDlg = new MsgDlg((int)OP_TYPE.RENAME);
                m_MsgDlg.SetOldFileName(this.FilePathInfo.SelectedItem.ToString());
                if (m_MsgDlg.ShowDialog() == DialogResult.OK)
                {
                    this.FileRename(m_MsgDlg.FileName);
                    this.GetFullPath();
                    FileInfo TheFile = new FileInfo(strFullPath);
                    File.Move(strFullPath, NewFilePath);
                    File.Delete(strFullPath);
                    this.TotalFileScan(true);
                }
            }
        }

        private void FileDelete_Click(object sender, EventArgs e)
        {
            if (0 < this.FilePathInfo.Items.Count)
            {
                DialogResult dr = MessageBox.Show("確定刪除?", "取消  ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    GetFullPath();
                    FileInfo TheFile = new FileInfo(strFullPath);
                    File.Delete(strFullPath);
                    TotalFileScan(true);
                }
            }
        }

        private void FilePathInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFullPath();
        }

        private void memGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (false == this.memGridView.MultiSelect)
            {
                if (true == this.is_show_text)
                {
                    int row = this.memGridView.CurrentCell.RowIndex;
                    int column = this.memGridView.CurrentCell.ColumnIndex;
                    this.lineNumLabel.Text = "LN: " + (row + 1).ToString();

                    string selected_text = this.memGridView[0, row].Value.ToString();

                    this.inputTextBox.Text = selected_text;
                    this.SetTextBoxFocus();

                    this.inputTextBox_Click(sender, e);
                }
            }
        }

        private void isMultiLineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.is_show_text = false;
            if (true == this.isMultiLineCheckBox.Checked)
            {
                this.memGridView.MultiSelect = true;
                this.is_show_text = false;
                this.inputTextBox.Text = "";                
            }
            else
            {
                this.memGridView.MultiSelect = false;
                this.is_show_text = true;
            }
            this.is_show_text = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if ("" == this.unsaveLabel.Text)
                this.unsaveLabel.Text = "*";

            if (1 >= this.memGridView.RowCount)
            {
                this.memGridView[0, 0].Value = "";
            }
            else
            {
                this.is_show_text = false;
                foreach (DataGridViewRow row in this.memGridView.SelectedRows)
                {
                    this.memGridView.Rows.Remove(row);
                }
                this.is_show_text = true;
            }

            this.memVScrollBar.Maximum = this.memGridView.RowCount;       
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            this.copyedString = "";
            this.copyedCount = this.memGridView.SelectedRows.Count;
            foreach (DataGridViewRow row in this.memGridView.SelectedRows)
            {
                EncodeString(this.memGridView[0, row.Index].Value.ToString());
            }
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            int current_row = this.memGridView.CurrentCell.RowIndex;
            int current_selected_count = this.memGridView.SelectedRows.Count;
            //int next_row = current_row + current_selected_count + 1;
            int next_row = current_row + current_selected_count;
            int last_row = this.memGridView.RowCount - 1;

            string temp_string = this.copyedString;
            for (int index = 0; index < this.copyedCount; index++)
            {
                this.InsertRow(current_row + index, this.DecodeString());
            }
            this.copyedString = temp_string;


            this.is_show_text = false;
            if (false == this.isMultiLineCheckBox.Checked)
            {
                this.memGridView.Rows.RemoveAt(current_row);
            }
            else
            {
                if ( 1 < current_selected_count)
                {
                    foreach (DataGridViewRow row in this.memGridView.SelectedRows)
                    {
                        this.memGridView.Rows.RemoveAt(row.Index);
                    }
                }
            }

            if (current_row == last_row)
            {
                this.memGridView.Rows.Add("");     //hpokai
                this.memGridView.CurrentCell = memGridView[0, next_row];
                this.memGridView.Focus();
                this.lineNumLabel.Text = "LN: " + (next_row + 1).ToString();
            }


            this.is_show_text = true;
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            if ("" == this.unsaveLabel.Text)
                this.unsaveLabel.Text = "*";

            int current_row = this.memGridView.CurrentCell.RowIndex;
            int current_row_num = current_row + 1;
            int next_row_num = current_row_num + 1;
            int next_row = next_row_num - 1;
            int last_row = this.memGridView.RowCount - 1;

            this.is_show_text = false;
            if (current_row == last_row)
            {
                this.memGridView.Rows.Add("");     //hpokai
                this.memGridView.CurrentCell = memGridView[0, next_row];
                this.memGridView.Focus();
                this.lineNumLabel.Text = "LN: " + (next_row + 1).ToString();
            }
            this.is_show_text = true;

            this.memGridView[0, current_row].Value = this.inputTextBox.Text;
            this.SetTextBoxFocus();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if ("" == this.unsaveLabel.Text)
                this.unsaveLabel.Text = "*";

            int current_row = this.memGridView.CurrentCell.RowIndex;

            if (0 == current_row)
            {
                DialogResult result = MessageBox.Show("插入行是否為上一行？", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    current_row--;
                }
            }

            this.InsertRow(current_row, "");

            this.memVScrollBar.Maximum = this.memGridView.RowCount;            
        }

        private void clearRowButton_Click(object sender, EventArgs e)
        {
            this.inputTextBox.Text = "";
            //this.inputButton_Click(sender, e);
            this.inputButton.PerformClick();
        }

        private void searchLineButton_Click(object sender, EventArgs e)
        {
            this.is_show_text = false;

            SearchLine searchLine = new SearchLine();
            searchLine.Owner = this;
            DialogResult result = searchLine.ShowDialog();

            if (DialogResult.OK == result)
            {
                if ((-1 < searchLine.Line_number) && (this.memGridView.RowCount > searchLine.Line_number))
                {
                    this.memGridView.CurrentCell = memGridView[0, searchLine.Line_number];
                    this.memGridView_SelectionChanged(sender, e);
                }
                else if (this.memGridView.RowCount <= searchLine.Line_number)
                {
                    MessageBox.Show("行號值超出範圍！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.memGridView.CurrentCell = memGridView[0, this.memGridView.RowCount - 1];
                    this.memGridView_SelectionChanged(sender, e);
                }
                else if (-1 >= searchLine.Line_number)
                {
                    MessageBox.Show("行號值超出範圍！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.memGridView.CurrentCell = memGridView[0, 0];
                    this.memGridView_SelectionChanged(sender, e);
                }
            }
            searchLine = null;

            int row = this.memGridView.CurrentCell.RowIndex;
            this.lineNumLabel.Text = "LN: " + (row + 1).ToString();
            this.memVScrollBar.Value = row;

            this.is_show_text = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int row = this.memGridView.CurrentCell.RowIndex;
            int count = this.memGridView.Rows.Count;
            int search_index = -1;
            StringOperation stringOperation = new StringOperation( (int)TYPE.SEARCH );

            this.is_show_text = false;

            this.start_index = 0;
            this.next_row = false;
            DialogResult result = stringOperation.ShowDialog();
            while (DialogResult.OK == result)
            {
                if (string.Empty != stringOperation.SearchString)
                {
                    row = this.memGridView.CurrentCell.RowIndex;
                    search_index = this.SearchString(count, row, stringOperation.SearchString);

                    if (-1 == search_index)
                    {
                        MessageBox.Show("找不到搜尋目標！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.memGridView.CurrentCell = this.memGridView[0, search_index];
                        //this.memGridView_SelectionChanged(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("請輸入正確搜尋字串!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.lineNumLabel.Text = "LN: " + (this.memGridView.CurrentRow.Index + 1).ToString();
                this.memVScrollBar.Value = this.memGridView.CurrentRow.Index;
                result = stringOperation.ShowDialog();
            }

            stringOperation = null;

            this.is_show_text = true;
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            int row = this.memGridView.CurrentCell.RowIndex;
            int count = this.memGridView.Rows.Count;
            int search_index = -1;
            bool is_replace_all = false;
            StringOperation stringOperation = new StringOperation((int)TYPE.REPLACE);

            this.is_show_text = false;

            this.start_index = 0;
            this.next_row = false;
            DialogResult result = stringOperation.ShowDialog();
            while (DialogResult.OK == result)
            {
                if ((string.Empty != stringOperation.SearchString) && (string.Empty != stringOperation.ReplaceString))
                {
                    if (false == stringOperation.ReplaceAll)
                    {
                        row = this.memGridView.CurrentCell.RowIndex;
                        search_index = this.SearchString(count, row, stringOperation.SearchString);

                        if (-1 == search_index)
                        {
                            MessageBox.Show("沒有符合搜尋目標之取代！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.is_show_text = false;
                            this.memGridView.CurrentCell = this.memGridView[0, search_index];
                            this.inputTextBox.Text = this.memGridView[0, search_index].Value.ToString();
                            //this.memGridView_SelectionChanged(sender, e);

                            DialogResult d_r = MessageBox.Show("是否要取代？", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (DialogResult.OK == d_r)
                            {
                                this.inputTextBox.Text = this.inputTextBox.Text.Replace(stringOperation.SearchString, stringOperation.ReplaceString);
                                this.inputButton.PerformClick();
                            }
                        }

                        this.lineNumLabel.Text = "LN: " + (this.memGridView.CurrentRow.Index + 1).ToString();
                        this.memVScrollBar.Value = this.memGridView.CurrentRow.Index;
                        result = stringOperation.ShowDialog();
                    }
                    else
                    {
                        if (false == is_replace_all)
                        {
                            DialogResult d_r = MessageBox.Show("是否要\"全部\"取代？", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (DialogResult.OK == d_r)
                            {
                                is_replace_all = true;
                            }
                            else
                            {
                                is_replace_all = false;

                                this.lineNumLabel.Text = "LN: " + (this.memGridView.CurrentRow.Index + 1).ToString();
                                this.memVScrollBar.Value = this.memGridView.CurrentRow.Index;
                                result = stringOperation.ShowDialog();
                            }
                        }
                        else
                        {
                            row = this.memGridView.CurrentCell.RowIndex;
                            search_index = this.SearchString(count, row, stringOperation.SearchString);

                            if (-1 == search_index)
                            {
                                MessageBox.Show("沒有符合搜尋目標之取代！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                is_replace_all = false;
                                result = stringOperation.ShowDialog();
                            }
                            else
                            {
                                this.is_show_text = false;
                                this.memGridView.CurrentCell = this.memGridView[0, search_index];
                                this.inputTextBox.Text = this.memGridView[0, search_index].Value.ToString();
                                //this.memGridView_SelectionChanged(sender, e);

                                this.inputTextBox.Text = this.inputTextBox.Text.Replace(stringOperation.SearchString, stringOperation.ReplaceString);
                                this.inputButton.PerformClick();
                            }
                        }
                    }
                }
                else
                {  
                    MessageBox.Show("請輸入正確搜尋或取代字串!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = stringOperation.ShowDialog();  
                }
            }

            stringOperation = null;

            this.is_show_text = true;
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            this.unsaveLabel.Text = "";
            this.WriteFile(strFullPath);
            
            ShareMemory.currentPath = string.Empty;
            ShareMemory.FileLoadOn = true;
        }

        private void saveAsFileButton_Click(object sender, EventArgs e)
        {
            MsgDlg m_MsgDlg = new MsgDlg((int)OP_TYPE.RENAME);
            if (m_MsgDlg.ShowDialog() == DialogResult.OK)
            {
                this.FileRename(m_MsgDlg.FileName);
                this.WriteFile(NewFilePath);
                this.TotalFileScan(true);

                this.unsaveLabel.Text = "";
            }
        }

        private void refreshFileListButton_Click(object sender, EventArgs e)
        {
            this.FilePathInfo.BeginUpdate();
            this.TotalFileScan(true);
            this.FilePathInfo.EndUpdate();
        }

        private void NewFileOpen_Click(object sender, EventArgs e)
        {
            MsgDlg m_MsgDlg = new MsgDlg((int)OP_TYPE.NEWFILE);
            if (m_MsgDlg.ShowDialog() == DialogResult.OK)
            {
                this.FileRename(m_MsgDlg.FileName);

                StreamWriter streamWriter = new StreamWriter(NewFilePath, false);
                streamWriter.WriteLine("");
                streamWriter.Close();

                this.TotalFileScan(true);

                this.unsaveLabel.Text = "";
            }
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        //this.inputButton_Click(sender, e);
                        this.inputButton.PerformClick();
                    }
                    break;
                default:
                    break;
            }
        }

        private void inputTextBox_Click(object sender, EventArgs e)
        {
            CNCKeys cncKeys_dlg = new CNCKeys(false);
            cncKeys_dlg.SetOldSentence(this.inputTextBox.Text);
            DialogResult ret = cncKeys_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                this.inputTextBox.Text = cncKeys_dlg.ReturnCurrentSentence();
                this.inputButton.PerformClick();

                this.memVScrollBar.Maximum = this.memGridView.RowCount;
                this.memVScrollBar.Value = this.memVScrollBar.Maximum;
                if (this.memGridView.CurrentRow.Index == this.memGridView.RowCount - 1)
                {
                    this.memGridView_Click(sender, e);
                }
            }
        }

        private void memGridView_Click(object sender, EventArgs e)
        {
            if (false == this.memGridView.MultiSelect)
            {
                this.memGridView_SelectionChanged(sender, e);
            }
        }

        private void fileListVScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.FilePathInfo.TopIndex = this.fileListVScrollBar.Value;
        }

        private void memVScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.memGridView.FirstDisplayedScrollingRowIndex = e.NewValue;
        }
        

    }
}
