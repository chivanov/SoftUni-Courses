using System;
using System.Collections.Generic;

namespace L04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    indexes.Push(i);    
                }
                else if (text[i] == ')')
                {
                    int endIndex = i;
                    int startIndex = indexes.Pop();
                    string substring = text.Substring(startIndex, endIndex-startIndex+1 );
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
