using System;

namespace T05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int operationOne = Sum(number1, number2);

            Console.WriteLine(Subtracts(operationOne, number3));
        }

        static int Sum(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        static int Subtracts(int operation1, int num3)

        {
            int substracts = operation1 - num3;
            return substracts;  
        }




    }
}
