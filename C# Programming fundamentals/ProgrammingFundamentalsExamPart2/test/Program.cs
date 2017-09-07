using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = new Dictionary<string, Dictionary<string, List<long>>>();

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
                        foreach (var pokemon in pokemons)
                        {
                            Console.WriteLine($"# {pokemon.Key}");

                            var typeIndex = pokemon.Value;
                            foreach (var item in typeIndex)
                            {
                                var typeName = item.Key;
                                var theList = item.Value;
                                foreach (var index in theList)
                                {
                                    Console.WriteLine(
                                        $"{typeName} <-> {index}");
                                }
                            }
                        }
                    }
                    continue;
                }

                var pokemonName = tokens[0];
                    var evolutionType = tokens[1];
                    var evolutionIndex = int.Parse(tokens[2]);

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new Dictionary<string, List<long>>();
                    }
                if (!pokemons[pokemonName].ContainsKey(evolutionType))
                {
                    pokemons[pokemonName][evolutionType] = new List<long>();
                }

                pokemons[pokemonName][evolutionType].Add(evolutionIndex);
                }

                foreach (var pokemon in pokemons)
                {
                    Console.WriteLine($"# {pokemon.Key}");

                    var typeIndex = pokemon.Value;
                    foreach (var item in typeIndex)
                    {
                        var typeName = item.Key;
                        var theList = item.Value;
                        foreach (var index in theList.OrderByDescending(index => index))
                        {
                            Console.WriteLine(
                                $"{typeName} <-> {index}");
                        }
                    }
                }
            }
        }
    }


