using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read and Print elements of an array:");

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Input 10 elements in the array:");

            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"element - {i} :");
            }
            int firstNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                firstNumber = numbers[i] + 2;
                numbers[i] += firstNumber + 2;

                

                Console.WriteLine(numbers[i]);

            }
        }
    }
}
