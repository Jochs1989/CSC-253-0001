using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawlerLibrary;

/**

* 10/06/2019
* CSC 253
* Rashad Henry, Jeffrey Ochs, Winston Stoker
* The program will allow the user to create or load a player profile. They will then be able to access a menu and see a list of options. Along with being able to move around 5 rooms in the game.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            // Here we call our list creation to create all our list from files we have saved in our bin
            // Then we show the user a welcome screen
            // Finally the program goes to player creation and asks the user if they want to create or load a player.
            
            #region Startup
            ListCreation.FromReader();

            Console.WriteLine("Welcome to The Kingdom Of Old Renown!"); //ToDo better welcome screeen!

            NewOrOldPlayer.PlayerCreateOrLoad(); //Todo Delete old player profiles
            #endregion Startup

            // Here the game gives the user starting options along with where they are located and what direction they would want to move.
            #region Game Starts
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type 'Menu' to see the Menu\n");

            Console.WriteLine("Type 'Quit' to quit the game\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nYou are currently at {0}.\nPlease Enter (North, South, East, West) to move!\n", Player.CurrentRoom.RoomName);
            #endregion Game Starts

            //The player is displayed exits points and previously a menu. They have access to either quit, go to the menu, or move to a new location.
            #region Player Decision
            do
            {
                ShowExitLocations.DisplayExits();                                           // Displays exits for user
                Console.Write("\nPlease enter what you would like to do: > ");              
                string input = Console.ReadLine().ToLower();                                
                Console.WriteLine("");
                if (input == "quit")
                {
                    exit = true;
                }
                else if (input == "menu")
                {
                    MenuOptions.DisplayMenu();                                              // Displays menu for user
                }
                else if (input != "menu")
                {
                    PlayerMovement.DisplayMovement(input);                                  // Moves players location
                }
                else
                {
                    Console.WriteLine("Not a Valid input! Type 'Menu' to display a menu!");
                }

            } while (exit == false);
            #endregion Player Decision

        }
    }
}
