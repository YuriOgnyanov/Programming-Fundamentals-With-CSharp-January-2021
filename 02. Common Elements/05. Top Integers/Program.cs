﻿using System;
using System.Linq;
namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            

            for (int i = 0; i < arr.Length; i++)
            {
                int leftNumber = arr[i];
                bool isValid = true;


                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNumber = arr[j];
                    if (rightNumber > leftNumber)
                    {
                        isValid = false;
                        break;
                    }
                    
                }
                if (isValid)
                {
                    Console.Write($"{leftNumber} ");
                }

            }
            



        }
    }
}
