namespace PhotoShare.Client.Core.Commands
{
    using Models;
    using Data;
    using Utilities;
    using System.Linq;
    using System;

    public class AddTagCommand
    {
        // AddTag <tag>
        public static string Execute(string[] data)
        {
            string tagName = data[0].ValidateOrTransform();

            //Extend
            if (Session.User == null)
            {
                throw new InvalidOperationException("Invalid credentials!");
            }


            using (PhotoShareContext context = new PhotoShareContext())
            {
                var tag = context.Tags.FirstOrDefault(t => t.Name == tagName);

                if (tag != null)
                {
                    throw new ArgumentException($"Tag {tagName} exists!");
                }

                context.Tags.Add(new Tag
                {
                    Name = tagName
                });

                context.SaveChanges();
            }

            return tagName + " was added successfully to database!";
        }
    }
}
