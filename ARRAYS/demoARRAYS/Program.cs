using System;
using System.Linq;

namespace demoARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n <= days.Length)
            {
                Console.WriteLine(days[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            

        }
    }
}
