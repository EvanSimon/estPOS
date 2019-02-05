using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estPOS
{
   public class PurchesdProduct : Product
    {
        public PurchesdProduct(string name, string catagory, string description, double price): base(name, catagory,  description,  price)
        {
            Name = name;
            Catagory = catagory;
            Description = description;
            Price = price;          
        }
    }
}
