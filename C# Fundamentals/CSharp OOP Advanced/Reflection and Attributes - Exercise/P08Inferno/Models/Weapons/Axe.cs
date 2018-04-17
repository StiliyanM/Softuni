namespace P08Inferno.Models.Weapons
{
    using Enums;

    public class Axe : Weapon
    {
        public Axe(string name, Rarity rarity) :
            base(name, 5, 10, rarity, 4)
        {
        }
    }
}
