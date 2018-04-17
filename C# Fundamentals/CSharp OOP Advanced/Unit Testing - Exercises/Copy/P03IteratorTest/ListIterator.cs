using System;
using System.Collections.Generic;
using System.Linq;

namespace P03IteratorTest
{
    public class ListIterator
    {
        private List<string> elements;

        private int currentIndex;

        public ListIterator(IEnumerable<string> elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException();
            }
            this.elements = new List<string>(elements);
        }

        public bool HasNext() =>
            currentIndex + 1 < this.elements.Count ? true : false;

        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (!this.elements.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.elements[currentIndex]);
        }
    }
}
