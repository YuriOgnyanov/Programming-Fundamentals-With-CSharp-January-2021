using System;
using System.Text;

namespace _01._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder reversedText = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText.Append(text[i]);
            }

            Console.WriteLine(reversedText);
        }
    }
}
