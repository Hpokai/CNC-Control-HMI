using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeyBoard;

namespace JCNC
{
    enum TYPE{ SEARCH, REPLACE };

    public partial class StringOperation : Form
    {
        private int selected_type;

        public StringOperation(int type)
        {
            InitializeComponent();

            this.selected_type = type;
            if ((int)TYPE.SEARCH == this.selected_type)
            {
                this.searchButton.Visible = true;

                this.replaceLabel.Visible = false;
                this.replaceComboBox.Visible = false;
                this.replaceButton.Visible = false;
                this.replaceAllCheckBox.Visible = false;
                this.editReplaceButton.Visible = false;

                for (int index = 0; index < 5; index++)
                {
                    this.searchComboBox.Items.Add("");
                }
            }
            else
            {
                this.searchButton.Visible = false;

                this.replaceLabel.Visible = true;
                this.replaceComboBox.Visible = true;
                this.replaceButton.Visible = true;
                this.replaceAllCheckBox.Visible = true;
                this.editReplaceButton.Visible = true;

                for (int index = 0; index < 5; index++)
                {
                    this.searchComboBox.Items.Add("");
                    this.replaceComboBox.Items.Add("");
                }
            }
        }

        private void StringOperation_Load(object sender, EventArgs e)
        {
            this.searchComboBox.Items[0] = SavedString.Default.search_0;
            this.searchComboBox.Items[1] = SavedString.Default.search_1;
            this.searchComboBox.Items[2] = SavedString.Default.search_2;
            this.searchComboBox.Items[3] = SavedString.Default.search_3;
            this.searchComboBox.Items[4] = SavedString.Default.search_4;
            if ((int)TYPE.REPLACE == this.selected_type)
            {
                this.replaceComboBox.Items[0] = SavedString.Default.replace_0;
                this.replaceComboBox.Items[1] = SavedString.Default.replace_1;
                this.replaceComboBox.Items[2] = SavedString.Default.replace_2;
                this.replaceComboBox.Items[3] = SavedString.Default.replace_3;
                this.replaceComboBox.Items[4] = SavedString.Default.replace_4;
            }
        }

        private string searchString;
        public string SearchString { get { return this.searchString; } }
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchString = this.searchComboBox.Text;

            if (this.searchComboBox.Items[0].ToString() != searchString)
            {
                this.SaveRecord((int)TYPE.SEARCH);
            }

            this.searchComboBox.Text = this.searchComboBox.Items[0].ToString();
        }

        private string replaceString;
        public string ReplaceString { get { return this.replaceString; } }
        private void replaceButton_Click(object sender, EventArgs e)
        {
            searchString = this.searchComboBox.Text;
            replaceString = this.replaceComboBox.Text;

            if (this.searchComboBox.Items[0].ToString() != searchString)    this.SaveRecord(TYPE.SEARCH);
            if (this.replaceComboBox.Items[0].ToString() != replaceString)  this.SaveRecord(TYPE.REPLACE);

            this.searchComboBox.Text = this.searchComboBox.Items[0].ToString();
            this.replaceComboBox.Text = this.replaceComboBox.Items[0].ToString();
        }

        private void SaveRecord(TYPE type)
        {
            switch (type)
            {
                case TYPE.SEARCH:                    
                    SavedString.Default.search_4 = SavedString.Default.search_3;
                    SavedString.Default.search_3 = SavedString.Default.search_2;
                    SavedString.Default.search_2 = SavedString.Default.search_1;
                    SavedString.Default.search_1 = SavedString.Default.search_0;
                    SavedString.Default.search_0 = this.searchString;

                    SavedString.Default.Save();
                    break;
                case TYPE.REPLACE:
                    SavedString.Default.replace_4 = SavedString.Default.replace_3;
                    SavedString.Default.replace_3 = SavedString.Default.replace_2;
                    SavedString.Default.replace_2 = SavedString.Default.replace_1;
                    SavedString.Default.replace_1 = SavedString.Default.replace_0;
                    SavedString.Default.replace_0 = this.replaceString;

                    SavedString.Default.Save();
                    break;
            }
        }

        private bool replaceAll;
        public bool ReplaceAll { get { return this.replaceAll; } }
        private void replaceAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.replaceAll = this.replaceAllCheckBox.Checked;
        }

        private void editSearchButton_Click(object sender, EventArgs e)
        {
            CNCKeys cncKeys_dlg = new CNCKeys(true);
            cncKeys_dlg.SetOldSentence(this.searchComboBox.Text);
            DialogResult ret = cncKeys_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                this.searchComboBox.Text = cncKeys_dlg.ReturnCurrentSentence();
            }
        }

        private void editReplaceButton_Click(object sender, EventArgs e)
        {
            CNCKeys cncKeys_dlg = new CNCKeys(true);
            cncKeys_dlg.SetOldSentence(this.replaceComboBox.Text);
            DialogResult ret = cncKeys_dlg.ShowDialog();
            if (DialogResult.OK == ret)
            {
                this.replaceComboBox.Text = cncKeys_dlg.ReturnCurrentSentence();
            }
        }


    }
}
