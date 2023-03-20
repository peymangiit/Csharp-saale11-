using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboandListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaddList_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 5)
            {

                if (comboBox1.Text.Length > 0)
                    listBox1.Items.Add(comboBox1.Text);
            }
            else
                MessageBox.Show("تعداد نامزدهای انتخابی از حد مجاز بیشتر است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        //با تغییر نام ،کد نامزد منتخب نشان بده
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedIndex.ToString();
        }
    }
}
