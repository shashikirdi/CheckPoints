using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Project_level2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asset Tracking Database");
            List<Laptop_Computers> asset1 = new List<Laptop_Computers>();
            List<Mobiles> asset2 = new List<Mobiles>();
            List<Device> asset3 = new List<Device>();

            asset1.Add(new Laptop_Computers("macbook", "1001", DateTime.Parse("2019-01-01"), 2000));
            asset1.Add(new Laptop_Computers("asus", "1002", DateTime.Parse("2018-07-27"), 1500));
            asset1.Add(new Laptop_Computers("lenovo", "1003", DateTime.Parse("2019-09-01"), 1200));

            asset2.Add(new Mobiles("Iphone", "12 pro", DateTime.Parse("2020-01-01"), 2000));
            asset2.Add(new Mobiles("samsung", "galaxy s21", DateTime.Parse("2018-08-27"), 2000));
            asset2.Add(new Mobiles("nokia", "5.8 4G", DateTime.Parse("2019-09-14"), 2000));

            asset1.Sort((x, y) => x.Purchase_Date < y.Purchase_Date ? 0 : 1);
            foreach (var Product in asset1)
            {
                var temp = Product.Purchase_Date.AddMonths(36);
                if (temp > DateTime.Now && temp <= DateTime.Now.AddMonths(3))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(Product.Name.PadRight(10) + Product.Model.PadRight(15) + Product.Purchase_Date.ToString().PadRight(20) + Product.Price);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.WriteLine(Product.Name.PadRight(10) + Product.Model.PadRight(15) + Product.Purchase_Date.ToString().PadRight(20) + Product.Price);
                }
            }

            asset2.Sort((x, y) => x.Purchase_Date < y.Purchase_Date ? 0 : 1);
            foreach (var Product in asset2)
            {
                var temp = Product.Purchase_Date.AddMonths(36);
                if (temp > DateTime.Now && temp <= DateTime.Now.AddMonths(3))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(Product.Name.PadRight(10) + Product.Model.PadRight(15) + Product.Purchase_Date.ToString().PadRight(20) + Product.Price);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.WriteLine(Product.Name.PadRight(10) + Product.Model.PadRight(15) + Product.Purchase_Date.ToString().PadRight(20) + Product.Price);
                }
            }

        }
    }
}

namespace Mini_Project_level2
{
    public class Laptop_Computers : Device
    {
        public Laptop_Computers(string name, string model, DateTime purchase_date, int price)
            : base(name, model, purchase_date, price)
        {
            device_type = "Laptop";

        }
        public string device_type { get; set; }
    }

}

public class Mobiles : Device
{
    public Mobiles(string name, string model, DateTime purchase_date, int price)
        : base(name, model, purchase_date, price)
    {
        device_type = "mobile";

    }
    public string device_type { get; set; }

}

public class Device
{
    public Device(string name, string model, DateTime purchase_date, int price)
    {
        Name = name;
        Model = model;
        Purchase_Date = purchase_date;
        Price = price;
    }
    public string Name { get; set; }
    public string Model { get; set; }
    public DateTime Purchase_Date { get; set; }
    public int Price { get; set; }

    internal static object OrderBy(Func<object, object> p)
    {
        throw new NotImplementedException();
    }
}