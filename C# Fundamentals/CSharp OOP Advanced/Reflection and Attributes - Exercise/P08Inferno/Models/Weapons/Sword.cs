namespace P08Inferno.Models.Weapons
{
    using Enums;

    public class Sword : Weapon
    {
        public Sword(string name, Rarity rarity) :
            base(name, 4, 6, rarity, 3)
        {
        }
    }
}
