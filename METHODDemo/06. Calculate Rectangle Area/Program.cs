using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int result = SumOfAreaOnTheRectangle(length, width);

            Console.WriteLine(result);
        }


        static int SumOfAreaOnTheRectangle(int length,int width)
        {
            return length * width;
        }
    }
}
