using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                    i = i - 1;

                }

                if (numbers.Count - 1 == 0)
                {
                    Console.WriteLine("empty");
                    return;

                }
            }


            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
