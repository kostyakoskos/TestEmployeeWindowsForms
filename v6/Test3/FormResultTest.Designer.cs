
namespace Test3
{
    partial class FormResultTest
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
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.персональныйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПодразделенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.результатТестаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.персоналBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.anketa1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anketa_1DataSet = new Test3.Anketa_1DataSet();
            this.персоналBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.anketa_1DataSet11 = new Test3.Anketa_1DataSet1();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персоналTableAdapter1 = new Test3.Anketa_1DataSet1TableAdapters.ПерсоналTableAdapter();
            this.fillBy4ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy4ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.anketa1DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anketa_1DataSet2 = new Test3.Anketa_1DataSet();
            this.dataTableПерсоналBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.anketa_1DataSet1 = new Test3.Anketa_1DataSet();
            this.dataTableПерсоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableПерсоналTableAdapter = new Test3.Anketa_1DataSetTableAdapters.DataTableПерсоналTableAdapter();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персоналTableAdapter = new Test3.Anketa_1DataSetTableAdapters.ПерсоналTableAdapter();
            this.dataTable1TableAdapter = new Test3.Anketa_1DataSetTableAdapters.DataTable1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.fillBy4ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anketa1DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableПерсоналBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableПерсоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
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
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.персональныйDataGridViewTextBoxColumn,
            this.кодПодразделенияDataGridViewTextBoxColumn,
            this.кодДолжностиDataGridViewTextBoxColumn,
            this.результатТестаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.персоналBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(995, 422);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // персональныйDataGridViewTextBoxColumn
            // 
            this.персональныйDataGridViewTextBoxColumn.DataPropertyName = "Персональный №";
            this.персональныйDataGridViewTextBoxColumn.HeaderText = "Персональный №";
            this.персональныйDataGridViewTextBoxColumn.Name = "персональныйDataGridViewTextBoxColumn";
            this.персональныйDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодПодразделенияDataGridViewTextBoxColumn
            // 
            this.кодПодразделенияDataGridViewTextBoxColumn.DataPropertyName = "КодПодразделения";
            this.кодПодразделенияDataGridViewTextBoxColumn.HeaderText = "КодПодразделения";
            this.кодПодразделенияDataGridViewTextBoxColumn.Name = "кодПодразделенияDataGridViewTextBoxColumn";
            this.кодПодразделенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодДолжностиDataGridViewTextBoxColumn
            // 
            this.кодДолжностиDataGridViewTextBoxColumn.DataPropertyName = "КодДолжности";
            this.кодДолжностиDataGridViewTextBoxColumn.HeaderText = "КодДолжности";
            this.кодДолжностиDataGridViewTextBoxColumn.Name = "кодДолжностиDataGridViewTextBoxColumn";
            this.кодДолжностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // результатТестаDataGridViewTextBoxColumn
            // 
            this.результатТестаDataGridViewTextBoxColumn.DataPropertyName = "Результат теста";
            this.результатТестаDataGridViewTextBoxColumn.HeaderText = "Результат теста";
            this.результатТестаDataGridViewTextBoxColumn.Name = "результатТестаDataGridViewTextBoxColumn";
            this.результатТестаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // персоналBindingSource2
            // 
            this.персоналBindingSource2.DataMember = "Персонал";
            this.персоналBindingSource2.DataSource = this.anketa1DataSetBindingSource;
            // 
            // anketa1DataSetBindingSource
            // 
            this.anketa1DataSetBindingSource.DataSource = this.anketa_1DataSet;
            this.anketa1DataSetBindingSource.Position = 0;
            // 
            // anketa_1DataSet
            // 
            this.anketa_1DataSet.DataSetName = "Anketa_1DataSet";
            this.anketa_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // персоналBindingSource1
            // 
            this.персоналBindingSource1.DataMember = "Персонал";
            this.персоналBindingSource1.DataSource = this.anketa_1DataSet11;
            // 
            // anketa_1DataSet11
            // 
            this.anketa_1DataSet11.DataSetName = "Anketa_1DataSet1";
            this.anketa_1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.anketa1DataSetBindingSource;
            // 
            // персоналTableAdapter1
            // 
            this.персоналTableAdapter1.ClearBeforeFill = true;
            // 
            // fillBy4ToolStrip
            // 
            this.fillBy4ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy4ToolStripButton});
            this.fillBy4ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy4ToolStrip.Name = "fillBy4ToolStrip";
            this.fillBy4ToolStrip.Size = new System.Drawing.Size(1035, 25);
            this.fillBy4ToolStrip.TabIndex = 2;
            this.fillBy4ToolStrip.Text = "fillBy4ToolStrip";
            this.fillBy4ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillBy4ToolStrip_ItemClicked);
            // 
            // fillBy4ToolStripButton
            // 
            this.fillBy4ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy4ToolStripButton.Name = "fillBy4ToolStripButton";
            this.fillBy4ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy4ToolStripButton.Text = "FillBy4";
            this.fillBy4ToolStripButton.Click += new System.EventHandler(this.fillBy4ToolStripButton_Click);
            // 
            // anketa1DataSet2BindingSource
            // 
            this.anketa1DataSet2BindingSource.DataSource = this.anketa_1DataSet2;
            this.anketa1DataSet2BindingSource.Position = 0;
            // 
            // anketa_1DataSet2
            // 
            this.anketa_1DataSet2.DataSetName = "Anketa_1DataSet";
            this.anketa_1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableПерсоналBindingSource1
            // 
            this.dataTableПерсоналBindingSource1.DataMember = "DataTableПерсонал";
            this.dataTableПерсоналBindingSource1.DataSource = this.anketa_1DataSet1;
            // 
            // anketa_1DataSet1
            // 
            this.anketa_1DataSet1.DataSetName = "Anketa_1DataSet";
            this.anketa_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableПерсоналBindingSource
            // 
            this.dataTableПерсоналBindingSource.DataMember = "DataTableПерсонал";
            this.dataTableПерсоналBindingSource.DataSource = this.anketa_1DataSet1;
            // 
            // dataTableПерсоналTableAdapter
            // 
            this.dataTableПерсоналTableAdapter.ClearBeforeFill = true;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.anketa_1DataSet1;
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(932, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormResultTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillBy4ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormResultTest";
            this.Text = "FormResultTest";
            this.Load += new System.EventHandler(this.FormResultTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.fillBy4ToolStrip.ResumeLayout(false);
            this.fillBy4ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anketa1DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableПерсоналBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableПерсоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource anketa1DataSetBindingSource;
        private Anketa_1DataSet anketa_1DataSet;
        private Anketa_1DataSet anketa_1DataSet1;
        private System.Windows.Forms.BindingSource dataTableПерсоналBindingSource;
        private Anketa_1DataSetTableAdapters.DataTableПерсоналTableAdapter dataTableПерсоналTableAdapter;
        private System.Windows.Forms.BindingSource dataTableПерсоналBindingSource1;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private Anketa_1DataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Anketa_1DataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource anketa1DataSet2BindingSource;
        private Anketa_1DataSet anketa_1DataSet2;
        private Anketa_1DataSet1 anketa_1DataSet11;
        private System.Windows.Forms.BindingSource персоналBindingSource1;
        private Anketa_1DataSet1TableAdapters.ПерсоналTableAdapter персоналTableAdapter1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn персональныйDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПодразделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn результатТестаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource персоналBindingSource2;
        private System.Windows.Forms.ToolStrip fillBy4ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy4ToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}