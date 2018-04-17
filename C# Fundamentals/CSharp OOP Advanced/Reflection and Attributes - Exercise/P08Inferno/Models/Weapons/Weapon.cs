namespace P08Inferno.Models.Weapons
{
    using Contracts;
    using Enums;
    using System.Linq;

    public abstract class Weapon : IWeapon
    {
        public Weapon(string name, int minDamage, int maxDamage, Rarity rarity, int numberOfSockets)
        {
            this.Name = name;
            this.MinDamage = minDamage * (int) rarity;
            this.MaxDamage = maxDamage * (int)rarity;
            this.Rarity = rarity;
            this.GemSockets = new IGem[numberOfSockets];
        }
        public string Name { get; private set; }

        public int MinDamage { get; private set; }

        public int MaxDamage { get; private set; }

        public Rarity Rarity { get; }

        public IGem[] GemSockets { get; }

        private bool IsValidIndex(int index) => 
            index >= 0 && index < this.GemSockets.Length ? true : false;

        public void Add(int socketIndex, IGem gem)
        {
            if (IsValidIndex(socketIndex))
            {
                GemSockets[socketIndex] = gem;
            }
        }

        public void Remove(int socketIndex)
        {
            if (IsValidIndex(socketIndex))
            {
                this.GemSockets[socketIndex] = null;
            }
        }     

        public override string ToString()
        {

            var strength = this.GemSockets.Where(g => g != null).Select(g => g.Strength).Sum();
            var agility = this.GemSockets.Where(g => g != null).Select(g => g.Agility).Sum();
            var vitality = this.GemSockets.Where(g => g != null).Select(g => g.Vitality).Sum();

            var minDamage = this.MinDamage + (strength * 2) + agility;
            var maxDamage = this.MaxDamage + (strength * 3) + (agility * 4);

            return $"{this.Name}: {minDamage}-{maxDamage} Damage, +{strength} Strength, +{agility} Agility, +{vitality} Vitality";
        }
    }
}
