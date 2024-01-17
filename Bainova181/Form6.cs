using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bainova181
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.view_goods". При необходимости она может быть перемещена или удалена.
            this.view_goodsTableAdapter.Fill(this.database1DataSet.view_goods);
            groupBox1.Hide(); 
            groupBox2.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(Properties.Settings.Default.dbcon);
            SqlCommand cmd = new SqlCommand();
            sqlConnection1.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"select * from view_goods where Название like N'%{textBox1.Text}%'", sqlConnection1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            view_goodsDataGridView.DataSource = dt;
            sqlConnection1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            groupBox1.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(Properties.Settings.Default.dbcon);
            SqlCommand cmd = new SqlCommand();
            sqlConnection1.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"select * from view_goods where [Тип продукта] like N'%{textBox2.Text}%'", sqlConnection1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            view_goodsDataGridView.DataSource = dt;
            sqlConnection1.Close();
        }
    }
}
