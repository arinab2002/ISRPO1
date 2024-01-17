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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bainova181
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = numericUpDown1.Value;
            var name = "N'" + textBox1.Text + "'";
            var type = comboBox1.SelectedIndex + 1;
            var price = numericUpDown2.Value;
            var amount = numericUpDown3.Value;
            SqlConnection sqlConnection1 = new SqlConnection(Properties.Settings.Default.dbcon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into goods values ({id}, {name}, {type}, {price}, {amount})";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            Random random = new Random();
            SqlCommand updv = new SqlCommand();
            updv.CommandType = System.Data.CommandType.Text;
            updv.CommandText = $"insert into st_updates values ({random.Next(1, 100)}, getdate(), 1, {id})";
            updv.Connection = sqlConnection1;
            sqlConnection1.Open();
            updv.ExecuteNonQuery();
            sqlConnection1.Close();
            this.Close();
        }
    }
}
