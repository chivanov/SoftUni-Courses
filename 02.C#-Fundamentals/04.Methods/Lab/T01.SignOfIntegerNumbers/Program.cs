using System;

namespace T01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SignOfIntegerNumbers(num);
        }

        static void SignOfIntegerNumbers(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
