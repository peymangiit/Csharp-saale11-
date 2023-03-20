namespace DialogBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_font = new System.Windows.Forms.Button();
            this.button_backcolor = new System.Windows.Forms.Button();
            this.button_fontColor = new System.Windows.Forms.Button();
            this.button_picture = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(33, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 214);
            this.textBox1.TabIndex = 1;
            // 
            // button_font
            // 
            this.button_font.Location = new System.Drawing.Point(539, 294);
            this.button_font.Name = "button_font";
            this.button_font.Size = new System.Drawing.Size(95, 35);
            this.button_font.TabIndex = 2;
            this.button_font.Text = "انتخاب قلم";
            this.button_font.UseVisualStyleBackColor = true;
            this.button_font.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_backcolor
            // 
            this.button_backcolor.Location = new System.Drawing.Point(434, 294);
            this.button_backcolor.Name = "button_backcolor";
            this.button_backcolor.Size = new System.Drawing.Size(95, 35);
            this.button_backcolor.TabIndex = 2;
            this.button_backcolor.Text = "انتخاب پس زمینه";
            this.button_backcolor.UseVisualStyleBackColor = true;
            this.button_backcolor.Click += new System.EventHandler(this.button_backcolor_Click);
            // 
            // button_fontColor
            // 
            this.button_fontColor.Location = new System.Drawing.Point(330, 294);
            this.button_fontColor.Name = "button_fontColor";
            this.button_fontColor.Size = new System.Drawing.Size(95, 35);
            this.button_fontColor.TabIndex = 2;
            this.button_fontColor.Text = "رنگ قلم";
            this.button_fontColor.UseVisualStyleBackColor = true;
            this.button_fontColor.Click += new System.EventHandler(this.button_fontColor_Click);
            // 
            // button_picture
            // 
            this.button_picture.Location = new System.Drawing.Point(169, 294);
            this.button_picture.Name = "button_picture";
            this.button_picture.Size = new System.Drawing.Size(110, 35);
            this.button_picture.TabIndex = 2;
            this.button_picture.Text = "انتخاب عکس";
            this.button_picture.UseVisualStyleBackColor = true;
            this.button_picture.Click += new System.EventHandler(this.button_picture_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Crimson;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(54, 294);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(95, 35);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "خروج";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "image file(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(654, 366);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_picture);
            this.Controls.Add(this.button_fontColor);
            this.Controls.Add(this.button_backcolor);
            this.Controls.Add(this.button_font);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "متن و تصویر";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_font;
        private System.Windows.Forms.Button button_backcolor;
        private System.Windows.Forms.Button button_fontColor;
        private System.Windows.Forms.Button button_picture;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

