using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Done")
                {
                    break;
                }

                string[] cmdArgs = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch (command)
                {
                    case "TakeOdd":
                        for (int i = 1; i < password.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sb.Append(password[i]);

                            }
                        }
                        password = sb.ToString();
                        Console.WriteLine(password);

                        break;

                    case "Cut":
                        int index = int.Parse(cmdArgs[1]);
                        int length = int.Parse(cmdArgs[2]);

                        password = password.Remove(index, length);

                        Console.WriteLine(password);


                        break;

                    case "Substitute":
                        //•	Substitute {substring} {substitute}
                        string substring = cmdArgs[1];
                        string substitute = cmdArgs[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);

                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
