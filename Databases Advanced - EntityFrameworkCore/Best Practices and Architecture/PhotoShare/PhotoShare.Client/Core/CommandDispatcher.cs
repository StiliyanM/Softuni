namespace PhotoShare.Client.Core
{
    using PhotoShare.Client.Core.Commands;
    using System;
    using System.Linq;

    public class CommandDispatcher
    {
        public readonly string[] loggedInUserCommands =
            { "Logout", "AcceptFriend", "AddFriend",
                "AddTag","AddTagTo","AddTown","CreateAlbum",
                "DeleteUser","ModifyUser","ShareAlbum","UploadPicture" };

        public string DispatchCommand(string[] commandParameters)
        {
            var command = commandParameters[0];
            
            if(loggedInUserCommands.Contains(command) && Session.User == null)
            {
                throw new InvalidOperationException("Invalid credentials!");
            }

            var args = commandParameters.Skip(1).ToArray();

            var returnValue = "";
            switch (command)
            {
                case "Login":
                    returnValue = LogInCommand.Execute(args);
                    break;
                case "RegisterUser":
                    returnValue = RegisterUserCommand.Execute(args);
                    break;
                case "ListFriends":
                    returnValue = PrintFriendsListCommand.Execute(args);
                    break;
                
                case "Logout":
                    returnValue = LogOutCommand.Execute(args);
                    break;
                case "AddTown":
                    returnValue = AddTownCommand.Execute(args);
                    break;
                case "ModifyUser":
                    returnValue = ModifyUserCommand.Execute(args);
                    break;
                case "DeleteUser":
                    returnValue = DeleteUser.Execute(args);
                    break;
                case "AddTag":
                    returnValue = AddTagCommand.Execute(args);
                    break;
                case "CreateAlbum":
                    returnValue = CreateAlbumCommand.Execute(args);
                    break;
                case "AddTagTo":
                    returnValue = AddTagToCommand.Execute(args);
                    break;
                case "AddFriend":
                    returnValue = AddFriendCommand.Execute(args);
                    break;
                case "AcceptFriend":
                    returnValue = AcceptFriendCommand.Execute(args);
                    break;
                case "ShareAlbum":
                    returnValue = ShareAlbumCommand.Execute(args);
                    break;
                case "UploadPicture":
                    returnValue = UploadPictureCommand.Execute(args);
                    break;
                case "Exit":
                    returnValue = ExitCommand.Execute();
                    break;
                default:
                    throw new InvalidOperationException($"Command {command} not valid!");
            }
            return returnValue;
        }
    }
}
