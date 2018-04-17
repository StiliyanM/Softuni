namespace P08Inferno.Factories
{
    using Contracts;
    using Enums;

    using System.Linq;
    using System.Reflection;
    using System;

    public class WeaponFactory
    {
        public IWeapon CreateWeapon(string weaponType, string name, string weaponRarity)
        {
            var rarity = ParseRarity(weaponRarity);
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == weaponType);

            if(type == null)
            {
                throw new ArgumentException("Invalid weapon type!");
            }

            var instance = Activator.CreateInstance(type, new object[] { name, rarity });

            return (IWeapon)instance;
        }

        private Rarity ParseRarity(string weaponRarity)
        {
            var isValid = Enum.TryParse<Rarity>(weaponRarity, out Rarity rarity);

            if (!isValid)
            {
                throw new ArgumentException("Invalid Rarity Type!");
            }

            return rarity;
        }
    }
}
