namespace Dictionary
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryDataSet = new Dictionary.DictionaryDataSet();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wordCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordMeansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.computerTableAdapter = new Dictionary.DictionaryDataSetTableAdapters.ComputerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.computerBindingSource;
            this.listBox1.DisplayMember = "WordName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 134);
            this.listBox1.TabIndex = 0;
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataMember = "Computer";
            this.computerBindingSource.DataSource = this.dictionaryDataSet;
            // 
            // dictionaryDataSet
            // 
            this.dictionaryDataSet.DataSetName = "DictionaryDataSet";
            this.dictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMeaning
            // 
            this.txtMeaning.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.computerBindingSource, "WordMeans", true));
            this.txtMeaning.Location = new System.Drawing.Point(217, 49);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(240, 57);
            this.txtMeaning.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.computerBindingSource, "WordName", true));
            this.txtSearch.Location = new System.Drawing.Point(226, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام واژه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "معنی واژه";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordCodeDataGridViewTextBoxColumn,
            this.wordNameDataGridViewTextBoxColumn,
            this.wordMeansDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.computerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(217, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(299, 191);
            this.dataGridView1.TabIndex = 4;
            // 
            // wordCodeDataGridViewTextBoxColumn
            // 
            this.wordCodeDataGridViewTextBoxColumn.DataPropertyName = "WordCode";
            this.wordCodeDataGridViewTextBoxColumn.HeaderText = "WordCode";
            this.wordCodeDataGridViewTextBoxColumn.Name = "wordCodeDataGridViewTextBoxColumn";
            // 
            // wordNameDataGridViewTextBoxColumn
            // 
            this.wordNameDataGridViewTextBoxColumn.DataPropertyName = "WordName";
            this.wordNameDataGridViewTextBoxColumn.HeaderText = "WordName";
            this.wordNameDataGridViewTextBoxColumn.Name = "wordNameDataGridViewTextBoxColumn";
            // 
            // wordMeansDataGridViewTextBoxColumn
            // 
            this.wordMeansDataGridViewTextBoxColumn.DataPropertyName = "WordMeans";
            this.wordMeansDataGridViewTextBoxColumn.HeaderText = "WordMeans";
            this.wordMeansDataGridViewTextBoxColumn.Name = "wordMeansDataGridViewTextBoxColumn";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.computerBindingSource;
            this.comboBox1.DisplayMember = "WordName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // computerTableAdapter
            // 
            this.computerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 337);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "واژه نامه فنی رایانه";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DictionaryDataSet dictionaryDataSet;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private DictionaryDataSetTableAdapters.ComputerTableAdapter computerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordMeansDataGridViewTextBoxColumn;
    }
}

