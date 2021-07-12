using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> resultColention = new Dictionary<string, int>();

            foreach (var element in words)
            {
                string toLowerElement = element.ToLower();
                if (!resultColention.ContainsKey(toLowerElement))
                {
                    resultColention.Add(toLowerElement, 1);
                }
                else
                {
                    resultColention[toLowerElement]++;
                }
            }

            foreach (var cvp in resultColention)
            {
                if (cvp.Value % 2 != 0)
                {
                    Console.Write($"{cvp.Key} ");
                }
            }


        }
    }
}
