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

namespace directoryMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDirectories_Click(object sender, EventArgs e)
        {
            string directory;
            //directory = @"c:\";
            directory = txtPath.Text;
            listBoard.Items.Clear();
            
           // listBoard.Items.AddRange(Directory.GetDirectories(directory));
            //نام پوشه بدون نشان دادن مسیر
            string[] dirs = Directory.GetDirectories(directory);
            foreach (string dir in dirs)
                listBoard.Items.Add(Path.GetFileName(dir));

        }

        private void btnShowFiles_Click(object sender, EventArgs e)
        {
            string directory;
           // directory = @"c:\";
            directory = txtPath.Text;
            listBoard.Items.Clear();
            //listBoard.Items.AddRange(Directory.GetFiles(directory));

            string[] dirs = Directory.GetFiles(directory);
            foreach (string dir in dirs)
                listBoard.Items.Add(Path.GetFileName(dir));
        }
    }
}
