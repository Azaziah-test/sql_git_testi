namespace sql_git_testi
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testifieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.git_testiDataSet = new sql_git_testi.git_testiDataSet();
            this.testiTableAdapter = new sql_git_testi.git_testiDataSetTableAdapters.testiTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.git_testiDataSet1 = new sql_git_testi.git_testiDataSet1();
            this.testiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testiTableAdapter1 = new sql_git_testi.git_testiDataSet1TableAdapters.testiTableAdapter();
            this.testifieldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.git_testiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.git_testiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(407, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "Taikanappi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testifieldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testiBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(648, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(198, 396);
            this.dataGridView1.TabIndex = 2;
            // 
            // testifieldDataGridViewTextBoxColumn
            // 
            this.testifieldDataGridViewTextBoxColumn.DataPropertyName = "testi_field";
            this.testifieldDataGridViewTextBoxColumn.HeaderText = "testi_field";
            this.testifieldDataGridViewTextBoxColumn.Name = "testifieldDataGridViewTextBoxColumn";
            // 
            // testiBindingSource
            // 
            this.testiBindingSource.DataMember = "testi";
            this.testiBindingSource.DataSource = this.git_testiDataSet;
            // 
            // git_testiDataSet
            // 
            this.git_testiDataSet.DataSetName = "git_testiDataSet";
            this.git_testiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testiTableAdapter
            // 
            this.testiTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Lisää tietokantaan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testifieldDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.testiBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(37, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(168, 395);
            this.dataGridView2.TabIndex = 6;
            // 
            // git_testiDataSet1
            // 
            this.git_testiDataSet1.DataSetName = "git_testiDataSet1";
            this.git_testiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testiBindingSource1
            // 
            this.testiBindingSource1.DataMember = "testi";
            this.testiBindingSource1.DataSource = this.git_testiDataSet1;
            // 
            // testiTableAdapter1
            // 
            this.testiTableAdapter1.ClearBeforeFill = true;
            // 
            // testifieldDataGridViewTextBoxColumn1
            // 
            this.testifieldDataGridViewTextBoxColumn1.DataPropertyName = "testi_field";
            this.testifieldDataGridViewTextBoxColumn1.HeaderText = "testi_field";
            this.testifieldDataGridViewTextBoxColumn1.Name = "testifieldDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 620);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.git_testiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.git_testiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private git_testiDataSet git_testiDataSet;
        private System.Windows.Forms.BindingSource testiBindingSource;
        private git_testiDataSetTableAdapters.testiTableAdapter testiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn testifieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private git_testiDataSet1 git_testiDataSet1;
        private System.Windows.Forms.BindingSource testiBindingSource1;
        private git_testiDataSet1TableAdapters.testiTableAdapter testiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testifieldDataGridViewTextBoxColumn1;
    }
}

