using System;

namespace TP05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentnum = int.Parse(Console.ReadLine());
                
                sum += currentnum;
            }

            double avarage = sum / n;
            Console.WriteLine($"{avarage:f2}");
        }
    }
}
