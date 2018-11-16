using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using JCNCShareMemory;

namespace FileTransfer
{
    public partial class FORM_Prog_FileTransfer : Form
    {
        enum pos { LOCAL, USB };

        private string[] USB_file_name;
        private int USB_file_slot;

        public FORM_Prog_FileTransfer()
        {
            InitializeComponent();

            this.USB_file_name = new string[] { @"D:\JCNC_FILE", @"E:\JCNC_FILE", @"F:\JCNC_FILE", @"G:\JCNC_FILE", @"H:\JCNC_FILE",
                                                @"I:\JCNC_FILE", @"J:\JCNC_FILE", @"K:\JCNC_FILE", @"L:\JCNC_FILE", @"M:\JCNC_FILE" };
     
            ShareMemory.PageInitFinshed = true;
        }

        //----------------------------------
        // sub-functions
        //----------------------------------
        private void CountFiles()
        {
            this.localFileNumLabel.Text = "file: " + this.localFileListBox.Items.Count.ToString();
            this.usbFileNumLabel.Text = "file: " + this.usbFileListBox.Items.Count.ToString();
        }

        private void TotalFileScan(pos location, string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] file = dir.GetFiles("*.NC");
            foreach (FileInfo f in file)
            {
                switch (location)
                {
                    case pos.LOCAL:
                        this.localFileListBox.Items.Add(Path.GetFileNameWithoutExtension(f.ToString()));
                        break;
                    case pos.USB:
                        this.usbFileListBox.Items.Add(Path.GetFileNameWithoutExtension(f.ToString()));
                        break;
                }
            }
            this.CountFiles();

            this.localVScrollBar.Maximum = this.localFileListBox.Items.Count;
            this.usbVScrollBar.Maximum = this.usbFileListBox.Items.Count;

            dir = null;
        }

        private void ButtonState(bool state)
        {
            this.toUSBTransferButton.Enabled = state;
            this.toLocalTransferButton.Enabled = state;
            this.selectAllUSBButton.Enabled = state;
            this.deleteUSBButton.Enabled = state;
            this.closeUSBFileButton.Enabled = state;
            this.usbFileListBox.Enabled = state;
            this.usbVScrollBar.Enabled = state;
        }

        //----------------------------------
        // event
        //----------------------------------
        private void FileTransfer_Load(object sender, EventArgs e)
        {
            this.localFileListBox.Items.Clear();
            this.TotalFileScan(pos.LOCAL, @"pfiles");
            if (0 < this.localFileListBox.Items.Count) this.localFileListBox.SetSelected(0, false);
            
            this.localVScrollBar.Maximum = this.localFileListBox.Items.Count;
            this.usbVScrollBar.Maximum = this.usbFileListBox.Items.Count;

            this.ButtonState(false);
        }

        private void loadUSBButton_Click(object sender, EventArgs e)
        {
            this.USB_file_slot = -1;
            for (int index = 0; index < USB_file_name.Length; index++)
            {
                if (System.IO.Directory.Exists(USB_file_name[index]))
                {
                    this.USB_file_slot = index;

                    this.usbFileListBox.Items.Clear();
                    this.TotalFileScan(pos.USB, USB_file_name[index]);
                    if (0 < this.usbFileListBox.Items.Count)    this.usbFileListBox.SetSelected(0, false);

                    this.ButtonState(true);
                    this.loadUSBButton.Enabled = false;

                    index = USB_file_name.Length;
                }
            }
            if ( -1 == this.USB_file_slot)
            {
                MessageBox.Show("無法搜尋到USB儲存裝置", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectAllUSBButton_Click(object sender, EventArgs e)
        {
            bool state = false;

            this.usbFileListBox.BeginUpdate();
            for (int index = 0; index < this.usbFileListBox.Items.Count; index++)
            {
                bool check = this.usbFileListBox.GetSelected(index);
                if (false == check)
                {
                    state = true;
                    index = this.usbFileListBox.Items.Count;
                }
            }

            for (int index = 0; index < this.usbFileListBox.Items.Count; index++)
            {
                this.usbFileListBox.SetSelected(index, state);
            }
            this.usbFileListBox.EndUpdate();
        }

        private void selectAllLocalButton_Click(object sender, EventArgs e)
        {
            bool state = false;

            this.localFileListBox.BeginUpdate();
            for (int index = 0; index < this.localFileListBox.Items.Count; index++)
            {
                bool check = this.localFileListBox.GetSelected(index);
                if (false == check)
                {
                    state = true;
                    index = this.localFileListBox.Items.Count;
                }
            }

            for (int index = 0; index < this.localFileListBox.Items.Count; index++)
            {
                this.localFileListBox.SetSelected(index, state);
            }
            this.localFileListBox.EndUpdate();
        }

        private void closeUSBFileButton_Click(object sender, EventArgs e)
        {
            this.loadUSBButton.Enabled = true;
            this.usbFileListBox.Items.Clear();
            this.ButtonState(false);
            this.CountFiles();
        }

        private void deleteUSBButton_Click(object sender, EventArgs e)
        {
            string file_name = "";
            string sub_name = "";
            IEnumerator usb_enumerator;

            DialogResult result = MessageBox.Show("確定刪除?", "取消  ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.usbFileListBox.BeginUpdate();

                usb_enumerator = this.usbFileListBox.SelectedItems.GetEnumerator();
                while (usb_enumerator.MoveNext())
                {
                    sub_name = usb_enumerator.Current.ToString() + ".NC";
                    file_name = System.IO.Path.Combine(this.USB_file_name[this.USB_file_slot], sub_name);

                    if (true == System.IO.File.Exists(file_name))
                    {
                        try
                        {
                            System.IO.File.Delete(file_name);
                        }
                        catch
                        {
                            //Console.WriteLine(IOe.Message);
                            return;
                        }
                    }
                }

                this.usbFileListBox.Items.Clear();
                this.TotalFileScan(pos.USB, USB_file_name[this.USB_file_slot]);
                if (0 < this.usbFileListBox.Items.Count)    this.usbFileListBox.SetSelected(0, false);

                this.usbFileListBox.EndUpdate();
            }
        }

        private void deleteLocalButton_Click(object sender, EventArgs e)
        {
            string file_name = "";
            string sub_name = "";
            IEnumerator local_enumerator;

            DialogResult result = MessageBox.Show("確定刪除?", "取消  ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.localFileListBox.BeginUpdate();

                local_enumerator = this.localFileListBox.SelectedItems.GetEnumerator();
                while (local_enumerator.MoveNext())
                {
                    sub_name = local_enumerator.Current.ToString() + ".NC";
                    file_name = System.IO.Path.Combine(@"pfiles", sub_name);

                    if (true == System.IO.File.Exists(file_name))
                    {
                        try
                        {
                            System.IO.File.Delete(file_name);
                        }
                        catch
                        {
                            return;
                        }
                    }
                }

                this.localFileListBox.Items.Clear();
                this.TotalFileScan((int)pos.LOCAL, @"pfiles");
                if (0 < this.localFileListBox.Items.Count) this.localFileListBox.SetSelected(0, false);

                this.localFileListBox.EndUpdate();
            }
        }

        private void toUSBTransferButton_Click(object sender, EventArgs e)
        {
            string source_file = "";
            string dest_file = "";
            string sub_name = "";
            IEnumerator local_enumerator;

            DialogResult result = MessageBox.Show("確定複製檔案?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.usbFileListBox.BeginUpdate();

                local_enumerator = this.localFileListBox.SelectedItems.GetEnumerator();
                while (local_enumerator.MoveNext())
                {
                    sub_name = local_enumerator.Current.ToString() + ".NC";

                    source_file = System.IO.Path.Combine(@"pfiles", sub_name);
                    dest_file = System.IO.Path.Combine(this.USB_file_name[this.USB_file_slot], sub_name);

                    if (true == System.IO.File.Exists(source_file))
                    {
                        try
                        {
                            System.IO.File.Copy(source_file, dest_file, true);
                        }
                        catch
                        {
                            return;
                        }
                    }
                }

                this.usbFileListBox.Items.Clear();
                this.TotalFileScan(pos.USB, USB_file_name[this.USB_file_slot]);
                if (0 < this.usbFileListBox.Items.Count) this.usbFileListBox.SetSelected(0, false);

                this.usbFileListBox.EndUpdate();
            }
        }

        private void toLocalTransferButton_Click(object sender, EventArgs e)
        {
            string source_file = "";
            string dest_file = "";
            string sub_name = "";
            IEnumerator usb_enumerator;

            DialogResult result = MessageBox.Show("確定複製檔案?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.localFileListBox.BeginUpdate();

                usb_enumerator = this.usbFileListBox.SelectedItems.GetEnumerator();
                while (usb_enumerator.MoveNext())
                {
                    sub_name = usb_enumerator.Current.ToString() + ".NC";

                    source_file = System.IO.Path.Combine(this.USB_file_name[this.USB_file_slot], sub_name);
                    dest_file = System.IO.Path.Combine(@"pfiles", sub_name);

                    if (true == System.IO.File.Exists(source_file))
                    {
                        try
                        {
                            System.IO.File.Copy(source_file, dest_file, true);
                        }
                        catch
                        {
                            return;
                        }
                    }
                }

                this.localFileListBox.Items.Clear();
                this.TotalFileScan((int)pos.LOCAL, @"pfiles");
                if (0 < this.localFileListBox.Items.Count) this.localFileListBox.SetSelected(0, false);

                this.localFileListBox.EndUpdate();
            }
        }

        private void refreshFileListButton_Click(object sender, EventArgs e)
        {
            this.localFileListBox.BeginUpdate();
            this.localFileListBox.Items.Clear();
            this.TotalFileScan((int)pos.LOCAL, @"pfiles");
            this.localFileListBox.EndUpdate();
        }

        private void localVScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.localFileListBox.TopIndex = this.localVScrollBar.Value;
        }

        private void usbVScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.usbFileListBox.TopIndex = this.usbVScrollBar.Value;
        }

    }
}
