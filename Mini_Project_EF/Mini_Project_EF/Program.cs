using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Project_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asset Tracking Database");
            var dbContext = new ProductDatabaseContext();

            // Add Device 
            while (true)
            {
                Console.WriteLine("Enter the type of device. Type 1: for Mobile, 2: For Laptop");
                var type = Console.ReadLine();

                Console.Write("Enter Name:");
                var name = Console.ReadLine();
                Console.Write("Enter Model:");
                var model = Console.ReadLine();
                Console.Write("Enter PurchaseDate:");
                var purchaseDate = Console.ReadLine();
                Console.Write("Enter Price:");
                var price = Console.ReadLine();
                Console.Write("Enter Office :1 For India, 2 For Sweden:");
                var office = Console.ReadLine();

                var actualPrice = GetPrice(decimal.Parse(price), office);
                if (type == "1")
                {
                    dbContext.Add(new Device { Name = name, Model = model, Price = actualPrice, Purchase_Date = DateTime.Parse(purchaseDate), Office = office, Type = "Mobile" });
                }
                else
                {
                    dbContext.Add(new Device { Name = name, Model = model, Price = actualPrice, Purchase_Date = DateTime.Parse(purchaseDate), Office = office, Type = "Laptop" });
                }

                dbContext.SaveChanges();
                Console.WriteLine("Would you like to continue, Y/n?");
                if (Console.ReadLine().ToLower() == "n".ToLower())
                {
                    break;
                }
            }

            var devices = dbContext.Devices.ToList();
            devices = devices.OrderBy(x => x.Office).ToList().OrderBy(y => y.Purchase_Date).ToList();
            foreach (var Product in devices)
            {
                var temp = Product.Purchase_Date.AddMonths(36);
                if (temp > DateTime.Now && temp <= DateTime.Now.AddMonths(6))
                {
                    if (temp > DateTime.Now && temp <= DateTime.Now.AddMonths(3))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(Product.Name.PadRight(10) + Product.Model.PadRight(15) + Product.Purchase_Date.ToString().PadRight(20) + Product.Price.ToString().PadRight(20) + Product.Office);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(Product.Name.PadRight(10) + Product.Model.PadRight(15) + Product.Purchase_Date.ToString().PadRight(20) + Product.Price.ToString().PadRight(20) + Product.Office);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                else
                {
                    Console.WriteLine(Product.Name.PadRight(10) + Product.Model.PadRight(15) + Product.Purchase_Date.ToString().PadRight(20) + Product.Price.ToString().PadRight(20) + Product.Office);
                }
            }
        }

        private static string GetPrice(decimal price, string office)
        {
            string actualPrice = "";
            switch (office)
            {
                // India
                case "1":
                    actualPrice = $"{price * 80}INR";
                    break;
                // Sweden
                case "2":
                    actualPrice = $"{price * (decimal)8.6}SEK";
                    break;
                default:
                    actualPrice = $"{price}USD";
                    break;
            }

            return actualPrice;
        }
    }
}


