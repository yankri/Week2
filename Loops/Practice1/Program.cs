using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.
            Console.WriteLine("Enter a number");

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i<= x; i++)
            {
                for (int n = 1; n<= x; n++)
                {
                    Console.Write((n * i) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
