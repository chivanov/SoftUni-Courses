using System;
using System.Linq;

namespace L02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadIntArrayFromConsole();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = ReadIntArrayFromConsole();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }

        }

        private static int[] ReadIntArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(new String[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
