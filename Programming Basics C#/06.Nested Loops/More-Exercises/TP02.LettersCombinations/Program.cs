using System;

namespace TP02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());

            int combination = 0;

            for (char letter1 = startLetter; letter1 <= endLetter; letter1++)
            {
                for (char letter2 = startLetter; letter2 <= endLetter;  letter2++)
                {
                    for (char letter3 = startLetter; letter3 <= endLetter; letter3++)
                    {
                        if (letter1 != skipLetter && letter2 != skipLetter && letter3 != skipLetter)
                        {
                            Console.Write($"{letter1}{letter2}{letter3} ");
                            combination++;
                        }
                    }
                }
            }
            Console.WriteLine($"{combination}");
        }
    }
}
