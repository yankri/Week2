using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("stuff");
            }

            if (y > x)
            {
                Console.WriteLine("y");
            }
             else
            {
                Console.WriteLine("more stuff");
            }   

            if (x == y)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("x");
            }

            if (y == x && x> 3)
            {
                Console.WriteLine("frosted flakes");
            }
            else if (x > 5 && y == 3)
            {
                Console.WriteLine("Fruit loops");
            }
            else if (y > 4 || x ==5 )
            {
                Console.WriteLine("honeycomb");
            }
            else
            {
                Console.WriteLine("raisin bran");
            }

            if (x + 3 > 5)
            {
                Console.WriteLine("stufffff");

            }
            else
            {
                Console.WriteLine("monkeys");
            }

            if (x == false)
            {
                Console.WriteLine("false");
            }
            else
            {
                if (y == false)
                {
                    Console.WriteLine(y);
                }
                else
                {
                    Console.WriteLine("true");
                }
            }

            if (x == y || y == 4)
            {
                Console.WriteLine("grumpy");
            }
            else
            {
                if (y == 56)
                {
                    Console.WriteLine("happy");
                }
                else
                {
                    Console.WriteLine("meh");
                }
            }

            if (y > x + y)
            {
                Console.WriteLine("you choose stupid numbers");
            }
            else if (x > y + x)
            {
                Console.WriteLine("who is choosing this crap");
            }
            else if (y > x)
            {
                Console.WriteLine("pick better stuff ");
            }
            else
            {
                Console.WriteLine(y);
            }

            if ( x == 4 && y == 5)
            {
                Console.WriteLine("cheeseburgers");
            }
            else
            {
                Console.WriteLine("chicken nuggets");
            }

            if (x == 4)
            {
                Console.WriteLine("ketchup");
            }
            else if (y == 5)
            {
                Console.WriteLine("mustard");
            }
            else
            {
                Console.WriteLine("mayo");
            }
        }
    }
}
