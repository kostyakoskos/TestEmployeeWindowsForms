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
    public partial class FormResultTest : Form
    {
        public FormResultTest()
        {
            InitializeComponent();
        }

        private void FormResultTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anketa_1DataSet11.Персонал' table. You can move, or remove it, as needed.
            //this.персоналTableAdapter1.Fill(this.anketa_1DataSet11.Персонал);
            //// TODO: This line of code loads data into the 'anketa_1DataSet.DataTable1' table. You can move, or remove it, as needed.
            //this.dataTable1TableAdapter.Fill(this.anketa_1DataSet.DataTable1);
            //// TODO: This line of code loads data into the 'anketa_1DataSet1.Персонал' table. You can move, or remove it, as needed.
            //this.персоналTableAdapter.Fill(this.anketa_1DataSet1.Персонал);
            //// TODO: This line of code loads data into the 'anketa_1DataSet1.DataTableПерсонал' table. You can move, or remove it, as needed.
           // this.dataTableПерсоналTableAdapter.Fill(this.anketa_1DataSet1.DataTableПерсонал);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.персоналTableAdapter.FillBy1(this.anketa_1DataSet.Персонал);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.персоналTableAdapter.FillBy2(this.anketa_1DataSet1.Персонал);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.персоналTableAdapter.FillBy3(this.anketa_1DataSet2.Персонал);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.персоналTableAdapter.FillBy4(this.anketa_1DataSet.Персонал);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
