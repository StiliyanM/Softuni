using System.Collections.Generic;

public class WareHouse : IWareHouse
{
    private List<IAmmunition> ammunitions = new List<IAmmunition>();
    public IReadOnlyList<IAmmunition> Ammunitions => this.ammunitions;

    public void EquipArmy(IArmy army)
    {
        throw new System.NotImplementedException();
    }
}
