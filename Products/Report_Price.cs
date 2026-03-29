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
    public partial class Report_Price : Form
    {
        public Report_Price()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Въведете положително цяло число.");
                return;
            }

            List<Product> sortedProducts = new List<Product>(Form1.ProductList);
            sortedProducts.Sort((a, b) => b.Price.CompareTo(a.Price));

            List<Product> topProducts = new List<Product>();

            int maxItems = count;
            if (count > sortedProducts.Count)
            {
                maxItems = sortedProducts.Count;
            }

            for (int i = 0; i < maxItems; i++)
            {
                topProducts.Add(sortedProducts[i]);
            }

            foreach (Product product in topProducts)
            {
                listBox1.Items.Add($"{product.Name} - {product.Price} лв.");
            }
        }
    }
}
