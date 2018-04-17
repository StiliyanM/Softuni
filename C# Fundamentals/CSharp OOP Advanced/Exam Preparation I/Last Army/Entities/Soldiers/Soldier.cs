using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
    {
        public IDictionary<string, IAmmunition> Weapons { get; }

        private double endurance;

        protected virtual List<string> WeaponsAllowed => new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "Helmet",
        };

        public string Name { get; private set; }

        public int Age { get; private set; }

        public Soldier(string name, int age, double experience, double endurance)
        {
            Name = name;
            Age = age;
            Experience = experience;
            Endurance = endurance;
        }

        public double Experience { get; private set; }

        public double Endurance
        {
            get { return endurance; }
            set
            {
                if (value > 100)
                {
                    value = 100;
                }
                endurance = value;
            }
        }


        public virtual double OverallSkill => this.Age + this.Experience;

        public bool ReadyForMission(IMission mission)
        {
            if (this.Endurance < mission.EnduranceRequired)
            {
                return false;
            }

            bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

            if (!hasAllEquipment)
            {
                return false;
            }

            return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;
        }

        private void AmmunitionRevision(double missionWearLevelDecrement)
        {
            IEnumerable<string> keys = this.Weapons.Keys.ToList();
            foreach (string weaponName in keys)
            {
                this.Weapons[weaponName].DecreaseWearLevel(missionWearLevelDecrement);

                if (this.Weapons[weaponName].WearLevel <= 0)
                {
                    this.Weapons[weaponName] = null;
                }
            }
        }

    public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);

    public virtual void Regenerate()
        {
            this.Endurance += 10 + this.Age;
        }

        public void CompleteMission(IMission mission)
        {
            throw new System.NotImplementedException();
        }
    }

