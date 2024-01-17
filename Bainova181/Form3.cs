using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bainova181
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.view_employee". При необходимости она может быть перемещена или удалена.
            this.view_employeeTableAdapter.Fill(this.database1DataSet.view_employee);
            groupBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = numericUpDown1.Value;
            var name = "N'" + textBox1.Text + "'";
            var spec = "N'" + textBox2.Text + "'";
            var exp = numericUpDown2.Value;
            SqlConnection sqlConnection1 = new SqlConnection(Properties.Settings.Default.dbcon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into employees values ({id}, {name}, {spec}, {exp})";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            groupBox1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ID = view_employeeDataGridView.CurrentCell.RowIndex + 1;
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить сотрудника № {ID}?", "Сообщение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection sqlConnection1 = new SqlConnection(Properties.Settings.Default.dbcon);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"delete employees where id_employee = {ID}";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.view_employeeTableAdapter.Fill(this.database1DataSet.view_employee);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }
    }
}
