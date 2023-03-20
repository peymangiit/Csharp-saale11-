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

namespace textnoteSample
{
    public partial class Form1 : Form
    {
        //متغیر های پابلیک تا بتوان در تمام برنامه استفاده شود و تغییرات را نگه دارد
        string dataFilePath = "";
        bool saveStatus = true;
        int selectStart, selectLentgh;
        string selectText;


        public Form1()
        {
            InitializeComponent();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dataFilePath = saveFileDialog1.FileName;
                File.WriteAllText(dataFilePath, textBox1.Text);
                saveStatus = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //اگر مسیر مشخص نیست صفحه انتخاب مسیر باز شود
            if (dataFilePath == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dataFilePath = saveFileDialog1.FileName;
                    File.WriteAllText(dataFilePath, textBox1.Text);
                    saveStatus = true;
                }
            }
            else
            {   
                //مستفیم دخیره کن در مسیر مشخص
                File.WriteAllText(dataFilePath, textBox1.Text);
                saveStatus = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveStatus== true)
                this.Close();
            else
            {
                DialogResult result = MessageBox.Show("آیا تغییرات را میخواهید ذخیره سازی کنید؟","هشدار",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:

                        if (dataFilePath == "")
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                dataFilePath = saveFileDialog1.FileName;
                                File.WriteAllText(dataFilePath, textBox1.Text);
                                saveStatus = true;
                            }
                        }
                        else
                        {
                            File.WriteAllText(dataFilePath, textBox1.Text);
                            saveStatus = true;
                        }
                        this.Close();
                        break;

                    case DialogResult.No:
                        this.Close();
                        break;

                    case DialogResult.Cancel:
                        return;
                }
            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //اگر متن تغییری کرد وضعیت ذخیره را تغییر بده
            saveStatus = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //اگر تغییری در متن اتفاق نیوفتاده فایل جدید باز کن
            if (saveStatus)//اگر true هست
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dataFilePath = openFileDialog1.FileName;
                    textBox1.Text = File.ReadAllText(dataFilePath);
                    saveStatus = true;
                }
            }
            else
            {
                //در غیر این صورت پیامی برای ذخیره بده و سپس فایل جدید باز کن
                DialogResult result = MessageBox.Show("آیا تغییرات را میخواهید ذخیره سازی کنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        dataFilePath = saveFileDialog1.FileName;
                        File.WriteAllText(dataFilePath, textBox1.Text);
                    }
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dataFilePath = openFileDialog1.FileName;
                    textBox1.Text = File.ReadAllText(dataFilePath);
                    saveStatus = true;
                }
                    
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectText = textBox1.SelectedText;
            textBox1.SelectedText = "";
           /* selectStart = textBox1.SelectionStart;
            selectLentgh = textBox1.SelectionLength;
            textBox1.Text = textBox1.Text.Remove(selectStart, selectLentgh);*/
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*selectStart = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selectStart, selectText);*/
            textBox1.SelectedText = selectText;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectText = textBox1.SelectedText;
            /*selectStart = textBox1.SelectionStart;
            selectLentgh = textBox1.SelectionLength;*/

        }
    }

       
}
