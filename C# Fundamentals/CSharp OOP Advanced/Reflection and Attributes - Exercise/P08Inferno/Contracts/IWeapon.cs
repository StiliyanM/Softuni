namespace P08Inferno.Contracts
{
    using Enums;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        Rarity Rarity { get; }

        IGem[] GemSockets { get; }

        void Add(int socketIndex, IGem gem);
        void Remove(int socketIndex);

    }
}
