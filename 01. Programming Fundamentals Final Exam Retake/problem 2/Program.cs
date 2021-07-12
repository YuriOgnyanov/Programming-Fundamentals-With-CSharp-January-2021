using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                string patern = @"^(U\$)([A-Z][a-z]+)\1(P\@\$)([A-Z]?[a-z]{5,}\d+)\3$";
                Regex regex = new Regex(patern);
                var match = regex.Matches(text);

                if (match.Count != 0)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match[0].Groups[2].Value}, Password: {match[0].Groups[4].Value}");
                    result.Add(match[0].Groups[0].Value);
                }
                else
                {
                    Console.WriteLine($"Invalid username or password");
                }

            }

            Console.WriteLine($"Successful registrations: {result.Count}");
        }
    }
}
