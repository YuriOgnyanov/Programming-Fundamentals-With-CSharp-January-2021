using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffects = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bombCasing = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(bombEffects);
            Stack<int> stack = new Stack<int>(bombCasing);

            int daturaBombs = 40;
            int cherryBombs = 60;
            int smokeDecoyBombs = 120;

            SortedDictionary<string, int> bombTypes = new SortedDictionary<string, int>();
            bombTypes["Datura Bombs"] = 0;
            bombTypes["Cherry Bombs"] = 0;
            bombTypes["Smoke Decoy Bombs"] = 0;


            bool isValid = false;
            int sumOfFirstAndLastElements = 0;

            while (queue.Any() && stack.Any())
            {

                int firstElementOnQueue = queue.Peek();
                int lastElementOnStack = stack.Peek();

                sumOfFirstAndLastElements = firstElementOnQueue + lastElementOnStack;


                while (sumOfFirstAndLastElements != daturaBombs && sumOfFirstAndLastElements != cherryBombs && sumOfFirstAndLastElements != smokeDecoyBombs)
                {
                    lastElementOnStack -= 5;
                    sumOfFirstAndLastElements = firstElementOnQueue + lastElementOnStack;
                }

                if (sumOfFirstAndLastElements == daturaBombs)
                {
                    queue.Dequeue();
                    stack.Pop();
                    bombTypes["Datura Bombs"] += 1;
                }
                else if (sumOfFirstAndLastElements == cherryBombs)
                {
                    queue.Dequeue();
                    stack.Pop();
                    bombTypes["Cherry Bombs"] += 1;
                }
                else if (sumOfFirstAndLastElements == smokeDecoyBombs)
                {
                    queue.Dequeue();
                    stack.Pop();
                    bombTypes["Smoke Decoy Bombs"] += 1;
                }

                if (bombTypes["Datura Bombs"] >= 3 && bombTypes["Cherry Bombs"] >= 3 && bombTypes["Smoke Decoy Bombs"] >= 3)
                {
                    isValid = true;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (queue.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", queue)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (stack.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", stack)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var elements in bombTypes)
            {
                Console.WriteLine($"{elements.Key}: {elements.Value}");
            }
        }
    }
}
