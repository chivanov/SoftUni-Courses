using System;

namespace T03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRaws = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int number = 1; number <= numberOfRaws; number++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }            
            double p1Percent = (double)p1 / numberOfRaws * 100;
            double p2Percent = (double)p2 / numberOfRaws * 100;
            double p3Percent = (double)p3 / numberOfRaws * 100;
            double p4Percent = (double)p4 / numberOfRaws * 100;
            double p5Percent = (double)p5 / numberOfRaws * 100;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
            Console.WriteLine($"{p4Percent:f2}%");
            Console.WriteLine($"{p5Percent:f2}%");
        }

    }
}
