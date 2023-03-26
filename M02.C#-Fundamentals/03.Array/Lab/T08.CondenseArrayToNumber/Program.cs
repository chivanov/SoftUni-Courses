using System;
using System.Linq;

namespace T08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firsLength = arrNums.Length;
            
            for (int i = 0; i < firsLength - 1; i++)
            {
                int[] condesedArr = new int[firsLength - 1];

                for (int j = 0; j < arrNums.Length - 1; j++)
                {
                    condesedArr[j] = arrNums[j] + arrNums[j + 1];
                }

                arrNums = condesedArr;  
            }

            Console.WriteLine(arrNums[0]);

        }
    }
}
