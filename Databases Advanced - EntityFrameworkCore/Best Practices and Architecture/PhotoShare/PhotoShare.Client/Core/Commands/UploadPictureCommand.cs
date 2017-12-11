namespace PhotoShare.Client.Core.Commands
{
    using System;
    using Models;
    using Data;
    using System.Linq;

    public class UploadPictureCommand
    {
        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public static string Execute(string[] data)
        {
            var albumName = data[0];
            var pictureTitle = data[1];
            var pictureFilePath = data[2];

            using (var context = new PhotoShareContext())
            {
                var album = context.Albums.FirstOrDefault(a => a.Name == albumName);

                if(album == null)
                {
                    throw new ArgumentException($"Album {album} not found!");
                }

                var picture = new Picture()
                {
                    Album = album,
                    Title = pictureTitle,
                    Path = pictureFilePath
                };

                album.Pictures.Add(picture);

                context.SaveChanges();
                return $"Picture {picture.Title} added to {album.Name}!";
            }

        }
    }
}
