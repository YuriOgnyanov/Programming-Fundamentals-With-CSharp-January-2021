using System;

namespace _03._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] specialWord = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            string symbol = "";
            
            foreach (var word in specialWord)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    symbol += "*";
                }
                if (text.Contains(word))
                {
                    text = text.Replace(word, symbol);
                }
                symbol = string.Empty;
            }
            Console.WriteLine(text);
        }
    }
}
