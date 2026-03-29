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
    public partial class Report_Quantity : Form
    {
        public Report_Quantity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> filtered = new List<Product>();
            int threshold;

            if (int.TryParse(textBox1.Text, out threshold))
            {
                foreach (Product p in Form1.ProductList)
                {
                    if (p.Quantity < threshold)
                    {
                        filtered.Add(p);
                    }
                }
            }
            else
            {
                foreach (Product p in Form1.ProductList)
                {
                    filtered.Add(p);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtered;
        }
    }
}
