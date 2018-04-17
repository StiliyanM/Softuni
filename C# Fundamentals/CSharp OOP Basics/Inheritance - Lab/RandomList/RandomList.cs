using System;
using System.Collections.Generic;

public class RandomList : List<string>
{
    public string RandomString()
    {
        var index = GetRandomIndex(0, base.Count);

        var str = base[index];

        base.RemoveAt(index);

        return str;
    }

    private int GetRandomIndex(int startIndex, int count)
    {
        var rnd = new Random();

        return rnd.Next(startIndex, count);
    }
}