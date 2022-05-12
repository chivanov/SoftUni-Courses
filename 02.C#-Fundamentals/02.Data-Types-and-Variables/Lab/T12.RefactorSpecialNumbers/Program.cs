using System;

namespace T12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int currNum = 0;
            bool isSpecial = false;
            for (int num = 1; num <= number; num++)
            {
                currNum = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currNum, isSpecial);
                sum = 0;
                num = currNum;
            }

        }
    }
}
