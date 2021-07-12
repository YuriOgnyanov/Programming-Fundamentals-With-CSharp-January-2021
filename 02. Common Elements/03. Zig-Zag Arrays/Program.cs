using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotaiton = int.Parse(Console.ReadLine());



            int[] redArray = new int[rotaiton];

            int[] blueArray = new int[rotaiton];

           
           


            for (int i = 0; i < rotaiton; i++)
            {
                int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 != 0)
                {
                    blueArray[i] = arr[0];
                    redArray[i] = arr[1];
                }
                else
                {
                    redArray[i] = arr[0];
                    blueArray[i] = arr[1];
                }
            }
            for (int i = 0; i < redArray.Length; i++)
            {
                Console.Write($"{redArray[i]} ");
            }
            Console.WriteLine();
            for (int j = 0; j < blueArray.Length; j++)
            {
                Console.Write($"{blueArray[j]} ");
            }


        }
    }
}
