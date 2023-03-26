using System;

namespace T06Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
         

            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());


            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = (paint + paint * 0.10) * 14.50;
            double thinnerPrice = thinner * 5.00;
            double matherialPrice = nylonPrice + paintPrice + thinnerPrice + 0.40;

            double workerPrice = (matherialPrice * 0.3) * workingHours;
            double finalPrice = matherialPrice + workerPrice;

            Console.WriteLine(finalPrice);
        }
    }
}
