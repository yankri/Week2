using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Write a console application that asks the user for an integer. 
            If that integer is evenly divisible by 3, then write “You Won!” 
            If it isn’t, write “You Lost.” Keep asking them for a number (looping) until they win. */

            

            while (true)
            { 
                Console.WriteLine("Enter an integer");
                int userInput = int.Parse(Console.ReadLine());
            
                if (userInput % 3 == 0)
                {
                    Console.WriteLine("You Won!");
                    break;
                }

                else
                {
                    Console.WriteLine("You Lost!");
                }
            }
        }
    }
}
