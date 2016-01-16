using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints on the console the numbers 
            //from 1 to n (get from user) which are NOT divisible by 3 and 7 simultaneously. 

            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++) 
            {
                if (i % 7 == 0 && i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
