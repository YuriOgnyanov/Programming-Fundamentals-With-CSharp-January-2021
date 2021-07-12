using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            int counter = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] command = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstCommand = command[0];

                switch (firstCommand)
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        counter++;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        counter++;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        counter++;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        counter++;
                        break;

                    case "Contains":
                        // Check if the list contains the number
                        int number = int.Parse(command[1]);
                        if (numbers.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        // Print all the even numbers, separated by a space

                        List<int> printEvenNumbers = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                printEvenNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", printEvenNumbers));
                        break;

                    case "PrintOdd":
                        // Print all the odd numbers, separated by a space.

                        List<int> printOddNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                printOddNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", printOddNumbers));
                        break;

                    case "GetSum":
                        //Print the sum of all the numbers.
                        int sumOfAllDigits = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sumOfAllDigits += numbers[i];
                        }
                        Console.WriteLine(sumOfAllDigits);
                        break;

                    case "Filter":
                        string condition = command[1];
                        int numberCommand = int.Parse(command[2]);

                        switch (condition)
                        {
                            case "<":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n < numberCommand)));
                                break;
                            case ">":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n > numberCommand)));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n >= numberCommand)));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n <= numberCommand)));
                                break;
                        }
                        break;
                }

            }
            if (counter > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
