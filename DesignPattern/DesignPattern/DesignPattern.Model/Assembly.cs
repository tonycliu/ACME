using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class Assembly : Item
    {
        private List<Item> items;

        public Assembly(string description) : base(description, 0) 
        {
            this.items = new List<Item>();
        }

        public override void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public override void RemoveItem(Item item)
        {
            this.items.Remove(item);
        }

        public override Item[] Items
        {
            get { return this.items.ToArray(); }
        }

        public override int Cost
        {
            get
            {
                int cost = 0;
                foreach (Item item in this.items)
                {
                    cost += item.Cost;
                }

                return cost;
            }
        }
    }
}
