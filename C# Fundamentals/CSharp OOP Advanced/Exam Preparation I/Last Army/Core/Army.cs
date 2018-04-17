using System.Collections.Generic;

public class Army : IArmy
{
    private List<ISoldier> soldiers = new List<ISoldier>();

    public IReadOnlyList<ISoldier> Soldiers
    {
        get
        {
            return soldiers;
        }
    }

    public void AddSoldier(ISoldier soldier)
    {
        this.soldiers.Add(soldier);
    }

    public void RegenerateTeam(string soldierType)
    {
        throw new System.NotImplementedException();
    }
}
