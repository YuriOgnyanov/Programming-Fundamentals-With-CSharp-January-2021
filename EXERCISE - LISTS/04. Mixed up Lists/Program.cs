using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            List<int> mixesUpTwoList = new List<int>();

            List<int> leftDigits = new List<int>();

            List<int> result = new List<int>();





            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray.Length - 1 > secondArray.Length - 1)
                {
                    mixesUpTwoList.Add(firstArray[i]);
                    mixesUpTwoList.Add(secondArray[i]);

                }
                else
                {
                    mixesUpTwoList.Add(secondArray[i]);
                    mixesUpTwoList.Add(firstArray[i]);
                }
            }

            for (int j = Math.Min(firstArray.Length, secondArray.Length); j < Math.Max(firstArray.Length, secondArray.Length); j++)
            {
                if (firstArray.Length - 1 > secondArray.Length - 1)
                {
                    leftDigits.Add(firstArray[j]);
                }
                else
                {
                    leftDigits.Add(secondArray[j]);
                }
            }

            foreach (int element in mixesUpTwoList)
            {
                if (element > Math.Min(leftDigits[1], leftDigits[0]) && element < Math.Max(leftDigits[1], leftDigits[0]))
                {
                    result.Add(element);
                }
            }
            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
