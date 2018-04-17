namespace P09CollectionHierarchy.Models
{
    using Contracts;
    using System.Linq;

    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        public int Used => base.data.Count;

        public override T Remove()
        {
            var element = this.data.First();
            this.data.RemoveAt(0);
            return element;
        }
    }
}
