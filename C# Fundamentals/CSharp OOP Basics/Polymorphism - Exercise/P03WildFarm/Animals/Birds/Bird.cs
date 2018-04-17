namespace P03WildFarm.Animals.Birds
{
    public abstract class Bird : Animal
    {
        public double WingSize { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {WingSize}, {this.Weight}, {FoodEaten}]";
        }
    }
}
