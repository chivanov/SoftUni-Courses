using System;

namespace T01.NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 7; number < 1000; number += 10)
            {
                Console.WriteLine(number);
            }
        }
    }
}
