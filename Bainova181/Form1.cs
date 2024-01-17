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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.view_goods". При необходимости она может быть перемещена или удалена.
            this.view_goodsTableAdapter.Fill(this.database1DataSet.view_goods);
            groupBox1.Hide();
            // Комментарий для первого коммита
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ID = view_goodsDataGridView.CurrentCell.RowIndex + 1;
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить продукт № {ID}?", "Сообщение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection sqlConnection1 = new SqlConnection(Properties.Settings.Default.dbcon);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"delete goods where id_good = {ID}";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var namount = numericUpDown1.Value;
            var ID = view_goodsDataGridView.CurrentCell.RowIndex + 1;
            DialogResult result = MessageBox.Show($"Вы действительно хотите изменить количество продукта № {ID} на {namount}?", "Сообщение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection sqlConnection1 = new SqlConnection(Properties.Settings.Default.dbcon);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"update goods set amount = {namount} where id_good = {ID}";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                SqlCommand updv = new SqlCommand();
                updv.CommandType = System.Data.CommandType.Text;
                updv.CommandText = $"insert into st_updates values ({random.Next(1, 100)}, getdate(), 1, {ID})";
                updv.Connection = sqlConnection1;
                sqlConnection1.Open();
                updv.ExecuteNonQuery();
                sqlConnection1.Close();
            }
            groupBox1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.view_goodsTableAdapter.Fill(this.database1DataSet.view_goods);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }
    }
}
