using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flagsgame
{
    public partial class Form4 : Form
    {
        int sum;
        public Form4(int s)
        {
            InitializeComponent();
            sum = s;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "you scored: " + sum.ToString() + "/3";
        }
    }
}
