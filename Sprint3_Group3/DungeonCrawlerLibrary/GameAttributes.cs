using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawlerLibrary
{
    // Class used to store information in object lists from the files read in ListCreation.cs. These are used to display information to the user.
    public static class GameAttributes
    {
        #region List 
        public static List<Mob> mobs = new List<Mob>();
        public static List<Weapon> weapons = new List<Weapon>();
        public static List<Potion> potions = new List<Potion>();
        public static List<Treasure> treasures = new List<Treasure>();
        public static List<Item> items = new List<Item>();
        public static List<Room> rooms = new List<Room>();
        public static List<Menu> options = new List<Menu>();

        #endregion
        // All methods are used to search for specific elements in the lists based of ID.
        public static Weapon PlayerWeaponByID(int id)
        {
            return weapons.SingleOrDefault(x => x.ID == id);
        }
        
        public static Potion PlayerPotionByID(int id)
        {
            return potions.SingleOrDefault(x => x.ID == id);
        }
        public static Treasure PlayerTreasureByID(int id)
        {
            return treasures.SingleOrDefault(x => x.ID == id);
        }
        public static Item PlayerItemByID(int id)
        {
            return items.SingleOrDefault(x => x.ID == id);
        }

        public static Mob MobByID(int id)
        {
            return mobs.SingleOrDefault(x => x.ID == id);
        }

        public static Room RoomByID(int id)
        {
            return rooms.SingleOrDefault(x => x.ID == id);
        }
    }
}
