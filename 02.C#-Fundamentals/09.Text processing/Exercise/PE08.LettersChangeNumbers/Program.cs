using System;
using System.Linq;

namespace PE08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            foreach (string word in text)
            {
                sum += GetCurrWordSum(word);
            }
          
            Console.WriteLine($"{sum:f2}");
        }

        static decimal GetCurrWordSum(string word)
        {
            decimal sum = 0;
            char startChar = word[0];
            char endChar = word[word.Length - 1];

            string num = word.Substring(1, word.Length - 2);
            int number = int.Parse(num);

            int startCharPossition = GetAphabeticalOrderOfLetter(startChar);
            int endCharPossition = GetAphabeticalOrderOfLetter(endChar);

            if (char.IsUpper(startChar))
            {               
                sum = (decimal)number / startCharPossition;
            }
            else if (char.IsLower(startChar))
            {                
                sum = (decimal)number * startCharPossition;
            }

            if (char.IsUpper(endChar))
            {               
                sum -= endCharPossition;
            }
            else if (char.IsLower(endChar))
            {               
                sum += endCharPossition;
            }

            return sum;
        }

        static int GetAphabeticalOrderOfLetter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return -1;
            }
            char chLowerCase = char.ToLowerInvariant(ch);  
            return (int)chLowerCase - 96;
        }
    }
}
