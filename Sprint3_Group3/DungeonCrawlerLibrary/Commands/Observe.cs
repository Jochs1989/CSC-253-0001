using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class Observe
    {
        // Method that takes in the players information for determining what exist in the players data. Then takes the noun that was passed and finds specially what the user is looking at.
        public static void ObserveArea(Player player,string noun)
        {
            if (player.CurrentRoom.CurrentMob != null && noun != "")
            {
                if (noun == player.CurrentRoom.CurrentMob.Name.ToLower())
                {
                    Console.WriteLine($"You see {player.CurrentRoom.CurrentMob.Description}");
                }
                else
                {
                    Console.WriteLine("You don't see anything");
                }
            }
            else if (noun == "")
            {
                Console.WriteLine($"{player.CurrentRoom.Description}");
                if (player.CurrentRoom.CurrentMob != null)
                {
                    Console.WriteLine($"You see a {player.CurrentRoom.CurrentMob.Name}");
                }
                else
                {
                    Console.WriteLine($"You don't see anything of importance.");
                }
            }
            
        }
    }
}
