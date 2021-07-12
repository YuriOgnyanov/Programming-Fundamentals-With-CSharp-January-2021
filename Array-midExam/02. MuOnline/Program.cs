using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read The Input;

            string[] roomsAtack = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int rooms = 0;

            int initialHealth = 100;
            int initialBitcoins = 0;

            foreach (string element in roomsAtack)
            {
                string[] arr = element
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arr[0];

                switch (command)
                {
                    case "potion":
                        int health = int.Parse(arr[1]);
                        if (initialHealth + health <= 100)
                        {
                            initialHealth += health;
                            Console.WriteLine($"You healed for {health} hp.");
                            Console.WriteLine($"Current health: {initialHealth} hp.");
                            rooms++;
                            continue;
                        }
                        else
                        {
                            int counter = 0;
                            int currHealth = 0;
                            while (initialHealth != 100)
                            {
                                counter++;
                                initialHealth += counter;
                                currHealth += counter;
                                counter = 0;
                            }
                            Console.WriteLine($"You healed for {currHealth} hp.");
                            Console.WriteLine($"Current health: {initialHealth} hp.");
                            rooms++;
                            continue;
                        }
                        break;

                    case "chest":
                        int bitcoin = int.Parse(arr[1]);
                        initialBitcoins += bitcoin;
                        Console.WriteLine($"You found {bitcoin} bitcoins.");
                        rooms++;
                        continue;
                        break;
                }

                string monster = command;
                int atack = int.Parse(arr[1]);
                initialHealth -= atack;
                rooms++;

                if (initialHealth > 0)
                {
                    Console.WriteLine($"You slayed {monster}.");
                }
                else
                {
                    Console.WriteLine($"You died! Killed by {monster}.");
                    Console.WriteLine($"Best room: {rooms}");
                    return;
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: { initialBitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
