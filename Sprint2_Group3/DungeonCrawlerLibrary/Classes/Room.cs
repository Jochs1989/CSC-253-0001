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
        public int ID { get; set; }
        public string RoomName { get; set; }
        public int North { get; set; }
        public int South { get; set; }
        public int East { get; set; }
        public int West { get; set; }

        // Constructor to assign incase no information is available
        public Room()
        {
            ID = 0;
            RoomName = null;
            North = 0;
            South = 0;
            East = 0;
            West = 0;
        }
        // Constructor to assign information gathered
        public Room(int id, string roomName, int north, int south, int east, int west)
        {
            ID = id;
            RoomName = roomName;
            North = north;
            South = south;
            East = east;
            West = west;
        }
    }
}
