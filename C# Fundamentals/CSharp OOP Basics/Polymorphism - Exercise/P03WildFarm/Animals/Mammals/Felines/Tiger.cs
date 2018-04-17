namespace P03WildFarm.Animals.Mammals.Felines
{
    public class Tiger : Mammal
    {
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }

        public override void Eat(string foodType)
        {
            base.Eat(foodType);

            if (foodType.ToLower() != "meat")
            {
                base.InvalidFood();
            }

            this.Weight += 1;

        }
    }
}
