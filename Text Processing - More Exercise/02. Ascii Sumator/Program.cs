using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            int sum = 0;
            string text = Console.ReadLine();


            foreach (char symbol in text)
            {
                if (symbol > firstSymbol && symbol < secondSymbol)
                {
                    sum += symbol;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
