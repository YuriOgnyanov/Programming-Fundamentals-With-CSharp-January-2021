using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string patern = @"(=|\/)([A-Z]{1}[A-Za-z]{2,})\1";

            Regex regex = new Regex(patern);

            var matches = regex.Matches(text);
           
            var towns = matches
                .Select(v => v.Groups[2].Value);

            int points = towns.Select(v => v.Length)
                .Sum();

            Console.WriteLine($"Destinations: {string.Join(", ", towns)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
