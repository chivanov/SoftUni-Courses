using System;

namespace T05SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int countPens = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            int cleaning = int.Parse(Console.ReadLine());
            int percents = int.Parse(Console.ReadLine());

            const double pensPrice = 5.80;
            const double markersPrice = 7.20;
            const double cleaningPrice = 1.20;

            double pricePerPens = countPens * pensPrice;
            double pricePerMarkers = countMarkers * markersPrice;
            double pricePerCleaning = cleaning * cleaningPrice;
            double percent = percents / 100.0;
            double totalPrice = pricePerPens + pricePerMarkers + pricePerCleaning;
            double finalPrice = totalPrice - (percent * totalPrice);

            Console.WriteLine(finalPrice);

        }
    }
}
