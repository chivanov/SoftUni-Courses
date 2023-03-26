using System;

namespace T01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int sumNum1Num2 = number1 + number2;
            int operation2 = sumNum1Num2 / number3;
            int operation3 = operation2 * number4;

            Console.WriteLine($"{operation3}");

        }
    }
}
