using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];





            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());

                arr[i] = curr;

                sum += curr;
            }
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine(sum);
        }
    }
}
