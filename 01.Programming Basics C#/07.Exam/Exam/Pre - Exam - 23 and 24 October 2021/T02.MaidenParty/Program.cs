using System;

namespace T02.MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Цена на моминското парти - реално число в интервала[1.00 … 10000.00]
            //2.Брой любовни послания -цяло число в интервала[0… 1000]
            //3.Брой восъчни рози -цяло число в интервала[0 … 1000]
            //4.Брой ключодържатели - цяло число в интервала[0 … 1000]
            //5.Брой карикатури - цяло число в интервала[0 … 1000]
            //6.Брой късмети изненада -цяло число в интервала[0 … 1000]

            double partyPrice = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keychains  =int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int luckSurprise = int.Parse(Console.ReadLine());

            //•	Любовно послание -0.60 лв.
            //•	Восъчна роза -7.20 лв.
            //•	Ключодържател - 3.60 лв.
            //•	Карикатура - 18.20 лв.
            //•	Късмет изненада -22 лв.

            int totalArticules = loveMessages + waxRoses + keychains + caricatures + luckSurprise;

            double totalSum = loveMessages * 0.60 + waxRoses * 7.20 + keychains * 3.60 + caricatures * 18.20 + luckSurprise * 22;

            if (totalArticules >= 25)
            {
                totalSum *= 0.65;
            }

            double finalSum = totalSum * 0.9;

            if (finalSum >= partyPrice)
            {
            Console.WriteLine($"Yes! {finalSum - partyPrice:f2} lv left.");

            }
            else
            {
                Console.WriteLine($"Not enough money! {partyPrice - finalSum:f2} lv needed.");
            }  
        }
    }
}
