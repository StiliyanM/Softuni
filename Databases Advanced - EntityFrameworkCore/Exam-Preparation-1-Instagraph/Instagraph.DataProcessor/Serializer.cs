using System;

using Instagraph.Data;
using System.Linq;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Instagraph.DataProcessor
{
    public class Serializer
    {
        public static string ExportUncommentedPosts(InstagraphContext context)
        {
            var uncommentedPosts = context.Posts
                .Where(p => p.Comments.Count == 0)
                .OrderBy(p => p.Id)
                .Select(p => new
                {
                    Id = p.Id,
                    Picture = p.Picture.Path,
                    User = p.User.Username
                }).ToArray();

            var jsonString = JsonConvert.SerializeObject(uncommentedPosts);

            return jsonString;
        }

        public static string ExportPopularUsers(InstagraphContext context)
        {
            var popularUsers = context.Users
                .Where(u => u.Posts
                                .Any(p => p.Comments
                                .Any(c => u.Followers
                                .Any(f => f.FollowerId == c.UserId))))
                .OrderBy(u => u.Id)
                .Select(u => new
                {
                    Username = u.Username,
                    Followers = u.Followers.Count
                }).ToArray();

            return JsonConvert.SerializeObject(popularUsers);
        }

        public static string ExportCommentsOnPosts(InstagraphContext context)
        {
            var result = context.Users
                .Select(u => new
                {
                    Username = u.Username,
                    PostCommentCount = u.Posts.Select(p => p.Comments.Count).ToArray()
                }).ToArray();

            var postComments = new List<PostCommentsDto>();

            foreach (var e in result)
            {
                var mostComments = 0;

                if(e.PostCommentCount.Length != 0)
                {
                    mostComments = e.PostCommentCount.OrderByDescending(p => p).First();
                }

                var postComment = new PostCommentsDto
                {
                    Username = e.Username,
                    MostComments = mostComments
                };

                postComments.Add(postComment);
            }

            var xDoc = new XDocument(new XElement("users"));

            foreach (var e in postComments
                                .OrderByDescending(p => p.MostComments)
                                .ThenBy(p => p.Username))
            {
                xDoc.Root.Add(new XElement("user",
                   new XElement("Username", e.Username),
                   new XElement("MostComments", e.MostComments))
                    );
            }

            return xDoc.ToString();
        }
    }
}
