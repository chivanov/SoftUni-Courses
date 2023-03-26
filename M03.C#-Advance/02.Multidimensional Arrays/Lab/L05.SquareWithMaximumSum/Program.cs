using System;
using System.Linq;

namespace L05.SquareWithMaximumSum
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
            int mxRow = 0;
            int mxCol = 0;
            int maxSum = int.MinValue; 
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col+1] + matrix[row + 1, col] + matrix[row+1, col+1];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        mxRow = row;    
                        mxCol = col;    
                    }
                }
            }

            Console.WriteLine($"{matrix[mxRow, mxCol]} {matrix[mxRow, mxCol+1]}");
            Console.WriteLine($"{matrix[mxRow+1, mxCol]} {matrix[mxRow+1, mxCol+1]}");
            Console.WriteLine(maxSum);

        }

        private static int[] ReadIntArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
