using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string text = Console.ReadLine();
                    
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = text[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c] == symbol)
                    {
                        Console.WriteLine($"{(r,c)}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");

        }
    }
}
