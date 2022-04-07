using System;

namespace T09FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Дължина в см – цяло число в интервала[10 … 500]
            //2.Широчина в см – цяло число в интервала[10 … 300]
            //3.Височина в см – цяло число в интервала[10… 200]
            //4.Процент  – реално число в интервала[0.000 … 100.000]
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double numPercent = double.Parse(Console.ReadLine());

            int area = lenght * width * height;
            double litters = area * 0.001;
            double percent = numPercent / 100.0;
            double usedArea = litters * (1 - percent);

            Console.WriteLine(usedArea);

        }
    }
}
