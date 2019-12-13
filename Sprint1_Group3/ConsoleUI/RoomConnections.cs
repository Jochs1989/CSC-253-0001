using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class RoomConnections
    {
        //I used a dictionary because we are dealing with both directions and rooms, This will also make it easier when we want to expand
        //the rooms. I'm sorry for going a little overboard, but the east west movement was really annoying along with the if/switch restrictions.
        //How a dictionary work is you can enter 2 data types call keys and values, and then pull from either one. These keys and methods can
        //be all the other datat types and as you see even classes or enums.
        public Dictionary<Direction, RoomConnections> exits = new Dictionary<Direction, RoomConnections>();
        public string RoomName { get; set; }

    }
}
