using System;

namespace TP01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int AGE = 18;

            double spendMoney = 0;

            for (int value = 1800; value <= year; value++)
            {
                if (value % 2 == 0)
                {
                    spendMoney += 12000;
                }
                else
                {
                    spendMoney += 12000 + (AGE * 50);
                }
                AGE += 1; 
            }
            
            if (money >= spendMoney)
            {
                double leftMOney = money - spendMoney;
                Console.WriteLine($"Yes! He will live a carefree life and will have {leftMOney:f2} dollars left.");
            }
            else
            {
                double needMoney = spendMoney - money;
                Console.WriteLine($"He will need {needMoney:f2} dollars to survive.");
            }

        }
    }
}
