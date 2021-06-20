using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_List_Class_Linq_20210615
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cars!");
            List<Car> cars = new List<Car>();

            Car car1 = new Car("Volvo", "245 GLT", 1982, 185);
            cars.Add(car1);

            cars.Add(new Car("Saab", "900 T", 1980, 195));

            List<Car> extraCars = new List<Car>
            {
                new Car("Saab", "900", 1981, 175),
                new Car("Volvo", "245 GLT", 1982, 185)
            };
            cars.AddRange(extraCars);

            cars.AddRange(new List<Car>
            {
                new Car("Opel", "Ascona", 1981, 170),
                new Car("Volvo", "244 GL", 1979, 180)
            });

            Console.WriteLine("My cars");
            Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Speed");
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Brand.PadRight(10) + car.Model.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
            }

            List<Car> sortedCars = cars.OrderBy(car => car.Brand).ThenBy(car => car.Speed).ToList();
            Console.WriteLine("My cars - Sorted");
            Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Speed");
            foreach (Car car in sortedCars)
            {
                Console.WriteLine(car.Brand.PadRight(10) + car.Model.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
            }

            List<Car> sortedDescCars = cars.OrderByDescending(car => car.Speed).ToList();
            Car fastestCar = sortedDescCars.FirstOrDefault();

            int highestSpeed = cars.Max(car => car.Speed);
            double averageSpeed = cars.Average(car => car.Speed);
            int countVolvos = cars.Where(car => car.Brand.Contains("Volvo")).Count();

            Console.WriteLine("Find the fastest car");
            Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Year".PadRight(10) + "Speed");
            Console.WriteLine(fastestCar.Brand.PadRight(10) + fastestCar.Model.PadRight(10) + fastestCar.Year.ToString().PadRight(10) + fastestCar.Speed);
            Console.ReadLine();
        }
    }

    class Car
    {
        public Car(string brand, string model, int year, int speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Speed = speed;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }
    }
}
