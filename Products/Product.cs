using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }


        public Product() { }

        public Product(string code, string name, decimal price, int quantity)
        {
            Code = code;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string DescribeForFile()
        {
            return $"{Code};{Name};{Price};{Quantity}";
        }

        public static Product ConvertFromFile(string line)
        {
            string[] parts = line.Split(';');

            return new Product(parts[0], parts[1], decimal.Parse(parts[2]), int.Parse(parts[3]));
        }
    }
}
