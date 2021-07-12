using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());

                    int theBestNumber = GetTheMaxNumber(firstNumber, secondNumber);

                    Console.WriteLine(theBestNumber);
                    break;

                case "char":
                    char firstSymbol = char.Parse(Console.ReadLine());
                    char secondSymbol = char.Parse(Console.ReadLine());

                    char theBestChars = GetTheBestOfChar(firstSymbol, secondSymbol);

                    Console.WriteLine(theBestChars);
                    break;

                case "string":
                    string firstText = Console.ReadLine();
                    string secondText = Console.ReadLine();

                    string theBestString = GetTheBestOfString(firstText, secondText);

                    Console.WriteLine(theBestString);

                    break;
            }
        }

        static int GetTheMaxNumber(int firstNumber, int secondNumber)
        {
            int maxNumber = Math.Max(firstNumber, secondNumber);
            return maxNumber;
        }


        static char GetTheBestOfChar(char firstSymbol, char secondSymbol)
        {
            char theBestOfChar = (char)Math.Max(firstSymbol, secondSymbol);
            return theBestOfChar;
        }

        static string GetTheBestOfString(string firstText, string secondText)
        {
            string theBestString = string.Empty;
            firstText.CompareTo(secondText);
            if (firstText.CompareTo(secondText) >= 0)
            {
                theBestString = firstText;
            }
            else
            {
                theBestString = secondText;
            }
            return theBestString;
        }
    }
}
