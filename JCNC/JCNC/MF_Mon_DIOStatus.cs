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

namespace JCNC
{

    public partial class FORM_Mon_DioStatus : Form
    {
        enum DI_GP { GP1 = 0, GP2 = 1, GP3 = 2, GP4 = 3, GP5 = 4, GP6 = 5 };
        enum DO_GP { GP1 = 0, GP2 = 1, GP3 = 2, GP4 = 3, GP5 = 4, GP6 = 5 };
        DI_GP DIGP = DI_GP.GP1;
        DO_GP DOGP = DO_GP.GP1;
        
        bool inputstate = false;
        bool outputstate = false;
                
        public FORM_Mon_DioStatus()
        {
            InitializeComponent();
            ShareMemory.PageInitFinshed = true;
            DIOTIMER.Interval = 100;
            DIOTIMER.Start();
        }

        private void MF_Mon_DIOStatus_Load(object sender, EventArgs e)
        {
                FreshDIStatus();
                FreshDOStatus();
        }

        private void FreshDIStatus()        // you can not to change each ui every times
        {
            Button[] input = new Button[32] { this.input1, this.input2, this.input3, this.input4, this.input5, this.input6,this.input7,this.input8,
                                              this.input9, this.input10, this.input11, this.input12, this.input13, this.input14, this.input15, this.input16,
                                              this.input17, this.input18, this.input19, this.input20, this.input21, this.input22, this.input23, this.input24,
                                              this.input25, this.input26, this.input27, this.input28, this.input29, this.input30, this.input31, this.input32};

            for (int i = 0; i < 32; i++)
            {
                if (false == Connection.CNCtoDT.GetDIState(i, out inputstate))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.GetDIState(i, out inputstate)");
                }
                else
                {
                    switch (inputstate)
                    {
                        case true:
                            input[i].BackColor = System.Drawing.Color.Green;
                            break;
                        case false:
                            input[i].BackColor = System.Drawing.Color.Red;
                            break;
                    }
                }
            }

        }

        private void FreshDOStatus()
        {
            Button[] output = new Button[32] { this.output1, this.output2, this.output3, this.output4, this.output5, this.output6,this.output7,this.output8,
                                              this.output9, this.output10, this.output11, this.output12, this.output13, this.output14, this.output15, this.output16,
                                              this.output17, this.output18, this.output19, this.output20, this.output21, this.output22, this.output23, this.output24,
                                              this.output25, this.output26, this.output27, this.output28, this.output29, this.output30, this.output31, this.output32};


            for (int i = 0; i < 32; i++)
            {
                if (false == Connection.CNCtoDT.GetDOState(i, out outputstate))
                {
                    MessageBox.Show("Error: Connection.CNCtoDT.GetDOState(i, out outputstate))");
                }
                else
                {
                    switch (outputstate)
                    {
                        case true:
                            output[i].BackColor = System.Drawing.Color.Green;
                            break;
                        case false:
                            output[i].BackColor = System.Drawing.Color.Red;
                            break;
                    }
                }
            }
        }
 
        private void DIOTIMER_Tick(object sender, EventArgs e)
        {
            FreshDIStatus();
        }

        private void DIUP_Click(object sender, EventArgs e)
        {
            switch (DIGP)
            {
                case DI_GP.GP1:
                    DIGP = DI_GP.GP2;
                    InputGroup.Text = "Input Group2";
                    break;
                case DI_GP.GP2:
                    DIGP = DI_GP.GP3;
                    InputGroup.Text = "Input Group3";
                    break;
                case DI_GP.GP3:
                    DIGP = DI_GP.GP4;
                    InputGroup.Text = "Input Group4";
                    break;
                case DI_GP.GP4:
                    DIGP = DI_GP.GP5;
                    InputGroup.Text = "Input Group5";
                    break;
                case DI_GP.GP5:
                    DIGP = DI_GP.GP6;
                    InputGroup.Text = "Input Group6";
                    break;
                case DI_GP.GP6:
                    break;
            }
        }

        private void DIDOWN_Click(object sender, EventArgs e)
        {
            switch (DIGP)
            {
                case DI_GP.GP1:
                    break;
                case DI_GP.GP2:
                    DIGP = DI_GP.GP1;
                    InputGroup.Text = "Input Group1";
                    break;
                case DI_GP.GP3:
                    DIGP = DI_GP.GP2;
                    InputGroup.Text = "Input Group2";
                    break;
                case DI_GP.GP4:
                    DIGP = DI_GP.GP3;
                    InputGroup.Text = "Input Group3";
                    break;
                case DI_GP.GP5:
                    DIGP = DI_GP.GP4;
                    InputGroup.Text = "Input Group4";
                    break;
                case DI_GP.GP6:
                    DIGP = DI_GP.GP5;
                    InputGroup.Text = "Input Group5";
                    break;
            }
        }

        private void DOUP_Click(object sender, EventArgs e)
        {
            switch (DOGP)
            {
                case DO_GP.GP1:
                    DOGP = DO_GP.GP2;
                    OutputGroup.Text = "Output Group2";
                    break;
                case DO_GP.GP2:
                    DOGP = DO_GP.GP3;
                    OutputGroup.Text = "Output Group3";
                    break;
                case DO_GP.GP3:
                    DOGP = DO_GP.GP4;
                    OutputGroup.Text = "Output Group4";
                    break;
                case DO_GP.GP4:
                    DOGP = DO_GP.GP5;
                    OutputGroup.Text = "Output Group5";
                    break;
                case DO_GP.GP5:
                    DOGP = DO_GP.GP6;
                    OutputGroup.Text = "Output Group6";
                    break;
                case DO_GP.GP6:
                    break;
            }
        }

        private void DODOWN_Click(object sender, EventArgs e)
        {
            switch (DOGP)
            {
                case DO_GP.GP1:
                    break;
                case DO_GP.GP2:
                    DOGP = DO_GP.GP1;
                    OutputGroup.Text = "Output Group1";
                    break;
                case DO_GP.GP3:
                    DOGP = DO_GP.GP2;
                    OutputGroup.Text = "Output Group2";
                    break;
                case DO_GP.GP4:
                    DOGP = DO_GP.GP3;
                    OutputGroup.Text = "Output Group3";
                    break;
                case DO_GP.GP5:
                    DOGP = DO_GP.GP4;
                    OutputGroup.Text = "Output Group4";
                    break;
                case DO_GP.GP6:
                    DOGP = DO_GP.GP5;
                    OutputGroup.Text = "Output Group5";
                    break;
            }
        }

        private void output_MouseDown(object sender, MouseEventArgs e)
        {
            Button[] output = new Button[32] { this.output1, this.output2, this.output3, this.output4, this.output5, this.output6,this.output7,this.output8,
                                              this.output9, this.output10, this.output11, this.output12, this.output13, this.output14, this.output15, this.output16,
                                              this.output17, this.output18, this.output19, this.output20, this.output21, this.output22, this.output23, this.output24,
                                              this.output25, this.output26, this.output27, this.output28, this.output29, this.output30, this.output31, this.output32};

            int index = -1;

            for (int i = 0; i < 32; i++)
            {
                if (sender == output[i])
                {
                    index = i;
                    i = 32;
                }
            }

            if (index != -1)
            {
                if (System.Drawing.Color.Red == output[index].BackColor)
                {
                    if (false == Connection.CNCtoDT.SetDOState(index, true))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.SetDOState(index, true)");
                    }
                    else
                    {
                        output1.BackColor = System.Drawing.Color.Green;
                    }
                }
                else
                {
                    if (false == Connection.CNCtoDT.SetDOState(index, false))
                    {
                        MessageBox.Show("Error: Connection.CNCtoDT.SetDOState(index, false)");
                    }
                    else
                    {
                        output1.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

    }
}
               