using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PE1.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[>]{2}(?<furniture>[A-Z]+[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

            string input = Console.ReadLine();
            List<string> furnitureBought = new List<string>();  
           double totalMoneyStent = 0;  

            while (input != "Purchase")
            {
                Match currMatch = Regex.Match(input, pattern);

                if (currMatch.Success)
                {
                    string furnitureName = currMatch.Groups["furniture"].Value;
                    double price = double.Parse(currMatch.Groups["price"].Value);
                    int quantity = int.Parse(currMatch.Groups["quantity"].Value);

                    furnitureBought.Add(furnitureName);
                    totalMoneyStent += GetTotalMOneySpent(price, quantity);
                }
                
                input = Console.ReadLine();
            }

            PrintOutput(furnitureBought, totalMoneyStent);

        }

        static void PrintOutput(List<string> furnitureBought, double totalMoneyStent)
        {
            Console.WriteLine("Bought furniture:");
            foreach (var item in furnitureBought)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalMoneyStent:f2}");
        }

        static double GetTotalMOneySpent(double price, int quantity)
        {
            
           return price * quantity;
        }
    }
}
