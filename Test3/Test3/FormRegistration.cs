﻿using System;
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

	public partial class FormRegistration : Form
	{
		public FormRegistration()
		{
			InitializeComponent();
			//if(!admin)
			{
				button3.Visible = button4.Visible = button5.Visible = false;
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

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				FormMain.idPerson = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
				FormMain.fio = "" + dataGridView1.SelectedRows[0].Cells[1].Value + " " + 
					dataGridView1.SelectedRows[0].Cells[2].Value +
					" " + dataGridView1.SelectedRows[0].Cells[3].Value;
				FormMain.countQuestions = 10;
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
	}
}