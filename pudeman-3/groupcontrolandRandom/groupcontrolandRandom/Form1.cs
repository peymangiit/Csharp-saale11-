using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupcontrolandRandom
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                label1.Visible = false;
            else
                label1.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = !checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = !checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = !checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = !checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = !checkBox6.Checked;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = !checkBox7.Checked;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = !checkBox8.Checked;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = !checkBox9.Checked;
        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num = rnd.Next(1, 8);
            pictureBox1.ImageLocation = num + ".JPG";
            // لغو چکباکس ها با زدن تغییر تصویر
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                CheckBox chBox = (CheckBox)groupBox2.Controls[i];
                chBox.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num = rnd.Next(1, 8);
            pictureBox1.ImageLocation = num + ".JPG";

        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            switch (num)
            {
                case 1:
                    MessageBox.Show(" امام زاده هاشم رشت");
                    break;
                case 2:
                    MessageBox.Show("قلعه رودخان فومن");
                    break;
                case 3:
                    MessageBox.Show("استخر لاهیجان");
                    break;
                case 4:
                    MessageBox.Show(" شیطان کوه لاهیجان");
                    break;
                case 5:
                    MessageBox.Show("ماسوله");
                    break;
                case 6:
                    MessageBox.Show("موزه روستایی رشت");
                    break;
                case 7:
                    MessageBox.Show("میدان شهرداری رشت");
                    break;

            }
        }

       

    }
}
