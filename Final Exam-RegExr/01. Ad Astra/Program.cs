using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patern = @"(\#|\|)([A-Za-z]+\s?[A-za-z]+?)\1(\w{2}\/\w{2}\/\w{2})\1(\w{1,5})\1";
            Regex regex = new Regex(patern);
            var match = regex.Matches(text);
            var arr = match
                .Select(v => v.Groups[4].Value)
                .Select(int.Parse)
                .Sum();
            int days = arr / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match info in match)
            {
                Console.WriteLine($"Item: {info.Groups[2]}, Best before: {info.Groups[3]}, Nutrition: {info.Groups[4]}");
            }
        }
    }
}
