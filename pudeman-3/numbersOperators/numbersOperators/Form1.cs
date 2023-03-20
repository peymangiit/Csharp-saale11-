using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbersOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            textBox3.Text = (num1 - num2).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            textBox3.Text = (num1 + num2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            textBox3.Text = (num1 * num2).ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            textBox3.Text = (num1 / num2).ToString();
        }
    }
}
