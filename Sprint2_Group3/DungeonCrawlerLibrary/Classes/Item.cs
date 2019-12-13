using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Item class to assign information for the items
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Constructor to assign information gathered
        public Item(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
