using System.Collections.Generic;
using System.Linq;

public class SpecialForce : Soldier
{
    private const double OverallSkillMiltiplier = 3.5;


    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }

    protected override List<string> WeaponsAllowed =>
        base.WeaponsAllowed.Concat(new List<string>
        {
               "RPG",
               "NightVision",
        }).ToList();

    public override double OverallSkill => base.OverallSkill * 3.5;

    public override void Regenerate()
    {
        base.Regenerate();
        this.Endurance += 20;
    }
}
