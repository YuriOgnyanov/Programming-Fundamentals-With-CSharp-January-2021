using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            double result = GetStepOfNumber(number, step);

            Console.WriteLine(result);
            
        }


        static double GetStepOfNumber(double number, int step)
        {

            double result = (double)Math.Pow(number, step);
            return result;
        }
    }
}
