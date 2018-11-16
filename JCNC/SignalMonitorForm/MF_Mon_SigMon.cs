using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using JCNCShareMemory;

namespace SignalMonitorForm
{
    public partial class FORM_Mon_Signal : Form
    {
        PointF[] points = new PointF[9];
        Pen pen = new Pen(Color.Black, 4);

        private const int kXAxisIndent = 10;
        private const int kYAxisIndent = 10;
        private float m_fXTickValue = 1.0f;
        private float m_fYTickValue = 1.0f;
        private float m_ptXOrigin = 0.0f;
        private float m_ptYOrigin = 0.0f;

        bool Showgrid = false;

        public FORM_Mon_Signal()
        {
            InitializeComponent();
            int Cx = this.ClientSize.Width / 2; // 視窗客戶區中心點
            int Cy = this.ClientSize.Height / 2;
            int k = 0;
            // 計算 PointF 陣列 的值
            for (int i = 0; i <= 360; i = i + 45)
            {
                points[k].X = (float)(Cx + 100 * Math.Cos(i * Math.PI / 180));
                points[k].Y = (float)(Cy + 100 * Math.Sin(i * Math.PI / 180));
                k++;
            }
            ShareMemory.PageInitFinshed = true;
        }

        private void MF_Mon_SigMon_Load(object sender, EventArgs e)
        {

        }

        private void MF_Mon_SigMon_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.White, 2);
            Rectangle rect = this.ClientRectangle;
            g.DrawRectangle(myPen, this.Left + 5, this.Top + 6, 892, 425);
            DrawXAxis(g);
            DrawYAxis(g);
        }

        private void DrawXAxis(Graphics g)
        {
            Pen myPen = new Pen(Color.Yellow, 2);
            Pen myPen2 = new Pen(Color.Yellow, 1);
            Pen myAxisPen = new Pen(Color.Yellow, 2);
            Font theAxisFont = new Font("Arial", 14);
            SolidBrush myBrush = new SolidBrush(Color.Yellow);

            int XLeft = this.Left + 5 * kXAxisIndent;
            int XRight = this.Right - 35 * kXAxisIndent + 4;
            int YTop = this.Top + 5 * kYAxisIndent - 2;
            int YLeft = this.Bottom - 5 * kYAxisIndent;
            int YRight = this.Bottom - 5 * kYAxisIndent;
            int num = 8;
            double[] XValue = new double[num];
//            double XMax = 56;
 //           double XMin = 1;
            int axisstep = 20;
            int steppixel = (XRight - XLeft) / axisstep;
            string indexvalue;
            int index = 0;
                        
            g.DrawLine(myPen, XLeft, YLeft, XRight, YRight);
            for (int j = 0; j < axisstep + 1; j++)
            {
                index = 0 + j * steppixel;
                indexvalue = index.ToString();
                g.DrawLine(myPen, XLeft + j * steppixel, YLeft - 3, XLeft + j * steppixel, YLeft + 3);
                if (Showgrid) {
                    myPen2.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
                    g.DrawLine(myPen2, XLeft + j * steppixel, YLeft, XLeft + j * steppixel, YTop);                
                }
                if (j == 0)
                {
//                    indexvalue = "0";
//                    g.DrawString(indexvalue, theAxisFont, myBrush, XLeft + j * steppixel-30, YLeft + 13);
                }
                else
                    g.DrawString(indexvalue, theAxisFont, myBrush, XLeft + j * steppixel-18, YLeft + 13);
            }

            myPen.Dispose();
            myAxisPen.Dispose();
            myBrush.Dispose();
            theAxisFont.Dispose();
        }

        private void DrawYAxis(Graphics g)
        {
            SolidBrush myBrush = new SolidBrush(Color.Yellow);
            Pen myPen = new Pen(Color.Yellow, 2);
            Pen myPen2 = new Pen(Color.Yellow, 1);
            Pen myAxisPen = new Pen(Color.Yellow, 2);
            Font theAxisFont = new Font("Arial", 14);

            int XTop = this.Left + 5 * kXAxisIndent;
            int XBottom = this.Left + 5 * kXAxisIndent;
            int XRight = this.Right - 35 * kXAxisIndent + 4;
            int YTop = this.Top + 5 * kYAxisIndent - 2;
            int YBottom = this.Bottom - 5 * kYAxisIndent;
            int num = 8;
            double[] XValue = new double[num];
 //           double XMax = 56;
   //         double XMin = 1;
            int axisstep = 10;
            int steppixel = (YBottom - YTop) / axisstep;
            string indexvalue;
            int index = 0;

            // (50,50) -> (50,390)
            g.DrawLine(myPen, XBottom, YBottom, XTop, YTop);

            for (int j = 0; j < axisstep + 1; j++)
            {
                index = 0 + j * steppixel;
                indexvalue = index.ToString();
//                MessageBox.Show("asd");
                g.DrawLine(myPen, XBottom - 3, YBottom - j * steppixel, XBottom + 3, YBottom - j * steppixel);
                if (Showgrid)
                {
                    myPen2.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
                    g.DrawLine(myPen2, XBottom, YBottom - j * steppixel, XRight, YBottom - j * steppixel);
                }
                if (j == 0)
                {
                }
                else{
                    g.DrawString(indexvalue, theAxisFont, myBrush, XBottom - 43, YBottom - j * steppixel - 12);
                }
            }

/*            for (float i = kYAxisIndent; i < this.ClientRectangle.Height - 10 * kYAxisIndent; i += (this.ClientRectangle.Height - 10 * kYAxisIndent) / 10)
            {                
//                if (UntranslateY((int)i) % 5 == 0)
  //              {
                    float ycalcValue = YTickValue * UntranslateY((int)i) + YOrigin;
                    string strCalcValue = ycalcValue.ToString();
                    int index = strCalcValue.IndexOf(".");
                    if (index != -1 && index + 2 < strCalcValue.Length)
                    {
                        strCalcValue = strCalcValue.Substring(0, index + 2);
                    }
                    g.DrawString(strCalcValue, theAxisFont, myBrush, this.ClientRectangle.Left + kXAxisIndent/2, i - kXAxisIndent);
    //            }
                g.DrawLine(myPen, this.ClientRectangle.Left + 5 * kXAxisIndent - 3, this.ClientRectangle.Bottom - 4 * kYAxisIndent - i, this.ClientRectangle.Left + 5 * kXAxisIndent + 3, this.ClientRectangle.Bottom - 4 * kYAxisIndent - i);
            }*/
            myPen.Dispose();
            myAxisPen.Dispose();
            theAxisFont.Dispose();
            myBrush.Dispose();
        }

        private int UntranslateX(int x)
        {
            int tmp = 0;
            tmp = x - (this.ClientRectangle.Left + kXAxisIndent);
            return tmp;
        }

        private int UntranslateY(int y)
        {
            int tmp = 0;
            tmp = this.ClientRectangle.Bottom - (y + kYAxisIndent);
            return tmp;
        }
        
        public float XTickValue
        {
            get
            {
                return m_fXTickValue;
            }

            set
            {
                m_fXTickValue = value;
            }
        }

        public float YTickValue
        {
            get
            {
                return m_fYTickValue;
            }

            set
            {
                m_fYTickValue = value;
            }
        }
        
        public float XOrigin
        {
            get
            {
                return m_ptXOrigin;
            }

            set
            {
                m_ptXOrigin = value;
            }

        }

        public float YOrigin
        {
            get
            {
                return m_ptYOrigin;
            }

            set
            {
                m_ptYOrigin = value;
            }

        }

        private void Grid_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Showgrid) { 
                Showgrid = true;
            }
            else if (Showgrid) {
                Showgrid = false;
            }
            this.Invalidate();
        }


    }
}
