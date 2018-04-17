using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P03Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> data = new List<T>();

        public bool IsEmpty => this.data.Count == 0;

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public T Pop()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No elements");
            }

            var index = this.data.Count - 1;
            var element = this.data[index];

            this.data.RemoveAt(index);

            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int k = 0; k < 2; k++)
            {
                for (int i = this.data.Count - 1; i >= 0; i--)
                {
                    yield return this.data[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
