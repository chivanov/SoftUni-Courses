using System;

namespace L07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] jagged = new long[n][];
          
            for (int i = 0; i < n; i++)
            {
                long[] rows = new long[i+1];
                rows[0] = 1;
                rows[i] = 1;
                for (int j = 1; j < i; j++)
                {                
                 
                    rows[j] = jagged[i - 1][j] + jagged[i - 1][j-1];
                }
                jagged[i] = rows;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(String.Join(" ", jagged[i]));
            }
           
        }
    }
}
