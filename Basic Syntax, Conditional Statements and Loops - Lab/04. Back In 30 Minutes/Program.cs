using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int mm = minutes + 30;

            if (mm > 59)
            {
                hours++;
                mm -= 60;

            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (mm <= 9)
            {
                Console.WriteLine($"{hours}:0{mm}");

            }
            else
            {
                Console.WriteLine($"{hours}:{mm}");

            }
        }
    }
}
