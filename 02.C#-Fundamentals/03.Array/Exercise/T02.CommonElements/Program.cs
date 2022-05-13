using System;
using System.Linq;

namespace T02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

             
            for (int i = 0; i < secondArray.Length; i++)
            {
                 string itemTwo = secondArray[i];

                for (int j = 0; j < firstArray.Length; j++) 
                {
                    string itemOne = firstArray[j];
                    if (itemOne == itemTwo)
                    {
                        Console.Write($"{secondArray[i]} ");
                    }
                }
            }

        }
    }
}
