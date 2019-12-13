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
        public static void DisplayExits(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nYou are currently at {player.CurrentRoom.RoomName}.\nPlease Enter an action (move, attack, look) then a directive (North, goblin, desk) !\n (Example: move north)\n");
            List<string> exits = new List<string>();
            if (player.CurrentRoom.North != -1)
            {
                exits.Add("North");
            }
            if (player.CurrentRoom.South != -1)
            {
                exits.Add("South");
            }
            if (player.CurrentRoom.East != -1)
            {
                exits.Add("East");
            }
            if (player.CurrentRoom.West != -1)
            {
                exits.Add("West");
            }
            if (player.CurrentRoom.Up != -1)
            {
                exits.Add("Stairway Up");
            }
            if (player.CurrentRoom.Down != -1)
            {
                exits.Add("Stairway Down");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("You see Exits: ");

            for (int index = 0; index < exits.Count; index++)
            {
                Console.Write($"({exits[index]}) ");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
