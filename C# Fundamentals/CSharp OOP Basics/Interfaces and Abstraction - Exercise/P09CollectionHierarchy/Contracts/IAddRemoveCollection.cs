namespace P09CollectionHierarchy.Contracts
{
    public interface IAddRemoveCollection<T> : IAddCollection<T>
    {
        T Remove();
    }
}
