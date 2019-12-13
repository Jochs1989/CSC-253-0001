using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Room class to assign information for the Room, the player class access a room list which has information from here.
    public class Room
    {
        private int _id;
        private string _roomName;
        private string _description;
        private int _north;
        private int _south;
        private int _east;
        private int _west;
        private int _up;
        private int _down;
        private Mob _mobs;

        public int ID { get { return _id; } set { _id = value; } }
        public string RoomName { get { return _roomName; } set { _roomName = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int North { get { return _north; } set { _north = value; } }
        public int South { get { return _south; } set { _south = value; } }
        public int East { get { return _east; } set { _east = value; } }
        public int West { get { return _west; } set { _west = value; } }
        public int Up { get { return _up; } set { _up = value; } }
        public int Down { get { return _down; } set { _down = value; } }
        public Mob CurrentMob { get { return _mobs; } set { _mobs = value; } }

        // Constructor to assign information gathered
        public Room(int id, string roomName, string description, int north, int south, int east, int west, int up, int down, int mobRoll)
        {
            ID = id;
            RoomName = roomName;
            Description = description;
            North = north;
            South = south;
            East = east;
            West = west;
            Up = up;
            Down = down;
            // Allows for the mob to be randomly generated.
            if (mobRoll > -1)
            {
                if (mobRoll < 1)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(0, 6);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
                else if (mobRoll < 2)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(7, 14);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
                else if (mobRoll < 3)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(15, 24);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
                else if (mobRoll < 4)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(25, 32);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
                else if (mobRoll < 5)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(33, 39);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
                else if (mobRoll < 6)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(40, 40);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
                else if (mobRoll < 6)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(41, 41);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
                else if (mobRoll < 6)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(42, 42);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
                else if (mobRoll < 6)
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(43, 43);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
                else
                {
                    int rolledMob = RandomNumGenerator.NumberBetween(44, 44);
                    CurrentMob = new Mob(GameAttributes.mobs[rolledMob]);
                }
            }
            
        }
    }
}
