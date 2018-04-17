using System;
using P08Inferno.Contracts;

namespace P08Inferno.Commands
{
    public class PrintCommand : Command
    {
        public PrintCommand(IWeaponRepository repository, string[] data) : base(repository, data)
        {
        }

        public override void Execute()
        {
            var weaponName = base.data[0];

            var weapon = repository.FindWeapon(weaponName);
            Console.WriteLine(weapon);
        }
    }
}
