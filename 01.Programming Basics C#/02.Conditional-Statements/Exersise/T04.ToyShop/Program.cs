using System;

namespace T04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {

            double tripPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzels = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            const double puzzelsPrice = 2.60;
            const double dollsPrice = 3.00;
            const double bearsPrice = 4.10;
            const double minionsPrice = 8.20;
            const double trucksPrice = 2.00;
    


            int totalToys = numberOfPuzzels + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;

            double totalSum = numberOfPuzzels * puzzelsPrice + numberOfDolls * dollsPrice + numberOfBears * bearsPrice + numberOfMinions * minionsPrice + numberOfTrucks * trucksPrice;

            if (totalToys >= 50)
            {
                totalSum -= totalSum * 0.25;
            }
            double finalSum = totalSum * 0.9;
            double difference = Math.Abs (finalSum - tripPrice);

            if (finalSum >= tripPrice)
            {
                //Yes! { оставащите пари} lv left."
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! { difference:F2} lv needed.");
            }
        }
    }
}
