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
using System.Data.Sql;
using Microsoft.Data.SqlClient;

namespace lab2crud
{
    public partial class Form1 : Form
    {
        System.Data.SqlClient.SqlConnection cn;
        System.Data.SqlClient.SqlCommand cmd;
        System.Data.SqlClient.SqlDataReader reader;
        System.Data.SqlClient.SqlDataAdapter da;
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            cn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sanek\\source\\repos\\lab2crud\\lab2crud\\Database1.mdf; Integrated Security=True");
            cn.Open();

            GetAllCarRecord();
        }

        private void GetAllCarRecord()
        {
            cmd = new System.Data.SqlClient.SqlCommand("Select * from VintageCar", cn);
            da = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
