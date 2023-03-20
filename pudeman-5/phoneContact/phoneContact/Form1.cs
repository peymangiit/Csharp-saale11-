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

namespace phoneContact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ContactText = txtFirstName.Text + "\t | " + txtLastName.Text + "\t | " + txtPhoneNum.Text + "\t | " + txtAddress.Text + "\r\n" ;
            File.AppendAllText("contactList.txt",ContactText) ;
            listBox1.Items.Add(ContactText);

            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtPhoneNum.ResetText();
            txtAddress.ResetText();

            
        }

        private void listBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("contactList.txt"))

                listBox1.Items.AddRange(File.ReadAllLines("contactList.txt"));
            else
                MessageBox.Show("پرونده مخاطبان در دسترس نیست");
        }

        private void txtPhoneNum_KeyDown(object sender, KeyEventArgs e)
        {
            //اگر دکمه فشرده شده حرف الفبا است جلوشو بگیر
            if(char.IsLetter((char)e.KeyCode))
                e.SuppressKeyPress = true;

        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            //اگر دکمه فشرده شده عدد است جلوشو بگیر
            if (char.IsDigit((char)e.KeyCode))
                e.SuppressKeyPress = true;

        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyCode))
                e.SuppressKeyPress = true;
            //Console.WriteLine(e.KeyCode);
            //Console.WriteLine(e.KeyData);
            //Console.WriteLine(e.KeyValue);

        }
    }
}
