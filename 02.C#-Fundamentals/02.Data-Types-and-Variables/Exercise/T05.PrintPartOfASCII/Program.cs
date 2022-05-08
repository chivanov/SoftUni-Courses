using System;

namespace T05.PrintPartOfASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code1 = int.Parse(Console.ReadLine());
            int code2 = int.Parse(Console.ReadLine());



            for (int symbol = code1; symbol <= code2; symbol++)
            {
                char currChar = Convert.ToChar(symbol);              

                Console.Write($"{currChar} ");
            }

        }
    }
}
