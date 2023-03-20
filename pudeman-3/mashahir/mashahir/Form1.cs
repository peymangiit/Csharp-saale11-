using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mashahir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParvin_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.parvin;
        }

        private void btnSohrab_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.sohrab;
        }

        private void btnNima_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.nima;
        }

        private void btnShahriar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.shahriar;
        }
    }
}
