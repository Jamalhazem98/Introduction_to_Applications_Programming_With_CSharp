using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int movingspeed = 5;
        private void update_timer_Tick(object sender, EventArgs e)
        {
            // mouse tracking
            player.Location = Control.MousePosition;
            player.Top -= 25;
            player.Left -= 10;

            // checking intersection
            if (player.Bounds.IntersectsWith(pictureBox1.Bounds)) touch();
            if (player.Bounds.IntersectsWith(pictureBox2.Bounds)) touch();
            if (player.Bounds.IntersectsWith(pictureBox3.Bounds)) touch();
            if (player.Bounds.IntersectsWith(pictureBox4.Bounds)) touch();
            if (player.Bounds.IntersectsWith(pictureBox5.Bounds)) touch();
            if (player.Bounds.IntersectsWith(pictureBox6.Bounds)) touch();
            if (player.Bounds.IntersectsWith(moving1.Bounds)) touch();

            if (player.Bounds.IntersectsWith(finish.Bounds))
            {
                player.Left = 90;
                player.Top = 70;
                update_timer.Stop();
                MessageBox.Show("لقد فزت");
            }

            
        }

        private void touch()
        {
            player.Left = 90;
            player.Top = 70;
            update_timer.Stop();
            MessageBox.Show("لقد خسرت");
        }
        private void player_Click(object sender, EventArgs e)
        {
            update_timer.Start();
        }

        private void moving_timer_Tick(object sender, EventArgs e)
        {
            if (moving1.Bounds.IntersectsWith(pictureBox4.Bounds)) movingspeed = -5;
            if (moving1.Bounds.IntersectsWith(pictureBox1.Bounds)) movingspeed = 5;

            moving1.Top += movingspeed;
        }
    }
}
