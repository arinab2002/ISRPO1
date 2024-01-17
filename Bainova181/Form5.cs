using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bainova181
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.view_employee". При необходимости она может быть перемещена или удалена.
            this.view_employeeTableAdapter.Fill(this.database1DataSet.view_employee);
            filldatagrid();
            groupBox1.Hide();
            duties();
        }

        private void filldatagrid()
        {
            dataGridView1.RowCount = view_employeeDataGridView.RowCount;
            dataGridView1.ColumnCount = 7;
            for (int i = 1; i < 7; i++)
            {
                DateTime date = DateTime.Now;
                DateTime date2 = date.AddDays(i);
                dataGridView1.Columns[i].HeaderText = date2.ToShortDateString();
            }
            for (int i = 0; i < dataGridView1.RowCount; i++) 
            {
                dataGridView1[0, i].Value = view_employeeDataGridView[1, i].Value;
            }
        }

        private void duties()
        {
            dataGridView1[1, 0].Value = "Выходной";
            dataGridView1[3, 0].Value = "Выходной";
            dataGridView1[5, 0].Value = "Выходной";
            dataGridView1[2, 1].Value = "Выходной";
            dataGridView1[5, 1].Value = "Выходной";
            dataGridView1[4, 2].Value = "Выходной";
            dataGridView1[5, 2].Value = "Выходной";
            dataGridView1[1, 3].Value = "Выходной";
            dataGridView1[2, 3].Value = "Выходной";
            dataGridView1[4, 3].Value = "Выходной";
            dataGridView1[5, 3].Value = "Выходной";
            dataGridView1[1, 4].Value = "Выходной";
            dataGridView1[2, 4].Value = "Выходной";
            dataGridView1[3, 4].Value = "Выходной";
            dataGridView1[1, 5].Value = "Выходной";
            dataGridView1[3, 5].Value = "Выходной";
            dataGridView1[4, 5].Value = "Выходной";
            dataGridView1[5, 5].Value = "Выходной";
            dataGridView1[2, 6].Value = "Выходной";
            dataGridView1[4, 6].Value = "Выходной";
            dataGridView1[5, 6].Value = "Выходной";
            dataGridView1[1, 7].Value = "Выходной";
            dataGridView1[2, 7].Value = "Выходной";
            dataGridView1[3, 7].Value = "Выходной";
            dataGridView1[4, 7].Value = "Выходной";
            dataGridView1[2, 0].Value = "9-12";
            dataGridView1[4, 0].Value = "9-12";
            dataGridView1[4, 1].Value = "9-12";
            dataGridView1[3, 1].Value = "9-12";
            dataGridView1[1, 1].Value = "9-12";
            dataGridView1[1, 2].Value = "9-12";
            dataGridView1[2, 2].Value = "9-12";
            dataGridView1[5, 2].Value = "9-12";
            dataGridView1[3, 2].Value = "9-12";
            dataGridView1[3, 3].Value = "9-12";
            dataGridView1[3, 3].Value = "9-12";
            dataGridView1[4, 4].Value = "9-12";
            dataGridView1[5, 4].Value = "9-12";
            dataGridView1[2, 5].Value = "9-12";
            dataGridView1[1, 6].Value = "9-12";
            dataGridView1[3, 6].Value = "9-12";
            dataGridView1[5, 6].Value = "9-12";
            dataGridView1[5, 7].Value = "9-12";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var dutytime = $"{numericUpDown1.Value}-{numericUpDown2.Value}";
            dataGridView1.CurrentCell.Value = dutytime;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = "Выходной";
        }
    }
}
