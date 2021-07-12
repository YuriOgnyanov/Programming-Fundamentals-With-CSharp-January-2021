using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            long fourtNumber = long.Parse(Console.ReadLine());

            long result = (firstNumber + secondNumber) / thirdNumber * fourtNumber;

            Console.WriteLine(result);
        }
    }
}
