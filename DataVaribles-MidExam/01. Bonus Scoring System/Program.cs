using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int numOfcourses = int.Parse(Console.ReadLine());
            double bonusPoint = int.Parse(Console.ReadLine());

            double totalBonus = 0;
            int theBestStudent = int.MinValue;
            bool isValid = false;




            for (int i = 1; i <= students; i++)
            {
                int studentsAttendaces = int.Parse(Console.ReadLine());

                if (studentsAttendaces > theBestStudent)
                {
                    theBestStudent = studentsAttendaces;
                    totalBonus = studentsAttendaces / (numOfcourses * 1.0) * (5 + bonusPoint);
                    isValid = true;
                }
            }
            if (isValid)
            {
                Console.WriteLine($"Max Bonus: {Math.Round(totalBonus)}.");
                Console.WriteLine($"The student has attended {theBestStudent} lectures.");
            }
            




        }
    }
}
