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
            Player oldplayer = new Player();
            if (File.Exists($"{username}.csv"))                                                 // Sees if the file exists
            {
                using (StreamReader fileReader = new StreamReader($"{username}.csv"))           // Opens the file
                {
                    fileReader.ReadLine();

                    while (!fileReader.EndOfStream)
                    {
                        string userName = fileReader.ReadLine();
                        string password = fileReader.ReadLine();
                        string playerClass = fileReader.ReadLine();
                        string playerRace = fileReader.ReadLine();

                        return oldplayer = new Player(userName, password, playerClass, playerRace); // returns file informaiton for password varification.
                    }
                    return oldplayer;
                }
            }
            else
            {
                Console.WriteLine("UserName does not exist!");
                return null;
            }
        }
    }
}
