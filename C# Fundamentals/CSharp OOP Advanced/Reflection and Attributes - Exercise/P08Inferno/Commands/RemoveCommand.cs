using P08Inferno.Contracts;

namespace P08Inferno.Commands
{
    public class RemoveCommand : Command
    {
        public RemoveCommand(IWeaponRepository repository, string[] data) : base(repository, data)
        {
        }

        public override void Execute()
        {
            var weaponName = base.data[0];
            var socketIndex = int.Parse(base.data[1]);

            repository.RemoveGem(weaponName, socketIndex);
        }
    }
}
