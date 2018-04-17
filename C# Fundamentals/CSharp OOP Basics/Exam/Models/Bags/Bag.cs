using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonsAndCodeWizards.Models.Bags
{
    using Items;
    public abstract class Bag
    {
        protected Bag(int capacity)
        {
            this.Capacity = capacity;
        }
        public virtual int Capacity { get; protected set; } = 100;

        private List<Item> items = new List<Item>();

        public IReadOnlyCollection<Item> Items => items;

        public int Load => this.Items.Sum(i => i.Weight);

        public virtual void AddItem(Item item)
        {
            if(this.Load + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            this.items.Add(item);
        }

        public virtual Item GetItem(string name)
        {
            if (this.Items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            var item = Items.FirstOrDefault(i => i.Name == name);

            if(item == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }

            var index = items.IndexOf(item);
            this.items.RemoveAt(index);

            return item;
        }
    }
}
