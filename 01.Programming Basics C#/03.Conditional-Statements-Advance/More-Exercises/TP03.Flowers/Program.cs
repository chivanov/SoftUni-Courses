using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Chrysanthemums Roses Tulips
			int chrysanthemumsCount = int.Parse(Console.ReadLine());
			int rosesCount = int.Parse(Console.ReadLine());
			int TulipsCount = int.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			string weekend = Console.ReadLine();

			double priceOfChrysanthemum = 0;
			double priceOfRose = 0;
			double priceOfTulip = 0;

			if (season == "Spring" || season == "Summer")
			{
				priceOfChrysanthemum = 2.00;
				priceOfRose = 4.10;
				priceOfTulip = 2.50;
			}
			else if (season == "Autumn" || season == "Winter")
			{
				priceOfChrysanthemum = 3.75;
				priceOfRose = 4.50;
				priceOfTulip = 4.15;
			}

			double bucketPrice = (chrysanthemumsCount * priceOfChrysanthemum) + (rosesCount * priceOfRose) + (TulipsCount * priceOfTulip);
			double totalFlaurs = chrysanthemumsCount + rosesCount + TulipsCount;

			if (weekend == "Y")
			{
				bucketPrice = bucketPrice + (bucketPrice * 0.15);
			}

			if (TulipsCount > 7)
			{
				if (season == "Spring")
				{
					bucketPrice = bucketPrice - (bucketPrice * 0.05);
				}
			}
			if (rosesCount >= 10)
			{
				if (season == "Winter")
				{
					bucketPrice = bucketPrice - (bucketPrice * 0.10);
				}
			}
			if (totalFlaurs > 20)
			{
				bucketPrice = bucketPrice - (bucketPrice * 0.2);
			}


			double finalPrice = bucketPrice + 2;

			Console.WriteLine($"{finalPrice:f2}");
		}
	}
}
