using System;
using System.Collections.Generic;
using System.Linq;

namespace PE04.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double> products = new Dictionary<string, double>();
            Dictionary<string, double> currProd = new Dictionary<string, double>();

            while (input != "buy")
            {
                string[] elements = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string prodName = elements[0];
                double price = double.Parse(elements[1]);
                int quantity = int.Parse(elements[2]);

                double totalCost = GetTotalCost(currProd, prodName, price, quantity);

                if (products.ContainsKey(prodName))
                {
                    products[prodName] = totalCost;
                }
                else
                {
                    products.Add(prodName, totalCost);

                }

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
        static double GetTotalCost(Dictionary<string, double> currProd, string currProduct, double currPrice, int quantity)
        {
            double price = 0;
            if (currProd.ContainsKey(currProduct))
            {
                currProd[currProduct] += quantity;
                price = currPrice;
            }
            else
            {
                currProd.Add(currProduct, quantity);
                price = currPrice;
            }
            return price * currProd[currProduct];
        }
    }
}
