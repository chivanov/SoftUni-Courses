using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace EP02.SpaceTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> routeToTitan = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries).ToList();

            int fuelStart = int.Parse(Console.ReadLine());
            int ammoStart = int.Parse(Console.ReadLine());

            for (int i = 0; i < routeToTitan.Count; i++)
            {
                string[] command = routeToTitan[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string input = command[0];

                if (input == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    break;
                }

                else if (input == "Travel")
                {
                    int value = int.Parse(command[1]);

                    if (fuelStart >= value)
                    {
                        fuelStart -= value;
                        Console.WriteLine($"The spaceship travelled {value} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }
                }
                else if (input == "Enemy")
                {
                    int value = int.Parse(command[1]);
                    if (ammoStart >= value)
                    {
                        ammoStart -= value;
                        Console.WriteLine($"An enemy with {value} armour is defeated.");
                    }
                    else
                    {
                        fuelStart -= value * 2;
                        if (fuelStart > 0)
                        {
                            Console.WriteLine($"An enemy with {value} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            break;
                        }
                    }
                }
                else if (input == "Repair")
                {
                    int value = int.Parse(command[1]);
                    fuelStart += value;
                    ammoStart += value * 2;
                    Console.WriteLine($"Ammunitions added: {value * 2}.");
                    Console.WriteLine($"Fuel added: {value}.");
                }
            }
        }

    }
}
