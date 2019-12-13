using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class Treasure
    {
        // Treasure class to assign information for the Treasures
        public int ID { get; set; }
        public string Name { get; set; }

        // Constructor to assign information gathered
        public Treasure(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
