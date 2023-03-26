using System;

namespace T05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string products = Console.ReadLine();

            int productQuantity = int.Parse(Console.ReadLine());

            switch (products)
            {
                case "coffee":
                    PrintCostOfCoffee(productQuantity);
                    break;
                case "water":
                    PrintCostOfWater(productQuantity);
                    break;
                case "coke":
                    PrintCostOfCoke(productQuantity);
                    break;
                case "snacks":
                    PrintCostOfSnacks(productQuantity); 
                    break;
            }

        }

        static void PrintCostOfCoffee(int quantity, double price = 1.50)
        {
            Console.WriteLine($"{(quantity * price):f2}");
        }

        static void PrintCostOfWater(int quantity, double price = 1.0)
        {
            Console.WriteLine($"{(quantity * price):f2}");
        }

        static void PrintCostOfCoke(int quantity, double price = 1.40)
        {
            Console.WriteLine($"{(quantity * price):f2}");
        }
        static void PrintCostOfSnacks(int quantity, double price = 2.00)
        {
            Console.WriteLine($"{(quantity * price):f2}");
        }
    }

}
