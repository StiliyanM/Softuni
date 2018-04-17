namespace DungeonsAndCodeWizards.Factories
{
    using Models.Items;
    public class ItemFactory
    {
        public Item CreateItem(string type)
        {
            switch (type)
            {
                case "ArmorRepairKit":
                    return new ArmorRepairKit();
                case "HealthPotion":
                    return new HealthPotion();
                case "PoisonPotion":
                    return new PoisonPotion();
                default:
                    throw new System.ArgumentException($"Invalid item \"{type}\"!");
            }
        }
    }
}
