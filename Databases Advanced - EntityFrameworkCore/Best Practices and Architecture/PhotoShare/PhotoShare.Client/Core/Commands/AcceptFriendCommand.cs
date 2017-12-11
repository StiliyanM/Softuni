namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Linq;

    public class AcceptFriendCommand
    {
        // AcceptFriend <username1> <username2>
        public static string Execute(string[] data)
        {
            var username1 = data[0];
            var username2 = data[1];

            using (var context = new PhotoShareContext())
            {
                var firstUser = context.Users.FirstOrDefault(u => u.Username == username1);
                var secondUser = context.Users.FirstOrDefault(u => u.Username == username2);

                if (firstUser == null)
                {
                    throw new ArgumentException($"{username1} not found!");
                }
                if (secondUser == null)
                {
                    throw new ArgumentException($"{username2} not found!");
                }

                if(!context.Friendships.Any(f => f.User == secondUser && f.Friend == firstUser))
                {
                    throw new InvalidOperationException($"{username2} has not added {username1} as a friend");
                }

                if (context.Friendships.Any(f => f.UserId == firstUser.Id && f.FriendId == secondUser.Id))
                {
                    throw new InvalidOperationException($"{username2} is already a friend to {username1}");
                }

                context.Friendships.Add(new Friendship()
                {
                    User = firstUser,
                    Friend = secondUser
                });

                context.SaveChanges();

                return $"{username1} accepted {username2} as a friend.";
            }
        }
    }
}
