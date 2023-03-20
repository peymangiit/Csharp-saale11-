using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Album
{
    public partial class Form1 : Form
    {
        int num = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num == 1) num = 11;
            num--;
            
            string path = num.ToString() + ".jpg";
            //مسیر لوکیشن را بر اساس پوشه خودتان تغییر دهید
           // pictureBox1.ImageLocation = "E:/dorusFanni/Csharp(saale11)/Album/Album/Resources/" + path;

            //اگر عکسها درون پوشه debug هستند
            pictureBox1.ImageLocation = path;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = num.ToString() + ".jpg";
            //مسیر لوکیشن را بر اساس پوشه خودتان تغییر دهید
           // pictureBox1.ImageLocation = "E:/dorusFanni/Csharp(saale11)/Album/Album/Resources/"+path;

            pictureBox1.ImageLocation = path;
            num++;
            if (num > 10) num = 1;
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            pictureBox1.Width += 5;
            pictureBox1.Height += 5;
            pictureBox1.Left = (this.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.Height - pictureBox1.Height) / 2;
            
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            pictureBox1.Width -= 5;
            pictureBox1.Height -= 5;
            pictureBox1.Left = (this.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.Height - pictureBox1.Height) / 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
