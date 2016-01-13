using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace driving_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");
            uint age = uint.Parse(Console.ReadLine());

            if (age >= 16 && age < 18)
            {
                Console.WriteLine("You can drive! Woohoo! You're still a kid though, listen to your mom.");
            }

            else
            {
                if (age >= 18)
                {
                    Console.WriteLine("You're an adult. Do what you want.");
                }

                else
                {
                    Console.WriteLine("You're not an adult yet. And you can't drive.");
                }
            }



        }
    }
}
