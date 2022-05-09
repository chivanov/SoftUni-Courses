using System;

namespace T07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int totalLiters = 0;
            int capacity = 0;

            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                capacity += input;

                if (capacity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity -= input;
                }
                else
                {
                    totalLiters += input;
                }
                                
            }
            Console.WriteLine(totalLiters);
        }
    }
}
