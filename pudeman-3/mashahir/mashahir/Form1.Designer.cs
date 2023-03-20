namespace mashahir
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
            this.btnParvin = new System.Windows.Forms.Button();
            this.btnSohrab = new System.Windows.Forms.Button();
            this.btnNima = new System.Windows.Forms.Button();
            this.btnShahriar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParvin
            // 
            this.btnParvin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParvin.Location = new System.Drawing.Point(353, 42);
            this.btnParvin.Name = "btnParvin";
            this.btnParvin.Size = new System.Drawing.Size(95, 23);
            this.btnParvin.TabIndex = 1;
            this.btnParvin.Text = "پروین اعتصامی";
            this.btnParvin.UseVisualStyleBackColor = true;
            this.btnParvin.Click += new System.EventHandler(this.btnParvin_Click);
            // 
            // btnSohrab
            // 
            this.btnSohrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSohrab.Location = new System.Drawing.Point(353, 90);
            this.btnSohrab.Name = "btnSohrab";
            this.btnSohrab.Size = new System.Drawing.Size(95, 23);
            this.btnSohrab.TabIndex = 2;
            this.btnSohrab.Text = "سهراب سپهری";
            this.btnSohrab.UseVisualStyleBackColor = true;
            this.btnSohrab.Click += new System.EventHandler(this.btnSohrab_Click);
            // 
            // btnNima
            // 
            this.btnNima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNima.Location = new System.Drawing.Point(353, 142);
            this.btnNima.Name = "btnNima";
            this.btnNima.Size = new System.Drawing.Size(95, 23);
            this.btnNima.TabIndex = 3;
            this.btnNima.Text = "نیما یوشیج";
            this.btnNima.UseVisualStyleBackColor = true;
            this.btnNima.Click += new System.EventHandler(this.btnNima_Click);
            // 
            // btnShahriar
            // 
            this.btnShahriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShahriar.Location = new System.Drawing.Point(353, 196);
            this.btnShahriar.Name = "btnShahriar";
            this.btnShahriar.Size = new System.Drawing.Size(95, 23);
            this.btnShahriar.TabIndex = 4;
            this.btnShahriar.Text = "شهریار";
            this.btnShahriar.UseVisualStyleBackColor = true;
            this.btnShahriar.Click += new System.EventHandler(this.btnShahriar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(498, 296);
            this.Controls.Add(this.btnShahriar);
            this.Controls.Add(this.btnNima);
            this.Controls.Add(this.btnSohrab);
            this.Controls.Add(this.btnParvin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "شاعران معاسر";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnParvin;
        private System.Windows.Forms.Button btnSohrab;
        private System.Windows.Forms.Button btnNima;
        private System.Windows.Forms.Button btnShahriar;
    }
}

