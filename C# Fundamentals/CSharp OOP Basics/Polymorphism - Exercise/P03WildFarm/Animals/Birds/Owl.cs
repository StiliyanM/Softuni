namespace P03WildFarm.Animals.Birds
{
    public class Owl : Bird
    {
        public override void Eat(string foodType)
        {
            if(foodType.ToLower() != "meat")
            {
                base.InvalidFood();
            }

            base.Eat(foodType);

            this.Weight += 0.25;
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
