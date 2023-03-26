using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> evenNumbers = new Queue<int>();

            foreach (var digit in numbers)
            {
                if (digit % 2 == 0)
                {
                    evenNumbers.Enqueue(digit);
                }
            }

            Console.Write(String.Join(", ", evenNumbers));

        }
    }
}
