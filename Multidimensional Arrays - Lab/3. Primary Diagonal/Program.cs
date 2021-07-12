using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                int[] numbersForMatrix = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = numbersForMatrix[c];
                }
            }

            int sum = 0;
            int counter = 0;
            for (int c = 0; c < n; c++)
            {
                
                for (int r = counter; r < n; r++)
                {
                    sum += matrix[r, c];
                    break;
                }
                counter++;
            }

            Console.WriteLine(sum);

        }
    }
}
