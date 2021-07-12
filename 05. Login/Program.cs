using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {


            string line = Console.ReadLine();

            char[] userName = line
                .Reverse()
                .ToArray();

            string isVallidPass = new string(userName);





            string input = Console.ReadLine();
            int invalidCounter = 0;
            while (true)
            {
                string password = input;
                if (password == isVallidPass)
                {
                    Console.WriteLine($"User {line} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    invalidCounter++;

                    if (invalidCounter == 3)
                    {
                        Console.WriteLine($"User {line} blocked!");
                        break;
                    }

                }




                input = Console.ReadLine();

                
            }
        }
    }
}
