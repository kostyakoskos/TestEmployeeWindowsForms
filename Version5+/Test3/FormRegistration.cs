using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test3
{

    public partial class FormRegistration : Form
    {

        [System.ComponentModel.Browsable(false)]
        public int FirstDisplayedScrollingRowIndex { get; set; }
        Anketa_1DataSetTableAdapters.ПерсоналTableAdapter cf = new Anketa_1DataSetTableAdapters.ПерсоналTableAdapter();
        public FormRegistration()
        {
            InitializeComponent();
            if (FormMain.admin)
            {
                button4.Visible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.персоналTableAdapter.Fill(this.anketa_1DataSet.Персонал);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain.idPerson = -1;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FormMain.admin)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormMain.idPerson = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                FormMain.fio = "" + dataGridView1.SelectedRows[0].Cells[1].Value + " " +
                    dataGridView1.SelectedRows[0].Cells[2].Value +
                    " " + dataGridView1.SelectedRows[0].Cells[3].Value;
                FormMain.countQuestions = 5;
                FormMain.countQ2 = 0;
                Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormRegistrationAdd a = new FormRegistrationAdd();
            a.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cf.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            this.персоналTableAdapter.Fill(this.anketa_1DataSet.Персонал);
            MessageBox.Show("Удаление прошло успешно.");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите номер работника");
            }
            else
            {
                var t = textBox1.Text;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int j = 0;
                    if (dataGridView1.Rows[i].Cells[j].Value != null && dataGridView1.Rows[i].Cells[j].Value.ToString().Equals(t))
                    {

                        dataGridView1.Rows[i].Selected = true;
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                        FormMain.idPerson = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                        FormMain.fio = "" + dataGridView1.SelectedRows[0].Cells[1].Value + " " +
                            dataGridView1.SelectedRows[0].Cells[2].Value +
                            " " + dataGridView1.SelectedRows[0].Cells[3].Value;
                        FormMain.countQuestions = 5;
                        FormMain.countQ2 = 0;
                        Close();
                        i = dataGridView1.RowCount;
                        break;
                    }
                }
            }
        }
    }
}
