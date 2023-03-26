using System;

namespace T06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < num; i++)
            {
                char firsChar = (char)('a' + i);
                for (int j = 0; j < num; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int k = 0; k < num; k++)
                    {
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firsChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
