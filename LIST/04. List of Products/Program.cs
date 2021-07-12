using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 4


            List<string> products = new List<string>(); // 0


            for (int i = 0; i < n; i++)     // 0 - 4
            {
                string currProduct = Console.ReadLine();
                products.Add(currProduct);

            }
            products.Sort();
            Console.WriteLine();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
