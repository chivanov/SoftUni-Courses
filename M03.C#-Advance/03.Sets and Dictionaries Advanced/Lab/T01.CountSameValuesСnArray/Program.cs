using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.CountSameValuesСnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-2.5 4 3 - 2.5 - 5.5 4 3 3 - 2.5 3
            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            foreach (var item in input)
            {
                if (!numbers.ContainsKey(item))
                {
                    numbers.Add(item, 1);
                }
                else
                {
                    numbers[item]++;
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
