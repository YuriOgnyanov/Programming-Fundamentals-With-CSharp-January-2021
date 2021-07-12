using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfThePerson = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            decimal courses = Math.Ceiling((decimal)numOfThePerson / capacity);
            Console.WriteLine(courses);
        }
    }
}
