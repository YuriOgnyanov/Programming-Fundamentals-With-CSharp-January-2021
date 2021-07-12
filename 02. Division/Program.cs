using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string dividerResult = string.Empty;

            int firstDivider = 10;
            int secondDivider = 7;
            int thirdDivider = 6;
            int fourDivider = 3;
            int fiveDivider = 2;


            if (number % firstDivider == 0)
            {
                dividerResult = $"The number is divisible by {firstDivider}";
            }
            else if (number % secondDivider == 0)
            {
                dividerResult = $"The number is divisible by {secondDivider}";
            }
            else if (number % thirdDivider == 0)
            {
                dividerResult = $"The number is divisible by {thirdDivider}";
            }
            else if (number % fourDivider == 0)
            {
                dividerResult = $"The number is divisible by {fourDivider}";
            }
            else if (number % fiveDivider == 0)
            {
                dividerResult = $"The number is divisible by {fiveDivider}";
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

            Console.WriteLine(dividerResult);





        }
    }
}
