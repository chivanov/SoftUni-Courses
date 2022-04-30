using System;

namespace T03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int validCombinationCounter = 0;
            for (int x1 = 0; x1 <= number; x1++)
            {
                for (int x2 = 0; x2 <= number; x2++)
                {
                    for (int x3 = 0; x3 <= number; x3++)
                    {
                        if (x1 + x2 + x3 == number)
                        {
                            validCombinationCounter ++;
                        }
                    }
                }
            }
            Console.WriteLine($"{validCombinationCounter}");
        }
    }
}
