using System;
using System.Collections.Generic;
using System.Linq;
namespace PE01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (letters.ContainsKey(letter))
                    {
                        letters[letter] += 1;
                    }
                    else
                    {
                        letters.Add(letter, 1);
                    }
                }
                
            }

            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> { item.Value}");
            }
        }
    }
}
