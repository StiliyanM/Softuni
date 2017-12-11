namespace PhotoShare.Client.Core.Commands
{
    using Microsoft.EntityFrameworkCore;
    using PhotoShare.Client.Utilities;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CreateAlbumCommand
    {
        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public static string Execute(string[] data)
        {
            var username = data[0];
            var albumTitle = data[1];
            var bgColor = data[2];
            var tags = data.Skip(3).Select(t => t.ValidateOrTransform()).ToArray();

            using (var context = new PhotoShareContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);

                if(user == null)
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                var album = context.Albums
                    .Include(a => a.AlbumRoles)
                    .FirstOrDefault(a => a.Name == albumTitle);

                if(album != null)
                {
                    throw new ArgumentException($"Album {album.Name} exists!");
                }

                foreach (var tag in tags)
                {
                    if(context.Tags.FirstOrDefault(t => t.Name == tag) == null)
                    {
                        throw new ArgumentException("Invalid tags!");
                    }
                }

                Color color;
                if (!Enum.TryParse(bgColor, out color))
                {
                    throw new ArgumentException($"Color {bgColor} not found!");
                }

                var newAblum = new Album()
                {
                    Name = albumTitle,
                    BackgroundColor = color,
                    AlbumRoles = new List<AlbumRole>()
                    {
                        new AlbumRole()
                        {
                            User = user,
                            Role = Role.Owner
                        }
                    },
                    AlbumTags = tags.Select(t => new AlbumTag()
                    {
                        Tag = context.Tags
                            .FirstOrDefault(ct => ct.Name == t)
                    })
                    .ToArray()
                };

                context.Albums.Add(newAblum);

                context.SaveChanges();

                return $"Album {albumTitle} successfully created!";
            }
        }
    }
}
