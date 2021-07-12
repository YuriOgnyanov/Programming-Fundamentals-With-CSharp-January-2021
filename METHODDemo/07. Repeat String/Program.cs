using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int iteration = int.Parse(Console.ReadLine());

            RepeatStringAndPrint(text,iteration);

            
        }


        static void RepeatStringAndPrint(string text,int iteration)
        {
            
            for (int i = 0; i < iteration; i++)
            {
                Console.Write(text);
            }
        }
    }
}
