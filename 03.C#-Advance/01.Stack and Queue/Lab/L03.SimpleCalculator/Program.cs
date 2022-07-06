using System;
using System.Collections.Generic;
using System.Linq;

namespace L03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();
            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int num1 = int.Parse(stack.Pop());
                string operant = stack.Pop();
                int num2 = int.Parse(stack.Pop());

                if (operant == "+")
                {
                   stack.Push((num1 + num2).ToString());
                }
                else if (operant == "-")
                {
                    stack.Push((num1 - num2).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
          
        }
    }
}
