using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int bestNumbers = 0;
            int num = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                int leftNumber = arr[i];
                int counter = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNumber = arr[j];

                    if (rightNumber == leftNumber)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > bestNumbers)
                {
                    bestNumbers = counter;
                    num = leftNumber;
                }

            }

            for (int i = 0; i < bestNumbers; i++)
            {
                Console.Write($"{num} ");
            }














        }
    }
}
