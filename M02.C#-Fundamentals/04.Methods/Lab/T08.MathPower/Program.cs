using System;

namespace T08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaisToPower(@base, power));
        }

        static double RaisToPower (double number, int power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
