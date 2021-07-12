using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+");

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                var match = regex.Match(text);
                
                if (match.Success)
                {
                    string barCode = match.Groups[0].Value;
                    Regex digit = new Regex(@"\d");
                    var digitMatch = digit.Matches(barCode);

                    if (digitMatch.Count != 0)
                    {
                        string digits = string.Empty;
                        for (int d = 0; d < digitMatch.Count; d++)
                        {
                            digits += digitMatch[d].Value;
                        }
                        Console.WriteLine($"Product group: {digits}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {"00"}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

        }
    }
}
