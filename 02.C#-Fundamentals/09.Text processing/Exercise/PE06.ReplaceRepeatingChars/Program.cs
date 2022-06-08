using System;
using System.Text;

namespace PE06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];

                if (i == input.Length - 1)
                {
                    sb.Append(currChar);
                }
                else if (currChar != input[i + 1])
                {
                    sb.Append(currChar);
                }
               
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
