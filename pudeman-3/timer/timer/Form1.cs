using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        int numSecond = 0, numMinute = 00, numHour = 00 ;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            numSecond += 1;
            second.Text = numSecond.ToString();
            Minute.Text = numMinute.ToString();
            Hour.Text = numHour.ToString();

            if (numSecond == 60)
            {
                numMinute += 1;
                numSecond = 00;
            }
            if (numMinute == 60)
            {
                numHour += 1;
                numMinute = 00;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numSecond = 0; numMinute = 00; numHour = 00;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
