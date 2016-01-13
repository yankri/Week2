using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slide_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = CheckNumber();
            int y = CheckNumber();
            int z = CheckNumber(); 

           if (x > y && x > z)
            {
                Console.WriteLine(x + " is the largest");
            }
            else
            {
                if (y > x && y > z)
                {
                    Console.WriteLine(y + " is the largest");
                }
                else
                {
                    Console.WriteLine(z + " is the largest");
                }
            }
          
                  
            


        }

        static int CheckNumber()
        {
            bool result = false;
            int x = 0;
            while (result == false)
            {
                Console.WriteLine("Please enter a number");
                string userInput = Console.ReadLine();
                result = int.TryParse(userInput, out x);
            }
            return x;
        }
    }
}
