using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];

                if (command == "Generate")
                {
                    break;
                }

                switch (command)
                {
                    case "Contains":
                        //•	Contains>>>{substring} 
                        string subString = cmdArgs[1];
                        if (text.Contains(subString))
                        {
                            Console.WriteLine($"{text} contains {subString}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        //•	Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}
                        string UpperOrLower = cmdArgs[1];
                        int startIndex = int.Parse(cmdArgs[2]);
                        int endIndex = int.Parse(cmdArgs[3]);

                        string textSubString = text.Substring(startIndex, endIndex - startIndex);

                        if (UpperOrLower == "Upper")
                        {
                            text = text.Replace(textSubString, textSubString.ToUpper());
                        }
                        else
                        {
                            text = text.Replace(textSubString, textSubString.ToLower());
                        }
                        Console.WriteLine(text);
                        break;

                    case "Slice":
                        //•	Slice>>>{startIndex}>>>{endIndex}
                        int removeStartIndex = int.Parse(cmdArgs[1]);
                        int removeEndIndex = int.Parse(cmdArgs[2]);

                        string remove = text.Substring(removeStartIndex, removeEndIndex - removeStartIndex);
                        text = text.Remove(removeStartIndex, removeEndIndex - removeStartIndex);
                        Console.WriteLine(text);
                        break;
                }

            }
            Console.WriteLine($"Your activation key is: {text}");
        }
    }
}
