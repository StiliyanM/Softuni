namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Client.Utilities;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Linq;

    public class AddTagToCommand 
    {
        // AddTagTo <albumName> <tag>
        public static string Execute(string[] data)
        {
            var albumName = data[0];
            var tagName = data[1].ValidateOrTransform();

            using (var context = new PhotoShareContext())
            {
                var tag = context.Tags.FirstOrDefault(t => t.Name == tagName);
                var album = context.Albums.FirstOrDefault(a => a.Name == albumName);

                if(!(tag != null && album != null))
                {
                    throw new ArgumentException($"Either tag or album do not exist!");
                }

                var albumTag = new AlbumTag()
                {
                    Album = album,
                    Tag = tag
                };

                context.AlbumTags.Add(albumTag);

                context.SaveChanges();
            }

            return $"Tag {tagName} added to {albumName}!";
        }
    }
}
