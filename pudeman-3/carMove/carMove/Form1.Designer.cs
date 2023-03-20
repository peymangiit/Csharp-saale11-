namespace carMove
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
            this.components = new System.ComponentModel.Container();
            this.move = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slowDown = new System.Windows.Forms.Button();
            this.speedUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(455, 34);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(75, 35);
            this.move.TabIndex = 0;
            this.move.Text = "حرکت";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(110, 34);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 35);
            this.stop.TabIndex = 1;
            this.stop.Text = "توقف";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::carMove.Properties.Resources.car;
            this.pictureBox1.Location = new System.Drawing.Point(46, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 44);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LocationChanged += new System.EventHandler(this.pictureBox1_LocationChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slowDown
            // 
            this.slowDown.Location = new System.Drawing.Point(274, 53);
            this.slowDown.Name = "slowDown";
            this.slowDown.Size = new System.Drawing.Size(86, 23);
            this.slowDown.TabIndex = 3;
            this.slowDown.Text = "کاهش سرعت";
            this.slowDown.UseVisualStyleBackColor = true;
            this.slowDown.Click += new System.EventHandler(this.slowDown_Click);
            // 
            // speedUp
            // 
            this.speedUp.Location = new System.Drawing.Point(274, 24);
            this.speedUp.Name = "speedUp";
            this.speedUp.Size = new System.Drawing.Size(86, 23);
            this.speedUp.TabIndex = 4;
            this.speedUp.Text = "افزایش سرعت";
            this.speedUp.UseVisualStyleBackColor = true;
            this.speedUp.Click += new System.EventHandler(this.speedUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "وقفه (مینی ثانیه)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(652, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(730, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedUp);
            this.Controls.Add(this.slowDown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "حرکت خودرو";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button slowDown;
        private System.Windows.Forms.Button speedUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

