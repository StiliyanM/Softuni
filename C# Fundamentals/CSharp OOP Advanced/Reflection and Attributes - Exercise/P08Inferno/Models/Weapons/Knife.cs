namespace P08Inferno.Models.Weapons
{
    using Enums;

    public class Knife : Weapon
    {
        public Knife(string name, Rarity rarity) :
            base(name, 3, 4, rarity, 2)
        {
        }
    }
}
