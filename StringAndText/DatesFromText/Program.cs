using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DatesFromText
{
    class Program
    {
        public static void Dates(string text)
        {
            const string MatchEmailPattern =
           @"\d{1,2}\.\d{1,2}\.\d{4}";
            Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            // Find matches.
            MatchCollection matches = rx.Matches(text);
            // Report the number of matches found.
            int noOfMatches = matches.Count;
            // Report on each match.
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.ToString());
            }
        }
            static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dates(text);
        }
    }
}
