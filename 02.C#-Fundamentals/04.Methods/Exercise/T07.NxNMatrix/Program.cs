using System;

namespace T07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrix(number);
        }

        static void PrintMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {                
                for (int row = 0; row < number; row++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }

          
        }
    }
}
