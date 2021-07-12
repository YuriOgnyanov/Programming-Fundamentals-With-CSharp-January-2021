using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_3
{
    class Program
    {
        class Facebook
        {
            public int Comment { get; set; }
            public int Like { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //Dictionary<string, int> nameComment = new Dictionary<string, int>();
            //Dictionary<string, int> nameLike = new Dictionary<string, int>();
            Dictionary<string, Facebook> result = new Dictionary<string, Facebook>();
            while (input != "Log out")
            {
                string[] parts = input
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                string username = parts[1];
                switch (command)
                {
                    case "New follower":
                        username = parts[1];
                        if (!result.ContainsKey(username))
                        {
                            //nameComment.Add(username, 0);
                            result.Add(username, new Facebook() { Comment = 0, Like = 0 });
                            
                        }
                        break;

                    case "Like":
                        int count = int.Parse(parts[2]);
                        if (result.ContainsKey(username))
                        {
                            //nameLike[username] += count;
                            result[username].Like += count;
                        }
                        else
                        {
                            //nameLike.Add(username, count);
                            result.Add(username, new Facebook() { Like = count });
                            
                        }
                        break;

                    case "Comment":
                        if (result.ContainsKey(username))
                        {
                            //nameComment[username] += 1;
                            result[username].Comment += 1;
                        }
                        else
                        {
                            //nameComment.Add(username, 1);
                            result.Add(username, new Facebook() {Comment  = 1 });
                        }
                        break;

                    case "Blocked":
                        if (result.ContainsKey(username))
                        {
                            //nameComment.Remove(username);
                            //nameLike.Remove(username);
                            result.Remove(username);
                        }
                        else
                        {
                            Console.WriteLine($"{username} doesn't exist.");
                        }
                        break;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"{result.Count} followers");
            foreach (var item in result.OrderByDescending(m => m.Value.Like + m.Value.Comment).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Comment + item.Value.Like}");
            }
        }
    }
}
