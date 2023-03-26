using System;
using System.Linq;

namespace L03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = ReadIntArrayFromConsole();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
                sum += matrix[row, row];
            }
           
            Console.WriteLine(sum);
        }

        private static int[] ReadIntArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }

   
}
