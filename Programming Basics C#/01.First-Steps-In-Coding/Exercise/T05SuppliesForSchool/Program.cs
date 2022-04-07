using System;

namespace T05SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Брой пакети химикали - цяло число в интервала[0...100]
            // •	Брой пакети маркери - цяло число в интервала[0...100]
            // •	Литри препарат за почистване на дъска -цяло число в интервала[0…50]
            // •	Процент намаление -цяло число в интервала[0...100]
            int countPens = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            int cleaning = int.Parse(Console.ReadLine());
            int percents = int.Parse(Console.ReadLine());

            //•	Пакет химикали -5.80 лв.
            //•	Пакет маркери -7.20 лв.
            //•	Препарат - 1.20 лв(за литър)

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
