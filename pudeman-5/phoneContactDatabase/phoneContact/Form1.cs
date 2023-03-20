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
            //string ContactText = txtFirstName.Text + "\t | " + txtLastName.Text + "\t | " + txtPhoneNum.Text + "\t | " + txtAddress.Text + "\r\n" ;
            //File.AppendAllText("contactList.txt",ContactText) ;
            //listBox1.Items.Add(ContactText);

            contactsTableAdapter.InsertQuery(txtFirstName.Text, txtLastName.Text, txtPhoneNum.Text, txtAddress.Text);
            contactsTableAdapter.Fill(contactListDataSet.Contacts);
            MessageBox.Show("با موفقیت اضافه شد");

          

            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNum.Clear();
            txtAddress.Clear();

            
        }

        private void listBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactListDataSet.Contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.contactListDataSet.Contacts);

            //if (File.Exists("contactList.txt"))
            //    listBox1.Items.AddRange(File.ReadAllLines("contactList.txt"));
            //else
            //    MessageBox.Show("پرونده مخاطبان در دسترس نیست");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            txtFirstName.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtPhoneNum.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string origin = dataGridView1.Rows[index].Cells[2].Value.ToString();

            contactsTableAdapter.UpdateQuery(txtFirstName.Text, txtLastName.Text, txtPhoneNum.Text, txtAddress.Text,origin);
            contactsTableAdapter.Fill(contactListDataSet.Contacts);
            MessageBox.Show(" ویرایش با موفقیت انجام شد ");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string origin = dataGridView1.Rows[index].Cells[2].Value.ToString();

            contactsTableAdapter.DeleteQuery(origin);
            contactsTableAdapter.Fill(contactListDataSet.Contacts);
            MessageBox.Show(" حذف با موفقیت انجام شد ");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchtxt = SearchBox.Text;
            contactsTableAdapter.FillBy(contactListDataSet.Contacts,searchtxt,searchtxt,searchtxt,searchtxt );
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.Fill(contactListDataSet.Contacts);
        }
    }
}
