using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            string patern = @"\+359( |-)2( |-)\w{3}( |-)\w{4}\b";

            MatchCollection matchCollection = Regex.Matches(phones, patern);


            foreach (Match phoneNumber in matchCollection)
            {
                Console.WriteLine(Match.);
            }




            
        }
    }
}
