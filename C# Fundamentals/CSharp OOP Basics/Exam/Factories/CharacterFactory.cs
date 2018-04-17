namespace DungeonsAndCodeWizards.Factories
{
    using Models.Characters;
    using System;

    public class CharacterFactory
    {
        public Character CreateCharacter(string faction,string type, string name)
        {
            var isFaction = Enum.TryParse<Faction>(faction, out Faction result);

            if (!isFaction)
            {
                throw new ArgumentException($"Invalid faction \"{faction}\"!");
            }
            switch (type)
            {
                case "Warrior":
                    return new Warrior(name, result);
                case "Cleric":
                    return new Cleric(name, result);
                default:
                    throw new System.ArgumentException($"Invalid character type \"{type}\"!");
            }
        }
    }
}
