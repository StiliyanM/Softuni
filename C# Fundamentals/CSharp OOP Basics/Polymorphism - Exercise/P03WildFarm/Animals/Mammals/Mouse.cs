namespace P03WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override void Eat(string foodType)
        {
            base.Eat(foodType);

            
            if(foodType.ToLower() != "fruit" || foodType.ToLower() != "vegetable")
            {
                base.InvalidFood();
            }

            this.Weight += 0.1;
        }
    }
}
