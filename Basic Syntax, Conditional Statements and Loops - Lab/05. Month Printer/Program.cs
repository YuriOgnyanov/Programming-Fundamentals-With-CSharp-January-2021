using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfMounth = int.Parse(Console.ReadLine());
            string nameOfMounth = "";

            switch (numOfMounth)
            {
                case 1:
                    nameOfMounth = "January";
                break;
                case 2:
                    nameOfMounth = "February";
                break;
                case 3:
                    nameOfMounth = "March";
                break;
                case 4:
                    nameOfMounth = "April";
                    break;
                case 5:
                    nameOfMounth = "May";
                    break;
                case 6:
                    nameOfMounth = "June";
                    break;
                case 7:
                    nameOfMounth = "July";
                    break;
                case 8:
                    nameOfMounth = "August";
                    break;
                case 9:
                    nameOfMounth = "September";
                    break;
                case 10:
                    nameOfMounth = "Octomber";
                    break;
                case 11:
                    nameOfMounth = "November";
                    break;
                case 12:
                    nameOfMounth = "December";
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;

            
            }
            Console.WriteLine(nameOfMounth);
        }
    }
}
