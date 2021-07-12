using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var list = new List<string>();

            foreach (var word in input)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    list.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", list.OrderBy(a => a).Distinct()));
        }
    }
}
