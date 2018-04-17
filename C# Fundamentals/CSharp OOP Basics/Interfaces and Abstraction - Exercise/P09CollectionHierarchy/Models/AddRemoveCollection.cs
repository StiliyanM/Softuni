namespace P09CollectionHierarchy.Models
{
    using Contracts;

    public class AddRemoveCollection<T> : AddCollection<T>,IAddRemoveCollection<T>
    {
        public override int Add(T item)
        {
            base.data.Insert(0, item);

            return 0;
        }

        public virtual T Remove()
        {
            var index = base.data.Count - 1;
            var element = base.data[index];

            base.data.RemoveAt(index);

            return element;
        }
    }
}
