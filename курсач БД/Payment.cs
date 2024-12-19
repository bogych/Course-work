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
using System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace курсач_БД
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            numericUpDown1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            numericUpDown1.Visible = true;
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string cmd = "SELECT * FROM Service"; // Из какой таблицы нужен вывод 
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            SqlCommand com = new SqlCommand(cmd, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "dbo.Clients");
            dataGridView1.DataSource = ds.Tables["dbo.Clients"].DefaultView;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            DateTime date = DateTime.Now;
            string auto = comboBox1.Text;
            string sql2 = "select price from auto where auto_id=" + auto;
            SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            DR2.Read();
            int a = Convert.ToInt16(DR2[0]);
            DR2.Close();
            string sql3 = "select price from service where service_id=" + numericUpDown1.Value;
            SqlCommand cmd3 = new SqlCommand(sql2, sqlConnection);
            SqlDataReader DR3 = cmd2.ExecuteReader();
            DR2.Read();
            int w = Convert.ToInt16(DR3[0]);
            DR2.Close();
            string sql1 = "select auto_id from auto where auto_name='" + comboBox1.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            DR1.Read();
            string ModelId = DR1[0].ToString();
            DR1.Close();
            int b = a + w;
            string sql = $"insert into payment (auto_id,payment_date,amount,payment_method,service_id) values('{ModelId}','{date}',{b},'{comboBox2.Text}',{numericUpDown1.Value})";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
        }
    }
}
