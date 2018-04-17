using System.Collections.Generic;

namespace P11PokemonTrainer
{
    class Trainer
    {
        public Trainer(string trainerName)
        {
            this.Name = trainerName;
        }
        public Trainer()
        {

        }
        public string Name { get; set; }
        public int BadgesCount { get; set; }
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
    }
}
