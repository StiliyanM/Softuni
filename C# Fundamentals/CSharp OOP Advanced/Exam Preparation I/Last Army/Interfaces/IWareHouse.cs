using System.Collections.Generic;

public interface IWareHouse
{
    IReadOnlyList<IAmmunition> Ammunitions { get; }

    void EquipArmy(IArmy army);
}
