using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> colection = new Dictionary<string, List<string>>();

            int nIterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < nIterations; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!colection.ContainsKey(word))
                {
                    colection.Add(word, new List<string> { synonym });
                }
                else
                {
                    colection[word].Add(synonym);
                }
            }

            foreach (var element in colection)
            {
                Console.WriteLine($"{element.Key} - {string.Join(", ", element.Value)}");
            }
        }
    }
}
