using System;
using System.Text;

namespace T07.RepeatString
{
    internal class Program
    {
        public static StringBuilder StringBuilder { get; private set; }

        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            int repiet = int.Parse(Console.ReadLine());

            Console.WriteLine(RepietString(stringInput, repiet));
        }

        static string RepietString(string input, int repiets)
        {
            string newString = String.Empty;

            for (int i = 0; i < repiets; i++)
            {
                newString += input;
            }

            return newString;
        }

    }
}
