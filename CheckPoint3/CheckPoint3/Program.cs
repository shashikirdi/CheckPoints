using System;
using System.Linq;

namespace CheckPoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the product name  and type 'exit' when its done ");
            var valueArray = new string[0];
            int index = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the product :");
                var data = Console.ReadLine();
                if (data.ToLower().Trim() == "exit")
                {
                    break;
                }
                
                var splitinput = data.Split("-");
                var valid = true;
                if(splitinput.Length != 2)
                {
                    Console.WriteLine("Invalid product name, you must not enter empty value");
                    valid = false;

                    
                }
                else
                {
                    var name = splitinput[0];
                    var id = splitinput[1];

                    int productNo = 0;
                    
                    if (!int.TryParse(id, out productNo))
                    {
                        Console.WriteLine("Invalid product name,Incorrect entry on the right part of product ");
                        valid = false;
                       
                    }

                    if (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("product name should not be  empty");
                        valid = false;
                    }

                    
                    foreach (char item in name)
                    {
                        var character = 0;
                        
                        if (int.TryParse(item.ToString(), out character))
                        {
                            Console.WriteLine("Invalid product entry,Incorrect entry on the left part of product");
                            valid = false;
                            
                        }
                    }

                    if (productNo < 200 || productNo > 500)
                    {
                        Console.WriteLine("Invalid product name,Numerical value must be between 200 and 500");
                        valid = false;

                    }
                }

                Console.WriteLine("{0} is a correct product name", data);
                Array.Resize(ref valueArray, index + 1);

                if (valid == true)
                {
                    valueArray[index] = data;
                    index++;
                }

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
