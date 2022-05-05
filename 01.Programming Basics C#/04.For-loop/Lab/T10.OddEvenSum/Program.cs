using System;

namespace T10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRaws = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int value = 1; value <= numberOfRaws; value++)
            {
                int number = int.Parse(Console.ReadLine());

                if (value % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }

            }
            int difference = Math.Abs(evenSum - oddSum);
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
