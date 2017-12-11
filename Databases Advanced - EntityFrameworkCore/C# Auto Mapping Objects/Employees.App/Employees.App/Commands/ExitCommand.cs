namespace Employees.App.Commands
{
    using System;

    class ExitCommand : ICommand
    {
        public string Execute(params string[] args)
        {
            Environment.Exit(0);

            return "Goodbye!";
        }
    }
}
