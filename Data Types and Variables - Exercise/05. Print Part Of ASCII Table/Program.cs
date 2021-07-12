using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
           int startSymbol = int.Parse(Console.ReadLine());
           int endSymbol = int.Parse(Console.ReadLine());
            
            

            for (char i = (char)startSymbol; i <= endSymbol; i++)
            {
                Console.Write(i +" ");
            }
        }
    }
}
