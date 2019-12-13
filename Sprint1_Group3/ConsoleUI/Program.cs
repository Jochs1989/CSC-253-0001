using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 09-18-2019
 * CSC-253
 * Winston Stoker / Jeffrey Ochs / Rashad Henry
 * This program will enable a user to move through a room and look at various arrays/lists(it's barely a game?)
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //This object was made using the room creation class, so that we can have a starting room. I could have made this method into a class, but
            //then we would start doing class librarys
            RoomConnections currentRoom = RoomCreation.CreateRoom();

            //Arrays to store our desired weapons, potions and treasures
            string[] weapons = new string[] { "Rusty Blade", "Warped Staff", "Worn Bow", "Old Dagger" };
            string[] Potions = new string[] { "Health Potion", "ManaPotion" };
            string[] Treasures = new string[] { "Rusty Armor", "Training Robes", "Leather Armor" };
            //Lists to store our items and mobs
            List<string> items = new List<string>() { "Home Beacon", "Coin Pouch", "Lock Pick", "Tinderbox" };
            List<string> mobs = new List<string>() { "Goblins", "Sewer Rats", "Giant Spider", "Skeleton" };

            //This sorts all the elements into alphabetical order
            Array.Sort(weapons);
            Array.Sort(Potions);
            Array.Sort(Treasures);
            items.Sort();
            mobs.Sort();

            Console.WriteLine("To Quit Type Quit");
            Console.WriteLine("To see Rooms type: Rooms!\n");
            Console.WriteLine("To see Weapons type: 'Weapons'");
            Console.WriteLine("To see Potions type: 'Potions'");
            Console.WriteLine("To see Treasures type: 'Treasures'");
            Console.WriteLine("To see Items type: 'Items'");
            Console.WriteLine("To see Monsters type: Monsters");
            bool exit = false;
            //normal do while
            do
            {
                //This is just to let the user know how to leave the program. We might need to have a leave the dungeon function later.
                
                
                //This calls the method to let the entrance become to current room for tracking where the user is
                GetLocation(currentRoom);
                //This just allows the user to input which direction from the list of current directions and issues a invlad statement if they
                //do not decide to go a direction listed
                Console.Write("\nPlease enter which direction you would like to go (North, South, East, West): > ");
                string input = Console.ReadLine();
                input = input.ToLower().Trim();
                //Here we take the Enums from the class enums and make sure the input matches the enum and validates the entry.
                if (Enum.TryParse<Direction>(input, out Direction movement))
                {
                    //This if statement will keep track of player movement and move them to the next room
                    //or tells them they are looking at a wall.
                    RoomConnections nextRoom;
                    if (currentRoom.exits.TryGetValue(movement, out nextRoom))
                    {
                        currentRoom = nextRoom;
                    }
                    else
                    {
                        Console.WriteLine("You are looking at a wall!");
                    }
                }
                else if (input == "rooms" || input == "room")
                {
                    foreach (RoomConnections rooms in RoomArrays())
                    {
                        Console.WriteLine(rooms.RoomName);
                    }
                }
                else if (input == "weapons" || input == "weapon")
                {
                    foreach (string weapon in weapons)
                    {
                        Console.WriteLine(weapon);
                    }
                }
                else if (input == "potions" || input == "potion")
                {
                    foreach (string potion in Potions)
                    {
                        Console.WriteLine(potion);
                    }
                }
                else if (input == "treasures" || input == "treasure")
                {
                    foreach (string treasure in Treasures)
                    {
                        Console.WriteLine(treasure);
                    }
                }
                else if (input == "items" || input == "item")
                {
                    foreach (string item in items)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (input == "Monsters" || input == "Monster")
                {

                    foreach (string mob in mobs)
                    {
                        Console.WriteLine(mob);
                    }
                }
                else if (input == "quit")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invlad Entry Please Try Again!");
                }
            } while (exit == false);
        }
        
        //This method uses the class RoomConnections so that was can use our dictionary and connect all the rooms with an array.
        //While the rooms themselves are not exactly an array the are connected by an array and it was the easiest way I found
        //to have movement and the rooms together without a huge if else statement/switch.
        //This is also the first time you see the keys part of the dictionary in use.
        static void GetLocation(RoomConnections room)
        {
            string exit = string.Join(",", room.exits.Keys.ToArray());
            if (string.IsNullOrEmpty(exit))
            {
                exit = "You did not enter Anything!";
            }
            Console.WriteLine("You are in {0}You see door(s) to your: {1}", room.RoomName, exit);
        }
        //this is the method to allow the user to see all the rooms in the dungeon and their name.
        public static RoomConnections[] RoomArrays()
        {
            const int ROOMSIZE = 5;

            RoomConnections entrance = new RoomConnections() { RoomName = "Entrance!\n" };
            RoomConnections roomOne = new RoomConnections() { RoomName = "Room One!\n" };
            RoomConnections roomTwo = new RoomConnections() { RoomName = "Room two!\n" };
            RoomConnections roomThree = new RoomConnections() { RoomName = "Room three!\n" };
            RoomConnections roomFour = new RoomConnections() { RoomName = "Room four!\n" };

            RoomConnections[] roomArray = new RoomConnections[ROOMSIZE] { entrance, roomOne, roomTwo, roomThree, roomFour };

            return roomArray;
        }

    }
}
