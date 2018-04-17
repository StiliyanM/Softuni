namespace P02KingsGambit.Models
{
    using Contracts;

    public abstract class Subordinate : ISubordinate
    {
        public Subordinate(string name)
        {
            Name = name;
            IsAlive = true;
        }

        public string Name { get; }

        public bool IsAlive { get; private set; }

        public event GetAttackedEventHandler GetAttackedEvent;

        public void Die()
        {
            this.IsAlive = false;
        }

        public abstract void ReactToAttack();

    }
}
