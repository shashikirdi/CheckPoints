using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car("Volvo", "224 TT", 190, 1986);
            car.NumberOfWheels  = 4;
            Car car2 = new Car("BMW", "w series", 220, 2019, 4);
            Console.ReadLine();

        }
    }
    class Car : Vehicle
    {
        public Car(string brand, string model, int speed, int year)
        {
         Brand = brand;
         Model = model;
         Speed = speed;
         Year  = year;
        }
        public Car(string brand, string model, int speed, int year, int numberofwheels)
        {
          Brand = brand;
          Model = model;
          Speed = speed;
          Year = year;
          NumberOfWheels = numberofwheels;
        }
    }
    
    class Vehicle : Wheels
    {
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Speed { get; set; }
    public int Year { get; set; }

    }

class Motercycle : Vehicle
{
    public  Motercycle (string brand, string model, int speed, int year)
        {

        Brand = brand;
        Model = model;
        Speed = speed;
        Year = year;

        }
}

class Wheels
{
    public int NumberOfWheels { get; set; }
}

}
