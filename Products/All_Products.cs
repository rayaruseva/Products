using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class All_Products : Form
    {
        public All_Products()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Form1.ProductList;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                try
                {
                    decimal price = (decimal)row.Cells[2].Value;
                    int quantity = (int)row.Cells[3].Value;
                    decimal total = price * quantity;
                    row.Cells[4].Value = total;
                }
                catch
                {
                    row.Cells[4].Value = "Error";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            decimal totalSum = 0;

            foreach (Product p in Form1.ProductList)
            {
                totalSum += p.Price * p.Quantity;
            }
            textBox1.Text = totalSum.ToString() + " лв.";
        }
    }
}
