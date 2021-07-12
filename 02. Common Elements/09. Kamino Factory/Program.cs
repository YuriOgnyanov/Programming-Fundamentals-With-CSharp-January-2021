using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagon = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isValid = true;
            int currPeople = 0;

            for (int i = 0; i < wagon.Length; i++) 
            {
                for (int j = 1; j <= people; j++)  
                {
                    while (true)
                    {
                        if (people == 0 || wagon[i] == 4)
                        {
                            break;
                        }
                        else
                        {
                            currPeople++;
                            wagon[i] += j;
                        }
                        people -= currPeople;
                        currPeople = 0;
                    }
                }
            }

            if (wagon[wagon.Length - 1] == 4 && people == 0)
            {
                Console.WriteLine(string.Join(" ", wagon));
                return;

            }

            if (people == 0)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagon));
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagon));

            }
            
            
        }
    }
}
