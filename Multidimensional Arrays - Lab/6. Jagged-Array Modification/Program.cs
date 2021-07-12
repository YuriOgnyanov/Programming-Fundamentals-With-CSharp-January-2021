using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                {
                    switch (command)
                    {
                        case "Add":
                            matrix[row, col] += value;
                            break;

                        case "Subtract":
                            matrix[row, col] -= value;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r,c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
