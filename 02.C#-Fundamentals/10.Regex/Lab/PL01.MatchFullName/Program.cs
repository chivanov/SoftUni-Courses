using System;
using System.Text.RegularExpressions;

namespace PL01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
