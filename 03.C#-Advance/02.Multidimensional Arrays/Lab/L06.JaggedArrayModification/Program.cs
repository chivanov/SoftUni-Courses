using System;
using System.Linq;

namespace L06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];  
            for (int row = 0; row < n; row++)
            {
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jagged[row] = arr;
            }

            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                string[] token = input.Split(' ');
                int row = int.Parse(token[1]);
                int col = int.Parse(token[2]);  
                int value = int.Parse(token[3]);

                if (token[0] == "add")
                {
                    if (IsValid(jagged, row, col))
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    
                }
                else if (token[0] == "subtract")
                {
                    if (IsValid(jagged, row, col))
                    {
                        jagged[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                
                input = Console.ReadLine().ToLower();
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

        private static bool IsValid(int[][] jagged, int row, int col)
        {
            if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
