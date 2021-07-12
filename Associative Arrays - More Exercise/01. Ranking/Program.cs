using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string contestAndPassword = Console.ReadLine();

            Dictionary<string, string> contestByPassword = new Dictionary<string, string>();

            while (contestAndPassword != "end of contests")
            {
                string[] parts = contestAndPassword
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                // {contest}:{password for contest}
                string contestPart = parts[0];
                string passwordPart = parts[1];

                contestByPassword.Add(contestPart, passwordPart);

                contestAndPassword = Console.ReadLine();
            }

            Dictionary<string, Contest> result = new Dictionary<string, Contest>();

            string input = Console.ReadLine();
            while (input != "end of submissions")
            {
                string[] cmdArgs = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                // {contest}=>{password}=>{username}=>{points}
                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                string username = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);

                if (contestByPassword.ContainsKey(contest))
                {
                    if (contestByPassword[contest] == password)
                    {
                        if (result.ContainsKey(username))
                        {
                            
                        }
                        else
                        {
                            result.Add(username, new Contest().MyProperty = new Dictionary<int, List<string>>().Add(points, value: new List<string>() { contest }));
                        }
                       

                    }
                }






                input = Console.ReadLine();
            }

        }
    }
}
