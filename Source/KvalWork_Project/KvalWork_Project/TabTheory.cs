using System;
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
    public partial class TabTheory : UserControl
    {
        public TabTheory()
        {
            InitializeComponent();
            string path = Application.StartupPath + @"\Theory.htm";
            webBrowser1.Navigate(path);
        }
    }
}
