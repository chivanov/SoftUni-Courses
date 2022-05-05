using System;

namespace T09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRaws = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int value = 0; value < 2 * numberOfRaws; value++)
            {
                int number = int.Parse(Console.ReadLine());


                if (value < numberOfRaws)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
                
            }

            int difference = Math.Abs(leftSum - rightSum);

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
