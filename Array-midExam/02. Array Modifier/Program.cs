using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read Input;
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            // I will receive commands and if receive "end" , break the while loop;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                // I will Split the line on the commands;
                string[] cmArgs = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmArgs[0];

                int index1 = 0;
                int index2 = 0;

                //Switch end find command
                switch (command)
                {
                    case "swap":
                        // do something
                        index1 = int.Parse(cmArgs[1]);
                        index2 = int.Parse(cmArgs[2]);
                        int saveFirstElement = numbers[index1];
                        numbers[index1] = numbers[index2];
                        numbers[index2] = saveFirstElement;
                        break;

                    case "multiply":
                        // do something
                        index1 = int.Parse(cmArgs[1]);
                        index2 = int.Parse(cmArgs[2]);
                        numbers[index1] *= numbers[index2];
                        break;

                    case "decrease":
                        //do something
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]--;
                        }
                        break;
                }

            }

            // On the end we will print the Otput(numbers) separated by ",";
            Console.WriteLine(string.Join(", ", numbers));
            

        }
    }
}
