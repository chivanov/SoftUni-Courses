using System;

namespace T03DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< .mine
           
=======
          
>>>>>>> .theirs
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
