using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        class Town
        {
            public int people { get; set; }
            public int gold { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Town> townByPeopleAndGold = new Dictionary<string, Town>();

            // Until the "Sail" command is given you will be receiving:
            while (true)
            {
                string commandSail = Console.ReadLine();
                if (commandSail == "Sail")
                {
                    break;
                }
                // Cities that you and your crew have targeted, with their population and gold, separated by "||".
                string[] parts = commandSail
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);

                string townPart = parts[0];
                int peoplePart = int.Parse(parts[1]);
                int goldPart = int.Parse(parts[2]);

                Town town = new Town()
                {
                    people = peoplePart,
                    gold = goldPart
                };

                // If you receive a city which has been already received, you have to increase the population and gold with the given values.
                if (townByPeopleAndGold.ContainsKey(townPart))
                {
                    townByPeopleAndGold[townPart].people += peoplePart;
                    townByPeopleAndGold[townPart].gold += goldPart;
                }
                else
                {
                    townByPeopleAndGold.Add(townPart, town);
                }
            }
            // After the "Sail" command, you will start receiving lines of text representing events until the "End" command is given. 

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] cmdArgs = line
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string town = cmdArgs[1];
                int gold = 0;

                switch (command)
                {
                    // "Plunder=>{town}=>{people}=>{gold}"
                    case "Plunder":
                        int people = int.Parse(cmdArgs[2]);
                         gold = int.Parse(cmdArgs[3]);

                        if (townByPeopleAndGold[town].people - people == 0)
                        {
                            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                            townByPeopleAndGold.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                        else if (townByPeopleAndGold[town].gold - gold == 0)
                        {
                            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                            townByPeopleAndGold.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                        else
                        {
                            townByPeopleAndGold[town].people -= people;
                            townByPeopleAndGold[town].gold -= gold;
                            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        }
                        break;

                    // "Prosper=>{town}=>{gold}"
                    case "Prosper":
                        gold = int.Parse(cmdArgs[2]);

                        // The gold amount can be a negative number, so be careful.
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            continue;
                        }
                        else
                        {
                            townByPeopleAndGold[town].gold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {townByPeopleAndGold[town].gold} gold.");
                        }
                        break;
                }
            }

            Console.WriteLine($"Ahoy, Captain! There are {townByPeopleAndGold.Count} wealthy settlements to go to:");

            foreach (var town in townByPeopleAndGold.OrderByDescending( g => g.Value.gold).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{town.Key} -> Population: {town.Value.people} citizens, Gold: {town.Value.gold} kg");
            }
        }
    }
}
