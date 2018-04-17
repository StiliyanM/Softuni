namespace P08Inferno.Factories
{
    using Enums;
    using Contracts;
    using System;
    using System.Reflection;
    using System.Linq;

    public class GemFactory
    {
        public IGem CreateGem(string gemType, string clarity)
        {
            var rarity = ParseClarity(clarity);
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == gemType);

            if (type == null)
            {
                throw new ArgumentException("Invalid gem type!");
            }

            var instance = Activator.CreateInstance(type, new object[] { rarity });

            return (IGem)instance;

        }

        private GemClarity ParseClarity(string clarity)
        {
            var isValid = Enum.TryParse<GemClarity>(clarity, out GemClarity gemClarity);

            if (!isValid)
            {
                throw new ArgumentException("Invalid GemClarity Type!");
            }

            return gemClarity;

        }
    }
}
