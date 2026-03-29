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
    public partial class Form1 : Form
    {
        public static string FN = "D:\\products.txt";
        public static List<Product> ProductList = new List<Product>();

        FileStream fs;
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(FN))
            {
                fs = new FileStream(FN, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        ProductList.Add(Product.ConvertFromFile(line));
                    }
                }
                sr.Close();
                fs.Close();
            }
            else
            {
                fs = new FileStream(FN, FileMode.Create);
                fs.Close();
            }
        }

        private void добавиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Add().ShowDialog();
        }

        private void редактиранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Edit().ShowDialog();
        }

        private void поКоличествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Report_Quantity().ShowDialog();
        }

        private void поЦенаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Report_Price().ShowDialog();
        }

        private void всичкиПродуктиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new All_Products().ShowDialog();
        }
    }
}
