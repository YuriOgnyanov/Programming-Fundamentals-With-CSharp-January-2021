using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            

            int numbersforEqual = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    firstNumber += numbers[j];
                    if (firstNumber == numbersforEqual)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}") ;
                    }
                    firstNumber -= numbers[j];
                }
            }
        }
    }
}
