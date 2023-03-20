using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace saveFormText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = string.Format("{0}\t {1}\t {2}\t {3}\t \r\n", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            File.AppendAllText("formData.txt", data);
        }
    }
}
