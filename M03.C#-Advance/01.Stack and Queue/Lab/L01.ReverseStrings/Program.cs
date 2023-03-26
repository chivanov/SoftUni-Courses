using System;
using System.Collections.Generic;


namespace L01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            foreach (char ch in text)
            {
                stack.Push(ch);
            }

            //Stack<char> stack = new Stack<char>(text);
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
