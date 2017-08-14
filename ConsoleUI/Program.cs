using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CFNewDb.Logic;
using System.Data.Entity;
using DbFirst;

namespace CFNewDb.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbFirst.ShoppingContext())
            {
                // Create and save a new Product 

                var apple = new DbFirst.Product { Name = "Pineapple",  Price = 1.22m, Description = "Green, yellow and tasty!", Category = 0 };
                db.Products.Add(apple);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Products
                            orderby b.Name
                            select b;

                Console.WriteLine("All products in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name+" "+item.Category+" "+item.Price+" "+item.Description);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
