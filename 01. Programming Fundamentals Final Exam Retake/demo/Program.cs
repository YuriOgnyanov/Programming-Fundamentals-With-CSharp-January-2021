using System;
using System.Linq;


namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string line = Console.ReadLine();
            while (line != "Sign up ")
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
                            input = input.ToLower();
                        }
                        else if (lowerOrUpper == "upper")
                        {
                            input = input.ToUpper();
                        }
                        Console.WriteLine(input);
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(partsOfLine[1]);
                        int endIndex = int.Parse(partsOfLine[2]);
                        string reversedSubString = string.Empty;
                        if ((startIndex >= 0 && startIndex <= input.Length) && (endIndex >= 0 && endIndex <= input.Length))
                        {
                            string substring = input.Substring(startIndex, endIndex);

                            for (int i = substring.Length - 1; i >= 0; i--)
                            {
                                reversedSubString += substring[i];
                            }
                            Console.WriteLine(reversedSubString);
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
                        char symbol = char.Parse(partsOfLine[1]);
                        input = input.Replace(symbol, '*');
                        Console.WriteLine(input);
                        break;

                    case "Check":
                        char chekSymbol = char.Parse(partsOfLine[1]);
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
