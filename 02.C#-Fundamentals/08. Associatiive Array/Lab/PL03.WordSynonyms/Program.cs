using System;
using System.Collections.Generic;
using System.Linq;
namespace PL03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();    

            char[] chars = text.ToCharArray();

          Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (Char ch in chars)
            {
                if (ch != ' ')
                {
                    if (count.ContainsKey(ch))
                    {
                        count[ch] += 1;
                    }
                    else
                    {
                        count.Add(ch, 1);   
                    }
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        
    }
}
