using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.SqlClient;
using System.Data;
namespace курсач_БД
{
    public partial class Form1 : Form
    {
        Thread ts; Thread t; Thread ta; Thread tg; Thread tx;

        public Form1()
        {
            InitializeComponent();
        }

        public void open(object obj)
        {
            Application.Run(new Form2());

        }
        public void openAuto(object obj)
        {
            Application.Run(new Auto());

        }
        public void openZakaz(object obj)
        {
            Application.Run(new Zakazi());
        }
        public void openService(object obj)
        {
            Application.Run(new Service());
        }
        public void openPay(object obj)
        {
            Application.Run(new Payment());
        }
        private void самавToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ts = new Thread(open);
            ts.SetApartmentState(ApartmentState.STA);
            ts.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string cmd = "SELECT * FROM auto"; // Из какой таблицы нужен вывод 
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            SqlCommand com = new SqlCommand(cmd, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "dbo.Clients");
            dataGridView1.DataSource = ds.Tables["dbo.Clients"].DefaultView;
        }

        private void вводКлиентовВБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ShowDialog(this);
        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.ShowDialog(this);
        }

        private void автоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(openAuto);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ta = new Thread(openZakaz);
            ta.SetApartmentState(ApartmentState.STA);
            ta.Start();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            tg = new Thread(openService);
            tg.SetApartmentState(ApartmentState.STA);
            tg.Start();
        }

        private void отчетностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            tx = new Thread(openPay);
            tx.SetApartmentState(ApartmentState.STA);
            tx.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string cmd = "SELECT * FROM auto"; // Из какой таблицы нужен вывод 
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            SqlCommand com = new SqlCommand(cmd, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "dbo.Clients");
            dataGridView1.DataSource = ds.Tables["dbo.Clients"].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string cmd = "SELECT * FROM Client"; // Из какой таблицы нужен вывод 
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            SqlCommand com = new SqlCommand(cmd, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "dbo.Clients");
            dataGridView1.DataSource = ds.Tables["dbo.Clients"].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string cmd = "SELECT * FROM Model"; // Из какой таблицы нужен вывод 
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            SqlCommand com = new SqlCommand(cmd, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "dbo.Clients");
            dataGridView1.DataSource = ds.Tables["dbo.Clients"].DefaultView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-H5AF047;Initial Catalog=sdf;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string cmd = "SELECT * FROM Mark_Types"; // Из какой таблицы нужен вывод 
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            SqlCommand com = new SqlCommand(cmd, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "dbo.Clients");
            dataGridView1.DataSource = ds.Tables["dbo.Clients"].DefaultView;
        }
    }
}
