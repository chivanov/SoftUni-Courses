using System;

namespace TP06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMonths = int.Parse(Console.ReadLine());

            const double waterBill = 20;
            const double internetBill = 15;
            double electricityBill = 0;
            double otherBill = 0;


            for (int i = 0; i < numberOfMonths; i++)
            {
                double currentElectricityBill = double.Parse(Console.ReadLine());
                electricityBill += currentElectricityBill;
                otherBill += (currentElectricityBill + waterBill + internetBill) + (currentElectricityBill + waterBill + internetBill) * 0.2;

            }


            double waterCost = waterBill * numberOfMonths;
            double internetCost = internetBill * numberOfMonths;

            double total = electricityBill + waterCost + internetCost + otherBill;
            double avarage = total / numberOfMonths;

            Console.WriteLine($"Electricity: {electricityBill:f2} lv");
            Console.WriteLine($"Water: {waterCost:f2} lv");
            Console.WriteLine($"Internet: {internetCost:f2} lv");
            Console.WriteLine($"Other: {otherBill:f2} lv");
            Console.WriteLine($"Average: {avarage:f2} lv");
        }
    }
}
