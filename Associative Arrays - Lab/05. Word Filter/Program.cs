using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
