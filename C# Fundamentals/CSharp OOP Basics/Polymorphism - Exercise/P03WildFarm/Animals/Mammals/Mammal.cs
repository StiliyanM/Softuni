namespace P03WildFarm.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {FoodEaten}]";

        }
    }
}
