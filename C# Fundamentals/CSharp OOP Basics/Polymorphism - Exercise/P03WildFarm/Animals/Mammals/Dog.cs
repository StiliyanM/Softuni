namespace P03WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override void Eat(string foodType)
        {
            base.Eat(foodType);

            if(foodType.ToLower() != "meat")
            {
                base.InvalidFood();
            }

            this.Weight += 0.4;
        }
    }
}
