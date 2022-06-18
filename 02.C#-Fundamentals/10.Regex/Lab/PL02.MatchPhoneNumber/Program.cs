using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PL02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);

            var phoneMatches = matches.Cast<Match>().Select(m => m.Value.Trim()).ToArray();

            Console.WriteLine(string.Join (", ", phoneMatches));
          
        }
    }
}
