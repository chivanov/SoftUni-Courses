using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "2")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    
                }
                else if (input == "3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (input == "4")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }

                }
                else
                {
                    string[] token = input.Split(" ");
                    int num = int.Parse(token[1]);
                    stack.Push(num);
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
