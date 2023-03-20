using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioandCheckbox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                MessageBox.Show("هنرجو محترم خوش آمدید");
            else if (radioButton2.Checked == true)
                MessageBox.Show("معلم محترم خوش آمدید");
            else if (radioButton3.Checked == true)
                MessageBox.Show("مدیر محترم خوش آمدید");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
