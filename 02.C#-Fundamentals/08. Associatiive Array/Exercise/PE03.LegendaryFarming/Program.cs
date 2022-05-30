using System;
using System.Collections.Generic;
using System.Linq;

namespace PE03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("motes", 0);
            keyMaterials.Add("fragments", 0);

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            bool isFound = false;

            while (!isFound)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < input.Length; i += 2)
                {
                    string material = input[i].ToLower();

                    int quantity = int.Parse(input[i - 1]);

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material] >= 250)
                        {
                            isFound = true;
                            break;
                        }

                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] += quantity;
                        }
                        else
                        {
                            junkMaterials.Add(material, quantity);
                        }
                    }
                }
            }
            if (keyMaterials["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                keyMaterials["shards"] -= 250;
            }
            else if (keyMaterials["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                keyMaterials["fragments"] -= 250;
            }
            else if (keyMaterials["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                keyMaterials["motes"] -= 250;
            }

            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
