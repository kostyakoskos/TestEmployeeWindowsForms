
namespace Test3
{
    partial class FormAllQuestions
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.anketa_1DataSet = new Test3.Anketa_1DataSet();
			this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.anketa1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.вариантыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.вопросыTableAdapter = new Test3.Anketa_1DataSetTableAdapters.ВопросыTableAdapter();
			this.вопросыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.вариантыTableAdapter = new Test3.Anketa_1DataSetTableAdapters.ВариантыTableAdapter();
			this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataTable1TableAdapter = new Test3.Anketa_1DataSetTableAdapters.DataTable1TableAdapter();
			this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataTable2TableAdapter = new Test3.Anketa_1DataSetTableAdapters.DataTable2TableAdapter();
			this.dataTable3TableAdapter = new Test3.Anketa_1DataSetTableAdapters.DataTable3TableAdapter();
			this.ответDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.баллDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.вопросDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.anketa1DataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.вариантыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.вопросыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ответDataGridViewTextBoxColumn,
            this.баллDataGridViewTextBoxColumn,
            this.вопросDataGridViewTextBoxColumn,
            this.Column1});
			this.dataGridView1.DataSource = this.dataTable1BindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1251, 476);
			this.dataGridView1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(13, 495);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Удалить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(1188, 495);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Выход";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataTable1BindingSource1
			// 
			this.dataTable1BindingSource1.DataMember = "DataTable1";
			this.dataTable1BindingSource1.DataSource = this.anketa_1DataSet;
			// 
			// anketa_1DataSet
			// 
			this.anketa_1DataSet.DataSetName = "Anketa_1DataSet";
			this.anketa_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataTable3BindingSource
			// 
			this.dataTable3BindingSource.DataMember = "DataTable3";
			this.dataTable3BindingSource.DataSource = this.anketa_1DataSet;
			// 
			// anketa1DataSetBindingSource
			// 
			this.anketa1DataSetBindingSource.DataSource = this.anketa_1DataSet;
			this.anketa1DataSetBindingSource.Position = 0;
			// 
			// вариантыBindingSource
			// 
			this.вариантыBindingSource.DataMember = "Варианты";
			this.вариантыBindingSource.DataSource = this.anketa_1DataSet;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataMember = "Вопросы";
			this.bindingSource1.DataSource = this.anketa_1DataSet;
			// 
			// вопросыTableAdapter
			// 
			this.вопросыTableAdapter.ClearBeforeFill = true;
			// 
			// вопросыBindingSource
			// 
			this.вопросыBindingSource.DataMember = "Вопросы";
			this.вопросыBindingSource.DataSource = this.anketa_1DataSet;
			// 
			// вариантыTableAdapter
			// 
			this.вариантыTableAdapter.ClearBeforeFill = true;
			// 
			// dataTable1BindingSource
			// 
			this.dataTable1BindingSource.DataMember = "DataTable1";
			this.dataTable1BindingSource.DataSource = this.anketa_1DataSet;
			// 
			// dataTable1TableAdapter
			// 
			this.dataTable1TableAdapter.ClearBeforeFill = true;
			// 
			// dataTable2BindingSource
			// 
			this.dataTable2BindingSource.DataMember = "DataTable2";
			this.dataTable2BindingSource.DataSource = this.anketa_1DataSet;
			// 
			// dataTable2TableAdapter
			// 
			this.dataTable2TableAdapter.ClearBeforeFill = true;
			// 
			// dataTable3TableAdapter
			// 
			this.dataTable3TableAdapter.ClearBeforeFill = true;
			// 
			// ответDataGridViewTextBoxColumn
			// 
			this.ответDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.ответDataGridViewTextBoxColumn.DataPropertyName = "Ответ";
			this.ответDataGridViewTextBoxColumn.FillWeight = 300F;
			this.ответDataGridViewTextBoxColumn.Frozen = true;
			this.ответDataGridViewTextBoxColumn.HeaderText = "Ответ";
			this.ответDataGridViewTextBoxColumn.Name = "ответDataGridViewTextBoxColumn";
			this.ответDataGridViewTextBoxColumn.ReadOnly = true;
			this.ответDataGridViewTextBoxColumn.Width = 62;
			// 
			// баллDataGridViewTextBoxColumn
			// 
			this.баллDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.баллDataGridViewTextBoxColumn.DataPropertyName = "Балл";
			this.баллDataGridViewTextBoxColumn.FillWeight = 50F;
			this.баллDataGridViewTextBoxColumn.Frozen = true;
			this.баллDataGridViewTextBoxColumn.HeaderText = "Балл";
			this.баллDataGridViewTextBoxColumn.Name = "баллDataGridViewTextBoxColumn";
			this.баллDataGridViewTextBoxColumn.ReadOnly = true;
			this.баллDataGridViewTextBoxColumn.Width = 57;
			// 
			// вопросDataGridViewTextBoxColumn
			// 
			this.вопросDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.вопросDataGridViewTextBoxColumn.DataPropertyName = "Вопрос";
			this.вопросDataGridViewTextBoxColumn.FillWeight = 300F;
			this.вопросDataGridViewTextBoxColumn.Frozen = true;
			this.вопросDataGridViewTextBoxColumn.HeaderText = "Вопрос";
			this.вопросDataGridViewTextBoxColumn.Name = "вопросDataGridViewTextBoxColumn";
			this.вопросDataGridViewTextBoxColumn.ReadOnly = true;
			this.вопросDataGridViewTextBoxColumn.Width = 69;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "КодВопр";
			this.Column1.HeaderText = "CodeQuestion";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// FormAllQuestions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 561);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormAllQuestions";
			this.Text = "FormAllQuestions";
			this.Load += new System.EventHandler(this.FormAllQuestions_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.anketa1DataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.вариантыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.вопросыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource anketa1DataSetBindingSource;
        private Anketa_1DataSet anketa_1DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Anketa_1DataSetTableAdapters.ВопросыTableAdapter вопросыTableAdapter;
        private System.Windows.Forms.BindingSource вопросыBindingSource;
        private System.Windows.Forms.BindingSource вариантыBindingSource;
        private Anketa_1DataSetTableAdapters.ВариантыTableAdapter вариантыTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Anketa_1DataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private Anketa_1DataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private Anketa_1DataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ответDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn баллDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn вопросDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}