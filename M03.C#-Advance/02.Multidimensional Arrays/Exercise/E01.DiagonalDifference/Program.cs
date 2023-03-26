using System;
using System.Linq;

namespace E01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            FillMatrixFromConsole(matrix);

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int num = matrix[row, col];
                    if (row == col)
                    {
                        primaryDiagonal += num;
                    }
                    else if (row + col == n-1)
                    {
                        secondaryDiagonal += num;
                    }
                }
            }
            Console.WriteLine($"{Math.Abs(primaryDiagonal - secondaryDiagonal)}");
        }

        private static void FillMatrixFromConsole(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
}
