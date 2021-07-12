using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{

    class Program
    {
        class Herous
        {
            public int HP { get; set; }
            public int MP { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Herous> heroByHpAndMp = new Dictionary<string, Herous>();

            // 1 - On the first line of the standard input you will receive an integer n
            int nIterations = int.Parse(Console.ReadLine());

            // 2 - On the next n lines, the heroes themselves will follow with their hit points and mana points 
            for (int i = 0; i < nIterations; i++)
            {
                // {hero name} {HP} {MP} 
                string[] parts = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string partHeroName = parts[0];
                int partHP = int.Parse(parts[1]);
                int partMP = int.Parse(parts[2]);

                Herous herous = new Herous()
                {
                    HP = partHP,
                    MP = partMP
                };
                heroByHpAndMp.Add(partHeroName, herous);

            }
            // 3 - You will be receiving different commands, each on a new line, separated by " – ", until the "End" command
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] cmdArgs = line
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string heroName = cmdArgs[1];

                switch (command)
                {
                    // CastSpell – {hero name} – {MP needed} – {spell name} 
                    case "CastSpell":
                        int neededMp = int.Parse(cmdArgs[2]);
                        string spellName = cmdArgs[3];

                        if (heroByHpAndMp[heroName].MP >= neededMp)
                        {
                            heroByHpAndMp[heroName].MP -= neededMp;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroByHpAndMp[heroName].MP} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    // TakeDamage – {hero name} – {damage} – {attacker}
                    case "TakeDamage":
                        int damage = int.Parse(cmdArgs[2]);
                        string attacker = cmdArgs[3];

                        if (heroByHpAndMp[heroName].HP - damage > 0)
                        {
                            heroByHpAndMp[heroName].HP -= damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroByHpAndMp[heroName].HP} HP left!");
                        }
                        else
                        {
                            heroByHpAndMp.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        break;
                    // Recharge – {hero name} – {amount}
                    case "Recharge":
                        int amount = int.Parse(cmdArgs[2]);
                        //- where HP stands for hit points, a hero can have a maximum of 200 MP
                        if (heroByHpAndMp[heroName].MP + amount <= 200)
                        {
                            heroByHpAndMp[heroName].MP += amount;
                            Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        }
                        else
                        {
                            int needed = amount - ((heroByHpAndMp[heroName].MP + amount) - 200);
                            heroByHpAndMp[heroName].MP += needed;
                            Console.WriteLine($"{heroName} recharged for {needed} MP!");
                        }
                        break;
                    // Heal – {hero name} – {amount}
                    case "Heal":
                        int amountHp = int.Parse(cmdArgs[2]);
                        //- where HP stands for hit points, a hero can have a maximum of 100 HP
                        if (heroByHpAndMp[heroName].HP + amountHp <= 100)
                        {
                            heroByHpAndMp[heroName].HP += amountHp;
                            Console.WriteLine($"{heroName} healed for {amountHp} HP!");
                        }
                        else
                        {
                            int neededHp = amountHp - ((heroByHpAndMp[heroName].HP + amountHp) - 100);
                            heroByHpAndMp[heroName].HP += neededHp;
                            Console.WriteLine($"{heroName} healed for {neededHp} HP!");
                        }
                        break;
                }

            }
            foreach (var hpAndMp in heroByHpAndMp.OrderByDescending(x => x.Value.HP).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{hpAndMp.Key}");
                Console.WriteLine($"  HP: {hpAndMp.Value.HP}");
                Console.WriteLine($"  MP: {hpAndMp.Value.MP}");
            }

        }
    }
}
