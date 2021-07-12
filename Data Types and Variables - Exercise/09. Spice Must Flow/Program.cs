using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int extract = int.Parse(Console.ReadLine());
            int days = 0;
            long totalExtract = 0L;
            if (extract < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);   
                return;
            }
            

            while (extract >= 100)
            {
                totalExtract += extract - 26;
                extract -= 10;
                days += 1;

            }

            totalExtract -= 26;
            Console.WriteLine(days);
            Console.WriteLine(totalExtract);
            
        }
    }
}
