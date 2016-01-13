using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpa_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that calculates a student’s GPA on a 4.0 scale. Take user input.

            Console.WriteLine("Welcome to GPA calculator! This is a 4.0 system.");
            Console.WriteLine();
            Console.WriteLine("Please enter the subject and grade. Type 'done' when you have finished entering grades.");
            Console.WriteLine();
            List<string> inputSubject = new List<string>();
            List<double> inputGrade = new List<double>();

            while (true)
            {
                Console.WriteLine("Enter the subject:");
                string userInput = Console.ReadLine();

                if (userInput == "done")
                {
                    break;
                }

                inputSubject.Add(userInput);

                Console.WriteLine("Enter the percentage you earned: ");
                double userInput2 = double.Parse(Console.ReadLine());
                inputGrade.Add(userInput2);
            }

            Console.WriteLine();

            string[] subjects = inputSubject.ToArray();
            double[] grades = inputGrade.ToArray();

            for (int i = 0; i < subjects.Length ; i++)
            {
                Console.WriteLine(subjects[i]);
                Console.WriteLine(grades[i]);
                Console.WriteLine();
            }

            Console.WriteLine();

            double total = 0;

            foreach (double num in grades)
            {
                total += num;
            }

            Console.WriteLine();

            double gpa = total / grades.Length;

            if (gpa >= 90)
            {
                Console.WriteLine("Your GPA is 4.0.");
            }
            else if (gpa >= 80 && gpa <=89)
            {
                Console.WriteLine("Your GPA is 3.0.");
            }
            else if (gpa >= 70 && gpa <= 79)
            {
                Console.WriteLine("Your GPA is 2.0");
            }
            else if (gpa>= 60 && gpa <=69)
            {
                Console.WriteLine("Your GPA is 1.0");
            }
            else
            {
                Console.WriteLine("I hope you have something good to tell your parents... Your GPA is 0.0");
            }

        }
    }
}
