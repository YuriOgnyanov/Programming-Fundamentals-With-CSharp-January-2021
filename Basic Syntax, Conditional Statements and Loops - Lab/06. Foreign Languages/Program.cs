using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePerCountry = Console.ReadLine();

            string language = "";

            if (namePerCountry == "USA" || namePerCountry == "England")
            {
                language = "English";
            }
            else if (namePerCountry == "Spain" || namePerCountry == "Argentina" || namePerCountry == "Mexico")
            {
                language = "Spanish";
            }
            else
            {
                Console.WriteLine("unknown");
            }
            Console.WriteLine(language);
            
        }
    }
}
