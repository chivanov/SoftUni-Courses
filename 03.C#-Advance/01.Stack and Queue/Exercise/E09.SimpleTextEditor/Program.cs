using System;
using System.Collections.Generic;
using System.Text;

namespace E09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder(); 
            Stack<string> stack = new Stack<string>();  
            for (int i = 0; i < n; i++)
            {
                string cmdInfo = Console.ReadLine();
                if (cmdInfo.StartsWith('1'))
                {
                    stack.Push(sb.ToString());
                    sb.Append(cmdInfo.Split()[1]);
                }
                else if (cmdInfo.StartsWith('2'))
                {
                    stack.Push(sb.ToString());
                    int count = int.Parse(cmdInfo.Split()[1]);   
                    sb.Remove(sb.Length-count, count);
                }
                else if (cmdInfo.StartsWith('3'))
                {
                    int index = int.Parse(cmdInfo.Split()[1]);
                    Console.WriteLine(sb[index-1]);
                }
                else if (cmdInfo.StartsWith('4'))
                {
                    sb = new StringBuilder(stack.Pop());   
                }
            }
        }
    }
}
