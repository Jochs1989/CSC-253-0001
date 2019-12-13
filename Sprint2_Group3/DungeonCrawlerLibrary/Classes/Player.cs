using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Player class to assign information for the player, also tracks the users movement between rooms and allows for player creation.
    public class Player
    {
        public string PlayerName { get; set; } 
        public string Password { get; set; }
        public string PlayerClass { get; set; }
        public string PlayerRace { get; set; }
        public static Room CurrentRoom { get; set; }

        // Constructor to fill incase no information is avaliable
        public Player()
        {
            PlayerName = "";
            Password = "";
            PlayerClass = "";
            PlayerRace = "";
            CurrentRoom = GameAttributes.rooms[0];
        }
        // Constructor to assign information gathered
        public Player(string playerName, string password, string playerClass, string race)
        {
            PlayerName = playerName;
            Password = password;
            PlayerClass = playerClass;
            PlayerRace = race;
            CurrentRoom = GameAttributes.rooms[0];
        }
    }
}
