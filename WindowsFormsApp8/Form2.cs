using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9, 9) + "ClothesShop.mdb;";
        private OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            MessageBox.Show(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9, 9));
        }

        private void Form2_Load(object sender, EventArgs e)
        {           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }
    }
}
