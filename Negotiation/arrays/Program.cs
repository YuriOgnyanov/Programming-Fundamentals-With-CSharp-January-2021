using System;
using System.Linq;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEvenNumbers = numbers
                .Where(x => x % 2 == 0)
                .Sum();
                
            Console.WriteLine(sumEvenNumbers);
        }
    }
}
