using System;
using System.Collections.Generic;
using System.Linq;

namespace P11PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command;

            var trainers = new HashSet<Trainer>();

            var trainer = new Trainer();

            while ((command = Console.ReadLine()) != "Tournament")
            {
                var tokens = command.Split();

                var trainerName = tokens[0];
                var pokemonName = tokens[1];
                var pokemonElement = tokens[2];
                var pokemonHealth = int.Parse(tokens[3]);

                var pokemon = new Pokemon(pokemonName, pokemonHealth, pokemonElement);

                trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

                if(trainer == null)
                {
                    trainer = new Trainer(trainerName);
                }

                trainer.Pokemons.Add(pokemon);

                trainers.Add(trainer);
            }

            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var t in trainers)
                {
                    var hasPokemonWithElement = t.Pokemons.Any(p => p.Element == command);

                    if (hasPokemonWithElement)
                    {
                        t.BadgesCount++;
                    }
                    else
                    {
                        for (int i = 0; i < t.Pokemons.Count; i++)
                        {
                            t.Pokemons[i].Health -= 10;
                        }

                        t.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
            }

            foreach (var t in trainers.OrderByDescending(t => t.BadgesCount))
            {
                Console.WriteLine($"{t.Name} {t.BadgesCount} {t.Pokemons.Count}");
            }
        }
    }
}
