using System;
using System.Collections.Generic;

namespace T05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string continentName = input.Split()[0];
                string countryName = input.Split()[1];  
                string cityName = input.Split()[2];

                FillNestedDictionary(continents, continentName, countryName, cityName); 
            }

            PrintNestedDictionaryWithList(continents);
        }

      

        static void FillNestedDictionary(Dictionary<string, Dictionary<string, List<string>>> continents, string continentName, string countryName, string cityName)
        {
            if (!continents.ContainsKey(continentName))
            {
                continents.Add(continentName, new Dictionary<string, List<string>>());
               
            }
            if (!continents[continentName].ContainsKey(countryName))
            {
                continents[continentName].Add(countryName, new List<string>());
            }
            continents[continentName][countryName].Add(cityName);  
        }

        static void PrintNestedDictionaryWithList(Dictionary<string, Dictionary<string, List<string>>> continents)
        {
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                var countries = continent.Value;
                foreach (var land in countries)
                {
                    Console.WriteLine($"{land.Key} -> {string.Join(", ", land.Value)}");
                }
            }
        }
    }
}
