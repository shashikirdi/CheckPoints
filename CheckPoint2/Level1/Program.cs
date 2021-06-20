using System;

namespace CheckPoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the product name  and type 'exit' when its done ");
            string[] valueArray = new string[0];
            int index = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the product :");
                string data = Console.ReadLine();
                if (data.ToLower().Trim() == "exit")
                {
                    break;
                }
                Array.Resize(ref valueArray, index + 1);
                valueArray[index] = data;
                index++;
            }

            Array.Sort(valueArray);
            Console.WriteLine("Sorted");
            for (int i = 0; i < valueArray.Length; i++)
            {
                Console.WriteLine(valueArray[i]);
            }

            Console.ReadLine();
        }
    }
}