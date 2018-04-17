using P08Inferno.Contracts;

namespace P08Inferno.Commands
{
    public class CreateCommand : Command
    {
        public CreateCommand(IWeaponRepository repository, string[] data) : base(repository, data)
        {
        }

        public override void Execute()
        {
            var weaponType = base.data[0];
            var weaponName = base.data[1];

            repository.Create(weaponType, weaponName);
        }
    }
}
