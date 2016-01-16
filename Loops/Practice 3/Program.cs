using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints a matrix of numbers:
            // 1 2 3 4
            // 2 3 4 5
            // 3 4 5 6
            // 4 5 6 7
            
            for (int n = 0; n<= 3; n++)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.Write((i+ n) + " ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
