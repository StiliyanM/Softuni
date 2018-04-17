namespace P08Inferno.Contracts
{
    public interface IWeaponRepository
    {
        void AddGem(string weaponName, int socketIndex, string gemInput);
        void Create(string type, string name);
        void RemoveGem(string weaponName, int socketIndex);
        IWeapon FindWeapon(string weaponName);
    }
}