using System;

namespace T04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                PrintLine(1, i);
                Console.WriteLine();
            }

            for (int i = number; i >= 1; i--)
            {
                PrintLine(1, i);
                Console.WriteLine();
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");

            }
        }
    }
}
