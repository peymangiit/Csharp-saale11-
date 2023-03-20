using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 15;
        }

        private void move_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void speedUp_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 100)
            {
                timer1.Interval -= 100;
                //برای نشان دادن زمان وقفه
                label2.Text = timer1.Interval.ToString();
            }
            else if (timer1.Interval > 1)
            {
                timer1.Interval -= 2;
                label2.Text = timer1.Interval.ToString();
            }
        }

        private void slowDown_Click(object sender, EventArgs e)
        {
            if (timer1.Interval < 100)
            {
                timer1.Interval += 2;
                label2.Text = timer1.Interval.ToString();
            }
            else
            {
                timer1.Interval += 100;
                label2.Text = timer1.Interval.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 730)
                pictureBox1.Location = new System.Drawing.Point(-100, 187);

        }
    }
}
