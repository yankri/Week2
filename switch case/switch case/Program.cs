using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 0 and 3.");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;

                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");
                    break;

                case 3:
                    Console.WriteLine("three");
                    break;

                default:
                    Console.WriteLine("did you enter a number between 0 and 3");
                    break;
            }
        }
    }
}
