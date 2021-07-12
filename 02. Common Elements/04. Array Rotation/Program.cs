using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            
            int rotation = int.Parse(Console.ReadLine());

            


            for (int i = 0; i < rotation; i++)
            {
                int firstElement = arr[0];
                for (int j = 1; j < arr.Length; j++) // 10   23  65  85;
                {                                    // [0] [1] [2] [3];
                    int previousItem = j - 1; // [0]
                    arr[previousItem] = arr[j]; // [1]

                }
                arr[arr.Length - 1] = firstElement;

            }


            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
