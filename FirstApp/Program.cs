using System;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please write something below");
                var query = Console.ReadLine();
                var option = InputChecker(query);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Hi!");
                        break;
                    case 2:
                        Console.WriteLine("I am not a calculator mate");
                        break;
                    case 3:
                        Console.WriteLine(DateTime.Now.ToShortDateString());
                        break;
                }
                Console.WriteLine("Press any key to continue or escape to quit");
                
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static int InputChecker(string input)
        {

            if (input.Any(char.IsDigit)) return 2;
            else if (input == "Date") return 3;
            else return 1;
        }
    }
}
