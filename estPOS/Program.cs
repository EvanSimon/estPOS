using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> shoppingList = new List<Product>();
            bool run = true;
            while (run)
            {
               shoppingList.Add(Item());
               run = ContinueShoping();
                if(run == false)
                {
                    Calculate(shoppingList);
                }
            }
        }
        public static Product Item()
        {
            Console.WriteLine("Welcome to the JEKK Shoe's Boutique");
            Console.WriteLine("\nWhich shoes are you intrested in?");
            List<Product> ShoesList = new List<Product>
            {
                     new Product("Micheal Kors Leather Cutout Pump", "Womans", "Micheal Kors red lether", 125.99),
                     new Product("Alexander Maqueen Sculpted Heal Boot", "Womans", "Alexander Maqueen black cashmere suede fitted", 1090.99),
                     new Product("Christian Louboutin Corneille Pump", "Womans", "Christian Louboutin black leather red heel", 695.99),
                     new Product("Air Jordan 11", "Mens", "Retro Black/NightShade-White-Vlt Ice", 380.99),
                     new Product("Tom Ford Sued Sneakers", "Mens", "Tom Ford Warwick Contrast Mid-Brown/Black", 850.99),
                     new Product("Jimmy Choo Over The knee Boot", "Womans", "Jimmy Choo Black Suede and Stretch Suede", 1795.99),
                     new Product("Kate Spade Noah Flats", "Womans", "Kate Spade Black/Pink Sheeps Leather", 198.99),
                     new Product("Nike Air Max 95", "Mens", "Oil Grey/Gunsmoke/Laser", 175.99),
                     new Product("Alexander Maqueen Suede Chelsea Boots", "Mens", "Alexander Maqueen black suede zip boot",950.99),
                     new Product("Jimmy Choo Joni Flats", "Womans", " Jimmy Choo Black Suede Slides", 175.99),
                     new Product("Stella MaCartney's Adidas Stan Smith Sneakers", "Womans", "Stella MaCartney's version of the Stan Smith Sneakers", 325.99),
                     new Product("Steve Maddan Hypnotic Black Crocodile", "Womans", "Steve Madden Black Crocodile Pumps", 110.99),
            };
                for (int i = 0; i < ShoesList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {ShoesList[i].Name}: ${ShoesList[i].Price}");
                }
               
                Console.WriteLine("Which shoe would you like to purchase (1-12)?");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("You selected:{0}:{1}:${2}", ShoesList[input - 1].Catagory , ShoesList[input - 1].Name, ShoesList[input - 1].Price);
             
            return ShoesList[input - 1];
        }

        public static bool ContinueShoping()
        {
            Console.WriteLine("would you like to continue shopping?(y/n)");
            string input = Console.ReadLine().ToLower();
            bool stuff;
            if (input == "y")
            {
                stuff = true;
            }
            else if (input == "n")
            {
                stuff = false;
            }
            else
            {
                Console.WriteLine("Sorry I didn't catch that. Please try agian (y/n)");
                stuff = ContinueShoping();
            }
            return stuff;
        }

        public static void Calculate(List<Product> Purchesed)
        {
            double userChange;
            double subTotal = 0;
            double Tax = 0;
            double Total = 0;
            for (int i = 0; i < Purchesed.Count; i++)
            {
                subTotal = Purchesed[i].Price + subTotal;
            }
            Tax = .06 * subTotal;
            Total = Tax + subTotal;
            for (int i = 0; i < Purchesed.Count; i++)
            {
                Console.WriteLine($"The items you purchesed are:{Purchesed[i].Name}:{Purchesed[i].Price}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Subtotal:${subTotal, 0:F2}" );
            Console.WriteLine($"Taxed:${Tax, 0:F2}" );
            Console.WriteLine($"Grand total is:${Total, 0:F2}" );
            Console.WriteLine("How much are you paying?");
            double userPayment = double.Parse(Console.ReadLine());
            userChange = userPayment - Total;
            Console.WriteLine($"Thank you for your payment.\nYour change is:${userChange, 0:F2}");

        }
    } 
}
