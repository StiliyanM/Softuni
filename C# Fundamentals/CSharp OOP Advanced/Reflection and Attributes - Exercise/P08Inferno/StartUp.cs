using System;

namespace P08Inferno
{
    using Repository;
    using Factories;
    class StartUp
    {
        static void Main(string[] args)
        {
            var repo = new WeaponRepository(new WeaponFactory(), new GemFactory());
            var interpreter = new CommandInterpreter(repo);
            var engine = new Engine(interpreter);
            engine.Run();
        }
    }
}
