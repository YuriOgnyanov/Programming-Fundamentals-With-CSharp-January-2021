using System;

namespace _02._Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            decimal areaOfCircle = (decimal)(Math.PI * radius * radius);

            Console.WriteLine($"{areaOfCircle:f12}");
        }
    }
}
