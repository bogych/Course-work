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
    public partial class Zakazi : Form
    {
        public Zakazi()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Zakazi_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string sql = "select Auto_name from auto";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);
            }
            DR.Close();
            string sql1 = "select client_name from client";
            SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            while (DR1.Read())
            {
                comboBox2.Items.Add(DR1[0]);
            }
            DR1.Close();
            string sql2 = "select staff_name from staff";
            SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (DR2.Read())
            {
                comboBox3.Items.Add(DR2[0]);
            }
            DR2.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            DateTime a = DateTime.Now;
            
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string sql1 = "select auto_id from auto where auto_name='" + comboBox1.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            DR1.Read();
            string ModelId = DR1[0].ToString();
            DR1.Close();
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
            int c = Convert.ToInt16(DR2[0]);
            DR3.Close();
            string sql4 = "select client_id from client where client_name=" + comboBox2.Text;
            SqlCommand cmd4 = new SqlCommand(sql2, sqlConnection);
            SqlDataReader DR4 = cmd4.ExecuteReader();
            DR4.Read();
            int staf = Convert.ToInt16(DR2[0]);
            DR4.Close();
            DateTime date = new DateTime();
            date = Convert.ToDateTime(monthCalendar1.SelectionStart);
            string sql = $"insert into orders (client_id,auto_id,order_date,dostavka_date,Total_price,staff_id) values({b},{ModelId},{a},{date},{textBox1.Text},{staf})";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ShowDialog(this);
        }
    }
}
