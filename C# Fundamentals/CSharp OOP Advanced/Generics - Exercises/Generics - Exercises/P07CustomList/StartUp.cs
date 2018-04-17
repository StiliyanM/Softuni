using System;

namespace P07CustomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var mylist = new CustomList<string>();
            var commandInterpreter = new CommandInterpreter(mylist);
            var engine = new Engine(commandInterpreter);

            engine.Run();
        }
    }
}
