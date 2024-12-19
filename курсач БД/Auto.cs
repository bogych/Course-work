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
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }
        Thread ts;
        private void Auto_Load(object sender, EventArgs e)
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
            DR.Close();

            string sql1 = "select model_description from Model";
            SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            while (DR1.Read())
            {
                comboBox2.Items.Add(DR1[0]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string sql = "select Mark_Type_ID from Mark_Types where mark_type_name='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
            string marktypeid = "1";
            try
            {
                DR.Read();
                marktypeid = DR[0].ToString();

            }
            catch (Exception ex) 
            {
                marktypeid= "1";
            }
            comboBox2.Items.Clear();
            DR.Close();
            string sql1 = "select model_description from Model where mark_type_id=" + marktypeid;
            SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            while (DR1.Read())
            {
                comboBox2.Items.Add(DR1[0]);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string sql = "select Model_ID from model where model_description='" + comboBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
            string marktypeid = "1";
            try
            {
                DR.Read();
                marktypeid = DR[0].ToString();

            }
            catch (Exception ex)
            {
                marktypeid = "1";
            }
            DR.Close();
            string s=comboBox2.Text;
            comboBox3.Items.Clear();
            string sql1 = "select model_engine_v from Model where model_id=" + marktypeid;
            SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            while (DR1.Read())
            {
                comboBox3.Items.Add(DR1[0]);
            }
            DR1.Close();
            string sql2 = "select price_start,price_end from Model where model_id=" + marktypeid;
            SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            DR2.Read();
            label1.Text = DR2[0].ToString() + "-" + DR2[1].ToString();
            DR2.Close();
        }
        public void open(object obj)
        {
            Application.Run(new Form1());

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ts = new Thread(open);
            ts.SetApartmentState(ApartmentState.STA);
            ts.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text;
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            DateTime date = new DateTime ();
            date = Convert.ToDateTime(monthCalendar1.SelectionStart);
            string podgotovka="Нет";
            if (checkBox1.Checked) 
            {
                podgotovka = "Да";
            }
            string sql1 = "select Model_ID from model where model_description='" + comboBox2.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            DR1.Read();
            string ModelId = DR1[0].ToString();
            DR1.Close();
            string sql = $"insert into auto (auto_name,auto_date,price,podgotovka,count,model_id) values('{s}','{date}',{textBox1.Text},'{podgotovka}',{numericUpDown1.Value},{ModelId})";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataReader DR = cmd.ExecuteReader();
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            textBox1.Text = null;
            numericUpDown1.Value = 1;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }
    }
}
