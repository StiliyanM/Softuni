namespace P08Inferno.Contracts
{
    using Enums;

    public interface IGem
    {
        string Name { get; }

        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }

        GemClarity Clarity { get; }
    }
}
