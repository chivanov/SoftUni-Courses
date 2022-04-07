using System;

namespace T03DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Депозирана сума – реално число в интервала[100.00 … 10000.00]
            //2.Срок на депозита(в месеци) – цяло число в интервала[1…12]
            //3.Годишен лихвен процент – реално число в интервала[0.00 …100.00]
            double deposit = double.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());
            double anualInterest = double.Parse(Console.ReadLine());

            double interest = deposit * anualInterest / 100;

            double monthlyInterest = interest / 12;

            double totalSum = deposit + depositPeriod * monthlyInterest;
           
            Console.WriteLine(totalSum);


        }
    }
}
