using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Program
    {
        class PokemonAttributes
        {
            public string EvolutionType { get; set; }
            public int EvolutionIndex { get; set; }
        }
        static void Main(string[] args)
        {
            var pokemons = new Dictionary<string, List<PokemonAttributes>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                var tokens = Regex.Split(input, @" -> ");

                if (tokens.Length == 1)
                {
                    var name = tokens[0];
                    if (pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");

                        foreach (var p in pokemons[name])
                        {
                            Console.WriteLine(
                                $"{p.EvolutionType} <-> {p.EvolutionIndex}");
                        }
                    }
                    continue;
                }

                var pokemonName = tokens[0];
                var evolutionType = tokens[1];
                var evolutionIndex = int.Parse(tokens[2]);

                if (!pokemons.ContainsKey(pokemonName))
                {
                    pokemons[pokemonName] = new List<PokemonAttributes>();
                }

                pokemons[pokemonName].Add(
                    new PokemonAttributes()
                    {
                        EvolutionType = evolutionType,
                        EvolutionIndex = evolutionIndex
                    });
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                var list = pokemon.Value;
                foreach (var item in list.OrderByDescending(item => item.EvolutionIndex))
                {
                    Console.WriteLine(
                        $"{item.EvolutionType} <-> {item.EvolutionIndex}");
                }
            }
        }
    }
}

