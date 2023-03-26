using System;

namespace T03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (input)
            {
                case "add":
                    Add(num1, num2);
                    break;
                case "multiply":
                    Multiply(num1, num2);   
                    break;
                case "subtract":
                    Subtract(num1, num2); 
                    break;
                case "divide":
                    Divide(num1, num2);
                    break;
            }
        }

        static void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        static void Subtract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }
        static void Divide(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }
    }
}
