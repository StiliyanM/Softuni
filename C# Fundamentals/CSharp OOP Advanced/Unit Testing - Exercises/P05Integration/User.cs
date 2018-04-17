using System.Collections.Generic;

namespace P05Integration
{
    public class User
    {
        public string Name { get;private set; }

        public ICollection<Category> Categories { get; private set; } = new List<Category>();

        public void AddCategory(Category category)
        {
            this.Categories.Add(category);
        }
    }
}