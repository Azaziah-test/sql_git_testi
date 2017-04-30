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
            con.Close();
            MessageBox.Show("Connection closed");
            // UUSI TESTI
            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\git_testi.mdf;
                          Integrated Security=True;
                          Connect Timeout=10;
                          User Instance=False");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM testi";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();


        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'git_testiDataSet1.testi' table. You can move, or remove it, as needed.
            this.testiTableAdapter1.Fill(this.git_testiDataSet1.testi);
            // TODO: This line of code loads data into the 'git_testiDataSet.testi' table. You can move, or remove it, as needed.
            this.testiTableAdapter.Fill(this.git_testiDataSet.testi);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\git_testi.mdf;
                          Integrated Security=True;
                          Connect Timeout=10;
                          User Instance=False");
            con.Open();
            con.Close();

            SqlCommand cmd = new SqlCommand("INSERT INTO [testi] ([testi_field], [testi_2]) VALUES (@testi_field, @testi_2)");
            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@testi_field", name);
            cmd.Parameters.AddWithValue("@testi_2", textBox1.Text);
            MessageBox.Show(textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();


            // TODO: This line of code loads data into the 'git_testiDataSet1.testi' table. You can move, or remove it, as needed.
            this.testiTableAdapter1.Fill(this.git_testiDataSet1.testi);
            // TODO: This line of code loads data into the 'git_testiDataSet.testi' table. You can move, or remove it, as needed.
            this.testiTableAdapter.Fill(this.git_testiDataSet.testi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "[testi_field] Like '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
