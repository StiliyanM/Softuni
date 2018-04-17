using System;
using System.Collections;
using System.Collections.Generic;

namespace P09LinkedListTraversal
{
    public class LinkedList<T> : IEnumerable<T>
                                where T : IComparable<T>
    {
        public class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }
            public T Value { get; set; }

            public Node Next { get; set; }
        }

        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public int Count { get; private set; }
        public bool IsEmpty => this.Count == 0;

        public void Add(T item)
        {
            Node old = this.Tail;
            this.Tail = new Node(item);

            if (this.IsEmpty)
            {
                this.Head = Tail;
            }
            else
            {
                old.Next = this.Tail;
            }

            this.Count++;
        }

        public bool Remove(T number)
        {
            Node current = this.Head;
            Node previous = null;

            while (current != null)
            {
                if (current.Value.CompareTo(number) == 0)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        current = current.Next;
                    }
                    else
                    {
                        previous = current;
                        current = current.Next;
                        this.Head = current;
                    }

                    this.Count--;
                    return true;
                }
                else
                    previous = current;

                current = current.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = this.Head;

            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
