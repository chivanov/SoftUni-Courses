using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.WildZoo
{
    internal class Program
    {
        class Animal
        {
            public Animal(int food, string area)
            {
                this.Food = food;
                this.Area = area;                
            }
            public int Food { get; set; }
            public string Area { get; set; }
           
        }
        static void Main(string[] args)
        {
            Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
          
            string input;
            while ((input = Console.ReadLine()) != "EndDay")
            {
                string[] cmdInfo = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdInfo[0];
                string[] animalInfo = cmdInfo[1].Split("-", StringSplitOptions.RemoveEmptyEntries);
                if (command == "Add")
                {
                    string animalName = animalInfo[0];
                    int foodNeeded = int.Parse(animalInfo[1]);
                    string area = animalInfo[2];

                    animals = AddAnimal(animals, animalName, foodNeeded, area);
                }
                else if (command == "Feed")
                {
              
                    string animalName = animalInfo[0];
                    int foodEaten = int.Parse(animalInfo[1]);

                    animals = FeedAnimals(animals, animalName, foodEaten);

                }
            }
            Console.WriteLine("Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine($" {animal.Key} -> {animal.Value.Food}g");
            }


            Dictionary<string, List<int>> areas = new Dictionary<string, List<int>>();

            foreach (var item in animals)
            {
                string areaName = item.Value.Area;
                int foodCount = item.Value.Food;
                if (!(areas.ContainsKey(item.Value.Area)) && foodCount > 0)
                {

                    areas.Add(areaName, new List<int> {foodCount});
                }
                else if (areas.ContainsKey(item.Value.Area) && foodCount > 0)
                {
                    areas[areaName].Add(foodCount);
                }
            }
            Console.WriteLine("Areas with hungry animals:");

            foreach (var item in areas)
            {
                    int count = item.Value.Count;
                if (count > 0)
                {                    
                    Console.WriteLine($" {item.Key}: {count}");
                }
            }

        }

        private static Dictionary<string, Animal> FeedAnimals(Dictionary<string, Animal> animals, string animalName, int foodEaten)
        {
            if (animals.ContainsKey(animalName))
            {
                animals[animalName].Food -= foodEaten;
                if (animals[animalName].Food <= 0)
                {
                    Console.WriteLine($"{animalName} was successfully fed");
                    animals.Remove(animalName);
                }
             
            }
            return animals;
        }

        private static Dictionary<string, Animal> AddAnimal(Dictionary<string, Animal> animals, string animalName, int foodNeeded, string area)
        {

            if (!animals.ContainsKey(animalName))
            {
                animals.Add(animalName, new Animal(foodNeeded, area));
            }
            else
            {
                animals[animalName].Food += foodNeeded;
            }
            return animals;
        }
    }
}
