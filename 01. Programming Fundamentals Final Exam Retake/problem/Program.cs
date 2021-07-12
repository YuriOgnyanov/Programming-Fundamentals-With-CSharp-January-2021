using System;
using System.Linq;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string line = Console.ReadLine();
            while (line != "Sign up")
            {
                string[] partsOfLine = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = partsOfLine[0];


                switch (command)
                {
                    case "Case":
                        string lowerOrUpper = partsOfLine[1];
                        if (lowerOrUpper == "lower")
                        {
                            input = input.Replace(input, input.ToLower());
                            Console.WriteLine(input);
                        }
                        else if(lowerOrUpper == "upper")
                        {
                            input = input.Replace(input, input.ToUpper());
                            Console.WriteLine(input);
                        }
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(partsOfLine[1]);
                        int endIndex = int.Parse(partsOfLine[2]);

                        if (startIndex >= 0 && startIndex <= input.Length && endIndex >= 0 && endIndex <= input.Length)
                        {
                            string substring = input.Substring(startIndex, endIndex);
                            string reversed = substring.Reverse().ToString();
                            
                            Console.WriteLine(reversed.ToCharArray());
                        }
                        break;

                    case "Cut":
                        string cutSubString = partsOfLine[1];
                        if (input.Contains(cutSubString))
                        {
                            input = input.Remove(input.IndexOf(cutSubString), cutSubString.Length);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine($"The word {input} doesn't contain {cutSubString}.");
                        }
                        break;

                    case "Replace":
                        string symbol = partsOfLine[1];
                        if (input.Contains(symbol))
                        {
                            input = input.Replace(symbol, "*");
                            Console.WriteLine(input);
                        }
                        break;

                    case "Check":
                        string chekSymbol = partsOfLine[1];
                        if (input.Contains(chekSymbol))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {chekSymbol}.");
                        }
                        break;
                }

                line = Console.ReadLine();

            }


        }
    }
}
