using System;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int midOfArray = (numbers.Length - 1) / 2;

            double leftCar = 0;

            for (int i = 0; i < midOfArray; i++)
            {
                if (numbers[i] != 0)
                {
                    leftCar += numbers[i];
                }
                else
                {
                    leftCar = leftCar - leftCar * 0.20;
                }
            }

            double rightCar = 0;

            for (int j = numbers.Length - 1; j > midOfArray; j--)
            {
                if (numbers[j] != 0)
                {
                    rightCar += numbers[j];
                }
                else
                {
                    rightCar = rightCar - rightCar * 0.20;
                }
            }

            if (leftCar < rightCar)
            {
                Console.WriteLine($"The winner is left with total time: {leftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightCar}");
            }
        }
    }
}
