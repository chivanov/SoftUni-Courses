using System;

namespace T07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardAmount = int.Parse(Console.ReadLine());
            int procesorsAmount = int.Parse(Console.ReadLine());
            int ramAmount = int.Parse(Console.ReadLine());

         
            const double videoCardPrice = 250;

            double videoCardCost = videoCardAmount * videoCardPrice;

            double procesorPrice = videoCardCost * 0.35;
            double ramPrice = videoCardCost * 0.10;

            double procesorsCost = procesorsAmount * procesorPrice;
            double ramCost = ramAmount * ramPrice;

            double totalSum = videoCardCost + procesorsCost + ramCost;

            if (videoCardAmount > procesorsAmount)
            {
                totalSum -= totalSum * 0.15;
            }

            double difference = Math.Abs(budget - totalSum);
            
            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {difference:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:F2} leva more!");
            }
        }
    }
}
