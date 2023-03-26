using System;
using System.Linq;
namespace T02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int vowelsCount = CountVowels(word);

            Console.WriteLine(vowelsCount);
        }

        static int CountVowels(string input)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int vowelCount = 0;

            foreach (char ch in input.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
