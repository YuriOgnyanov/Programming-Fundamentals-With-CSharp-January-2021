using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < text.Length / 2; i++)
            {
                string oldSymbol = text[i];
                text[i] = text[text.Length - 1 - i];
                text[text.Length - 1 - i] = oldSymbol;

            }

            Console.WriteLine(string.Join(" ", text));



        }
    }
}
