﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KvalWork_Project
{
    public partial class TabFAQ : UserControl
    {
        public TabFAQ()
        {
            InitializeComponent();
            string path = Application.StartupPath + @"\FAQ.htm";
            webBrowser1.Navigate(path);
        }
    }
}
