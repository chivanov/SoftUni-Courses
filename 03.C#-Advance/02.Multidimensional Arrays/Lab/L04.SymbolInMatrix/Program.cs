using System;
using System.Linq;

namespace L04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                char[] arr = input.ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            char ch = char.Parse(Console.ReadLine());
            int rowIndex = 0;
            int colIndex = 0;

            bool isFound = false;   

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (!(matrix[row, col] == ch))
                    {
                        continue;
                    }
                    else
                    {
                        isFound = true;
                        rowIndex = row;
                        colIndex = col;
                        break;
                        
                    }
                }
                if (isFound)
                {
                    break;
                }
              
            }
            if (isFound)
            {
                Console.WriteLine($"({rowIndex}, {colIndex})");
            }
            else
            {
                Console.WriteLine($"{ch} does not occur in the matrix");
            }
        }
    }
}
