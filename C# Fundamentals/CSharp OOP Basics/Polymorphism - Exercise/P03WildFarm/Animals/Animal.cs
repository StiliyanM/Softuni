using System;

namespace P03WildFarm.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract string ProduceSound();

        protected string FoodType;
        public virtual void Eat(string foodType)
        {
            this.FoodType = foodType;
        }

        public void InvalidFood()
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {this.FoodType}!");
        }
    }
}
