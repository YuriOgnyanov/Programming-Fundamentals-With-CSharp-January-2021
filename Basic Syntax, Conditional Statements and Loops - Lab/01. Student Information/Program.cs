using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            int ageOfStudent = int.Parse(Console.ReadLine());
            double averagePerGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {nameOfStudent}, Age: {ageOfStudent}, Grade: {averagePerGrade:F2}");
        }
    }
}
