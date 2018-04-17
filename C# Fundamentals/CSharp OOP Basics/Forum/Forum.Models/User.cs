using System.Collections.Generic;

namespace Forum.Models
{
    public class User
    {
        public User(int id, string username, string password, IEnumerable<int> postIds)
            :this(id,username,password)
        {
            this.PostIds = new List<int>(postIds);
        }

        public User(int id, string username, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
        }
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public ICollection<int> PostIds { get; set; } = new List<int>();

    }
}
