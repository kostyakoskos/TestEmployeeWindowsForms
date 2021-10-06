using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3
{
	public partial class FormAllQuestions : Form
	{
		Anketa_1DataSetTableAdapters.ПерсоналTableAdapter cl = new Anketa_1DataSetTableAdapters.ПерсоналTableAdapter();
		public FormAllQuestions()
		{
			InitializeComponent();
		}

		private void FormAllQuestions_Load(object sender, EventArgs e)
		{
			//// TODO: This line of code loads data into the 'anketa_1DataSet.DataTable3' table. You can move, or remove it, as needed.
			//this.dataTable3TableAdapter.Fill(this.anketa_1DataSet.DataTable3);
			//// TODO: This line of code loads data into the 'anketa_1DataSet.DataTable2' table. You can move, or remove it, as needed.
			//this.dataTable2TableAdapter.Fill(this.anketa_1DataSet.DataTable2);
			//// TODO: This line of code loads data into the 'anketa_1DataSet.DataTable1' table. You can move, or remove it, as needed.
			this.dataTable1TableAdapter.Fill(this.anketa_1DataSet.DataTable1);
			//// TODO: This line of code loads data into the 'anketa_1DataSet.Варианты' table. You can move, or remove it, as needed.
			//this.вариантыTableAdapter.Fill(this.anketa_1DataSet.Варианты);
			//// TODO: This line of code loads data into the 'anketa_1DataSet.Вопросы' table. You can move, or remove it, as needed.
			//this.вопросыTableAdapter.Fill(this.anketa_1DataSet.Вопросы);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int t = (int)dataGridView1.SelectedRows[0].Cells[3].Value;

			вопросыTableAdapter.DeleteQuery(t);
			вариантыTableAdapter.DeleteQuery(t);

			this.dataTable1TableAdapter.Fill(this.anketa_1DataSet.DataTable1);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
