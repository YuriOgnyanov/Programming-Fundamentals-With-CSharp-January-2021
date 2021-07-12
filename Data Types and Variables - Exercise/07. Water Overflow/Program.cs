using System;

namespace _07._Water_Overflow
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int sumOfLiters = 0;
            for (int i = 0; i < n; i++)
            {
                int quantites = int.Parse(Console.ReadLine());
                sumOfLiters += quantites;
                
                if (sumOfLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumOfLiters -= quantites;
                }
            }
            if (sumOfLiters <= 255)
            {
                Console.WriteLine(sumOfLiters);
            }





        }
    }
}
