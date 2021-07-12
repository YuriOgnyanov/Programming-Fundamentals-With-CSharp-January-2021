using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string regex = @"\+359( |-)2( |-)\w{3}( |-)\w{4}\b";

            MatchCollection matchCollection = Regex.Matches(names, regex);

            var filterPhone = matchCollection
                .Cast<Match>()
                .Select(f => f.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ",filterPhone));
            
        }
    }
}
