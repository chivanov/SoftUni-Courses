using System;
using System.Text;

namespace PE04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char currChar in text)
            {
                int currPosition = currChar;
                currPosition += 3;
                sb.Append((char)currPosition);
            }

            Console.WriteLine(sb);
        }
    }
}
