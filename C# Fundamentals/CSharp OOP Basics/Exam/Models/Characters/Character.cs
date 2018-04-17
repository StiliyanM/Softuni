using System;

namespace DungeonsAndCodeWizards.Models.Characters
{
    using Bags;
    using Items;

    public abstract class Character
    {
        private string name;
        private double health;
        private double armor;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
        }

        public string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }

        public void RestoreArmor()
        {
            this.Armor = this.BaseArmor;
        }

        public void DecreaseHealth(double amount)
        {
            this.Health -= amount;
        }

        public void IncreaseHealth(double amount)
        {
            this.Health += amount;
        }

        public double Health
        {
            get { return health; }
            protected set
            {
                if (value > this.BaseHealth)
                {
                    value = BaseHealth;
                }

                if (value <= 0)
                {
                    value = 0;
                    IsAlive = false;
                }
                health = value;
            }
        }

        public double Armor
        {
            get { return armor; }
            protected set
            {
                if(value > this.BaseArmor)
                {
                    value = this.BaseArmor;
                }

                if(value <= 0)
                {
                    value = 0;
                }
                armor = value;
            }
        }

        public double BaseHealth { get; protected set; }

        public double BaseArmor { get; protected set; }

        public bool IsAlive { get; protected set; } = true;

        public double AbilityPoints { get; protected set; }

        public Bag Bag { get;protected set; }

        public Faction Faction { get;protected set; }

        public virtual double RestHealMultiplier => 0.2;

        public string AliveOrDead => this.IsAlive ? "Alive" : "Dead";

        //Overview later
        public void TakeDamage(double hitPoints)
        {
            CheckIfAlive();
            if(this.Armor > 0)
            {

                if(hitPoints <= Armor)
                {
                    Armor -= hitPoints;
                    hitPoints = 0;
                }
                else
                {
                    hitPoints -= Armor;
                    Armor = 0;
                }
            }

            if(hitPoints > 0)
            {
                this.Health -= hitPoints;
            }
        }

        public void Rest()
        {
            CheckIfAlive();

            this.Health += this.BaseHealth * RestHealMultiplier;
        }

        public void CheckIfAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        public void UseItem(Item item)
        {
            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            CheckIfAlive();
            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            CheckIfAlive();
            character.CheckIfAlive();

            character.ReceiveItem(item);
        }

        public void ReceiveItem(Item item)
        {
            CheckIfAlive();
            this.Bag.AddItem(item);
        }

        public override string ToString()
        {
            return $"{this.Name} - HP: {health}/{BaseHealth}, AP: {armor}/{BaseArmor}, " +
                $"Status: {this.AliveOrDead}";
        }
    }
}
