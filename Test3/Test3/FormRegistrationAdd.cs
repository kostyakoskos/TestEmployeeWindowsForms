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
   
    public partial class FormRegistrationAdd : Form
    {
        //public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = D:\\Универ\\3 этап\\КурсП\\ДР\\Test3\\Test3\\Anketa_1.accdb";
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Anketa_1.accdb";
        private OleDbConnection myConnection;
        public FormRegistrationAdd()
        {
            InitializeComponent();
            //myConnection = new OleDbConnection(connectString);
            //myConnection.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
			// TODO: This line of code loads data into the 'anketa_1DataSet.Персонал' table. You can move, or remove it, as needed.
			this.персоналTableAdapter.Fill(this.anketa_1DataSet.Персонал);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "anketa_1DataSet.Должности". При необходимости она может быть перемещена или удалена.
			this.должностиTableAdapter.Fill(this.anketa_1DataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "anketa_1DataSet.Подразделения". При необходимости она может быть перемещена или удалена.
            this.подразделенияTableAdapter.FillBy(this.anketa_1DataSet.Подразделения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "anketa_1DataSet.Тест". При необходимости она может быть перемещена или удалена.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int kod = Convert.ToInt32(textBox1.Text);
            string Fam = textBox1.Text;
            string Name = textBox2.Text;
            string Otch = textBox3.Text;
            int kod = Convert.ToInt32(textBox4.Text);
            //string Podr = comboBox1.Text;
            string query = "INSERT INTO Персонал (Фамилия, Имя, Отчество, [Персональный №]) VALUES ('" + Fam + "', '" + Name + "', '" + Otch + "', " + kod + ")";
            //string query2 = "INSERT INTO Подразделения (Названия) VALUES ('" + Podr + "')";
            OleDbCommand comand = new OleDbCommand(query, myConnection);
            comand.ExecuteNonQuery();
            MessageBox.Show("Спасибо, сохранено!");
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.должностиTableAdapter.FillBy(this.anketa_1DataSet.Должности);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
      Anketa_1DataSetTableAdapters.ПерсоналTableAdapter a = new Anketa_1DataSetTableAdapters.ПерсоналTableAdapter();
      var f = textBox1.Text;
      var i = textBox2.Text;
      var o = textBox3.Text;
      int num = 0;
      int.TryParse(textBox4.Text, out num);
      var aqw = comboBox1.SelectedItem as DataRowView;
      int index = -Convert.ToInt32(aqw.Row[0]);

      var aqw2 = comboBox2.SelectedItem as DataRowView;
      int index2 = -Convert.ToInt32(aqw.Row[0]);

      //персоналTableAdapter
       a.InsertQuery(f, i, o, num, index, index2);
      //anketa_1DataSet.AcceptChanges();
      this.персоналTableAdapter.Fill(this.anketa_1DataSet.Персонал);
    }
  }
}
