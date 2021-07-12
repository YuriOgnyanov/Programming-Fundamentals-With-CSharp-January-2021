using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());
            int lastDigits = 0; 
            int sumOfDigits = 0;

            while (number > 0) 
            {
                lastDigits = number % 10; 
                sumOfDigits += lastDigits; 
                number /= 10;
            }
            Console.WriteLine(sumOfDigits);





        }
    }
}
