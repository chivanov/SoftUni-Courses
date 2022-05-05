using System;

namespace TP02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int sum = 0;
            int cashCounter = 0;
            int cardCounter = 0;
            int moneyCash = 0;
            int moneyCard = 0;
            int numberOfPayments = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {
                numberOfPayments++;
                currentSum = int.Parse(input);

                if (numberOfPayments % 2 != 0)
                {
                    if (currentSum > 100)
                    {
                        Console.WriteLine("Error in transaction!");

                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        moneyCash += currentSum;
                        cashCounter++;
                        sum += currentSum;
                    }

                }
                else
                {
                    if (currentSum < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        moneyCard += currentSum;
                        cardCounter++;
                        sum += currentSum;
                    }
                }
                if (sum >= totalSum)
                {
                    double percentCash = 1.0 * moneyCash / cashCounter;
                    double percentCard = 1.0 * moneyCard / cardCounter;
                    Console.WriteLine($"Average CS: {percentCash:f2}");
                    Console.WriteLine($"Average CC: {percentCard:f2}");
                    break;
                }

                input = Console.ReadLine();

            }
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }


        }
    }
}
