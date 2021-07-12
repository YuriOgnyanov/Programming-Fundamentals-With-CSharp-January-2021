using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Need_for_Speed_III
{
    
    class Program
    {

        class Cars
        {
            public int mileage { get; set; }

            public int fuel { get; set; }
        }
        static void Main(string[] args)
        {
            SortedDictionary<string, Cars> carsColetion = new SortedDictionary<string, Cars>();

            int nIteration = int.Parse(Console.ReadLine());

            for (int i = 0; i < nIteration; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string carPart = parts[0];
                int mileagePart = int.Parse(parts[1]);
                int fuelPart = int.Parse(parts[2]);

                Cars car = new Cars()
                {
                    fuel = fuelPart,
                    mileage = mileagePart
                    
                };

                carsColetion.Add(carPart, car);
            }

            

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Stop")
                {
                    break;
                }
                string[] cmdArgs = line
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                string car = cmdArgs[1];
                int fuel = 0;

                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(cmdArgs[2]);
                        fuel = int.Parse(cmdArgs[3]);
                        if (fuel < carsColetion[car].fuel)
                        {
                            carsColetion[car].fuel -= fuel;
                            carsColetion[car].mileage += distance;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }

                        if (carsColetion[car].mileage >= 100000)
                        {
                            carsColetion.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                        break;

                    case "Refuel":
                        fuel = int.Parse(cmdArgs[2]);
                        if (carsColetion[car].fuel + fuel <= 75)
                        {
                            carsColetion[car].fuel += fuel;
                            Console.WriteLine($"{car} refueled with {fuel} liters");
                            continue;
                        }
                        else
                        {
                            int sumFuel = carsColetion[car].fuel += fuel; //74 + 40 = 114;
                            int leftFuel = sumFuel - 75;                //114 - 75 = 39;
                            int needed = fuel - leftFuel;              // 40 - 39 = 1
                            carsColetion[car].fuel += needed;          // 74 + 1;
                            Console.WriteLine($"{car} refueled with {needed} liters");
                        }
                        break;

                    case "Revert":
                        int cilometers = int.Parse(cmdArgs[2]);
                        if (carsColetion[car].mileage - cilometers >= 10000)
                        {
                            carsColetion[car].mileage -= cilometers;
                            Console.WriteLine($"{car} mileage decreased by {cilometers} kilometers");
                        }
                        else
                        {
                            carsColetion[car].mileage = 10000;
                        }
                        break;
                }
            }

            foreach (var car in carsColetion.OrderByDescending(v => v.Value.mileage))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.mileage} kms, Fuel in the tank: {car.Value.fuel} lt.");
            }
        }
    }
}
