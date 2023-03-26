using System;

namespace T05.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            double filmBudget = double.Parse(Console.ReadLine());
            int numberOfStatemen = int.Parse(Console.ReadLine());
            double priceOfClothesPerStatemen = double.Parse(Console.ReadLine());

            double priceOfDecor = filmBudget * 0.1;
            double priceOfAllClothes = numberOfStatemen * priceOfClothesPerStatemen;

            if (numberOfStatemen > 150)
            {
                priceOfAllClothes -= priceOfAllClothes * 0.1;
            }

            double neededMoney = priceOfDecor + priceOfAllClothes;
            double difference = Math.Abs(neededMoney - filmBudget);

            if (neededMoney > filmBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }

        }
    }
}
