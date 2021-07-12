using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> resultColection = new SortedDictionary<double, int>();

            foreach (var element in numbers)
            {
                if (!resultColection.ContainsKey(element))
                {
                    resultColection.Add(element, 1);
                }
                else
                {
                    resultColection[element]++;
                }
            }

            foreach (var printElement in resultColection)
            {
                Console.WriteLine($"{printElement.Key} -> {printElement.Value}");
            }
        }
    }
}
