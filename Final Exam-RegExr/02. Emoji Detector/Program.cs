using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {  
            // Regex And Match
            string text = Console.ReadLine();
            string petern = @"(\:{2}|\*{2})([A-Z][a-z]{2,})\1";
            Regex regex = new Regex(petern);
            var matches = regex.Matches(text);

            // matches is digits
            Regex digit = new Regex(@"(\d)");
            var digitsMatches = digit.Matches(text);

            // sum of all number in the text
            int coolThreshold = 1;
            foreach (Match match in digitsMatches)
            {
                coolThreshold *= int.Parse(match.Value);
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");

            // matches is AnimalWords
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match word in matches)
            {
                int sumOfLetters = 0;
                foreach (char leters in word.Groups[0].Value)
                {
                    if (leters != ':' && leters != '*')
                    {
                        sumOfLetters += leters;
                    }
                }

                if (sumOfLetters > coolThreshold)
                {
                    Console.WriteLine(word.Value);
                }
            } 
        }
    }
}
