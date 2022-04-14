using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            string progection = Console.ReadLine();
            int raws = int.Parse(Console.ReadLine());
            int coloms = int.Parse(Console.ReadLine());

            int totalSeats = raws * coloms;
            double price = 0;

            switch (progection)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;

            }
            double income = totalSeats * price;
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
