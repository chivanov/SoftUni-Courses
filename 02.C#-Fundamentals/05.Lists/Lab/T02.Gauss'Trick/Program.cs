using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> output = new List<int>();

            for (int i = 0; i < numbers.Count/2; i++)
            {
                int newNumber = numbers[i] + numbers[numbers.Count - 1 - i];
                output.Add(newNumber);

            }
                if (numbers.Count % 2 != 0)
                {
                    output.Add(numbers[numbers.Count / 2]);
                }

            Console.WriteLine(String.Join(' ', output));
        }
    }
}
