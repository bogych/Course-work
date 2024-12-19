using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace курсач_БД
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            DateTime date = DateTime.Now;
            string sql2 = "select client_id from client where client_name=" + comboBox2.Text;
            SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            DR2.Read();
            int b = Convert.ToInt16(DR2[0]);
            DR2.Close();
            string sql3 = "select staff_id from staff where staff_name=" + comboBox3.Text;
            SqlCommand cmd3 = new SqlCommand(sql2, sqlConnection);
            SqlDataReader DR3 = cmd3.ExecuteReader();
            DR3.Read();
            string sql = $"insert into orders (client_id,service_date,price,service_dec,staff_id) values({b},{date},{textBox2.Text},'{richTextBox1.Text}',{sql3})"; ;
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ShowDialog(this);
        }
    }
}
