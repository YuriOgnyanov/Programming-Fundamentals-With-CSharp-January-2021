using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            List<int> secondNumbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();


            List<int> result = new List<int>();




            for (int i = 0; i < Math.Min(numbers.Count, secondNumbers.Count); i++)
            {
                result.Add(numbers[i]);
                result.Add(secondNumbers[i]);

            }
            for (int i = Math.Min(numbers.Count, secondNumbers.Count); i < Math.Max(numbers.Count, secondNumbers.Count); i++)
            {
                if (numbers.Count - 1 > secondNumbers.Count - 1)
                {
                    result.Add(numbers[i]);
                }
                else
                {
                    result.Add(secondNumbers[i]);
                }
            }



            Console.WriteLine(string.Join(" ", result));

        }
    }
}
