using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> pieceByKey = new SortedDictionary<string, string>();

            SortedDictionary<string, string> pieceByComposer = new SortedDictionary<string, string>();


            int nIterations = int.Parse(Console.ReadLine());


            for (int i = 0; i < nIterations; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = cmdArgs[0];
                string composer = cmdArgs[1];
                string key = cmdArgs[2];

                if (!pieceByKey.ContainsKey(piece))
                {
                    pieceByKey.Add(piece, key);
                    pieceByComposer.Add(piece, composer);
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Stop")
                {
                    break;
                }
                string[] commands = line
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = string.Empty;
                string composer = string.Empty;
                string key = string.Empty;

                switch (commands[0])
                {
                    case "Add":
                        piece = commands[1];
                        composer = commands[2];
                        key = commands[3];
                        if (!pieceByKey.ContainsKey(piece))
                        {
                            pieceByKey.Add(piece, key);
                            pieceByComposer.Add(piece, composer);
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;

                    case "Remove":
                        piece = commands[1];
                        if (pieceByKey.ContainsKey(piece))
                        {
                            pieceByKey.Remove(piece);
                            pieceByComposer.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }

                        break;

                    case "ChangeKey":
                        piece = commands[1];
                        string newKey = commands[2];
                        if (pieceByKey.ContainsKey(piece))
                        {
                            foreach (var item in pieceByKey)
                            {
                                if (item.Key == piece)
                                {
                                    pieceByKey[item.Key] = newKey;
                                    break;
                                }
                            }
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;

                }

            }

            foreach (var item in pieceByKey)
            {
                foreach (var composer in pieceByComposer)
                {
                    if (item.Key == composer.Key)
                    {
                        Console.WriteLine($"{item.Key} -> Composer: {composer.Value}, Key: {item.Value}");
                    }
                }
            }
        }

    }
}

