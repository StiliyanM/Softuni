using P03BarracksFactory.Contracts;

namespace P03BarracksFactory.Core.Commands
{
    public abstract class Command : IExecutable
    {
        protected string[] Data { get; private set; }
        protected IRepository Repository { get; private set; }
        protected IUnitFactory UnitFactory { get; private set; }

        protected Command(string[] data, IRepository repository ,IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        public abstract string Execute();
    }
}