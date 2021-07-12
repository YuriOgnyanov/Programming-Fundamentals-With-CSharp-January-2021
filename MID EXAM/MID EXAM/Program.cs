using System;
using System.Collections.Generic;
using System.Linq;

namespace MID_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<String> result = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Ready")
                {
                    break;
                }
                string[] cmArgs = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmArgs[0];

                string cardName = string.Empty;

                switch (command)
                {
                    case "Add":
                        cardName = cmArgs[1];
                        if (cards.Contains(cardName))
                        {
                            result.Add(cardName);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;

                    case "Insert":
                        cardName = cmArgs[1];
                        int index = int.Parse(cmArgs[2]);
                        if (cards.Contains(cardName) && index >= 0 && index <= result.Count)
                        {
                            result.Insert(index, cardName);
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        break;

                    case "Remove":
                        cardName = cmArgs[1];
                        if (result.Contains(cardName))
                        {
                            result.Remove(cardName);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;

                    case "Swap":
                        string firstCard = cmArgs[1];
                        string secondCard = cmArgs[2];
                        string saveCard = string.Empty;
                        for (int i = 0; i < result.Count; i++)
                        {
                            if (result[i] == firstCard)
                            {
                                saveCard = result[i];
                                result[i] = secondCard;
                                continue;
                            }
                            else if (result[i] == secondCard)
                            {
                                result[i] = saveCard;
                            }
                        }
                        break;
                    case "Shuffle":
                        result.Reverse();
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
