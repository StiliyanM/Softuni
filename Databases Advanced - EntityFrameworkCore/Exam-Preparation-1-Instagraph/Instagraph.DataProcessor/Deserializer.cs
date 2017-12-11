using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

using Newtonsoft.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using Instagraph.Data;
using Instagraph.Models;

namespace Instagraph.DataProcessor
{
    public class Deserializer
    {
        private static string ErrorMsg = "Error: Invalid data.";
        private static string SuccessMsg = "Successfully imported {0}.";

        public static string ImportPictures(InstagraphContext context, string jsonString)
        {
            var pictures = JsonConvert.DeserializeObject<Picture[]>(jsonString);

            var sb = new StringBuilder();
            var validatedPictures = new List<Picture>();

            foreach (var p in pictures)
            {
                bool isValid = !String.IsNullOrWhiteSpace(p.Path) && p.Size > 0;

                if (!isValid)
                {
                    sb.AppendLine(ErrorMsg);
                    continue;
                }

                validatedPictures.Add(p);
                sb.AppendLine(String.Format(SuccessMsg, $"Picture {p.Path}"));
            }

            context.Pictures.AddRange(validatedPictures);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportUsers(InstagraphContext context, string jsonString)
        {
            var deserializedUsers = JsonConvert.DeserializeObject<UserDto[]>(jsonString);

            var sb = new StringBuilder();
            var users = new List<User>();

            foreach (var userDto in deserializedUsers)
            {
                bool isValid = !String.IsNullOrWhiteSpace(userDto.Username)
                    && userDto.Username.Length <= 30
                    && !String.IsNullOrWhiteSpace(userDto.Password)
                    && userDto.Password.Length <= 20
                    && !String.IsNullOrWhiteSpace(userDto.ProfilePicture);

                var picture = context.Pictures.FirstOrDefault(p => p.Path == userDto.ProfilePicture);

                if (!isValid || picture == null)
                {
                    sb.AppendLine(ErrorMsg);
                    continue;
                }
                var user = Mapper.Map<User>(userDto);
                user.ProfilePicture = picture;

                users.Add(user);
                sb.AppendLine(String.Format(SuccessMsg, $"User {userDto.Username}"));
            }

            context.Users.AddRange(users);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
            
        }

        public static string ImportFollowers(InstagraphContext context, string jsonString)
        {
            var followers = JsonConvert.DeserializeObject<FollowersDto[]>(jsonString);

            var sb = new StringBuilder();

            var validatedFollowers = new List<UserFollower>();
            foreach (var followerDto in followers)
            {
                bool isValid = !string.IsNullOrWhiteSpace(followerDto.Follower)
                    && followerDto.Follower.Length <= 30
                    && !string.IsNullOrWhiteSpace(followerDto.User)
                    && followerDto.User.Length <= 30;

                var user = context.Users
                    .FirstOrDefault(u => u.Username == followerDto.User);

                var follower = context.Users
                    .FirstOrDefault(u => u.Username == followerDto.Follower);

                bool FollowerExists = validatedFollowers
                    .Any(f => f.Follower == follower && f.User == user);

                if(!isValid || user == null || follower == null || FollowerExists)
                {
                    sb.AppendLine(ErrorMsg);
                    continue;
                }

                var validFollower = Mapper.Map<UserFollower>(followerDto);

                validFollower.Follower = follower;
                validFollower.User = user;

                validatedFollowers.Add(validFollower);
                sb.AppendLine(
                    String.Format(SuccessMsg, 
                    $"Follower {validFollower.Follower.Username} to User {validFollower.User.Username}"));
            }

            context.UsersFollowers.AddRange(validatedFollowers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportPosts(InstagraphContext context, string xmlString)
        {
            var xmlDoc = XDocument.Parse(xmlString);

            var sb = new StringBuilder();

            var posts = new List<Post>();

            var elements = xmlDoc.Root.Elements();

            foreach (var e in elements)
            {
                string caption = e.Element("caption").Value;
                string userName = e.Element("user").Value;
                string picturePath = e.Element("picture").Value;

                bool isValid = userName.Length <= 30;

                var user = context.Users.FirstOrDefault(u => u.Username == userName);
                var picture = context.Pictures.FirstOrDefault(p => p.Path == picturePath);

                if (!isValid || user == null || picture == null)
                {
                    sb.AppendLine(ErrorMsg);
                    continue;
                }

                var post = new Post
                {
                    Caption = caption,
                    Picture = picture,
                    User = user
                };

                posts.Add(post);
                sb.AppendLine(String.Format(SuccessMsg, $"Post {caption}"));
            }

            context.Posts.AddRange(posts);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportComments(InstagraphContext context, string xmlString)
        {
            var xDoc = XDocument.Parse(xmlString);

            var sb = new StringBuilder();

            var comments = new List<Comment>();

            var elements = xDoc.Root.Elements();

            foreach (var e in elements)
            {

                bool IsValid = (e.Elements().Any(el => el.Name == "post"))
                    && (e.Elements().Any(el => el.Name == "content"))
                    && (e.Elements().Any(el => el.Name == "user"));

                if (!IsValid)
                {
                    sb.AppendLine(ErrorMsg);
                    continue;
                }
                var content = e.Element("content").Value;
                var username = e.Element("user").Value;
                var postId = int.Parse(e.Element("post").Attribute("id").Value);

                var user = context.Users.FirstOrDefault(u => u.Username == username);
                var post = context.Posts.Find(postId);

                if(user == null || post == null)
                {
                    sb.AppendLine(ErrorMsg);
                    continue;
                }

                var comment = new Comment
                {
                    Content = content,
                    User = user,
                    Post = post
                };

                comments.Add(comment);
                sb.AppendLine(String.Format(SuccessMsg, $"Comment {content}"));
            }

            context.Comments.AddRange(comments);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }
    }
}
