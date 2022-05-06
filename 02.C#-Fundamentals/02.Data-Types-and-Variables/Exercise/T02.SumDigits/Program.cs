using System;

namespace T02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                char currCh = number[i];
                int currDigit = (int)currCh - 48;                            

                sum += currDigit;
            }

            Console.WriteLine($"{sum}");

        }
    }
}
