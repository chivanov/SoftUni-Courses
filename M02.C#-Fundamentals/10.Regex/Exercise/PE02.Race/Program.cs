using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace PE02.Race
{
    internal class Program
    {
        public static object StringBUilder { get; private set; }

        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> results = new Dictionary<string, int>();

            string input = Console.ReadLine();
            string namePattern = @"([A-Z]|[a-z])";
            string digitPattern = @"\d";

          

            while (input != "end of race")
            {
                
                // string[] nameOfRacer = string.Join("", input.Where(x => char.IsLetter(x)));
                // int distance = input.Where(x => char.IsDigit(x)).Select(x => int.Parse(x.ToString())).Sum();
                
                StringBuilder sbName = new StringBuilder();
                MatchCollection nameMatches = Regex.Matches(input, namePattern);
                foreach (Match item in nameMatches)
                {
                    sbName.Append(item).ToString();
                }

                MatchCollection digitMatches = Regex.Matches(input, digitPattern);
                int distance = 0;
                foreach (Match match in digitMatches)
                {
                    distance += int.Parse(match.Value);
                }

                if (participants.Contains(sbName.ToString()))
                {
                    if (results.ContainsKey(sbName.ToString()))
                    {
                        results[sbName.ToString()] += distance;
                    }
                    else
                    {
                        results.Add(sbName.ToString(), distance);
                    }
                }                

                input = Console.ReadLine();
            }

            var winners = results.OrderByDescending(x => x.Value).Take(3);
            var first = winners.Take(1);    
            var second = winners.OrderByDescending(x=> x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var third = winners.OrderBy(x=>x.Value).Take(1);

            //var myList = results.ToList();
            //myList.Sort((pair1, pair2) => (pair1.Value.CompareTo(pair2.Value)));

            //var reversedList = myList.ToList();

            //foreach (var item in myList)
            //{
            //    reversedList.Insert(0, item);
            //}

            //string first = reversedList[0].Key.ToString();
            //string second = reversedList[1].Key.ToString();
            //string third = reversedList[2].Key.ToString();

            //Console.WriteLine($"1st place: {first}");
            //Console.WriteLine($"2nd place: {second}");
            //Console.WriteLine($"3rd place: {third}");
        }
    }
}
