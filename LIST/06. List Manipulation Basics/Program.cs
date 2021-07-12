using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {

                List<string> cmArgs = input
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .ToList();


                switch (cmArgs[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(cmArgs[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(cmArgs[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(cmArgs[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(cmArgs[2]), int.Parse(cmArgs[1]));
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
