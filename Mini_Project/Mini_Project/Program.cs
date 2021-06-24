using System;
using System.Collections.Generic;

namespace Mini_Project_level1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asset Tracking Database");
            List<Laptop_Computers> asset1 = new List<Laptop_Computers>();
            List<Mobiles> asset2 = new List<Mobiles>();

            asset1.Add(new Laptop_Computers("macbook", "1001", "2017-01-01", 2000));
            asset1.Add(new Laptop_Computers("asus", "1002", "2021-07-01", 1500));
            asset1.Add(new Laptop_Computers("lenovo", "1003", "2019-09-01", 1200));

            asset2.Add(new Mobiles("Iphone", "12 pro", "2020-01-01", 2000));
            asset2.Add(new Mobiles("samsung", "galaxy s21", "2019-04-19", 2000));
            asset2.Add(new Mobiles("nokia", "5.8 4G", "2016-09-14", 2000));
            foreach (var Product in asset1)
            {
                Console.WriteLine(Product.Name.PadRight(10) + Product.Model.PadRight(15) + Product.Purchase_Date.PadRight(20) + Product.Price);
            }

            foreach (var Product in asset2)
            {
                Console.WriteLine(Product.Name.PadRight(10) + Product.Model.PadRight(15) + Product.Purchase_Date.PadRight(20) + Product.Price);
            }

        }
    }
}

namespace Mini_Project_level1
{
    public class Laptop_Computers : Device
    {
        public Laptop_Computers(string name, string model, string purchase_date, int price)
            : base(name, model, purchase_date, price)
        {
            device_type = "Laptop";

        }
        public string device_type { get; set; }
    }

    }

    public class Mobiles : Device
    {
    public Mobiles(string name, string model, string purchase_date, int price)
        : base(name,model,purchase_date,price)
    {
        device_type = "mobile";
     
    }
    public string device_type { get; set; }

}

    public class Device
    {
    public Device(string name, string model, string purchase_date, int price)
    {
        Name = name;
        Model = model;
        Purchase_Date = purchase_date;
        Price = price;
    }
    public string Name { get; set; }
    public string Model { get; set; }
    public string Purchase_Date { get; set; }
    public int Price { get; set; }
    
    }


