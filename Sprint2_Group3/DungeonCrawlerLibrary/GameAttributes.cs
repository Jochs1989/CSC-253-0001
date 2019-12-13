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

        

        #region old object lists
        //public static List<Menu> menu = new List<Menu>()
        //{           
        //    new Menu("Type 'Room' to see all Rooms!"),
        //    new Menu("Type 'Quit' to exit the game!"),
        //    new Menu("Type 'Location' to see where you are!"),
        //    new Menu("Type 'Weapons' to see weapons!"),
        //    new Menu("Type 'Potions' to see Potions!"),
        //    new Menu("Type 'Treasures' to see Treasures!"),
        //    new Menu("Type 'Items' to see Items!"),
        //    new Menu("Type 'Mobs' to see Monsters!")
        //};


        //public static List<Room> rooms = new List<Room>()
        //{
        //    new Room(1, "entrance", 1, -1, -1, -1),
        //    new Room(2, "room1",    2,  0,  4, -1),
        //    new Room(3, "room2",   -1,  1,  3, -1),
        //    new Room(4, "room3",   -1,  4, -1,  2),
        //    new Room(5, "room4",    3, -1, -1,  1)
        //};

        //public static List<Weapon> weapons = new List<Weapon>()
        //{
        //    new Weapon(6, "Rusty Blade"),
        //    new Weapon(7, "Warped Staff"),
        //    new Weapon(8, "Worn Bow"),
        //    new Weapon(9, "Old Dagger")
        //};

        //public static List<Potion> potions = new List<Potion>()
        //{
        //    new Potion(1,  "Health Potion"),
        //    new Potion(11, "Mana Potion")
        //};

        //public static List<Treasure> treasures = new List<Treasure>()
        //{
        //    new Treasure(12, "Rusty Armor"),
        //    new Treasure(13, "Training Robes"),
        //    new Treasure(14, "Leather Armor")
        //};

        //public static List<Item> items = new List<Item>()
        //{
        //    new Item(15,"Home Beacon"),
        //    new Item(16,"Coin Pouch"),
        //    new Item(17,"Lock Pick"),
        //    new Item(18,"Tinderbox")
        //};

        //public static List<Mob> mobs = new List<Mob>()
        //{
        //    new Mob(15, "Goblin"),
        //    new Mob(16, "Sewer Rats"),
        //    new Mob(17, "Giant Spider"),
        //    new Mob(18, "Skeleton")
        //};
        #endregion

    }
}
