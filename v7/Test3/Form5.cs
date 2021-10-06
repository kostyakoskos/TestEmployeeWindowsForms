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
    public partial class Form5 : Form
    {
        //public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Anketa_1.accdb";
        //private OleDbConnection myConnection;
        public Form5()
        
        {
            InitializeComponent();
            //myConnection = new OleDbConnection(connectString);
            //myConnection.Open();
        }
        string Log = "admin";
        string Psw = "admin1";
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
