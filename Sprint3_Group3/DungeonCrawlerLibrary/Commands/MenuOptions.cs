using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class MenuOptions
    {
        public static void DisplayMenu(Player player)
        {
            bool exit = false;
            string input;

            // Displays a list of options the user can type. After takes the user's input and displays that the user was asking for.
            do
            {
                #region Menu display
                Console.ForegroundColor = ConsoleColor.Cyan;
                foreach (Menu name in GameAttributes.options)
                {
                    Console.WriteLine(name.Options);
                }
                Console.ForegroundColor = ConsoleColor.White;
                #endregion
                Console.Write("\nPlease enter what you would like to do: > ");

                input = Console.ReadLine().ToLower();

                #region Option Displays
                switch (input.ToLower())
                {
                    case "room":
                    {
                        foreach (Room name in GameAttributes.rooms)
                        {
                            Console.WriteLine(name.RoomName);
                        }
                        break;
                    }
                    case "location":
                    {
                        Console.WriteLine($"You are Currently in {player.CurrentRoom.RoomName}");
                        break;
                    }
                    case "weapons":
                    {
                        foreach (Weapon name in GameAttributes.weapons)
                        {
                            Console.WriteLine(name.Name);
                        }
                        break;
                    }
                    case "mobs":
                    {
                            foreach (Mob name in GameAttributes.mobs)
                            {
                                Console.WriteLine(name.Name);
                            }
                            break;
                        }
                    case "potions":
                    {
                        foreach (Potion name in GameAttributes.potions)
                        {
                            Console.WriteLine(name.Name);
                        }
                        break;
                    }
                    case "treasures":
                    {
                        foreach (Treasure name in GameAttributes.treasures)
                        {
                            Console.WriteLine(name.Name);
                        }
                        break;
                    }
                    case "items":
                    {
                        foreach (Item name in GameAttributes.items)
                        {
                            Console.WriteLine(name.Name);
                        }
                        break;
                    }
                    case "quit":
                        {
                            Environment.Exit(1);
                            break;
                        }
                    case "back":
                    {
                        exit = true;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("\nNot a Valid input!");
                            break;
                    }
                }
                #endregion Option Displays

            } while (exit == false);
        }
    }
}
