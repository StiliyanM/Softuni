using System;

public class Scale<T> where T : IComparable<T>
{
    private T Left { get; set; }
    private T Right { get; set; }

    public Scale(T left, T right)
    {
        this.Left = left;
        this.Right = right;
    }

    public T GetHeavier()
    {
        var result = Left.CompareTo(Right);

        switch (result)
        {
            case 1:
                return Left;
            case -1:
                return Right;
            default:
                return default(T);
        }
    }
}
