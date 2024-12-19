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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text;
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string sql = $"insert into client (Client_name,client_nomer) values('{a}','{textBox4.Text}')";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
