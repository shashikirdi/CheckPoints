using System;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var Shashi = new Person();
            Shashi.FirstName = "Akshara";
            Shashi.SecondName = "Patil";
            Shashi.Introduce();

            calculate calculate = new calculate();
            var result = calculate.Add(14,14);
            Console.WriteLine(result);
        }
    }
}
