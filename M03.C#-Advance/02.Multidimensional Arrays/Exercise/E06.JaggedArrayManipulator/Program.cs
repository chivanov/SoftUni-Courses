using System;
using System.Linq;

namespace E06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];
            FillJaggedArrayFromConsole(rows, jagged);

            for (int row = 0; row < rows-1; row++)
            {
                if (jagged[row].Length == jagged[row+1].Length)
                {
                    jagged[row] = jagged[row].Select(el => el * 2).ToArray();
                    jagged[row+1] = jagged[row+1].Select(el => el * 2).ToArray();
                }
                else
                {
                    jagged[row] = jagged[row].Select(el => el / 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(el => el / 2).ToArray();
                }
            }
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);    
                int value = int.Parse(command.Split()[3]);  

                if (command.Split()[0]=="add")
                {
                    if (row >= 0 && row < rows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (command.Split()[0] == "subtract")
                {
                    if (row >= 0 && row < rows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

      
        private static void FillJaggedArrayFromConsole(int rows, int[][] jagged)
        {
            for (int i = 0; i < rows; i++)
            {
                int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jagged[i] = arr;
            }
        }
    }
}
