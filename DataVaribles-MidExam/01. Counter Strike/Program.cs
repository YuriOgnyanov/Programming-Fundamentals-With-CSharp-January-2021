using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int winsBattle = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End of battle")
                {
                    Console.WriteLine($"Won battles: {winsBattle}. Energy left: {energy}");
                    break;
                }
                int distance = int.Parse(line);
                if (energy >= distance)
                {
                    energy -= distance;
                    winsBattle++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winsBattle} won battles and {energy} energy");
                    break;
                }
                 
                if (winsBattle % 3 == 0)
                {
                    energy += winsBattle;
                }
            } 
        }
    }
}
