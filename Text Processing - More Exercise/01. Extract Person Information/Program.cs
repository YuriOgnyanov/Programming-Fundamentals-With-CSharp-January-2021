using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int nIterations = int.Parse(Console.ReadLine());

            string name = string.Empty;
            string age = string.Empty;

            Dictionary<string, string> nameByAge = new Dictionary<string, string>();

            for (int i = 0; i < nIterations; i++)
            {
                string text = Console.ReadLine();

                // format "{name} is {age} years old.

                if (text.Contains("@"))
                {
                    int startIndexName = text.IndexOf("@") + 1;
                    int endIndexName = text.IndexOf("|");
                    int elementsByName = endIndexName - startIndexName;
                    name = text.Substring(startIndexName, elementsByName);
                    
                }

                if (text.Contains("|"))
                {
                    int startIndexAge = text.IndexOf("#") + 1;
                    int endIndexAge = text.IndexOf("*");
                    int elementsByAge = endIndexAge - startIndexAge;
                    age = text.Substring(startIndexAge, elementsByAge);
                }
                nameByAge.Add(name, age);
            }
            foreach (var person in nameByAge)
            {
                Console.WriteLine($"{person.Key} is {person.Value} years old.");
            }
            
        }

        
    }
}
