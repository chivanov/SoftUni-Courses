using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PE04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            //string decriptingPattern = @"[STARstar]+";

            string decrPattern = @"\@(?<planetName>[A-Za-z]+)[^@\-!:>]:(?<population>\d+)[^@\-!:>]!(?<atackType>A|D)!->(\d+)";

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();             

                string decriptedMessage = DecriptMessage(input);
                               

                Match orderInfo = Regex.Match(decriptedMessage, decrPattern);
                if (orderInfo.Success)
                { 
                string plannetName = orderInfo.Groups["plannetName"].Value; 

                
                }
            }
        }

        private static string DecriptMessage(string input)
        {
            int decrKey = GetDecriptionKey(input);
            StringBuilder sb = new StringBuilder();

            foreach (char currCh in input)
            {
                char decriptrdCh = (char)(currCh - decrKey);

                sb.Append(decriptrdCh);
            }
            return sb.ToString();   
        }

        static int GetDecriptionKey(string input)
        {
            string decriptingPattern = @"[star]{1}";
            MatchCollection matches = Regex.Matches(input, decriptingPattern, RegexOptions.IgnoreCase);
            return matches.Count;   
           
        }
    }
}
