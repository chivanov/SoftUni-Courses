using System;

namespace T04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageOfLily = int.Parse(Console.ReadLine());
            double priceOfLaundry = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());

            int money = 0;
            int toys = 0;
            int totalMoney = 0;

            for (int i = 1; i <= ageOfLily; i++)
            {
                money += 5;
                if (i % 2 == 0)
                {                    
                    totalMoney += money - 1;
                }
                else
                {
                    toys++;
                }
            }
            double moneyFromToys = toys * priceOfToy;
            double totalSum = totalMoney + moneyFromToys;
            double difference = Math.Abs(totalSum - priceOfLaundry);
            if (totalSum >= priceOfLaundry)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
                Console.WriteLine($"No! {difference:f2}");
            }
        }
    }
}
