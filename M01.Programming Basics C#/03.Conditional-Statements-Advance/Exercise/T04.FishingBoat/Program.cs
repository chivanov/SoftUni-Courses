using System;
class HelloWorld
{
    static void Main()
    {
        int budget = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        double numberOfFishmen = double.Parse(Console.ReadLine());

        const int springTax = 3000;
        const int summerAutumnTax = 4200;
        const int wintertax = 2600;
        double totalCost = 0;

        if (season == "Spring")
        {
            totalCost = springTax;
            if (numberOfFishmen <= 6)
            {
                totalCost -= totalCost * 0.1;
            }
            else if (numberOfFishmen > 6 && numberOfFishmen <= 11)
            {
                totalCost -= totalCost * 0.15;
            }
            else
            {
                totalCost -= totalCost * 0.25;
            }
        }
        else if (season == "Summer" || season == "Autumn")
        {
            totalCost = summerAutumnTax;
            if (numberOfFishmen <= 6)
            {
                totalCost -= totalCost * 0.1;
            }
            else if (numberOfFishmen > 6 && numberOfFishmen <= 11)
            {
                totalCost -= totalCost * 0.15;
            }
            else
            {
                totalCost -= totalCost * 0.25;
            }
        }
        else if (season == "Winter")
        {
            totalCost = wintertax;
            if (numberOfFishmen <= 6)
            {
                totalCost -= totalCost * 0.1;
            }
            else if (numberOfFishmen > 6 && numberOfFishmen <= 11)
            {
                totalCost -= totalCost * 0.15;
            }
            else
            {
                totalCost -= totalCost * 0.25;
            }
        }

        if (numberOfFishmen % 2 == 0)
        {
            if (season == "Spring" || season == "Summer" || season == "Winter")
            {
                totalCost -= totalCost * 0.05;
            }
        }
        double difference = Math.Abs(budget - totalCost);
        if (budget >= totalCost)
        {
            Console.WriteLine($"Yes! You have {difference:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {difference:F2} leva.");
        }


    }
}


