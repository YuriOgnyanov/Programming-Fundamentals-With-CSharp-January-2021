using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        const int Shoot = -1;
        static void Main(string[] args)
        {
            //Read Input;

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int shotTargets = 0;

            //I will receive indexs util "End", and break; the loop;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                int index = int.Parse(line);
                //if will index is valid, do something

                if (index >= 0 && index <= numbers.Length - 1)
                {
                    //find this index and shoot;

                    int saveFirstElement = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        //if we shot the numbers from collection with index , he will be equal on - 1;

                        saveFirstElement = numbers[i];
                        if (numbers[i] != Shoot)
                        {
                            if (i == index)
                            {
                                numbers[i] = Shoot;
                                shotTargets++;
                                break;
                            }

                        }
                    }
                   
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] == Shoot)
                        {
                            continue;
                        }
                        else
                        {
                            if (numbers[j] > saveFirstElement)
                            {
                                numbers[j] -= saveFirstElement;
                                continue;
                            }

                            if (numbers[j] <= saveFirstElement)
                            {
                                numbers[j] += saveFirstElement;
                            }
                        }
                        
                    }


                }

            }

            //print the otput;

            Console.Write($"Shot targets: {shotTargets} -> ");
            Console.WriteLine(string.Join(" ", numbers));

           

           

            


        }
    }
}
