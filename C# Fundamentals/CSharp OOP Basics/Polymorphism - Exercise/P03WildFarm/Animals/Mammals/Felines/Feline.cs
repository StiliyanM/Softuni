namespace P03WildFarm.Animals.Mammals.Felines
{
    public abstract class Feline : Mammal
    {
        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {Breed}, {this.Weight}, {this.LivingRegion}, {FoodEaten}]";
        }
    }
}
