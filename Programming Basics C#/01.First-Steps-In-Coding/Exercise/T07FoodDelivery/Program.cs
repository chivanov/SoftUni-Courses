using System;

namespace T07FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Брой пилешки менюта – цяло число в интервала[0 … 99]
            //•	Брой менюта с риба – цяло число в интервала[0 … 99]
            //•	Брой вегетариански менюта – цяло число в интервала[0 … 99]
            //•	Пилешко меню –  10.35 лв.
            //•	Меню с риба – 12.40 лв.
            //•	Вегетарианско меню  – 8.15 лв.
            // delivery - 2.50

            int chickenCount = int.Parse(Console.ReadLine());
            int fishCount = int.Parse(Console.ReadLine());
            int vegeterianCount = int.Parse(Console.ReadLine());

            double chickenPrice = chickenCount * 10.35;
            double fishPrice = fishCount * 12.40;
            double vegeterianPrice = vegeterianCount * 8.15;

            double totalPrice = chickenPrice + fishPrice + vegeterianPrice;
            double desert = totalPrice * 0.2;
            double finalPrice = totalPrice + desert + 2.50;

            Console.WriteLine(finalPrice);



        }
    }
}
