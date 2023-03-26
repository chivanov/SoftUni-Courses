using System;
using System.Linq;

namespace E02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);

            string[,] matrix = new string[rows, cols];
            FillMatrixFromConsole(matrix);

            int count = 0;

            //A B B D
            //E B B B
            //I J B B

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if (matrix[row, col] == matrix[row,col+1]
                        && matrix[row,col] == matrix[row+1, col]
                        && matrix[row,col] == matrix[row+1,col+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        private static void FillMatrixFromConsole(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] arr = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
}
