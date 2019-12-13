using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawlerLibrary
{
    public class PlayerToFile
    {
        public static void SavePlayerData(Player player)
        {
            // The players information is created using a previous object that stored the user's input for player creation.
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText($"{player.PlayerName}.csv");

                outputFile.WriteLine($"{player.PlayerName.Trim()},{player.Password.Trim()},{player.PlayerClass.Trim()},{player.PlayerRace.Trim()}," +
                    $"{player.PlayerLevel},{player.CurrentRoom.ID},{player.HP},{player.AC},{player.Gold},{player.XP},{player.IsDead}");

                outputFile.Close();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error loading player!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Makes a file for the users equipped weapon.
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText($"{player.PlayerName}Weapon.csv");

                    outputFile.WriteLine($"{player.Equipment.ID},{player.Equipment.Name},{player.Equipment.Description},{player.Equipment.Price}," +
                        $" {player.Equipment.CanEquip},{player.Equipment.Damage},{player.Equipment.DiceAmount},{player.Equipment.DiceSides},{player.Equipment.Upgrades}");

                outputFile.Close();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EError loading Equipment!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Makes a file for the users inventory.
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText($"{player.PlayerName}Inventory.csv");

                for (int i = 0; i < player.Inventory.Count; i++)
                {
                    outputFile.WriteLine($"{player.Inventory[i].ID},{player.Inventory[i].Name},{player.Inventory[i].Description},{player.Inventory[i].Price}");
                }

                outputFile.Close();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error loading Inventory!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
