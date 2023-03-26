using System;

namespace PL03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(word))
            {
               int startIndex = text.IndexOf(word);
               text = text.Remove(startIndex, word.Length);
            }
            Console.WriteLine(text);
        }
    }
}
