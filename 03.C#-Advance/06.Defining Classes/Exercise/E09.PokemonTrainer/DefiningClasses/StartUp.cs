using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var trainers = new List<Trainer>(); 

            while (input != "Tournament")
            {
                string[] data = input.Split();

                string trainerName = data[0];
                string pokemonName = data[1];
                string pokemonElement = data[2];
                int pokemonHealth = int.Parse(data[3]);

                if (!trainers.Any(x => x.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                var currTrainer = trainers.Find(t => t.Name == trainerName);
                currTrainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                input = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(pokemon => pokemon.Element == command))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;
                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
            foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}