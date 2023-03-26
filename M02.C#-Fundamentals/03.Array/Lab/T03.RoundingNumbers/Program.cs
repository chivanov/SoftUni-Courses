using System;
using System.Linq;

namespace T03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{(decimal)arr[i]} => {Math.Round((decimal)arr[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
