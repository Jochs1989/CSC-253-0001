using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Treasure class to assign information for the Treasures
    public class Treasure : InheritItem
    {
        private bool _questItem;
        private bool _canUse;

        public bool QuestItem { get { return _questItem; } set { _questItem = value; } }
        public bool CanUse { get { return _canUse; } set { _canUse = value; } }

        // Constructor to assign information gathered
        public Treasure(int id, string name, string description, int price, bool canUse, bool questItem) : base(id, name, description, price)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            CanUse = canUse;
            QuestItem = questItem;
        }
    }
}
