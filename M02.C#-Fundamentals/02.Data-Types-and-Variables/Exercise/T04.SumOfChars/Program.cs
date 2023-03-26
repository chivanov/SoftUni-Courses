using System;

namespace T04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int charCode = (int)character;

                sum += charCode;
            }

            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
