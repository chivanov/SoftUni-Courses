using System;

namespace T08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double result = (CalculateFactorialOne(numberOne)) / (CalculateFactorialTwo(numberTwo));

            Console.WriteLine($"{result:f2}");
        }

        static double CalculateFactorialOne(double number)
        {
            double fact1 = 1;
            for (int i = 1; i <= number; i++)
            {
                fact1 *= i;
            }
            return fact1;
        }
        static double CalculateFactorialTwo(double number)
        {
            double fact2 = 1;
            for (int i = 1; i <= number; i++)
            {
                fact2 *= i;
            }
            return fact2;
        }
    }
}
