using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        int min, sec, tenth;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            count = 0;
            label1.Text = "00:00.0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count ++;
            min = (count - count % 600) / 600;
            sec = ((count - count % 10) / 10) % 60;
            tenth = count % 10;

            label1.Text = min.ToString("00") + ":" + sec.ToString("00") + "." + tenth.ToString(); 
        }
    }
}
