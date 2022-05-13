using System;
using System.Linq;

namespace T05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] topIntArr = new int[arr.Length];
            int topIntegerIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isTopInteger = true;

                int currNum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];

                    if (currNum <= nextNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntArr[topIntegerIndex] = currNum;
                    topIntegerIndex++;
                }
                
            }

            for (int i = 0; i < topIntegerIndex; i++)
            {
                Console.Write($"{topIntArr[i]} ");
            }
        }
    }
}
