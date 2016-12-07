using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractTextFromHTML
{
    class Program
    {
        public static void TextExtractor(string text)
        {
            int titleStart = text.IndexOf("<title>");
            int titleEnd = text.IndexOf("</title>");
            if (titleStart + 7 != titleEnd)
            {
                string title = text.Substring(titleStart + 7, titleEnd -(titleStart+7));
                string titleRep = title + ": ";

                string result = null;
                result = result + title;

                const string MatchEmailPattern =
              @"<[^>]*>";
                Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                // Find matches.
                MatchCollection matches = rx.Matches(text);
                // Report the number of matches found.
                int noOfMatches = matches.Count;
                // Report on each match.

                for (int i = 0; i < matches.Count; i++)
                {

                    int indexStart = text.IndexOf(matches[i].ToString());
                    int matchLenght = matches[i].Length;
                    text = text.Remove(indexStart, matchLenght);
                }
                text = text.Replace(title, titleRep);
                Console.WriteLine(text);
            }
            else
            {


                const string MatchEmailPattern =
               @"<[^>]*>";
                Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                // Find matches.
                MatchCollection matches = rx.Matches(text);
                // Report the number of matches found.
                int noOfMatches = matches.Count;
                // Report on each match.

                for (int i = 0; i < matches.Count; i++)
                {

                    int indexStart = text.IndexOf(matches[i].ToString());
                    int matchLenght = matches[i].Length;
                    text = text.Remove(indexStart, matchLenght);
                }
               
            Console.WriteLine(text);
            }
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            TextExtractor(text);
        }
    }
}
