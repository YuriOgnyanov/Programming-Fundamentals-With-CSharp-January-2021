using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowAndCol = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = rowAndCol[0];
            var cols = rowAndCol[1];

            var matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                var currentCol = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = currentCol[c];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            var sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
