using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpacalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int current_hrs = 0;
        int total_hrs = 0;
        double value;
        double sum = 0;
        double result;
        private void button1_Click(object sender, EventArgs e)
        {
            current_hrs = Convert.ToInt32(hrstxt.Text);

            if (gradetxt.Text == "A") value = 4;
            if(gradetxt.Text == "B") value = 3;
            if(gradetxt.Text == "C") value = 2;
            if(gradetxt.Text == "D") value = 1;

            total_hrs = total_hrs + current_hrs;
            sum = sum + value * current_hrs;

            hrstxt.Text = "";
            gradetxt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = sum / total_hrs;
            resultlabel.Text = "GPA = " + result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
