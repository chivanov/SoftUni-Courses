using System;

namespace T06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (minNumber > num)
                {
                    minNumber = num;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{minNumber}");
        }
    }
}
