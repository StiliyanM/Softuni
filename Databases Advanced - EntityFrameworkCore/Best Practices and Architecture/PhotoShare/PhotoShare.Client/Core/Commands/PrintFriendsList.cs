namespace PhotoShare.Client.Core.Commands
{
    using Microsoft.EntityFrameworkCore;
    using PhotoShare.Data;
    using System;
    using System.Linq;
    using System.Text;

    public class PrintFriendsListCommand 
    {
        // PrintFriendsList <username>
        public static string Execute(string[] data)
        {
            var username = data[0];

            var result = new StringBuilder();

            using (var db = new PhotoShareContext())
            {
                var user = db.Users
                    .Include(u => u.FriendsAdded)
                    .ThenInclude(u => u.Friend)
                    .FirstOrDefault(u => u.Username == username);

                if(user == null)
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                var friends = user.FriendsAdded.Select(fa => fa.Friend).ToList();

                if(friends.Count == 0)
                {
                    return "No friends for this user. :(";
                }

                result.AppendLine("Friends:");

                foreach (var f in friends.OrderBy(f => f.Username))
                {
                    result.AppendLine($"-{f.Username}");
                }
            }

            return result.ToString();
        }
    }
}
