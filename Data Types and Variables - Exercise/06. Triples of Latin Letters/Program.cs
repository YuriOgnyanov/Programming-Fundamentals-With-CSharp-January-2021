using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + iterations; i++)
            {
                for (char j = 'a'; j < 'a' + iterations; j++)
                {
                    for (char k = 'a'; k < 'a' + iterations; k++)
                    {
                       
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
