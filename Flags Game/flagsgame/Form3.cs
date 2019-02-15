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
    public partial class Form3 : Form
    {
        int sum;
        public Form3(int s)
        {
            InitializeComponent();
            sum = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                sum += 1;
            }
            this.Hide();
            Form4 f2 = new Form4(sum);
            f2.Show();
        }

   
    }
}
