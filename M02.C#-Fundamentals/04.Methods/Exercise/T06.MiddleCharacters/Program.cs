using System;

namespace T06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine(PringMIdCharacter(word));

        }

        static string PringMIdCharacter(string word)
        {
            int length = word.Length;

            string result = string.Empty;

            if (length % 2 != 0)
            {
                result = word[word.Length / 2].ToString();
            }
            else
            {
                result = word[word.Length / 2 - 1].ToString() + word[word.Length / 2].ToString();
            }

            return result;
        }

    }
}
