using System;
using System.Linq;

namespace T05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;

            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
            }

            Console.WriteLine($"{evenSum}");
        }
    }
}
