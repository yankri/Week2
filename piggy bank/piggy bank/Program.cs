using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggy_bank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program for a piggy bank counter.
                Ask the user for the number of pennies, nickels, dimes, quarters, 
                    half dollars, and gold dollars.
                    Print the total amount of money in the piggy bank.
           Bonus: If the piggy bank holds $20.00 or more, tell the user 
           how many $20 bills they can exchange their coins for. */

            Console.WriteLine("Welcome to Piggy Bank Counter!");
            Console.WriteLine();
            Console.WriteLine("Enter the number of pennies: ");
            uint pennies = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of nickels: ");
            uint nickels = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of dimes: ");
            uint dimes = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of quarters: ");
            uint quarters = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of half dollars: ");
            uint halfDollar = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of dollar coins: ");
            uint dollarCoin = uint.Parse(Console.ReadLine());

            Console.WriteLine("Do you have any paper money? If so, type yes. Otherwise, hit enter.");
            string query = Console.ReadLine();

            uint paperMoney = 0;

            if (query == "yes")
            {
                Console.WriteLine("Enter the total amount of paper money in dollars: ");
                paperMoney = uint.Parse(Console.ReadLine());
            }

            double total = (pennies/100) + (nickels/20) + (dimes/10) + (quarters/4) + (halfDollar/2) + dollarCoin + paperMoney;
            Console.WriteLine("The total amount of money in your piggy bank is $" + total);

            if (total > 20)
            {
                uint jacksons = (uint)total / 20;
                Console.WriteLine("You could exchange your piggy bank change for " + jacksons + " $20 bills.");
            }

            if (paperMoney == 0)
            {
                Console.WriteLine("Better start rolling change!");
            }
        }
    }
}
