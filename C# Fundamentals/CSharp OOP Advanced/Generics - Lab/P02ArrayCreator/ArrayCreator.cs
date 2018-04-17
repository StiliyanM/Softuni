using System.Linq;

public static class ArrayCreator
{
    public static T[] Create<T>(int length, T item) 
    {
        var array = new T[length];

        return array.Select(e => e = item).ToArray();
    }
}

