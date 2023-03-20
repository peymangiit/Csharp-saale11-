namespace directoryMethods
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowFiles = new System.Windows.Forms.Button();
            this.btnShowDirectories = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoard = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(50, 31);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(125, 20);
            this.txtPath.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnShowDirectories);
            this.panel1.Controls.Add(this.btnShowFiles);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Location = new System.Drawing.Point(304, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 298);
            this.panel1.TabIndex = 1;
            // 
            // btnShowFiles
            // 
            this.btnShowFiles.Location = new System.Drawing.Point(50, 173);
            this.btnShowFiles.Name = "btnShowFiles";
            this.btnShowFiles.Size = new System.Drawing.Size(120, 54);
            this.btnShowFiles.TabIndex = 1;
            this.btnShowFiles.Text = "فهرست پرونده ها";
            this.btnShowFiles.UseVisualStyleBackColor = true;
            this.btnShowFiles.Click += new System.EventHandler(this.btnShowFiles_Click);
            // 
            // btnShowDirectories
            // 
            this.btnShowDirectories.Location = new System.Drawing.Point(50, 84);
            this.btnShowDirectories.Name = "btnShowDirectories";
            this.btnShowDirectories.Size = new System.Drawing.Size(120, 54);
            this.btnShowDirectories.TabIndex = 1;
            this.btnShowDirectories.Text = "فهرست پوشه ها";
            this.btnShowDirectories.UseVisualStyleBackColor = true;
            this.btnShowDirectories.Click += new System.EventHandler(this.btnShowDirectories_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoard);
            this.panel2.Location = new System.Drawing.Point(24, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 298);
            this.panel2.TabIndex = 2;
            // 
            // listBoard
            // 
            this.listBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoard.FormattingEnabled = true;
            this.listBoard.Location = new System.Drawing.Point(0, 0);
            this.listBoard.Name = "listBoard";
            this.listBoard.Size = new System.Drawing.Size(261, 298);
            this.listBoard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "مسیر انتخابی خود را بنویسید";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowDirectories;
        private System.Windows.Forms.Button btnShowFiles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoard;
        private System.Windows.Forms.Label label1;
    }
}

