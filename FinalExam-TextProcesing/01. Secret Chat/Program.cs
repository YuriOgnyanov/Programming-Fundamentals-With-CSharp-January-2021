using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Reveal")
                {
                    break;
                }

                string[] cmdArgs = line
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(cmdArgs[1]);
                        message = message.Insert(index, " ");

                        Console.WriteLine(message);
                        break;

                    case "Reverse":
                        string reverseSubString = cmdArgs[1];
                        string reversed = string.Empty;

                        if (message.Contains(reverseSubString))
                        {

                            var indexWord = message.IndexOf(reverseSubString);

                            message = message.Remove(indexWord, reverseSubString.Length);

                            for (int i = reverseSubString.Length - 1; i >= 0; i--)
                            {
                                reversed += reverseSubString[i];
                            }
                            message = message.Insert(message.Length, reversed);
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "ChangeAll":
                        string substring = cmdArgs[1];
                        string replacement = cmdArgs[2];

                        message = message.Replace(substring, replacement);
                        Console.WriteLine(message);
                        break;
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
