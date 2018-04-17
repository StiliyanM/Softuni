namespace P08Inferno.Repository
{
    using Contracts;
    using System.Collections.Generic;
    using Factories;
    using System.Linq;
    using System;

    public class WeaponRepository : IWeaponRepository
    {
        private List<IWeapon> weapons = new List<IWeapon>();
        private WeaponFactory weaponFactory;
        private GemFactory gemFactory;
        public WeaponRepository(WeaponFactory weaponFactory,GemFactory gemFactory)
        {
            this.weaponFactory = weaponFactory;
            this.gemFactory = gemFactory;
        }

        public void Create(string type, string name)
        {
            var rarity = type.Split().First();
            var weaponType = type.Split().Last();

            var weapon = weaponFactory.CreateWeapon(weaponType, name, rarity);

            this.weapons.Add(weapon);
        }

        public void AddGem(string weaponName, int socketIndex, string gemInput)
        {
            IWeapon weapon = FindWeapon(weaponName);

            var gemArgs = gemInput.Split();
            var gemClarity = gemArgs[0];
            var gemType = gemArgs[1];

            var gem = gemFactory.CreateGem(gemType, gemClarity);

            weapon.Add(socketIndex, gem);

        }

        public void RemoveGem(string weaponName, int socketIndex)
        {
            var weapon = FindWeapon(weaponName);

            weapon.Remove(socketIndex);
        }

        public IWeapon FindWeapon(string weaponName)
        {
            var weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);

            if(weapon == null)
            {
                throw new ArgumentException("Invalid Weapon Name!");
            }

            return weapon;
        }
    }
}
