using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int sumOfCharacters = 0;
            

            for (int i = 0; i < nLines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sumOfCharacters += symbol;
            }
            Console.WriteLine($"The sum equals: {sumOfCharacters}");
        }
    }
}
