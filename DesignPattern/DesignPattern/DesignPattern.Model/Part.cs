using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class Part : Item
    {
        public Part(string description, int cost) : base(description, cost) { }

        // unit part, no implementation
        public override void AddItem(Item item)
        {
            
        }

        // unit part, no implementation
        public override void RemoveItem(Item item)
        {
            
        }

        public override Item[] Items
        {
            get { return new Item[0]; }
        }
    }
}
