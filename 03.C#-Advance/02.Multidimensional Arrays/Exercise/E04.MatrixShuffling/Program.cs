using System;
using System.Linq;

namespace E04.MatrixShuffling
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

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                if (IsValid(command, matrix, rows, cols))
                {
                    int row1 = int.Parse(command.Split()[1]);
                    int col1 = int.Parse(command.Split()[2]);
                    int row2 = int.Parse(command.Split()[3]);
                    int col2 = int.Parse(command.Split()[4]);

                    string num1 = matrix[row1, col1];
                    string num2 = matrix[row2, col2];

                    matrix[row1, col1] = num2;
                    matrix[row2, col2] = num1;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine().ToLower();
                    continue;
                }


                command = Console.ReadLine().ToLower();
            }
        }

        private static bool IsValid(string command, string[,] matrix, int rows, int cols)
        {

            string cmd = command.Split()[0];

            if (cmd == "swap" && command.Split().Length == 5)
            {
                int rowIndex1 = int.Parse(command.Split()[1]);
                int colIndex1 = int.Parse(command.Split()[2]);
                int rowIndex2 = int.Parse(command.Split()[3]);
                int colIndex2 = int.Parse(command.Split()[4]);
                if (rowIndex1 >= 0 && rowIndex1 < rows
                               && colIndex1 >= 0 && colIndex1 < cols
                               && rowIndex2 >= 0 && rowIndex2 < rows
                               && colIndex2 >= 0 && colIndex2 < cols)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            else
            {
                return false;
            }
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
