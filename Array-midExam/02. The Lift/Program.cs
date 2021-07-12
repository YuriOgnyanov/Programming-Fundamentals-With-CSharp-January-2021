using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            // reading Input 
            int tourist = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           
            int guest = 0;


            for (int j = 0; j < wagons.Length; j++)
            {
                if (wagons[j] < 4)
                {
                    guest++;
                    wagons[j] += guest;
                    tourist -= guest;
                    guest = 0;
                    j--;
                }

                if (wagons[wagons.Length - 1] == 4 && tourist == 0)
                {
                    Console.WriteLine(string.Join(" ", wagons));
                    return;
                }

                if (tourist == 0)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ", wagons));
                    return;
                }

            }

            Console.WriteLine($"There isn't enough space! {tourist} people in a queue!");
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
