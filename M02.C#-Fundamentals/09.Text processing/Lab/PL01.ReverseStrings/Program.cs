using System;
using System.Linq;

namespace PL01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                //string reversedWord = string.Empty;

                char[] word = command.ToCharArray();
                Array.Reverse(word);
                string reversedWord = new string(word);
                //for (int i = word.Length - 1; i >= 0; i--)
                //{
                //    reversedWord += word[i];
                //}
                Console.WriteLine($"{command} = {reversedWord}");

                command = Console.ReadLine();
            }

        }
    }
}
