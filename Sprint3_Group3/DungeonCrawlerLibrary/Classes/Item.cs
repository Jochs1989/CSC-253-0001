using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Item class to assign information for the items
    public class Item : InheritItem
    {
        private bool _canUse;

        public bool CanUse { get { return _canUse; } set { _canUse = value; } }

        public Item(int id, string name, string description, int price, bool canUse) : base(id, name, description, price)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            CanUse = canUse;
        }
    }
}
