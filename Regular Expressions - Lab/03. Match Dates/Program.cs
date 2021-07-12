using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataText = Console.ReadLine();

            string patern = @"(\d{2})(\.|\-|\/)([A-Z]{1}[a-z]{2})\2(\d{4})";
            Regex regex = new Regex(patern);
            var matches = regex.Matches(dataText);

            foreach (Match data in matches)
            {
                Console.WriteLine($"Day: {data.Groups[1].Value}, Month: {data.Groups[3].Value}, Year: {data.Groups[4].Value}");
            }
            
        }
    }
}
