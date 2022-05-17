using System;

namespace T03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());

            PrintCharacter(startSymbol, endSymbol);

        }

        static void PrintCharacter(char start, char end)
        {
            int firstChar = Math.Min(start, end);
            int endChar = Math.Max(start, end);

            for (int i = firstChar+1; i < endChar; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
            Console.WriteLine();
        }

    }
}
