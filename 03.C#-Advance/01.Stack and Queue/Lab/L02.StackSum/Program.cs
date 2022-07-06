using System;
using System.Collections.Generic;
using System.Linq;

namespace L02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); 
            Stack<int> stack = new Stack<int>();

            foreach (int num in numbers)
            {
                stack.Push(num);
            }
            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdInfo[0])
                {
                    case("add"):
                        int num1 = int.Parse(cmdInfo[1]);   
                        int num2 = int.Parse(cmdInfo[2]);   
                        stack.Push(num1);   
                        stack.Push(num2);   
                        break;
                    case ("remove"):
                        int count = int.Parse(cmdInfo[1]);
                        if (stack.Count >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");        
        }
    }
}
