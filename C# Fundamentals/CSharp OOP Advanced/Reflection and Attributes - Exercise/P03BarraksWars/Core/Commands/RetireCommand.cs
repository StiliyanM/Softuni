using System;
using P03BarracksFactory.Contracts;

namespace P03BarracksFactory.Core.Commands
{
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            var unitType = this.Data[1];
            try
            {
                Repository.RemoveUnit(unitType);

                return ($"{unitType} retired!");
            }
            catch (ArgumentException ax)
            {
                return ax.Message;
            }
        }
    }
}
