using System;

namespace T02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRaws = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < numberOfRaws; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            int finalSum = sum - maxNumber;
            int difference = Math.Abs(finalSum - maxNumber);
            if (finalSum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {finalSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
