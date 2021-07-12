using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowInput = input[0];
            int columnsInput = input[1];

            List<int> sumOfColumns = new List<int>();

            int[,] matrix = new int[rowInput, columnsInput];

            for (int row = 0; row < rowInput; row++)
            {
                int[] columnsValue = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int columns = 0; columns < columnsInput; columns++)
                {
                    matrix[row, columns] = columnsValue[columns];
                }
            }


            int sum = 0;
            for (int col = 0; col < columnsInput; col++)
            {
                for (int row = 0; row < rowInput; row++)
                {
                    sum += matrix[row, col];
                    
                }
                sumOfColumns.Add(sum);
                sum = 0;
            }
            foreach (var item in sumOfColumns)
            {
                Console.WriteLine(item);
            }
        }
    }
}
