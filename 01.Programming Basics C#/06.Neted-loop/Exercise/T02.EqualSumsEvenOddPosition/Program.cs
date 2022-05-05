using System;

namespace T02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            for (int num = firstNumber; num <= lastNumber; num++)
            {
                int currNum = num;
                int evenSum = 0;
                int oddSum = 0;
                int count = 0;

                while (currNum != 0)
                {
                    int digit = currNum % 10;
                    if (count % 2 == 0 )
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currNum /= 10;
                    count++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{num} ");
                }
            } 
        }
    }
}
