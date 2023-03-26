using System;
using System.Text.RegularExpressions;

namespace PE03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^%$|.]*?\<(?<product>\w+)\>[^%$|.]*?\|(?<count>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)\$";

            string input = Console.ReadLine();

            decimal totalIncom = 0m;
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
               
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    
                    decimal totalCost = count * price;
                    totalIncom += totalCost;

                    Console.WriteLine($"{name}: {product} - {totalCost:f2}");
                }              

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncom:f2}");
        }
    }
}
