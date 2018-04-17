using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    public int Count => Elements.Count;

    private List<T> Elements { get; set; } = new List<T>();
    public void Add(T element)
    {
        Elements.Add(element);
    }

    public T Remove()
    {
        var elementToRemove = Elements.Last();
        Elements.RemoveAt(this.Count - 1);

        return elementToRemove;
    }
}
