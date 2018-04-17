using System;

namespace DungeonsAndCodeWizards.Models.Characters
{
    using Bags;
    using Contracts;

    public class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction) : base(name, 50, 25, 40, new Backpack(), faction)
        {
        }

        public override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            base.CheckIfAlive();

            character.CheckIfAlive();

            if (this.Faction != character.Faction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }

            character.IncreaseHealth(this.AbilityPoints);
        }
    }
}
