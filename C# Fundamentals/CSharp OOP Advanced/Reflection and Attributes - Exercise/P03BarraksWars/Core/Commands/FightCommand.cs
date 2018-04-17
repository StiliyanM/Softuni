using System;
using P03BarracksFactory.Contracts;

namespace P03BarracksFactory.Core.Commands
{
    public class FightCommand : Command
    {
        public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);

            return "";
        }
    }
}
