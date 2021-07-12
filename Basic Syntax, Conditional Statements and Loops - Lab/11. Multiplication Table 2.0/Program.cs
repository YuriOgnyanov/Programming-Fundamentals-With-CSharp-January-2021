using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int currNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = currNum; i <= 10; i++)
            {
                sum = num * i;
                Console.WriteLine($"{num} X {i} = {sum}");
            }
            if (currNum > 10)
            {
                sum = num * currNum;
                Console.WriteLine($"{num} X {currNum} = {sum}");
            }
        }
    }
}
