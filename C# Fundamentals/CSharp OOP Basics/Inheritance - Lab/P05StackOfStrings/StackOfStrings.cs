using System;
using System.Collections.Generic;
using System.Linq;

public class StackOfStrings
{
    private List<String> data = new List<string>();

    public void Push(string item)
    {
        data.Add(item);
    }

    public string Pop()
    {
        var itemToPop = Peek();
        data.RemoveAt(data.Count - 1);

        return itemToPop;
    }

    public string Peek()
    {
        return data.Last();
    }

    public bool IsEmpty()
    {
        return data.Count == 0;
    }
}