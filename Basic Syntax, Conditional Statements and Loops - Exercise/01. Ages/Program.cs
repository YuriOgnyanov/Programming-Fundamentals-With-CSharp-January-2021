using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            string type = string.Empty;

            if (ages >= 0 && ages <= 2)
            {
                type = "baby";
            }
            else if (ages <= 13)
            {
                type = "child";
            }
            else if (ages <= 19)
            {
                type = "teenager";
            }
            else if (ages <= 65)
            {
                type = "adult";
            }
            else
            {
                type = "elder";
            }
            Console.WriteLine(type);
        }
    }
}
