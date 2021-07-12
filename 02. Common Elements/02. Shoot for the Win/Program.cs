using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            int strike = 0;

            while (input != "End")
            {
                int index = int.Parse(input);

                if (index <= array.Length - 1)
                {


                    for (int i = 0; i < array.Length; i++)
                    {
                         int indexNumber = array[index];

                        if (array[index] == array[i])
                        {
                            if (array[i] > indexNumber && array[index] != array[i])
                            {
                                array[i] = array[i] - indexNumber;
                                

                            }
                            else if (indexNumber >= array[i] && array[index] != array[i])
                            {
                                array[i] = array[i] + indexNumber;
                            }
                        }
                        else
                        {
                            continue;
                        }
                           array[i] = -1;
                            strike++;
                        
                        
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {strike} -> {string.Join(' ', array)}");



        }
    }
}
