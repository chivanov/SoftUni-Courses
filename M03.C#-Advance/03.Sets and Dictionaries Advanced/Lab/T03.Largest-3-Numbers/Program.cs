using System;
using System.Linq;

namespace T03.Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] orderedArr = numbers.OrderByDescending(x => x).Take(3).ToArray();

            for (int i = 0; i < orderedArr.Length; i++)
            {
                Console.Write($"{orderedArr[i]} ");
            }
        }
    }
}
