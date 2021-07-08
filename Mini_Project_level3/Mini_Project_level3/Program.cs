using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Project_level3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asset Tracking Database");
            List<Device> asset3 = new List<Device>();

            asset3.Add(new Laptop_Computers("macbook", "1001", DateTime.Parse("2019-01-01"), 2000, "India"));
            asset3.Add(new Laptop_Computers("asus", "1002", DateTime.Parse("2018-10-27"), 1500, "Sweden"));
            asset3.Add(new Laptop_Computers("lenovo", "1003", DateTime.Parse("2019-09-01"), 1200, "Sweden"));

            asset3.Add(new Mobiles("Iphone", "12 pro", DateTime.Parse("2020-01-01"), 2000, "India"));
            asset3.Add(new Mobiles("samsung", "galaxy s21", DateTime.Parse("2018-08-27"), 2000, "Sweden"));
            asset3.Add(new Mobiles("nokia", "5.8 4G", DateTime.Parse("2019-09-14"), 2000, "Sweden"));

            asset3 = asset3.OrderBy(x => x.Office).ToList().OrderBy(y => y.Office).ToList();
            foreach (var Product in asset3)
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
    }
}

namespace Mini_Project_level3
{
    public class Laptop_Computers : Device
    {
        public Laptop_Computers(string name, string model, DateTime purchase_date, int price, string office)
            : base(name, model, purchase_date, price, office)
        {
            device_type = "Laptop";

        }
        public string device_type { get; set; }
    }

}

public class Mobiles : Device
{
    public Mobiles(string name, string model, DateTime purchase_date, int price, string office)
        : base(name, model, purchase_date, price, office)
    {
        device_type = "mobile";

    }
    public string device_type { get; set; }

}

public class Device
{
    public Device(string name, string model, DateTime purchase_date, int price, string office)
    {
        Name = name;
        Model = model;
        Purchase_Date = purchase_date;
        Price = price;
        Office = office;
    }
    public string Name { get; set; }
    public string Model { get; set; }
    public DateTime Purchase_Date { get; set; }
    public int Price { get; set; }
    public string Office { get; set; }

    internal static object OrderBy(Func<object, object> p)
    {
        throw new NotImplementedException();
    }
}