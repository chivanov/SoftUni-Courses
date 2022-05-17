using System;

namespace T01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCoubt = 3;

            PrintSmallestNumber(numberCoubt);
        }

        static void PrintSmallestNumber(int number)
        {
            int theSmall = int.MaxValue;
            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < theSmall)
                {
                    theSmall = num;
                }
            }
            Console.WriteLine(theSmall);    
        }
    }
}
