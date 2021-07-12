using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondBox = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(firstBox);
            Stack<int> stack = new Stack<int>(secondBox);

            int value = 0;

            while (queue.Any() && stack.Any())
            {
                int firstElement = queue.Peek();
                int lastElement = stack.Peek();
                if ((firstElement + lastElement) % 2 == 0)
                {
                    value += queue.Dequeue() + stack.Pop();
                }
                else
                {
                    queue.Enqueue(stack.Pop());
                }
            }

            if (!queue.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (!stack.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (value >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {value}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {value}");
            }


        }
    }
}
