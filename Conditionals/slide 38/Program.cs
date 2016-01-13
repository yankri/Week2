using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slide_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to evaluate.");
            string userInput = Console.ReadLine();
            int num;
            bool result = int.TryParse(userInput, out num);

            if (result == false)
            {
                Console.WriteLine("Please enter a number.");
            }
            else
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
