using System;

namespace T06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int maxNumber = int.MinValue;
            
            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (maxNumber < num)
                {
                    maxNumber = num;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{maxNumber}");
        }
    }
}
