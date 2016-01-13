using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your score between 1 and 9");
            string userInput = Console.ReadLine();
            uint score;
            bool result = uint.TryParse(userInput, out score);

            
            if (result == false)
            {
                Console.WriteLine("You didn't enter a number.");
            }
            else
            {
                if (score >= 1 && score <= 3)
                {
                    uint bonus = 10;
                    uint totalScore = score * bonus;
                    Console.WriteLine("Your score was: " + score);
                    Console.WriteLine("Your bonus was: " + bonus);
                    Console.WriteLine("Your total score was " + totalScore);
                }
                else if (score >= 4 && score <= 6)
                {
                    uint bonus = 100;
                    uint totalScore = score * bonus;
                    Console.WriteLine("Your score was: " + score);
                    Console.WriteLine("Your bonus was: " + bonus);
                    Console.WriteLine("Your total score was " + totalScore);
                }
                else if (score >= 7 && score <= 9)
                {
                    uint bonus = 1000;
                    uint totalScore = score * bonus;
                    Console.WriteLine("Your score was: " + score);
                    Console.WriteLine("Your bonus was: " + bonus);
                    Console.WriteLine("Your total score was " + totalScore);
                }
                else
                {
                    Console.WriteLine("Error. Please enter a score between 1 and 9.");
                }
            }
            

            
        }

    }
}
