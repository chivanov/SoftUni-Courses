using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            string token = Console.ReadLine();

            while (token != "Revision")
            {
                string shop = token.Split(", ")[0];
                string product = token.Split(", ")[1];
                double price = double.Parse(token.Split(", ")[2]);
                FillNestedDictionary(shops, shop, product, price);

                token = Console.ReadLine();
            }

            var orderedShops = shops.OrderBy(s => s.Key).ToDictionary(x=>x.Key, x=>x.Value);

            foreach (var shop in orderedShops)
            {
                Console.WriteLine($"{shop.Key}->");
                var products = shop.Value;
                foreach (var item in products)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
               
            }
        }

        private static void FillNestedDictionary(Dictionary<string, Dictionary<string, double>> shops, string shop, string product, double price)
        {
            if (!shops.ContainsKey(shop))
            {
                shops.Add(shop, new Dictionary<string, double>());

            }
            shops[shop].Add(product, price);
        }
    }
}
