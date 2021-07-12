using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double saveMoney = double.Parse(Console.ReadLine());

            List<int> drums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            List<int> currDrums = new List<int>();
            currDrums.AddRange(drums);


            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Hit it again, Gabsy!")
                {
                    break;
                }

                int power = int.Parse(line);

                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= power;
                    if (drums[i] <= 0)
                    {
                        if (saveMoney - (currDrums[i] * 3) >= 0)
                        {
                            saveMoney -= currDrums[i] * 3;
                            drums[i] = currDrums[i];
                        }
                        else
                        {
                            if (i == 0)
                            {
                                drums.Remove(drums[i]);
                                currDrums.Remove(currDrums[i]);
                                i -= 1;
                            }
                            else
                            {
                                drums.Remove(drums[i]);
                                currDrums.Remove(currDrums[i]);
                            }

                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", drums));
            Console.WriteLine($"Gabsy has {saveMoney:F2}lv.");
        }
    }
}
