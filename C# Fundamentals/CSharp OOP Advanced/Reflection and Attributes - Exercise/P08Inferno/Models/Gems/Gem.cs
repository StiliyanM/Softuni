namespace P08Inferno.Models.Gems
{
    using Contracts;
    using Enums;

    public abstract class Gem : IGem
    {
        public Gem(int strength, int agility, int vitality, GemClarity clarity)
        {
            this.Strength = strength + (int)clarity;
            this.Agility = agility + (int)clarity;
            this.Vitality = vitality + (int)clarity;
            this.Clarity = clarity;
        }
        public string Name => this.GetType().Name;

        public int Strength { get; }

        public int Agility { get; }

        public int Vitality { get; }

        public GemClarity Clarity { get; }

        public override string ToString()
        {
            return $"+{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
        }
    }
}
