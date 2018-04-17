using System;

namespace P01Database
{
    public class Database<T>
    {
        private const int Capacity = 16;

        protected readonly T[] values = new T[Capacity];

        private int currentIndex = -1;
        public Database(params T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Add(values[i]);
            }
        }

        public virtual void Add(T value)
        {
            if(currentIndex + 1 >= Capacity)
            {
                throw new InvalidOperationException();
            }

            currentIndex++;

            this.values[currentIndex] = value;
        }

        public T Remove()
        {
            if(this.currentIndex == -1)
            {
                throw new InvalidOperationException();
            }

            var element = this.values[currentIndex];

            this.values[currentIndex] = default(T);

            return element;
        }

        public T[] Fetch()
        {
            var resultArr = new T[16];

            Array.Copy(this.values, resultArr, this.currentIndex + 1);

            return resultArr;
        }
    }
}
