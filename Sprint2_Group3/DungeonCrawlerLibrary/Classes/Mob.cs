using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Mob class to assign information for the Mobs
    public class Mob
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public int Armour { get; set; }
        #endregion

        // Constructor to assign information gathered
        #region Constructors
        public Mob(int id, string name, string description, int hp, int ac, int armour)
        {
            ID = id;
            Name = name;
            HP = hp;
            Description = description;
            AC = ac;
            Armour = armour;
        }
        #endregion
    }
}
