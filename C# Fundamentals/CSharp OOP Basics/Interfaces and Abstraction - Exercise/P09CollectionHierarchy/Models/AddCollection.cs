using System.Collections.Generic;

namespace P09CollectionHierarchy.Models
{
    using Contracts;
    public class AddCollection<T> : IAddCollection<T>
    {
        public AddCollection()
        {
            this.data = new List<T>();
        }

        protected readonly List<T> data;

        public virtual int Add(T item)
        {
            this.data.Add(item);

            return this.data.Count - 1;
        }
    }
}
