namespace P02KingsGambit.Contracts
{
    public interface ISubordinate : IKillable,INamable
    {
        void ReactToAttack();
    }
}
