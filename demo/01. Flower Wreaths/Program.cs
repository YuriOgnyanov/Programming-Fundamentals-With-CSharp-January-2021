using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] roses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(lilies);
            Queue<int> queue = new Queue<int>(roses);

            Dictionary<string, int> wreathResult = new Dictionary<string, int>();
            wreathResult["wreath"] = 0;
            wreathResult["leftFlowers"] = 0;


            int totalFlowers = 15;
            int sumOfLastAndFirstElement = 0;
            
            while (stack.Any() && queue.Any())
            {
                int lastLilies = stack.Peek();
                int firstRoses = queue.Peek();

                sumOfLastAndFirstElement = lastLilies + firstRoses;

                if (sumOfLastAndFirstElement >= 15)
                {
                    while (sumOfLastAndFirstElement != totalFlowers)
                    {
                        firstRoses -= 2;
                        sumOfLastAndFirstElement = lastLilies + firstRoses;
                        if (sumOfLastAndFirstElement < 15)
                        {
                            break;
                        }
                    }

                    if (sumOfLastAndFirstElement == totalFlowers)
                    {
                        stack.Pop();
                        queue.Dequeue();
                        wreathResult["wreath"] += 1;
                    }
                }
                if (sumOfLastAndFirstElement < 15)
                {
                    stack.Pop();
                    queue.Dequeue();
                    wreathResult["leftFlowers"] += sumOfLastAndFirstElement;
                }
                
            }

            
            while (wreathResult["leftFlowers"] > 15)
            {
                wreathResult["leftFlowers"] -= 15;
                wreathResult["wreath"] += 1;
            }

            if (wreathResult["wreath"] >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathResult["wreath"]} wreaths!");
            }
            else
            {
                int neededWreath = 5 - wreathResult["wreath"];
                Console.WriteLine($"You didn't make it, you need {neededWreath} wreaths more!");
            }


        }
    }
}
