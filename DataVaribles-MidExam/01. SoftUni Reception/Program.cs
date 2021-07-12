using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstGuest = int.Parse(Console.ReadLine());
            int secondGuest = int.Parse(Console.ReadLine());
            int thirdGuest = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int answer = firstGuest + secondGuest + thirdGuest;

            int hour = 0;

            while (students > 0)
            {
                hour++;
                if (hour % 4 == 0)
                {
                    continue;
                }
                else
                {
                    students -= answer;
                }
            }

            Console.WriteLine($"Time needed: {hour}h.");

        }
    }
}
