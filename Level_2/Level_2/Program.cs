using System;
using System.Collections.Generic;
using System.Linq;

namespace Level_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Level_2.Product> catelog = new List<Level_2.Product>();

            while (true)
            {
                Console.WriteLine("Enter the product infromation, press q to exit ");
                //Read user inputs
                Console.WriteLine("Enter the product name:");
                var userInput = Console.ReadLine();
                if (userInput.ToLower().Trim() == "q")
                {
                    break;
                }

                var productName = userInput;
                Console.WriteLine("Enter the product category;");
                userInput = Console.ReadLine();
                if (userInput.ToLower().Trim() == "q")
                {
                    break;
                }
                var category = userInput;
                Console.WriteLine("Enter the price of product:");
                userInput = Console.ReadLine();
                if(userInput.ToLower().Trim() == "q")
                {
                    break;
                }
                var price = int.Parse(userInput);
                // Create the products using user inputs 
                var product = new Product(productName, category, price);
                // Add the product to catelog
                catelog.Add(product);

            }
            Console.WriteLine("*********Product Summary*************");
            Console.WriteLine("Product Name".PadRight(20) + "Category".PadRight(20) + "Price");
            foreach (var Product in catelog)
            {
                Console.WriteLine(Product.Name.PadRight(20) + (Product.Category.PadRight(20) + (Product.Price)));
            }

            Console.WriteLine("*********Sorted Product List*************");

            var sortedCatelog = catelog.OrderBy(x => x.Price);
            Console.WriteLine("Product Name".PadRight(20) + "Category".PadRight(20) + "Price");
            foreach (var product in sortedCatelog) 
            {
                Console.WriteLine(product.Name.PadRight(20) + product.Category.PadRight(20) + product.Price);
            }

           //Calculate Total price
            var sum = 0;
            foreach (var Product in catelog)
            {
                sum = sum + Product.Price;
            }

            Console.WriteLine($"Total price:{sum}");



        }
    }
}


namespace Level_2
{
    public class Product
    {
        public Product(String ProductName, String ProductCategory, int ProductPrice)
        {
            Name = ProductName;
            Category = ProductCategory;
            Price = ProductPrice;
        }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
}
