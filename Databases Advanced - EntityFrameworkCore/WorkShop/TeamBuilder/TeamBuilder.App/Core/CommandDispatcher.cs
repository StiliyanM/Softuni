using System;
using System.Linq;
using System.Text.RegularExpressions;
using TeamBuilder.App.Core.Commands;

namespace TeamBuilder.App.Core
{
    public class CommandDispatcher
    {
        public string Dispatch(string input)
        {
            string result = "";

            var commandArgs = Regex.Split(input.Trim(),@"\s");

            var command = commandArgs.Length > 0 ? commandArgs[0] : string.Empty;

            var args = commandArgs.Skip(1).ToArray();

            switch (command)
            {
                case "Login":
                    result = LoginCommand.Execute(args);
                    break;
                case "Logout":
                    result = LogoutCommand.Execute(args);
                    break;
                case "RegisterUser":
                    result = RegisterUserCommand.Execute(args);
                    break;
                case "DeleteUser":
                    result = DeleteUserCommand.Execute(args);
                    break;
                case "CreateEvent":
                    result = CreateEventCommand.Execute(args);
                    break;
                case "CreateTeam":
                    result = CreateTeamCommand.Execute(args);
                    break;
                case "InviteToTeam":
                    result = InviteToTeamCommand.Execute(args);
                    break;
                case "AcceptInvite":
                    result = AcceptInviteCommand.Execute(args);
                    break;
                case "DeclineInvite":
                    result = DeclineInviteCommand.Execute(args);
                    break;
                case "KickMember":
                    result = KickMemberCommand.Execute(args);
                    break;
                case "Exit":
                    result = ExitCommand.Execute(args);
                    break;
                case "Disband":
                    result = DisbandCommand.Execute(args);
                    break;
                case "AddTeamTo":
                    result = AddTeamToCommand.Execute(args);
                    break;
                case "ShowTeam":
                    result = ShowTeamCommand.Execute(args);
                    break;
                case "ShowEvent":
                    result = ShowEventCommand.Execute(args);
                    break;
                default:
                    throw new NotSupportedException($"Command {command} not supported!");
            }

            return result;
        }

        private void Execute(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
