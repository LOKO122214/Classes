using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHelper
{
    internal class Product
    {
        private string name;
        private double price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price 
        { 
         get { return price;}
         set { price = value; }
        }

        public Product(string name,int price) 
        {
        Name = name;
        Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Продукта {name} е с цена {price} лв");
        }

        public void PrintMessage()
        {
            Console.WriteLine($"В наличност");
        }
    }
}
