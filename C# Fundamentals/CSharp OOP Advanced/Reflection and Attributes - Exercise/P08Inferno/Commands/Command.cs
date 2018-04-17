namespace P08Inferno.Commands
{
    using Contracts;

    public abstract class Command : ICommand
    {
        protected string[] data;
        protected IWeaponRepository repository;

        public Command(IWeaponRepository repository, string[] data)
        {
            this.repository = repository;
            this.data = data;
        }
        public abstract void Execute();
    }
}
