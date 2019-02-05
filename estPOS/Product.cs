using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estPOS
{
   public class Product
    {
        public string Name;
        public string Catagory;
        public string Description;
        public double Price;
        

        public Product(string name, string catagory, string description, double price)
        {
            Name = name;
            Catagory = catagory;
            Description = description;
            Price = price;         
        }
    }
}
