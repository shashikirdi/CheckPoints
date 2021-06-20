using System;
using System.Collections.Generic;
using System.Linq;

namespace Level1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Level1.Product> catelog = new List<Level1.Product>();

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
                // Create the products using user inputs 
                var product = new Product(productName, category);
                // Add the product to catelog
                catelog.Add(product);

            }
                Console.WriteLine("*********Product Summary*************");
                Console.WriteLine("Product Name".PadRight(20) + "Category");              
                foreach (var Product in catelog)
                {
                    Console.WriteLine(Product.Name.PadRight(20)+ (Product.Category));
                }

                

            
        }
    }
}


namespace Level1
{
    public class Product
        {
          public Product(String ProductName, String ProductCategory)
        {
            Name = ProductName;
            Category = ProductCategory;
        }
            public string Name { get; set; }
            public string Category { get; set; }
        }
 }
