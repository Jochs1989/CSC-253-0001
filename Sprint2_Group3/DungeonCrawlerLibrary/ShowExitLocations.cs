using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class ShowExitLocations
    {
        // This is used to display the users current location then access the current room they are in and find which directions are valid.
        // Then the program displays the valid directions back to user.
        public static void DisplayExits()
        {
            Console.WriteLine("You are at {0}", Player.CurrentRoom.RoomName);
            List<string> exits = new List<string>();
            if (Player.CurrentRoom.North != -1)
            {
                exits.Add("North ");
            }
            if (Player.CurrentRoom.South != -1)
            {
                exits.Add("South ");
            }
            if (Player.CurrentRoom.East != -1)
            {
                exits.Add("East ");
            }
            if (Player.CurrentRoom.West != -1)
            {
                exits.Add("West");
            }

            Console.Write("You see Exits: ");

            for (int index = 0; index < exits.Count; index++)
            {
                Console.Write(exits[index]);
            }

        }
    }
}
