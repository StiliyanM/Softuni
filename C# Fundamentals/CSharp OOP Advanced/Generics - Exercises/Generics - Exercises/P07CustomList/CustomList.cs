using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07CustomList
{
    public class CustomList<T> : IEnumerable<T> where T: IComparable
    {
        private List<T> data = new List<T>();

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove(int index)
        {
            var removed = this.data[index];

            this.data.RemoveAt(index);

            return removed;
        }

        public bool Contains(T element)
        {
            if (this.data.Contains(element))
            {
                return true;
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            var temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            var count = 0;

            foreach (var item in data)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public void Sort()
        {
            this.data = this.data.OrderBy(e => e).ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
}
