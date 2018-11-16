using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyBoard
{
    public partial class CNCKeys : Form
    {
        enum KeyType { WORD, FN };

        private string[] enWord;
        private string[] signWord;
        private string[] signWord_file;
        private string[] numWord;

        private Button[] enKeys;
        private Button[] signKeys;
        private Button[] numKeys;

        private string currentSentence;
        public string CurrentSentence { get { return currentSentence; } }
        private string oldSentence;

        private bool is_file_keyboard;

        public CNCKeys( bool isFile )
        {
            InitializeComponent();

            this.InitailObject();
            this.currentSentence = string.Empty;
            this.oldSentence = string.Empty;
            this.is_file_keyboard = isFile;
        }

        private void InitailObject()
        {
            this.enWord = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                                           "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            this.signWord = new string[6] { "#", "/", "+", "-", ".", " " };
            this.signWord_file = new string[6] { "(", ")", "_", "-", ".", " " };
            this.numWord = new string[11] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "." };


            this.enKeys = new Button[26] { this.AkeyButton, this.BkeyButton, this.CkeyButton, this.DkeyButton, this.EkeyButton,
                                           this.FkeyButton, this.GkeyButton, this.HkeyButton, this.IkeyButton, this.JkeyButton,
                                           this.KkeyButton, this.LkeyButton, this.MkeyButton, this.NkeyButton, this.OkeyButton, 
                                           this.PkeyButton, this.QkeyButton, this.RkeyButton, this.SkeyButton, this.TkeyButton,
                                           this.UkeyButton, this.VkeyButton, this.WkeyButton, this.XkeyButton, this.YkeyButton,
                                           this.ZkeyButton};
            this.signKeys = new Button[6] { this.signNumberButton, this.signSlashButton, this.signPlusButton, 
                                            this.signMinusButton, this.signDotButton, this.spaceButton };
            this.numKeys = new Button[11] { this.num0Button, this.num1Button, this.num2Button, this.num3Button, this.num4Button,
                                            this.num5Button, this.num6Button, this.num7Button, this.num8Button, this.num9Button,
                                            this.numDotButton };
        }

        private void CNCKeys_Load(object sender, EventArgs e)
        {
            this.currentSentence = string.Empty;
            this.inputTextBox.Text = this.oldSentence;
            this.inputTextBox.Select(this.inputTextBox.Text.Length, 0);
            this.inputTextBox.Focus();
            
            int sign_max = 6;
            if (true == this.is_file_keyboard)
            {
                for (int index = 0; index < sign_max; index++)
                {
                    this.signKeys[index].Text = this.signWord_file[index];
                }
            }
            else
            {
                for (int index = 0; index < sign_max; index++)
                {
                    this.signKeys[index].Text = this.signWord[index];
                }
            }
        }

        public string ReturnCurrentSentence()
        {
            return this.CurrentSentence;
        }

        public void SetOldSentence(string old_sentence)
        {
            this.oldSentence = old_sentence;
        }

        private void MakeSentence(int type, string word)
        {
            int position = this.inputTextBox.SelectionStart;

            switch (type)
            {
                case ((int)KeyType.WORD):
                    this.inputTextBox.Text = this.inputTextBox.Text.Insert(position, word);
                    this.inputTextBox.Select(position + 1, 0);
                    break;
                case ((int)KeyType.FN):
                    switch (word)
                    {
                        case "DEL":
                            if (this.inputTextBox.Text.Length > position)
                            {
                                this.inputTextBox.Text = this.inputTextBox.Text.Remove(position, 1);
                            }
                            this.inputTextBox.Select(position, 0);
                            break;
                        case "BS":
                            if (0 < position)
                            {
                                this.inputTextBox.Text = this.inputTextBox.Text.Remove(position - 1, 1);
                                this.inputTextBox.Select(position - 1, 0);
                            }
                            break;
                    }
                    break;
            }

            this.inputTextBox.Focus();
        }

        private void enKeyButton_Click(object sender, EventArgs e)
        {
            int eng_index = 0, eng_max = 26;

            for (eng_index = 0; eng_index < eng_max; eng_index++)
            {
                if (this.enKeys[eng_index] == sender)
                {
                    this.inputTextBox.BackColor = Color.FromArgb(255, 255, 255);

                    this.MakeSentence((int)KeyType.WORD, this.enWord[eng_index]);
                    eng_index = eng_max;
                }
            }
        }

        private void signKeyButton_Click(object sender, EventArgs e)
        {
            int sign_index = 0, sign_max = 6;

            for (sign_index = 0; sign_index < sign_max; sign_index++)
            {
                if (this.signKeys[sign_index] == sender)
                {
                    this.inputTextBox.BackColor = Color.FromArgb(255, 255, 255);

                    if (true == this.is_file_keyboard)
                    {
                        this.MakeSentence((int)KeyType.WORD, this.signWord_file[sign_index]);
                    }
                    else
                    {
                        this.MakeSentence((int)KeyType.WORD, this.signWord[sign_index]);
                    }
                    sign_index = sign_max;
                }
            }
        }

        private void numKeyButton_Click(object sender, EventArgs e)
        {
            int num_index = 0, num_max = 11;

            for (num_index = 0; num_index < num_max; num_index++)
            {
                if (this.numKeys[num_index] == sender)
                {
                    this.inputTextBox.BackColor = Color.FromArgb(255, 255, 255);

                    this.MakeSentence((int)KeyType.WORD, this.numWord[num_index]);
                    num_index = num_max;
                }
            }
        }

        private void fnKeyButton_Click(object sender, EventArgs e)
        {
            this.inputTextBox.BackColor = Color.FromArgb(255, 255, 255);

            if (this.deleteButton == sender)
            {
                this.MakeSentence((int)KeyType.FN, "DEL");
            }
            else if (this.backspaceButton == sender)
            {
                this.MakeSentence((int)KeyType.FN, "BS");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.inputTextBox.BackColor = Color.FromArgb(255, 255, 255);

            this.Close();
        }
        
        private void enterButton_Click(object sender, EventArgs e)
        {
            this.inputTextBox.BackColor = Color.FromArgb(255, 255, 255);

            this.currentSentence = this.inputTextBox.Text;
        }

        private void toLeftButton_Click(object sender, EventArgs e)
        {
            this.inputTextBox.BackColor = Color.FromArgb(255, 255, 255);

            int position = this.inputTextBox.SelectionStart;

            if (0 < position)
            {
                this.inputTextBox.Select(position - 1, 0);
            }
            this.inputTextBox.Focus();
        }

        private void toRightButton_Click(object sender, EventArgs e)
        {
            this.inputTextBox.BackColor = Color.FromArgb(255, 255, 255);

            int position = this.inputTextBox.SelectionStart;

            if (this.inputTextBox.Text.Length > position)
            {
                this.inputTextBox.Select(position + 1, 0);
            }
            this.inputTextBox.Focus();
        }
    }
}
