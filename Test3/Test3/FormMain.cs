using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Test3
{
	public partial class FormMain : Form
	{
		public static bool admin = false;
		public static int idPerson = -1;
		public static string fio = "";
		public static int countQuestions = -1, forQuestions = -1, countQ2 = 0;
		public static int countRightResult = 0;
		private static string p = "admin123";
		//https://coderoad.ru/6649363/%D0%9F%D0%BE%D1%81%D1%82%D0%B0%D0%B2%D1%89%D0%B8%D0%BA-Microsoft-ACE-OLEDB-12-0-%D0%BD%D0%B5-%D0%B7%D0%B0%D1%80%D0%B5%D0%B3%D0%B8%D1%81%D1%82%D1%80%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD-%D0%BD%D0%B0-%D0%BB%D0%BE%D0%BA%D0%B0%D0%BB%D1%8C%D0%BD%D0%BE%D0%BC-%D0%BA%D0%BE%D0%BC%D0%BF%D1%8C%D1%8E%D1%82%D0%B5%D1%80%D0%B5
		public FormMain()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{			
			FormRegistration f2 = new FormRegistration();
			f2.Owner = this;
			f2.ShowDialog();
			if(idPerson != -1)
			{
				label4.Text = "Кто проходит тест: " + fio;
				button2.Visible = true;
				label2.Visible = true;
			}
			else
			{
				label4.Text = "Выберите кто проходит тест: ";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(countQ2 != 0)
            {
				MessageBox.Show("Вы не можете пройти тест 2-й раз");
            }
            else
            {
				FormQuestions f3 = new FormQuestions();
				f3.Owner = this;
				f3.ShowDialog();
			}		
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.Owner = this;
			f4.ShowDialog();
		}

        private void button5_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == p)
			{
				button3.Visible = true;
				textBox1.Text = "";
				label3.Text = "Права администратора";
				button5.Visible = false;
				textBox1.Visible = false;
				button2.Visible = true;
				label2.Visible = true;
				button6.Visible = true;
				admin = true;
			}
			else
            {
				textBox1.Text = "";
				MessageBox.Show("Введите верный пароль для администратора");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
			FormAllQuestions fA = new FormAllQuestions();
			fA.Owner = this;
			fA.ShowDialog();
		}

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anketa_1DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.anketa_1DataSet1.DataTable1);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
