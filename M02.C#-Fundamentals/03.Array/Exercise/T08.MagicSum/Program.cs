using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace T08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());
            int iteration = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int num1 = arr[i];
                iteration ++;

                for (int j = iteration; j < arr.Length; j++)
                {
                    int num2 = arr[j];

                    int sum = num1 + num2;

                    if (sum == num)
                    {
                        Console.WriteLine($"{num1} {num2} ");
                    }
                }
            }
        }
    }
}
