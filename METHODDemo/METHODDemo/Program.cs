using System;

namespace METHODDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SingInteger(num);
            
        }

        static void SingInteger(int number)
        {
            string result = string.Empty;
            if (number > 0)
            {
                result = "positive";
            }
            else if (number < 0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }

            Console.WriteLine($"The number {number} is {result}.");
        }

    }
}
