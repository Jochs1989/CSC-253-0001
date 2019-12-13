using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class PlayerMovement
    {
        public static string DisplayMovement(string input)
        {
            // Here after the player enters a direction the program finds which direction the user entered, then finds if the direction is valid by accessing the players current location.
            // If the direction is valid it will move the players current location to the new room by changing the currentroom in player.cs to the new subscript location.

            #region Player Movement North
            if (input.ToLower() == "north")
            {
                if (Player.CurrentRoom.North != -1)
                {
                    Player.CurrentRoom = GameAttributes.rooms[Player.CurrentRoom.North];
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
                if (Player.CurrentRoom.South != -1)
                {
                    Player.CurrentRoom = GameAttributes.rooms[Player.CurrentRoom.South];
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
                if (Player.CurrentRoom.East != -1)
                {
                    Player.CurrentRoom = GameAttributes.rooms[Player.CurrentRoom.East];
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
                if (Player.CurrentRoom.West != -1)
                {
                    Player.CurrentRoom = GameAttributes.rooms[Player.CurrentRoom.West];
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
            #endregion Player Movement West

            return input;
        }
    }
}
