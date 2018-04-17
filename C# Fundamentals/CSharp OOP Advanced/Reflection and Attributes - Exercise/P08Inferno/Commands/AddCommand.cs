using P08Inferno.Contracts;

namespace P08Inferno.Commands
{
    public class AddCommand : Command
    {
        public AddCommand(IWeaponRepository repository, string[] data) : base(repository, data)
        {
        }

        public override void Execute()
        {
            var weaponName = base.data[0];
            var socketIndex = int.Parse(base.data[1]);
            var gemInput = base.data[2];

            repository.AddGem(weaponName, socketIndex, gemInput);
        }
    }
}
