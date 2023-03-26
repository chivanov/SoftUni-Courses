using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charCollection = new Dictionary<char, int>();

            foreach (var ch in text)
            {
                if (!charCollection.ContainsKey(ch))
                {
                    charCollection.Add(ch, 1);
                }
                else
                {
                    charCollection[ch]++;   
                }
            }
            var sorted = charCollection.OrderBy(x => x.Key);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
