using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<List<string>, List<int>>> contestByUsername = new Dictionary<string, KeyValuePair<List<string>, List<int>>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "no more time")
                {
                    break;
                }
                string[] parts = line
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                // {username} -> {contest} -> {points}
                string username = parts[0];
                string contest = parts[1];
                int points = int.Parse(parts[2]);

                if (contestByUsername.ContainsKey(contest))
                {
                    if (contestByUsername[contest].Key.Contains(username))
                    {
                        contestByUsername[contest].Value.Max();
                    }
                    else
                    {
                        contestByUsername[contest].Key.Add(username);
                        contestByUsername[contest].Value.Add(points);
                    }
                }
                else
                {
                    contestByUsername.Add(contest, new KeyValuePair<List<string>, List<int>>(new List<string>() { username }, new List<int>() { points }));
                }

            }


            int counter = 0;
            foreach (var cvp in contestByUsername)
            {
                Console.WriteLine($"{cvp.Key}: {cvp.Value.Key.Count} participants");
                foreach (var item in cvp.Value.Key)
                {

                }
            }
        }
    }
}
