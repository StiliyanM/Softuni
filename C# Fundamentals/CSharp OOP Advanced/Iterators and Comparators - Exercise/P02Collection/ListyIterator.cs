using System;
using System.Collections;
using System.Collections.Generic;

namespace P02Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;

        private int index = 0;

        public ListyIterator(ICollection<T> data)
        {
            this.data = new List<T>(data);
        }

        public ListyIterator()
        {
            this.data = new List<T>();
        }

        public void Create(List<T> elements)
        {
            this.data = elements;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext() => index + 1 < this.data.Count ? true : false;

        public void Print()
        {
            if(this.data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.data[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
