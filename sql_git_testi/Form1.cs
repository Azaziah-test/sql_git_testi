using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sql_git_testi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection con;
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\git_testi.mdf;
                          Integrated Security=True;
                          Connect Timeout=10;
                          User Instance=False";
            con.Open();
            MessageBox.Show("Connection opened");
            con.Close();
            MessageBox.Show("Connection closed");
        }
    }
}
