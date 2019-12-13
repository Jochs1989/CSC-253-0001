using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawlerLibrary
{
    public class LoadPlayerFromFile
    {
        // After the user enters their username, the program see's if the file exist. Then if the file is present the program will write all information to player.cs.
        // Also the program sends back the information for use in identifying if the user knows the password.
        public static Player LoadPlayer(string username)
        {
            Player oldplayer = new Player("name", "pw", "class", "race", 0, 0, 0, 0, 0, 0, false);

            if (File.Exists($"{username}.csv"))                                                 // Sees if the file exists
            {
                using (StreamReader playerfileReader = new StreamReader($"{username}.csv"))           // Opens the file
                {
                    while (!playerfileReader.EndOfStream)
                    {
                        var line = playerfileReader.ReadLine();
                        var values = line.Split(',');

                        // returns file informaiton for password varification.
                        oldplayer = new Player(values[0], values[1], values[2], values[3], int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6]), int.Parse(values[7]),
                            int.Parse(values[8]), int.Parse(values[9]), bool.Parse(values[10]));                   
                    }

                    using (StreamReader weapontFileReader = new StreamReader($"{username}Weapon.csv"))      // Loads in the users weapon. This makes it so that if there are any changes to the weapon the changes are saved.
                    {
                        while(!weapontFileReader.EndOfStream)
                        {
                            var line = weapontFileReader.ReadLine();
                            var values = line.Split(',');
                            oldplayer.Equipment = new Weapon(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), bool.Parse(values[4]), values[5], int.Parse(values[6]), int.Parse(values[7]), int.Parse(values[8]));
                        }

                        using (StreamReader inventoryFileReader = new StreamReader($"{username}Inventory.csv")) // TODO Still need to figure out how to make the inventory work.
                        {
                            while (!inventoryFileReader.EndOfStream)
                            {
                                var line = inventoryFileReader.ReadLine();
                                var values = line.Split(',');
                                oldplayer.Inventory = new List<InheritItem>() { new InheritItem (int.Parse(values[0]), values[1], values[2], int.Parse(values[3])) };
                            }
                        }
                    }
                    return oldplayer;
                }
            }
            else
            {
                Console.WriteLine($"Username ({username}) does not exist!");
                return null;
            }
        }
    }
}
