using System;
using TeamBuilder.App.Utilities;

namespace TeamBuilder.App.Core.Commands
{
    static class ExitCommand
    {
        public static string Execute(string[] data)
        {
            Check.CheckLength(0, data);

            Environment.Exit(0);

            return "Bye";
        }
    }
}
