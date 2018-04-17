using System.Collections.Generic;
using System.Linq;

public class Corporal : Soldier
{
    public Corporal(string name, int age, double experience, double endurance) : base(name, age, experience, endurance)
    {
    }

    protected override List<string> WeaponsAllowed
        => base.WeaponsAllowed
        .Concat(new List<string>
        {
              "MachineGun",
              "Knife",
        }).ToList();

    public override double OverallSkill => base.OverallSkill * 2.5;
}
