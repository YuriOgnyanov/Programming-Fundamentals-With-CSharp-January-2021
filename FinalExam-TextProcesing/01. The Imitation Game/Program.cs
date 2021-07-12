using System;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Decode")
                {
                    break;
                }
                string[] cmdArgs = line
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Move":
                        int letters = int.Parse(cmdArgs[1]);
                        string nLetters = text.Substring(0, letters);

                        text = text.Remove(0, letters);
                        text = text.Insert(text.Length, nLetters);

                        break;

                    case "Insert":
                        int index = int.Parse(cmdArgs[1]);
                        string value = cmdArgs[2];

                        text = text.Insert(index, value);
                        break;

                    case "ChangeAll":
                        char subString = char.Parse(cmdArgs[1]);
                        char replacement = char.Parse(cmdArgs[2]);

                        text = text.Replace(subString, replacement);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {text}");
        }
    }
}
