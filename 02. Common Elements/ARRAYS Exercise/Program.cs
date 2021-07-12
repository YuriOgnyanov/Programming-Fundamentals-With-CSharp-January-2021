using System;
using System.Linq;

namespace ARRAYS_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fisrtArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries); // Hey   hello   2   4;



            string[] secondArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries); // 10   hey   4   hello;


            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = fisrtArr.Length - 1; j >= 0; j--)
                {
                    if (fisrtArr[j] == secondArr[i])
                    {
                        Console.Write($"{secondArr[i]} ");
                    }
                }
            }



        }
    }
}
