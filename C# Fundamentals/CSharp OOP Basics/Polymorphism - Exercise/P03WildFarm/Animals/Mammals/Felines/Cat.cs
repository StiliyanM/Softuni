namespace P03WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public override string ProduceSound()
        {
            return "Meow";
        }

        public override void Eat(string foodType)
        {
            base.Eat(foodType);

            if(foodType.ToLower() != "vegetable" || foodType.ToLower() != "meat")
            {
                base.InvalidFood();
            }

            this.Weight += 0.3;
        }
    }
}
