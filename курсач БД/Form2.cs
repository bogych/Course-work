using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace курсач_БД
{
    public partial class Form2 : Form
    {
        Thread ts;
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string sql = "select Mark_Type_Name from Mark_Types";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string sql = $"insert into model (Cuzov_Type,Price_Start,Price_End,Model_Engine_V,Model_Engine_Type,Model_KPP,Model_Description,Mark_Type_ID) values('{comboBox2.Text}',{textBox2.Text},{textBox3.Text},{textBox1.Text},'{comboBox3.Text}','{comboBox4.Text}','{richTextBox1.Text}',{comboBox1.SelectedIndex + 1})";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
            comboBox1.Text=null;
            comboBox2.Text=null;
            comboBox3.Text=null;
            comboBox4.Text=null;
            textBox1.Text=null;
            textBox2.Text=null;
            textBox3.Text=null;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void open(object obj)
        {
            Application.Run(new Form1());

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ts = new Thread(open);
            ts.SetApartmentState(ApartmentState.STA);
            ts.Start();
        }
    }
}
