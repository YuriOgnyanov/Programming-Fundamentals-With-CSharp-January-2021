using System;
using System.Linq;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listWithProduct = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string input = Console.ReadLine();



            while (true)
            {
                string[] ComandWithProduct = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input == "Go Shopping!")
                {
                    break;
                }

                if (ComandWithProduct[0] == "Unnecessary")
                {
                    foreach (string index in listWithProduct)
                    {
                        if (ComandWithProduct[1] == index)
                        {
                            
                        }
                        
                        
                    }
                     
                }
                    
            }

                

                input = Console.ReadLine();
        }

    }
}
