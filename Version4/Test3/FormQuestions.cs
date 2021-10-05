using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Test3.Anketa_1DataSet;
// вывод списка вопросов для администратора

namespace Test3
{
    public struct ArrayQuestions
    {
        public int numQuetion;
        public string question;
        public string answer;
        public int numRightQuestion;
    }

    public partial class FormQuestions : Form
    {
        public static int q = 1;
        // Заносим все в array и из него подставляем вопросы и ответы
        Anketa_1DataSetTableAdapters.DataTable1TableAdapter a = new Anketa_1DataSetTableAdapters.DataTable1TableAdapter();
        string numRight1 = "", numRight2 = "", numRight3 = "";
        List<string> radb = new List<string>();
        ArrayQuestions[] cd;

        public FormQuestions()
        {
            InitializeComponent();

            Text = "Тест (" + FormMain.fio + ")";

            List<ArrayQuestions> arr = new List<ArrayQuestions>();

            var c = a.GetData();
            arr.Clear();
            ArrayQuestions aq = new ArrayQuestions();
            foreach (DataTable1Row c1 in c.Rows)
            {
                aq.numQuetion = c1.КодВопр;
                aq.question = c1.Вопрос;
                aq.answer = c1.Ответ;
                aq.numRightQuestion = c1.Балл;
                arr.Add(aq);
            }
            cd = arr.OrderBy(u => u.numQuetion).ToArray();
            FormMain.countQ2 = 0;
            textBox1.Text = cd[FormMain.countQ2 * 3 + 0].question;
            textBox2.Text = cd[FormMain.countQ2 * 3 + 0].answer;
            textBox3.Text = cd[FormMain.countQ2 * 3 + 1].answer;
            textBox4.Text = cd[FormMain.countQ2 * 3 + 2].answer;
            numberQuestion.Text = (FormMain.countQ2 + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anketa_1DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.anketa_1DataSet1.DataTable1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                FormMain.countQ2++;
                bool repeat = false;
                try
                {
                    switch (radb[FormMain.countQ2])
                    {
                        case "numRight1":
                            radioButton1.Checked = true;
                            repeat = true;
                            break;
                        case "numRight2":
                            radioButton2.Checked = true;
                            repeat = true;
                            break;
                        case "numRight3":
                            radioButton3.Checked = true;
                            repeat = true;
                            break;
                    }
                }
                catch (Exception mes)
                {
                    //q++;
                }
                if (radioButton1.Checked == true && !repeat)
                {
                    radb.Add("numRight1");
                }
                if (radioButton2.Checked == true && !repeat)
                {
                    radb.Add("numRight2");
                }
                if (radioButton3.Checked == true && !repeat)
                {
                    radb.Add("numRight3");
                }
                // если вопросы еще есть
                if (FormMain.countQ2 < 10)
                {
                    numberQuestion.Text = (FormMain.countQ2 + 1).ToString();
                    textBox1.Text = cd[FormMain.countQ2 * 3].question;
                    textBox2.Text = cd[FormMain.countQ2 * 3 + 0].answer;
                    textBox3.Text = cd[FormMain.countQ2 * 3 + 1].answer;
                    textBox4.Text = cd[FormMain.countQ2 * 3 + 2].answer;

                    if ((radioButton1.Checked == true && cd[3 * FormMain.countQ2].numRightQuestion == 1) ||
                            (radioButton2.Checked == true && cd[3 * FormMain.countQ2].numRightQuestion == 1) ||
                            (radioButton3.Checked == true && cd[3 * FormMain.countQ2].numRightQuestion == 1) &&
                            !repeat)
                    {
                        FormMain.countRightResult++;
                    }
                }
                else
                {
                    MessageBox.Show("Ваш результат: "
                        + FormMain.countRightResult + " верных ответов из 10", FormMain.fio);
                    FormMain.countRightResult = 0;
                    Close();
                }
                if (!repeat)
                {
                    radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = false;
                }

            }
            else
            {
                MessageBox.Show("Выберите ответ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FormMain.countQ2 > 0)
            {
                FormMain.countQ2--;
                numberQuestion.Text = (FormMain.countQ2 + 1).ToString();
                // если вопросы еще есть
                textBox1.Text = cd[3 * FormMain.countQ2].question;
                textBox2.Text = cd[3 * FormMain.countQ2].answer;
                textBox3.Text = cd[3 * FormMain.countQ2 + 1].question;
                textBox4.Text = cd[3 * FormMain.countQ2 + 2].question;

                switch (radb[FormMain.countQ2])
                {
                    case "numRight1":
                        radioButton1.Checked = true;
                        break;
                    case "numRight2":
                        radioButton2.Checked = true;
                        break;
                    case "numRight3":
                        radioButton3.Checked = true;
                        break;
                }
                // radb.Remove[FormMain.countQ2 + 1];
            }
        }
    }
}
