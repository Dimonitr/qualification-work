using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.IO;

namespace KvalWork_Project
{
    public partial class TabMode2 : UserControl
    {
        Bitmap bt;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (frmTitle.updated)
            {
                gr.Clear(Color.LightSkyBlue);
                int deltab = frmTitle.db - frmTitle.b0;
                int deltal = frmTitle.dl - frmTitle.l0;
                int deltat = frmTitle.dt - frmTitle.t0;
                int deltar = frmTitle.dr - frmTitle.r0;

                int delah = deltab - deltat;
                int delaw = deltar - deltal;

                for (int i = 54; i < 648; i += 54)
                {
                    gr.DrawLine(Pens.DarkViolet, i, 0, i, 432);
                    gr.DrawLine(Pens.DarkViolet, 0, i, 648, i);
                }
                for (int c = 215; c <= 217; c++)
                {
                    gr.DrawLine(Pens.DarkViolet, 0, c, 648, c);
                }
                for (int c = 323; c <= 325; c++)
                {
                    gr.DrawLine(Pens.DarkViolet, c, 0, c, 432);
                }

                int del = (delaw + delah) / 2;
                del = 80 - del;
                gr.FillRectangle(Brushes.DarkTurquoise, (325 - (del/2)), (216 - (del/2)), (del), (del));
            }
            pbZooming.Image = bt;
        }
        public TabMode2()
        {
            InitializeComponent();
            bt = new Bitmap(pbZooming.Width, pbZooming.Height);
            gr = Graphics.FromImage(bt);
            timer.Interval = 1;
            timer.Start();
        }
        Graphics gr;
    }
}
