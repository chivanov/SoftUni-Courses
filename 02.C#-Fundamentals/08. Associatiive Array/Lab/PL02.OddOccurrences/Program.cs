using System;
using System.Collections.Generic;
using System.Linq;

namespace PL02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (string word in words)
            {
               string wordInLowerCase = word.ToLower();

                if (count.ContainsKey(wordInLowerCase))
                {
                    count[wordInLowerCase] += 1;
                }
                else
                {
                    count.Add(wordInLowerCase, 1);
                }
            
            }
            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }

        }
    }
}
