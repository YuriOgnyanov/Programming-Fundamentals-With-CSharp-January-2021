using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read The Input

            List<String> initialList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //Will Be Receiving Commands,Until You receive "Go Shopping"

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Go Shopping!")
                {
                    break;
                }
                string[] cmArgs = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firsCommand = cmArgs[0];

                //Switch On The Command and do something
                string item = string.Empty;
                switch (firsCommand)
                {
                    case "Urgent":
                        //Do Something;
                        item = cmArgs[1];
                        if (!initialList.Contains(item))
                        {
                            initialList.Insert(0, item);
                        }
                        break;

                    case "Unnecessary":
                        //Do Something;
                        item = cmArgs[1];
                        if (initialList.Contains(item))
                        {
                            initialList.Remove(item);
                        }
                        break;

                    case "Correct":
                        //Do Something;
                        string oldItem = cmArgs[1];
                        string newItem = cmArgs[2];
                        if (initialList.Contains(oldItem))
                        {
                            initialList[initialList.IndexOf(oldItem)] = newItem; 
                        }
                        break;

                    case "Rearrange":
                        //Do Something;
                        item = cmArgs[1];
                        if (initialList.Contains(item))
                        {
                            initialList.Remove(item);
                            initialList.Add(item);
                        }
                        break;
                }

            }

            //Print The Result, Joined by ", "

            Console.WriteLine(string.Join(", ", initialList));
        }
    }
}
