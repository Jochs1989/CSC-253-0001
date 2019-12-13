using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class PlayerMovement
    {
        public static string DisplayMovement(Player player, string input)
        {
            // Here after the player enters a direction the program finds which direction the user entered, then finds if the direction is valid by accessing the players current location.
            // If the direction is valid it will move the players current location to the new room by changing the currentroom in player.cs to the new subscript location.

            #region Player Movement North
            if (input.ToLower() == "north")
            {
                if (player.CurrentRoom.North != -1)
                {
                    player.CurrentRoom = GameAttributes.RoomByID(player.CurrentRoom.North);
                }
                else
                {
                    Console.WriteLine("\nYou are looking at a wall\n");
                }
            }
            #endregion Player Movement North

            #region Player Movement South
            else if (input.ToLower() == "south")
            {
                if (player.CurrentRoom.South != -1)
                {
                    player.CurrentRoom = GameAttributes.RoomByID(player.CurrentRoom.South);
                }
                else
                {
                    Console.WriteLine("\nYou are looking at a wall\n");
                }
            }
            #endregion Player Movement South

            #region Player Movement East
            else if (input.ToLower() == "east")
            {
                if (player.CurrentRoom.East != -1)
                {
                    player.CurrentRoom = GameAttributes.RoomByID(player.CurrentRoom.East);
                }
                else
                {
                    Console.WriteLine("\nYou are looking at a wall\n");
                }
            }
            #endregion Player Movement East

            #region Player Movement West
            else if (input.ToLower() == "west")
            {
                if (player.CurrentRoom.West != -1)
                {
                    player.CurrentRoom = GameAttributes.RoomByID(player.CurrentRoom.West);
                }
                else
                {
                    Console.WriteLine("\nYou are looking at a wall\n");
                }
            }
            #endregion Player Movement West

            #region Player Movement Up
            else if (input.ToLower() == "up")
            {
                if (player.CurrentRoom.Up != -1)
                {
                    player.CurrentRoom = GameAttributes.RoomByID(player.CurrentRoom.Up);
                }
                else
                {
                    Console.WriteLine("\nYou are looking at a wall\n");
                }
            }
            #endregion Player Movement Up

            #region Player Movement Down
            else if (input.ToLower() == "down")
            {
                if (player.CurrentRoom.Down != -1)
                {
                    player.CurrentRoom = GameAttributes.RoomByID(player.CurrentRoom.Down);
                }
                else
                {
                    Console.WriteLine("\nYou are looking at a wall\n");
                }
            }
            else
            {
                Console.WriteLine("\nNot a Valid Direction\n");
            }
            #endregion Player Movement Down
            return input;
        }
    }
}
