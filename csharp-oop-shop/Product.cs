using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace csharp_oop_shop
{
    internal class Product
    {
        private int code;
        private string name;
        private string description;
        private double price;
        private double iva;



        public Product(string name, string description, double price)
        {
            var random = new Random();
            this.code = random.Next(100, 999);
            this.name = name;
            this.description = description;
            this.price = price;
            this.iva = price * 0.22;
        }

        public int Code { get => code; }
        public string Name { get => name; set { name = value; } }
        public string Description { get => description; set { description = value; } }
        public double Price
        {
            get => price; set
            {
                price = value;
            }
        }
        public double Iva { get => iva; }

        public double TotalPrice()
        {
            return price + this.iva;
        }

        public string ExtendedName()
        {
            return $"{Code} - {Name}";
        }
    }
}