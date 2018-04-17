using Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data
{
    public class ForumData
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Reply> Replies { get; set; } = new List<Reply>();


        public ForumData()
        {
            this.Categories = DataMapper.LoadCategories();
            this.Users = DataMapper.LoadUsers();
            this.Posts = DataMapper.LoadPosts();
            this.Replies = DataMapper.LoadReplies();
        }

        public void SaveChanges()
        {
            DataMapper.SaveCategories(this.Categories);
            DataMapper.SaveUsers(this.Users);
            DataMapper.SavePosts(this.Posts);
            DataMapper.SaveReplies(this.Replies);
        }
    }
}
