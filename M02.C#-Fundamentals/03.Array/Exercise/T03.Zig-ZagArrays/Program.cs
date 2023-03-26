using System;
using System.Linq;

namespace T03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            int[] arr1 = new int[lines];
            int[] arr2 = new int[lines];

            
            for (int i = 0; i < lines; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int num1 = input[0];
                int num2 = input[1];

                if (i % 2 == 0)
                {
                    arr1[i] = num1;
                    arr2[i] = num2;
                }
                else
                {
                    arr1[i] = num2;
                    arr2[i] = num1;
                }
            }

            Console.Write(String.Join(' ', arr1));
            Console.WriteLine();
            Console.Write(String.Join(' ', arr2));
        }
    }
}
