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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Product result = Form1.ProductList.Find(product => product.Code == textBox1.Text);
            if (result != null)
            {
                MessageBox.Show("Този код вече е използван!");
                textBox1.Text = "";
                return;
            }
            Product p = new Product(textBox1.Text, textBox2.Text, decimal.Parse(textBox3.Text), int.Parse(textBox4.Text));

            Form1.ProductList.Add(p);

            FileStream fs = new FileStream(Form1.FN, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Product product in Form1.ProductList)
            {
                sw.WriteLine(product.DescribeForFile());
            }

            MessageBox.Show("Продуктът е довавен!");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            sw.Close();
            fs.Close();
        }
    }
}
