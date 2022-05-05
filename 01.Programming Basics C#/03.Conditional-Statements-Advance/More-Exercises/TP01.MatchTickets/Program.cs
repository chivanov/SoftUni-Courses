using System;
class HelloWorld
{
    static void Main()
    {
        const double VIPTicketPrice = 499.99;
        const double NormalTicketPrice = 249.99;

        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int numberOfPeople = int.Parse(Console.ReadLine());
        double moneyFofTransport = 0;

        if (numberOfPeople >= 1 && numberOfPeople <= 4)
        {
            moneyFofTransport = budget * 0.75;
        }
        else if (numberOfPeople >= 5 && numberOfPeople <= 9)
        {
            moneyFofTransport = budget * 0.60;
        }
        else if (numberOfPeople >= 10 && numberOfPeople <= 24)
        {
            moneyFofTransport = budget * 0.50;
        }
        else if (numberOfPeople >= 25 && numberOfPeople <= 49)
        {
            moneyFofTransport = budget * 0.40;
        }
        else if (numberOfPeople >= 50)
        {
            moneyFofTransport = budget * 0.25;
        }

        double ticketBudget = budget - moneyFofTransport;

        double ticketMoneyNeeded = 0;
        if (category == "VIP")
        {
            ticketMoneyNeeded = numberOfPeople * VIPTicketPrice;
        }
        else
        {
            ticketMoneyNeeded = numberOfPeople * NormalTicketPrice;
        }
        double difference = Math.Abs(ticketBudget - ticketMoneyNeeded);

        if (ticketBudget >= ticketMoneyNeeded)
        {
            Console.WriteLine($"Yes! You have {difference:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {difference:F2} leva.");
        }
    }
}

