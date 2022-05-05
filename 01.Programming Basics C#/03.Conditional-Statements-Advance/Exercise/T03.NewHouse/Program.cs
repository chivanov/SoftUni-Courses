using System;
class HelloWorld
{
    static void Main()
    {
        string floursType = Console.ReadLine();
        int numberOFlouers = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        const double rosePrice = 5.00;
        const double dahliasPrice = 3.80;
        const double tulipPrice = 2.80;
        const double narcissPrice = 3.00;
        const double gladiolusPrice = 2.50;
        double totalCost = 0;

        if (floursType == "Roses")
        {
            totalCost = numberOFlouers * rosePrice;
            if (numberOFlouers > 80)
            {
                totalCost -= totalCost * 0.1;
            }
        }
        else if (floursType == "Dahlias")
        {
            totalCost = numberOFlouers * dahliasPrice;
            if (numberOFlouers > 90)
            {
                totalCost -= totalCost * 0.15;
            }
        }
        else if (floursType == "Tulips")
        {
            totalCost = numberOFlouers * tulipPrice;
            if (numberOFlouers > 80)
            {
                totalCost -= totalCost * 0.15;
            }
        }
        else if (floursType == "Narcissus")
        {
            totalCost = numberOFlouers * narcissPrice;
            if (numberOFlouers < 120)
            {
                totalCost += totalCost * 0.15;
            }
        }
        else if (floursType == "Gladiolus")
        {
            totalCost = numberOFlouers * gladiolusPrice;
            if (numberOFlouers < 80)
            {
                totalCost += totalCost * 0.20;
            }
        }
        double difference = Math.Abs(budget - totalCost);
        if (budget >= totalCost)
        {
            Console.WriteLine($"Hey, you have a great garden with {numberOFlouers} {floursType} and {difference:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
        }


    }
}

