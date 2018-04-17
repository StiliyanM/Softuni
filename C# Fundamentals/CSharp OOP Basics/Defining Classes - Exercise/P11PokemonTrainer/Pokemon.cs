namespace P11PokemonTrainer
{
    class Pokemon
    {
        public Pokemon(string pokemonName, int pokemonHealth, string pokemonElement)
        {
            this.Name = pokemonName;
            this.Health = pokemonHealth;
            this.Element = pokemonElement;
        }

        public Pokemon()
        {

        }

        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
    }
}
