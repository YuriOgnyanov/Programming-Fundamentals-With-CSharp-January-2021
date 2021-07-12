using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            SignGrades(num);
        }

        static void SignGrades(double grades)
        {
            string input = string.Empty;

            if (grades >= 2.00 && grades <= 2.99)
            {
                input = "Fail";
            }
            else if (grades <= 3.49)
            {
                input = "Poor";
            }
            else if (grades <= 4.49)
            {
                input = "Good";
            }
            else if (grades <= 5.49)
            {
                input = "Very good";
            }
            else if (grades <= 6.00)
            {
                input = "Excellent";
            }

            Console.WriteLine($"{input}");
        }
    }
}
