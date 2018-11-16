using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Compensation;
using CoordinateSystem;
using WorkpieceMeasurement;
using ToolMeasurement;
using JCNCShareMemory;

namespace Offset
{
    public partial class FORM_Off_CoordinateSystem : Form
    {
        public Tool m_Tool;
        public CS m_CS;
        public WMeas m_WMeas;
        public TMeas m_TMeas;

        double XAxisFB, YAxisFB, ZAxisFB;

        public FORM_Off_CoordinateSystem()
        {
            InitializeComponent();
            
            m_WMeas = new WMeas();
            m_TMeas = new TMeas();
            m_Tool = new Tool();
            m_CS = new CS();

            m_Tool.TopLevel = false;
            m_CS.TopLevel = false;
            m_WMeas.TopLevel = false;
            m_TMeas.TopLevel = false;
            ShareMemory.PageInitFinshed = true;
            CSUpdateTimer.Interval = 20;
            CSUpdateTimer.Start();
        }

        private void MF_Offset_CS_Load(object sender, EventArgs e)
        {

        }

        private void FuncReset() {
            OffsetFuncPanel.Controls.Remove(m_Tool);
            OffsetFuncPanel.Controls.Remove(m_CS);
            OffsetFuncPanel.Controls.Remove(m_WMeas);
            OffsetFuncPanel.Controls.Remove(m_TMeas);
        }

        public void FuncToolCompLoad() {
            FuncReset();
            OffsetFuncPanel.Controls.Add(m_Tool);
            m_Tool.Show();
        }

        public void FuncCS()
        {
            FuncReset();
            OffsetFuncPanel.Controls.Add(m_CS);
            m_CS.Show();
        }

        public void FuncWMeas()
        {
            FuncReset();
            OffsetFuncPanel.Controls.Add(m_WMeas);
            m_WMeas.Show();
        }

        public void FuncTMeas()
        {
            FuncReset();
            OffsetFuncPanel.Controls.Add(m_TMeas);
            m_TMeas.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void CSUpdateTimer_Tick(object sender, EventArgs e)
        {
                    XAxisFB = ShareMemory.CS.Machine[ShareMemory.X];
                    if (System.Math.Abs(XAxisFB) < 0.001)
                    {
                        XAxisFB = 0.0;
                        AbsCood_XValue.Text = "0.000";
                    }
                    else
                    {
                        AbsCood_XValue.Text = string.Format("{0:0.000}", XAxisFB);
                    }

                    YAxisFB = ShareMemory.CS.Machine[ShareMemory.Y];
                    if (System.Math.Abs(YAxisFB) < 0.001)
                    {
                        YAxisFB = 0.0;
                        AbsCood_YValue.Text = "0.000";
                    }
                    else
                    {
                        AbsCood_YValue.Text = string.Format("{0:0.000}", YAxisFB);
                    }

                    ZAxisFB = ShareMemory.CS.Machine[ShareMemory.Z];
                    if (System.Math.Abs(ZAxisFB) < 0.001)
                    {
                        ZAxisFB = 0.0;
                        AbsCood_ZValue.Text = "0.000";
                    }
                    else
                    {
                        AbsCood_ZValue.Text = string.Format("{0:0.000}", ZAxisFB);
                    }

                    RelX.Text = string.Format("{0:0.000}", ShareMemory.CS.Rel[ShareMemory.X] - ShareMemory.CS.RelOffset[ShareMemory.X]);
                    RelY.Text = string.Format("{0:0.000}", ShareMemory.CS.Rel[ShareMemory.Y] - ShareMemory.CS.RelOffset[ShareMemory.Y]);
                    RelZ.Text = string.Format("{0:0.000}", ShareMemory.CS.Rel[ShareMemory.Z] - ShareMemory.CS.RelOffset[ShareMemory.Z]);
                 
        }

        private void MacCood_X_Click(object sender, EventArgs e)
        {
            ShareMemory.CS.RelOffset[ShareMemory.X] = ShareMemory.CS.Rel[ShareMemory.X];
            this.RelX.Focus();
        }

        private void MacCood_Y_Click(object sender, EventArgs e)
        {
            ShareMemory.CS.RelOffset[ShareMemory.Y] = ShareMemory.CS.Rel[ShareMemory.Y];
            this.RelY.Focus();
        }

        private void MacCood_Z_Click(object sender, EventArgs e)
        {
            ShareMemory.CS.RelOffset[ShareMemory.Z] = ShareMemory.CS.Rel[ShareMemory.Z];
            this.RelZ.Focus();
        }

        private void MacCood_C__Click(object sender, EventArgs e)
        {
            this.RelC.Focus();
        }

    }
}
