using System;
using System.Linq;


namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isValid = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int lefttSum = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    lefttSum += arr[j];
                }
                int rightSum = 0;
                for (int k = i + 1 ; k < arr.Length; k++)
                {
                    rightSum += arr[k];

                }
                if (rightSum == lefttSum)
                {
                    Console.WriteLine(i);
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("no");
            }

        }
    }
}
