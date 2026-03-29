using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class Edit : Form
    {
        FileStream fs;
        StreamWriter sw;
        public Edit()
        {
            InitializeComponent();
            dataGridView1.DataSource = Form1.ProductList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            Product productUpdate = Form1.ProductList.Find(product => code == product.Code);
            if (productUpdate != null)
            {
                productUpdate.Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                productUpdate.Price = decimal.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                productUpdate.Quantity = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

                bindingSource1.ResetBindings(false);

                fs = new FileStream(Form1.FN, FileMode.OpenOrCreate);
                sw = new StreamWriter(fs);

                foreach (Product product in Form1.ProductList)
                {
                    sw.WriteLine(product.DescribeForFile());
                }
                MessageBox.Show("Продуктът беше обновен!");
                sw.Close();
                fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            Product productDelete = Form1.ProductList.Find(product => product.Code == code);
            if (productDelete != null)
            {
                Form1.ProductList.Remove(productDelete);
                fs = new FileStream(Form1.FN, FileMode.Create, FileAccess.ReadWrite);
                sw = new StreamWriter(fs);

                foreach (Product product in Form1.ProductList)
                {
                    sw.WriteLine(product.DescribeForFile());
                }
                MessageBox.Show("Продуктът беше изтрит!");
                sw.Close();
                fs.Close();
                this.Close();
            }
        }
    }
}
