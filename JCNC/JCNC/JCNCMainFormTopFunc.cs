using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SignalMonitorForm;
using System.IO;
using IDStatus;
using Offset;
using MDIOP;
using WorkAreaLimit;
using JOGSetUpUI;
using JCNCShareMemory;
using JCNCSystemTime;
using PagesAuthority;

namespace JCNC
{
    public partial class jcncMainForm : Form
    {
        private void HomeX_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("X", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(5, 5));
        }

        private void HomeY_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("Y", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(5, 5));
        }

        private void HomeZ_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("Z", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(5, 5));
        }

        private void Home4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("4", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(7, 5));
        }
        
        private void XLimit_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("X", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(5, 5));
        }

        private void YLimit_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("Y", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(5, 5));
        }

        private void ZLimit_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, ((Control)sender).Width - 2, ((Control)sender).Height - 2));
            g.DrawString("Z", new Font(FontFamily.GenericSerif, 16f), Brushes.Black, new PointF(5, 5));
        }

    }
}
