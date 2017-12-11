using BusTicketSystem.App.Core.Commands;
using System;
using System.Linq;

namespace BusTicketSystem.App
{
    public class CommandDispatcher
    {
        internal string DispatchCommand(string[] args)
        {
            var command = args[0];

            var data = args.Skip(1).ToArray();

            var result = "";
            switch (command)
            {
                case "BusStationInfo":
                    result = BusStationInfoCommand.Execute(data);
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}