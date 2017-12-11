namespace PhotoShare.Client.Core.Commands
{
    using System;
    using Models;
    using Data;
    using System.Linq;

    public class ShareAlbumCommand
    {
        // ShareAlbum <albumId> <username> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public static string Execute(string[] data)
        {
            var albumId = int.Parse(data[0]);
            var username = data[1];
            var permission = data[2];

            using (var context = new PhotoShareContext())
            {
                var album = context.Albums.Find(albumId);
                var user = context.Users.FirstOrDefault(u => u.Username == username);

                if(album == null)
                {
                    throw new ArgumentException($"Album {albumId} not found!");
                }

                if(user == null)
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                Role role;
                if(!Enum.TryParse(permission,out role))
                {
                    throw new ArgumentException("Permission must be either \"Owner\" or \"Viewer\"!");
                }

                context.AlbumRoles.
                    FirstOrDefault(ar => ar.Album == album && ar.User == user)
                    .Role = role;

                context.SaveChanges();

                return $"Username {username} added to album {albumId} ({permission})";
            }
        }
    }
}
