using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int even = 0;

            while (true)
            {
                int num = int.Parse(text);
                if (num % 2 == 0)
                {
                    even = num;
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                text = Console.ReadLine();
            }
        }
    }
}
