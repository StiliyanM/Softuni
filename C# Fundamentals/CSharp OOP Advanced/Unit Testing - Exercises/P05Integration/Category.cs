using System;
using System.Collections.Generic;
using System.Text;

namespace P05Integration
{
    public class Category
    {
        public string Name { get;private set; }

        public ICollection<User> Users { get; private set; } = new List<User>();

        public ICollection<Category> Categories { get; private set; } = new List<Category>();
    }
}
