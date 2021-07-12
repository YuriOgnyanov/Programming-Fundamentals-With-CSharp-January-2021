using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //group of people
            int peopleGroup = int.Parse(Console.ReadLine());

            //type of the group
            string groupType = Console.ReadLine();

            //which day of the week 
            string dayOfWeek = Console.ReadLine();


            double calculatePrice = 0.0;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            calculatePrice = peopleGroup * 8.45;
                            break;

                        case "Saturday":
                            calculatePrice = peopleGroup * 9.80;
                            break;

                        case "Sunday":
                            calculatePrice = peopleGroup * 10.46;
                            break;
                    }
                    break;

                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            calculatePrice = peopleGroup * 10.90;
                            break;

                        case "Saturday":
                            calculatePrice = peopleGroup * 15.60;
                            break;

                        case "Sunday":
                            calculatePrice = peopleGroup * 16;
                            break;
                    }
                    break;

                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            calculatePrice = peopleGroup * 15;
                            break;

                        case "Saturday":
                            calculatePrice = peopleGroup * 20;
                            break;

                        case "Sunday":
                            calculatePrice = peopleGroup * 22.50;
                            break;
                    }
                    break;
            }

            if (groupType == "Students")
            {
                if (peopleGroup >= 30)
                {
                    calculatePrice = calculatePrice - calculatePrice * 0.15;
                }
            }
            else if (groupType == "Business")
            {
                if (peopleGroup >= 100)
                {
                    int peopleFree = 10;
                    if (dayOfWeek == "Friday")
                    {
                        calculatePrice = calculatePrice - peopleFree * 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        calculatePrice = calculatePrice - peopleFree * 15.60;
                    }
                    else
                    {
                        calculatePrice = calculatePrice - peopleFree * 16;
                    }
                }
            }
            else
            {
                if (peopleGroup >= 10 && peopleGroup <= 20)
                {
                    calculatePrice = calculatePrice - calculatePrice * 0.5;
                }
            }

            Console.WriteLine($"Total price: {1.0 * calculatePrice:F2}");
        }
    }
}
