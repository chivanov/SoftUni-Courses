using System;

namespace E05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dementions = Console.ReadLine();
            string snake = Console.ReadLine();
            //char[] chars = snake.ToCharArray();
            int rows = int.Parse(dementions.Split()[0]);
            int cols = int.Parse(dementions.Split()[1]);

            char[,] matrix = new char[rows, cols];

            int index = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }

                }

                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }

                }

            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

