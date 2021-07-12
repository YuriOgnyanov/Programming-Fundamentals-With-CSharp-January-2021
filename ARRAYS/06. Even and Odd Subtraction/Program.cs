using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                var curruntNum = numbers[i];
                if (curruntNum % 2 == 0)
                {
                    evenSum += curruntNum;
                }
                else
                {
                    oddSum += curruntNum;
                }
                result = evenSum - oddSum;
            }
            Console.WriteLine(result);
        }
    }
}
