using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.IO;
using System.Threading;
using System.IO.Ports;

namespace KvalWork_Project
{
    public partial class frmTitle : Form
    {
        public static int db, dl, dt, dr;

        public static int b0 = -1000000, l0 = -1000000, t0 = -1000000, r0 = -1000000;

        public static Thread tread;

        public static bool updated = false;
        void thr()
        {
            //На випадок декількох пристроїв, що підключені через послідовний порт та призодять до помилки в програмі
            //serialPort1.PortName = "COM5";
            //serialPort1.BaudRate = 9600;
            //serialPort1.Open();

            string[] port = SerialPort.GetPortNames();
            foreach (string p in port)
                serialPort1.PortName = p;
            serialPort1.BaudRate = 9600;
            try
            {
                serialPort1.Open();
            }
            catch (Exception) { }

            bool gate = false;
            bool dot = false;

            int k = 0;
            string s = "";
            while (true)
            {
                if (!playing)
                {
                    if (serialPort1.IsOpen)
                    {
                        try
                        {
                            s = serialPort1.ReadLine();
                        }
                        catch (Exception) { }
                        if (s != "")
                        {
                            if(s == "d\r")
                            {
                                dot = true;
                            }
                            if (s == "o\r")
                            {
                                gate = true;
                            }
                            if (s == "c\r")
                            {
                                gate = false;
                                updated = true;
                                k = 0;
                            }
                            if (gate)
                            {
                                updated = false;
                                try
                                {
                                    int n = int.Parse(s);
                                    if (k == 0)
                                    {
                                        db = n;
                                        if (b0 == (-1000000) || dot)
                                            b0 = n;
                                    }
                                    else
                                    {
                                        if (k == 1)
                                        {
                                            dl = n;
                                            if (l0 == (-1000000) || dot)
                                                l0 = n;
                                        }
                                        else
                                        {
                                            if (k == 2)
                                            {
                                                dt = n;
                                                if (t0 == (-1000000) || dot)
                                                    t0 = n;
                                            }
                                            else
                                            {
                                                if (k == 3)
                                                {
                                                    dr = n;
                                                    if (r0 == (-1000000) || dot)
                                                    {
                                                        r0 = n;
                                                        dot = false;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    k++;
                                }
                                catch (Exception)
                                {
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                }
            }
        }

        static public int mode = 0;
        public frmTitle()
        {
            InitializeComponent();
            tread = new Thread(thr);
            tread.Start();
            timerPW.Interval = 1;
            timerPW.Start();
            ToolTip t = new ToolTip();
            t.SetToolTip(btRecord, "Record");
            t.SetToolTip(btPlay, "Play");
            t.SetToolTip(btExit, "Exit");
        }

        Graphics UX;
        Bitmap XU;

        private void btExit_Click(object sender, EventArgs e)
        {
            mode = 0;
            serialPort1.Close();
            tread.Abort();
            Application.Exit();
        }

        int ct = 0, d = 0;
        private void timerUX_Tick(object sender, EventArgs e)
        {
            XU = new Bitmap(pbUX.Width, pbUX.Height);
            UX = Graphics.FromImage(XU);
            if (ct == 0)
            {
                d = animt / timerUX.Interval;
                d = (np - cp) / d;
            }
            if (((d>0)&&(cp<np))||((d<0)&&(cp>np)))
            {
                ct += timerUX.Interval;
                cp += d;
                UX.Clear(Color.FromArgb(255, 194, 248, 203));
                SolidBrush UXb = new SolidBrush(Color.FromArgb(255, 131, 103, 199));
                UX.FillRectangle(UXb, 0, cp, 10, 80);
            }
            else
            {
                cp = np;
                UX.Clear(Color.FromArgb(255, 194, 248, 203));
                SolidBrush UXb = new SolidBrush(Color.FromArgb(255, 131, 103, 199));
                UX.FillRectangle(UXb, 0, cp, 10, 80);
            }
            pbUX.Image = XU;
        }


        private Point mouseOffset;
        private bool isMouseDown = false;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        bool record = false, playing = false;
        int k = 0;
        string[] data = new string[6];
        private void timerPW_Tick(object sender, EventArgs e)
        {
            if (updated)
            {
                if (record)
                {
                    if (k == 0)
                    {
                        File.Delete(Application.StartupPath + "/Database.txt");
                        data[0] = "s";
                        data[1] = b0.ToString();
                        data[2] = l0.ToString();
                        data[3] = t0.ToString();
                        data[4] = r0.ToString();
                        data[5] = "t";
                        k++;
                    }
                    else
                    {
                        data[0] = "o";
                        data[1] = db.ToString();
                        data[2] = dl.ToString();
                        data[3] = dt.ToString();
                        data[4] = dr.ToString();
                        data[5] = "c";
                    }
                    File.AppendAllLines(Application.StartupPath + "/Database.txt", data);
                }
                if (playing)
                {
                    string[] reda = File.ReadAllLines(Application.StartupPath + "/Database.txt");
                    string[] curr = new string[6];
                    try
                    {
                        curr[0] = reda[k * 6 + 0];
                        curr[1] = reda[k * 6 + 1];
                        curr[2] = reda[k * 6 + 2];
                        curr[3] = reda[k * 6 + 3];
                        curr[4] = reda[k * 6 + 4];
                        curr[5] = reda[k * 6 + 5];
                    }
                    catch (Exception)
                    {
                        playing = false;
                        MessageBox.Show("Відтворення завершено");
                    }
                    if(curr[0] == "s")
                    {
                        b0 = int.Parse(curr[1]);
                        l0 = int.Parse(curr[2]);
                        t0 = int.Parse(curr[3]);
                        r0 = int.Parse(curr[4]);
                    }
                    else
                    {
                        if(curr[0] == "o")
                        {
                            db = int.Parse(curr[1]);
                            dl = int.Parse(curr[2]);
                            dt = int.Parse(curr[3]);
                            dr = int.Parse(curr[4]);    
                        }
                    }
                    k++;
                }
            }
        }
        private void btRecord_Click(object sender, EventArgs e)
        {
            if (!record)
            {
                record = true;
                k = 0;
            }
            else
            {
                record = false;
            }
            playing = false;
        }
        

        private void btPlay_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playing = true;
                k = 0;
            }
            else
            {
                playing = false;
            }
            record = false;
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }


        int cp = 0, np = 0, animt = 150;

        private void btTitle_Click(object sender, EventArgs e)
        {
            tabTitle1.BringToFront();
            panelCrutch.Visible = false;
            np = 0;
            ct = 0;
            timerUX.Start();
        }

        private void btTheory_Click(object sender, EventArgs e)
        {
            tabTheory1.BringToFront();
            panelCrutch.Visible = false;
            np = 80;
            ct = 0;
            timerUX.Interval = 10;
            timerUX.Start();
        }

        private void btMode1_Click(object sender, EventArgs e)
        {
            tabMode11.BringToFront();
            panelCrutch.Visible = false;
            np = 160;
            ct = 0;
            timerUX.Interval = 10;
            timerUX.Start();
        }

        private void btMode2_Click(object sender, EventArgs e)
        {
            tabMode21.BringToFront();
            panelCrutch.Visible = false;
            np = 240;
            ct = 0;
            timerUX.Interval = 10;
            timerUX.Start();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            tabFAQ1.BringToFront();
            panelCrutch.Visible = false;
            np = 320;
            ct = 0;
            timerUX.Interval = 10;
            timerUX.Start();
        }
    }
}
