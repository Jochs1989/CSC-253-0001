using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    public class RoomCreation
    {
        //This method is uesd to create our rooms as objects and store them in an array.
        public static RoomConnections CreateRoom()
        {
            //This is where it gets a little iffy, these are obviously all objects that are arrays, but they are used in the
            //dictionary where they add exits to them to make them connect. This is where i can understand if you wouldn't want
            //to use this since while we do create an array of these, we only use it to display the rooms.
            RoomConnections entrance = new RoomConnections() { RoomName = "Entrance!\n" };
            RoomConnections roomOne = new RoomConnections() { RoomName = "Room One!\n" };
            RoomConnections roomTwo = new RoomConnections() { RoomName = "Room two!\n" };
            RoomConnections roomThree = new RoomConnections() { RoomName = "Room three!\n" };
            RoomConnections roomFour = new RoomConnections() { RoomName = "Room four!\n" };

            //this uses the .Add function to allow us to connect the rooms in any way we want to create an entire dungeon,
            //we could also use a randomizer to choose what rooms are connected in what way so that the rooms change each time we
            //run the game, but that isn't what we want at this time.
            entrance.exits.Add(Direction.north, roomOne);
            roomOne.exits.Add(Direction.south, entrance);
            roomOne.exits.Add(Direction.east, roomFour);
            roomOne.exits.Add(Direction.north, roomTwo);
            roomTwo.exits.Add(Direction.east, roomThree);
            roomTwo.exits.Add(Direction.south, roomOne);
            roomThree.exits.Add(Direction.south, roomFour);
            roomThree.exits.Add(Direction.west, roomTwo);
            roomFour.exits.Add(Direction.west, roomOne);
            roomFour.exits.Add(Direction.north, roomThree);

            return entrance;
        }
    }
}
