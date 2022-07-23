using System;
using System.Collections.Generic;

namespace E06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',');
                Dictionary<string, int> dict = new Dictionary<string, int>();
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    foreach (var item in clothes)
                    {
                        if (!dict.ContainsKey(item))
                        {
                            dict.Add(item, 0);
                        }
                        dict[item]++;
                    }
                    wardrobe[color] = dict;
                }
                else
                {
                    foreach (var item in clothes)
                    {
                        if (!wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color].Add(item, 1);
                        }
                        else
                        {
                            wardrobe[color][item]++;
                        }
                    }
                }
            }

            string[] clothToLook = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string colorToFind = clothToLook[0];
            string clothToFind = clothToLook[1];

            foreach (var item in wardrobe)
            {
                if (wardrobe.ContainsKey(colorToFind))
                {
                    Console.WriteLine($"{item.Key} clothes:");
                    Dictionary<string, int> dict = item.Value;


                    foreach (var cloth in dict)
                    {
                        if (cloth.Key == clothToFind && wardrobe.ContainsKey(colorToFind))
                        {
                            Console.WriteLine($"* {clothToFind} - {cloth.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                        }
                    }
                                  
                }
            }
        }
    }
}
