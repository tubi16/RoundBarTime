using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundBarTime
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[Convert.ToInt32(DateTime.Now.DayOfWeek)];
            label2.Text = DateTime.Now.ToString("T");
            label3.Text = DateTime.Now.ToString("MMMM");

            int saat = Convert.ToInt32(DateTime.Now.ToString("HH"));
            int dakika = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int saniye = Convert.ToInt32(DateTime.Now.ToString("ss"));

            dakika += saat * 60;
            saniye += dakika * 60;

            circularProgressBar1.Value = saniye;
            circularProgressBar2.Value = Convert.ToInt16(DateTime.Now.DayOfWeek);
        }
    }
}
