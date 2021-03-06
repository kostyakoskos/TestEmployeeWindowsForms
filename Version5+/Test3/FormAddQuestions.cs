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
	public partial class FormAddQuestions : Form
	{
		static bool temp = true;
		public FormAddQuestions()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'anketa_1DataSet1.Виды' table. You can move, or remove it, as needed.
            this.видыTableAdapter.Fill(this.anketa_1DataSet1.Виды);
            // TODO: This line of code loads data into the 'anketa_1DataSet1.Варианты' table. You can move, or remove it, as needed.
            //this.вариантыTableAdapter.Fill(this.anketa_1DataSet1.Варианты);
            // TODO: This line of code loads data into the 'anketa_1DataSet1.Виды' table. You can move, or remove it, as needed.
            this.видыTableAdapter.Fill(this.anketa_1DataSet1.Виды);
            // TODO: This line of code loads data into the 'anketa_1DataSet1.Вопросы' table. You can move, or remove it, as needed.
            //this.вопросыTableAdapter.Fill(this.anketa_1DataSet1.Вопросы);
            //// TODO: This line of code loads data into the 'anketa_1DataSet1.DataTable3' table. You can move, or remove it, as needed.
            //this.dataTable3TableAdapter.Fill(this.anketa_1DataSet1.DataTable3);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// обработать ситуацию ничего не выбрано в вопросе
			if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
				!(checkBox1.Checked == checkBox2.Checked == checkBox3.Checked == false))
			{
				var typeQuestion = comboBox1.SelectedItem as DataRowView;
				var codeQuestion = typeQuestion.Row.ItemArray[0] as int?;
				var question = textBox1.Text;
				var answer1 = textBox2.Text;
				var answer2 = textBox3.Text;
				var answer3 = textBox4.Text;
				short numRight1 = 0, numRight2 = 0, numRight3 = 0;
				if (checkBox1.Checked)
				{
					numRight1 = 1;
				}
				if (checkBox2.Checked)
				{
					numRight2 = 1;
				}
				if (checkBox3.Checked)
				{
					numRight3 = 1;
				}

				Anketa_1DataSetTableAdapters.ВопросыTableAdapter qt = new Anketa_1DataSetTableAdapters.ВопросыTableAdapter();

				int sd = qt.InsertQuery2(question, codeQuestion);

				var cf = qt.GetDataBy1(question);
				int t = Convert.ToInt32(cf.Rows[0].ItemArray[0]);
				Anketa_1DataSetTableAdapters.ВариантыTableAdapter vt = new Anketa_1DataSetTableAdapters.ВариантыTableAdapter();
				vt.InsertQuery(t, answer1, numRight1);
				vt.InsertQuery(t, answer2, numRight2);
				vt.InsertQuery(t, answer3, numRight3);
				Close();
			}
            else
            {
				MessageBox.Show("Заполните поля");
            }
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (temp)
			{
				temp = false;
				if (checkBox1.Checked == true)
				{
					checkBox2.Checked = true;
					checkBox1.Checked = false;
				}
				else if (checkBox3.Checked == true)
				{
					checkBox2.Checked = true;
					checkBox3.Checked = false;
				}
			}
			temp = true;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (temp)
			{
				temp = false;
				if (checkBox2.Checked == true)
				{
					checkBox2.Checked = false;
					checkBox1.Checked = true;
				}
				else if (checkBox3.Checked == true)
				{
					checkBox3.Checked = false;
					checkBox1.Checked = true;
				}
			}
			temp = true;
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (temp)
			{
				temp = false;
				if (checkBox1.Checked == true)
				{
					checkBox3.Checked = true;
					checkBox1.Checked = false;
				}
				else if (checkBox2.Checked == true)
				{
					checkBox2.Checked = false;
					checkBox3.Checked = true;
				}
			}
			temp = true;
		}

        private void button3_Click(object sender, EventArgs e)
        {
			
		}

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.видыTableAdapter.FillBy(this.anketa_1DataSet1.Виды);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.видыTableAdapter.FillBy(this.anketa_1DataSet1.Виды);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
