public class Ranker : Soldier
{
    public Ranker(string name, int age, double experience, double endurance) : base(name, age, experience, endurance)
    {
    }

    public override double OverallSkill => base.OverallSkill * 1.5;
}
