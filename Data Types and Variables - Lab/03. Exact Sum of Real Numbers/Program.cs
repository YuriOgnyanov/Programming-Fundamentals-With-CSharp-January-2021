using System;
using System.Numerics;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal sumOfDigits = 0M;

            for (int i = 0; i < numbers; i++)
            {
                decimal currNumber = decimal.Parse(Console.ReadLine());

                sumOfDigits += currNumber;

            }
            Console.WriteLine(sumOfDigits);
        }
    }
}
