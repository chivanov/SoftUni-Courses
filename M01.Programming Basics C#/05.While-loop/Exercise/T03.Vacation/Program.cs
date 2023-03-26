using System;

namespace T03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripNeededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int spentCounter = 0;
            int daysCounter = 0;


            while (spentCounter != 5)
            {
                string activities = Console.ReadLine();
                double moneySpendOrSafe = double.Parse(Console.ReadLine());
                daysCounter++;

                if (activities == "save")
                {
                    availableMoney += moneySpendOrSafe;
                    spentCounter = 0;
                }
                else if (activities == "spend")
                {
                    spentCounter++;
                    if (moneySpendOrSafe > availableMoney)
                    {
                        availableMoney = 0;
                    }
                    else
                    {
                        availableMoney -= moneySpendOrSafe;
                    }
                }

                if (availableMoney >= tripNeededMoney)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                    break;
                }
            }
            if (spentCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }


        }
    }
}
