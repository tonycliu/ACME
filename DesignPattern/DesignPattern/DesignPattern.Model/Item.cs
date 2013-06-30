using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public abstract class Item
    {
        private string description;
        private int cost;

        public Item(string description, int cost)
        {
            this.description = description;
            this.cost = cost;
        }

        public virtual string Description { get { return this.description; } }
        public virtual int Cost { get { return this.cost; } }

        public abstract void AddItem(Item item);
        public abstract void RemoveItem(Item item);
        public abstract Item[] Items { get; }

        public override string ToString()
        {
            return this.Description + " (Cost: " + this.Cost + ")";
        }
    }
}
