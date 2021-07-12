using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string patern = @"(\@|\#)([A-Za-z]{3,})\1{2,}([A-Za-z]{3,})\1";

            Dictionary<string, string> wordAndReversedWord = new Dictionary<string, string>();
            List<string> result = new List<string>();


            Regex regex = new Regex(patern);
            var matches = regex.Matches(text);
            ;
            if (matches.Count != 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                foreach (Match item in matches)
                {
                    string reverse = string.Empty;
                    for (int i = item.Groups[2].Value.Length - 1; i >= 0; i--)
                    {
                        reverse += item.Groups[2].Value[i];
                    }
                    if (reverse == item.Groups[3].Value)
                    {
                        wordAndReversedWord.Add(item.Groups[2].Value, item.Groups[3].Value);
                    }
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            
            
            if (wordAndReversedWord.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                Console.WriteLine("The mirror words are:");
                foreach (var words in wordAndReversedWord)
                {
                    sb.Append(words.Key);
                    sb.Append(" <=> ");
                    sb.Append(words.Value);
                    result.Add(sb.ToString());
                    sb.Clear();
                    
                }
                Console.WriteLine(string.Join(", ", result));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
