
namespace Test3
{
    partial class FormRegistrationAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrationAdd));
			this.anketa_1DataSet = new Test3.Anketa_1DataSet();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.подразделенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.подразделенияTableAdapter = new Test3.Anketa_1DataSetTableAdapters.ПодразделенияTableAdapter();
			this.должностиTableAdapter = new Test3.Anketa_1DataSetTableAdapters.ДолжностиTableAdapter();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.ПерсоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.персоналTableAdapter = new Test3.Anketa_1DataSetTableAdapters.ПерсоналTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.подразделенияBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ПерсоналBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// anketa_1DataSet
			// 
			this.anketa_1DataSet.DataSetName = "Anketa_1DataSet";
			this.anketa_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(876, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Выход";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(17, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Фамилия";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(129, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(239, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Отчество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(365, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Персональный №";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.подразделенияBindingSource;
			this.comboBox1.DisplayMember = "Название";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(525, 52);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(198, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// подразделенияBindingSource
			// 
			this.подразделенияBindingSource.DataMember = "Подразделения";
			this.подразделенияBindingSource.DataSource = this.anketa_1DataSet;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(522, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Подразделение";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(746, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Должность";
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.должностиBindingSource;
			this.comboBox2.DisplayMember = "Название";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(749, 54);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(202, 21);
			this.comboBox2.TabIndex = 9;
			// 
			// должностиBindingSource
			// 
			this.должностиBindingSource.DataMember = "Должности";
			this.должностиBindingSource.DataSource = this.anketa_1DataSet;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(20, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 10;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(132, 54);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 11;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(242, 54);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 12;
			// 
			// подразделенияTableAdapter
			// 
			this.подразделенияTableAdapter.ClearBeforeFill = true;
			// 
			// должностиTableAdapter
			// 
			this.должностиTableAdapter.ClearBeforeFill = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(759, 155);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Сохранить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(368, 55);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 14;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// ПерсоналBindingSource
			// 
			this.ПерсоналBindingSource.DataMember = "Персонал";
			this.ПерсоналBindingSource.DataSource = this.anketa_1DataSet;
			// 
			// персоналTableAdapter
			// 
			this.персоналTableAdapter.ClearBeforeFill = true;
			// 
			// FormRegistrationAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 207);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormRegistrationAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.anketa_1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.подразделенияBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ПерсоналBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Anketa_1DataSet anketa_1DataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource подразделенияBindingSource;
        private Anketa_1DataSetTableAdapters.ПодразделенияTableAdapter подразделенияTableAdapter;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private Anketa_1DataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.BindingSource ПерсоналBindingSource;
		private Anketa_1DataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
	}
}