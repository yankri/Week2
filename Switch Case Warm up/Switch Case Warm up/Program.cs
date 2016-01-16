using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Warm_up
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a positive integer, find the sum of its constituent digits.
            string line = Console.ReadLine();
            int num = int.Parse(line);

            int total = 0;

            foreach (int i in num)
            {
                total += num[i];
            }

            Console.WriteLine(total);
        }
    }
}
