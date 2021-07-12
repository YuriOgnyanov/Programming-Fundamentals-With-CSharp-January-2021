using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> plantRatity = new Dictionary<string, int>(); // Here we save only Plant and Ratity

            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>(); // Here we save only Plant and Rating

            //1. On the first line you will receive a number n
            int nIteration = int.Parse(Console.ReadLine());

            //2. On the next n lines, you will be given some information about the plants in the format: "{plant}<->{rarity}". 
            for (int i = 0; i < nIteration; i++)
            {
                string[] planInformation = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string partOfPlant = planInformation[0];
                int partOfRatity = int.Parse(planInformation[1]);

                //3. If you receive a plant more than once, update its rarity.
                if (plantRatity.ContainsKey(partOfPlant))
                {
                    plantRatity[partOfPlant] = partOfRatity;
                }
                else
                {
                    plantRatity.Add(partOfPlant, partOfRatity);
                }

            }

            //4. After that until you receive the command "Exhibition" you will be given some of these commands
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Exhibition")
                {
                    break;
                }
                string[] cmdArgs = line
                    .Split(new char[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string command = cmdArgs[0];
                string plant = cmdArgs[1];

                switch (command)
                {
                    //  • Rate: {plant} - {rating} – add the given rating to the plant (store all ratings)
                    case "Rate":
                        double rating = double.Parse(cmdArgs[2]);

                        if (plantRating.ContainsKey(plant))
                        {
                            plantRating[plant].Add(rating);
                        }
                        else
                        {
                            plantRating.Add(plant, new List<double>() { rating });
                        }
                        break;

                    //  • Update: { plant} - { new_rarity} – update the rarity of the plant with the new one
                    case "Update":
                        int newRatity = int.Parse(cmdArgs[2]);
                        plantRatity[plant] = newRatity;
                        break;

                    //  • Reset: { plant} – remove all the ratings of the given plant
                    case "Reset":
                        plantRating[plant].Clear();
                        plantRating[plant].Add(0.0);
                        break;

                    // Note: If any of the command is invalid, print "error"
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            Dictionary<string, double> avgRating = new Dictionary<string, double>();
            //6. After the command "Exhibition" print the information that you have about the plants in the following format
            // Plants for the exhibition: - { plant_name}; Rarity: { rarity}; Rating: { average_rating formatted to the 2nd digit}
            //7.The plants should be sorted by rarity descending, then by average rating descending
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plandAndRatity in plantRatity.OrderByDescending(x => x.Value))
            {
                foreach (var item in plantRating.OrderByDescending(x => x.Value.Average()).ThenByDescending(x => x.Value.Average()  ))
                {
                    if (plandAndRatity.Key == item.Key)
                    {
                        Console.WriteLine($"- {plandAndRatity.Key}; Rarity: {plandAndRatity.Value}; Rating: {item.Value.Average():F2}");
                    }
                    
                }
            }

            



        }
    }
}
