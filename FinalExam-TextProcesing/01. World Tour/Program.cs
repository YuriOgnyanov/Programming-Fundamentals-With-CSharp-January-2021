using System;
using System.Text;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Travel")
                {
                    break;
                }

                string[] cmdArgs = line
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(cmdArgs[1]);
                        string town = cmdArgs[2];
                        if (index >= 0 && index < text.Length)
                        {
                            text = text.Insert(index, town);
                            Console.WriteLine(text);
                        }
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(cmdArgs[1]);
                        int endIndex = int.Parse(cmdArgs[2]);

                        string removeSubstring = string.Empty;
                        if ((startIndex >= 0 && startIndex < text.Length) && (endIndex >= 0 && endIndex < text.Length))
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                if (i >= startIndex && i <= endIndex)
                                {
                                    removeSubstring += text[i];
                                }
                            }
                            if (text.Contains(removeSubstring))
                            {
                                text = text.Replace(removeSubstring, string.Empty);
                            }
                        }
                        Console.WriteLine(text);
                        break;

                    case "Switch":
                        string oldString = cmdArgs[1];
                        string newString = cmdArgs[2];
                        text = text.Replace(oldString,newString);
                        Console.WriteLine(text);
                        break;
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
            
        }
    }
}
