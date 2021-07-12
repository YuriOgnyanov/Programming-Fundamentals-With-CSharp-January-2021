using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int ageOfThePerson = int.Parse(Console.ReadLine());
            int pricePerTickets = 0;



            if (ageOfThePerson >= 0 && ageOfThePerson <= 122)
            {
                if (typeOfDay == "Weekday")
                {

                    if (ageOfThePerson >= 0 && ageOfThePerson <= 18)
                    {
                        pricePerTickets = 12;
                    }
                    else if (ageOfThePerson > 18 && ageOfThePerson <= 64)
                    {
                        pricePerTickets = 18;
                    }
                    else if (ageOfThePerson > 64 && ageOfThePerson <= 122)
                    {
                        pricePerTickets = 12;
                    }

                }
                else if (typeOfDay == "Weekend")
                {
                    if (ageOfThePerson >= 0 && ageOfThePerson <= 18)
                    {
                        pricePerTickets = 15;
                    }
                    else if (ageOfThePerson > 18 && ageOfThePerson <= 64)
                    {
                        pricePerTickets = 20;
                    }
                    else if (ageOfThePerson > 64 && ageOfThePerson <= 122)
                    {
                        pricePerTickets = 15;
                    }

                }
                else if (typeOfDay == "Holiday")
                {

                    if (ageOfThePerson >= 0 && ageOfThePerson <= 18)
                    {
                        pricePerTickets = 5;
                    }
                    else if (ageOfThePerson > 18 && ageOfThePerson <= 64)
                    {
                        pricePerTickets = 12;
                    }
                    else if (ageOfThePerson > 64 && ageOfThePerson <= 122)
                    {
                        pricePerTickets = 10;
                    }

                }
                Console.WriteLine($"{pricePerTickets}$");
            }
            else
            {
                Console.WriteLine($"Error!");
            }

        }
    }
}
