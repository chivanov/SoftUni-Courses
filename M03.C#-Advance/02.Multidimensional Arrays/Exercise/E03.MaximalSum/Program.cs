using System;
using System.Linq;

namespace E03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);

            int[,] matrix = new int[rows, cols];
            FillMatrixFromConsole(matrix);

            int mxSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > mxSum)
                    {
                        mxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {mxSum}");
            //Console.WriteLine($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]} {matrix[rowIndex, colIndex + 2]}");
            //Console.WriteLine($"{matrix[rowIndex+1, colIndex]} {matrix[rowIndex+1, colIndex + 1]} {matrix[rowIndex+1, colIndex + 2]}");
            //Console.WriteLine($"{matrix[rowIndex+2, colIndex]} {matrix[rowIndex+2, colIndex + 1]} {matrix[rowIndex+2, colIndex + 2]}");
            Console.WriteLine(matrix[rowIndex, colIndex] + " " + matrix[rowIndex, colIndex + 1] + " " + matrix[rowIndex, colIndex + 2]);
            Console.WriteLine(matrix[rowIndex + 1, colIndex] + " " + matrix[rowIndex + 1, colIndex + 1] + " " + matrix[rowIndex + 1, colIndex + 2]);
            Console.WriteLine(matrix[rowIndex + 2, colIndex] + " " + matrix[rowIndex + 2, colIndex + 1] + " " + matrix[rowIndex + 2, colIndex + 2]);

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
