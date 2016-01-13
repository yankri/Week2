using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Please enter your age.");
             uint userAge = uint.Parse(Console.ReadLine());

             if (userAge >= 17)
                {
                  Console.WriteLine("You may see the movie!");
                }
             else 
                {
                  Console.WriteLine("Go get your parent to see the movie with you, or no dice, bro.");
                }

            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            if (name[0] == 'A' || name[0] == 'a')
            {
                Console.WriteLine("You may go to the front of the line.");
            }

            else
            {
                Console.WriteLine("Get in back.");
            }*/

            Console.WriteLine("How old are you?");
            uint age = uint.Parse(Console.ReadLine());

            Console.WriteLine("How tall are you in inches?");
            uint height = uint.Parse(Console.ReadLine());

            if (age >= 18 && height >= 60)
            {
                Console.WriteLine("You may ride the roller coaster!");
            }

            else if (age < 18 && height >= 60)
            {
                Console.WriteLine("Try again when you're older.");
            }

            else if (age >= 18 && height < 60)
            {
                Console.WriteLine("Try some Miracle Grow.");
            }

            else 
            {
                Console.WriteLine("Sorry, you don't meet the requirements to ride.");
            }
        }
    }
}
