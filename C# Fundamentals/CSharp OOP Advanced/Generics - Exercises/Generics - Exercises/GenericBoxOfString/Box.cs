using System;

namespace P01GenericBoxOfString
{
    public class Box<T> where T: IComparable
    {
        private T t;

        public string FullName => this.t.GetType().FullName;
        public T Value => t;

        public Box(T T)
        {
            this.t = T;
        }

        public int Compare(T element)
        {
            return this.t.CompareTo(element);
        }

        public override string ToString()
        {
            return $"{this.FullName}: {this.Value}";
        }
    }
}
