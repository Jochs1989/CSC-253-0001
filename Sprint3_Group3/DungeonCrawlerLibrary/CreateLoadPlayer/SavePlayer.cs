using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class SavePlayer
    {
        public static void Saving(Player player)
        {
            Console.WriteLine("\n.........Saving...........\n");
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
                Console.WriteLine("Player did not save!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Saves the users weapon in case of changes to the weapon.
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText($"{player.PlayerName}Weapon.csv");

                outputFile.WriteLine($"{player.Equipment.ID},{player.Equipment.Name},{player.Equipment.Description},{player.Equipment.Price}," +
                    $"{player.Equipment.CanEquip},{player.Equipment.Damage},{player.Equipment.DiceAmount},{player.Equipment.DiceSides},{player.Equipment.Upgrades}");

                outputFile.Close();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Equipment did not save!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //TODO figure out how to save the inventory correctly if is is possible.
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText($"{player.PlayerName}Inventory.csv");

                for (int i = 0; i < player.Inventory.Count; i++)
                {
                    outputFile.Write($"{player.Inventory[i].ID},{player.Inventory[i].Name},{player.Inventory[i].Description},{player.Inventory[i].Price}"); 
                }

                outputFile.Close();
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inventory did not save!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
