using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawlerLibrary
{
    public class ListCreation
    {
        public static void FromReader()
        {
            // Each one is used to read from the designated file. Then stores the information pulled into list of objects in GameAttributes.cs
            #region Mob
            using (StreamReader fileReader = new StreamReader("Mob.csv"))
            {
                fileReader.ReadLine(); // Skips the headers in .xml file

                while (!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    GameAttributes.mobs.Add(new Mob(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6]), values[7], int.Parse(values[8]), bool.Parse(values[9])));
                }
            }
            #endregion

            #region Weapon
            using (StreamReader fileReader = new StreamReader("Weapon.csv"))
            {
                fileReader.ReadLine();

                while (!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    GameAttributes.weapons.Add(new Weapon(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), bool.Parse(values[4]), values[5], int.Parse(values[6]), int.Parse(values[7]), int.Parse(values[8])));
                }
            }
            #endregion

            #region Potion
            using (StreamReader fileReader = new StreamReader("Potion.csv"))
            {
                fileReader.ReadLine();

                while (!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    GameAttributes.potions.Add(new Potion(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6])));
                }
            }
            #endregion

            #region Treasure
            using (StreamReader fileReader = new StreamReader("Treasure.csv"))
            {
                fileReader.ReadLine();

                while (!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    GameAttributes.treasures.Add(new Treasure(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), bool.Parse(values[4]), bool.Parse(values[5])));
                }
            }
            #endregion

            #region Item
            using (StreamReader fileReader = new StreamReader("Item.csv"))
            {
                fileReader.ReadLine();

                while (!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    GameAttributes.items.Add(new Item(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), bool.Parse(values[4])));
                }
            }
            #endregion

            #region Room
            using (StreamReader fileReader = new StreamReader("Room.csv"))
            {
                fileReader.ReadLine();
                while (!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    GameAttributes.rooms.Add(new Room(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6]), int.Parse(values[7]), int.Parse(values[8]), int.Parse(values[9])));
                }
            }
            #endregion

            #region Menu
            using (StreamReader fileReader = new StreamReader("Menu.csv"))
            {
                fileReader.ReadLine();

                while (!fileReader.EndOfStream)
                {
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');

                    GameAttributes.options.Add(new Menu(values[0]));
                }
            }
            #endregion
        }
    }
}
