using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

           

            if ( n1 > n2 && n1 > n3)
            {
                Console.Write($"{n1} ");

                if (n2 > n3)
                {
                    Console.Write($"{n2} ");
                    Console.Write($"{n3} ");
                    
                }
               
            }
            






























            //int[] arr = Console.ReadLine().
            //    Split(" ", StringSplitOptions.RemoveEmptyEntries).
            //    Select(int.Parse).
            //    ToArray();



            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = 0; j < arr.Length - 1; j++)
            //    {
            //        arr[j] = arr[j] + arr[j + 1];
            //    }
            //}
            //Console.WriteLine(arr[0]);


        }
    }
}
