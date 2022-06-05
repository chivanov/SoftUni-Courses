using System;
using System.Collections.Generic;
using System.Linq;

namespace PL01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            SortedDictionary<int, int> result = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (result.ContainsKey(number))
                {
                    result[number] += 1;
                }
                else
                {
                    result.Add(number, 1);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
