namespace P03WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        public override void Eat(string foodType)
        {
            base.Eat(foodType);
            this.Weight += 0.35;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
