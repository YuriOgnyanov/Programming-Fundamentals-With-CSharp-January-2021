using System;
using System.Linq;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int currNumber = array[i];
                    for (int j = 0; j < array.Length; j++)
                    {
                        int number = array[j];
                        if (input == $"swap {i} {j}")
                        {
                            currNumber = array[j];
                            number = array[i];
                            array[i] = currNumber;
                            array[j] = number;
                        }
                        else if (input == $"multiply {i} {j}")
                        {
                            array[i] = array[i] * array[j];
                        }
                    }
                }

                if (input == "decrease")
                {
                    for (int y = 0; y < array.Length; y++)
                    {
                        array[y] = array[y] - 1;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",array));
        }
    }
}
