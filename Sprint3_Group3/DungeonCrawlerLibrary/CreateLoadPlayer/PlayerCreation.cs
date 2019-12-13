using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawlerLibrary
{
    public class PlayerCreation
    {
        public static Player CreatePlayer(Player newPlayer)
        {
            // variables and objects for validation and player creation.
            string password = null;
            string name = null;
            bool validName = false;
            bool validClass = false;
            bool validRace = false;

            // Continues to run until the user has made a user name that is not in use. To keep previous users data safe.
            #region User Name Creation
            while (validName == false)
            {
                Console.Write("\nPlease create a User Name! > ");
                name = Console.ReadLine();

                // After the user enters their name the if statement checks to see if the file name exits. If it doesn't then the program will continue. 
                if (!File.Exists($"{name}.csv"))
                {
                    newPlayer.PlayerName = name;
                    validName = true;
                }
                else
                {
                    Console.WriteLine("\nUser Name already Exists!\n");
                }
            }

            #endregion

            // Continues to run until the user meets all requirements allocated for a password.
            #region Password Creation
            while (password == null || !password.Any(char.IsLower) || !password.Any(char.IsUpper) || !password.Any(x => char.IsLetterOrDigit(x)))
            {
                Console.WriteLine("\nMake a Password. Must have 1 captical letter, 1 lowercase letter, and 1 special character.");
                Console.Write("Please create a Password! > ");

                // Takes users Entry and passes it to a method for validation. Method will only return once user has a valid password, which will then exit the loop.
                password = PasswordValidator(Console.ReadLine());
            }
            newPlayer.Password = password;
            #endregion Password Creation

            // Continues to run until the user chooses a class that we have allocated in our enums.
            #region Class Options
            while (validClass == false)
            {
                Console.WriteLine("Pick Class. Choose Warrior, Mage, Rogue, Paladin");
                Console.Write("Choose a class!  > ");
                // Created the class method to make sure that the users entry matches our enum.
                string playerClass = FirstLetterToCap.MakeFirstLetterCap(Console.ReadLine());

                // This accesses our enum class and converts data inside to a string so that we can use our enums as comparision to user's entry.
                if (playerClass == Classes.Warrior.ToString() || playerClass == Classes.Mage.ToString() || playerClass == Classes.Rogue.ToString() || playerClass == Classes.Paladin.ToString())
                {
                    // After the class is chosen, the player gets stats based off class chosen.
                    newPlayer.PlayerClass = playerClass;
                    switch (playerClass)
                    {
                        case "Warrior":
                            newPlayer.PlayerLevel = 1;
                            newPlayer.CurrentRoom = GameAttributes.rooms[0];
                            newPlayer.Equipment = GameAttributes.PlayerWeaponByID(201);
                            newPlayer.HP = 100;
                            newPlayer.AC = 12;
                            newPlayer.Gold = 50;
                            newPlayer.XP = 125;
                            newPlayer.IsDead = false;
                            break;
                        case "Mage":
                            newPlayer.PlayerLevel = 1;
                            newPlayer.CurrentRoom = GameAttributes.rooms[0];
                            newPlayer.Equipment = GameAttributes.PlayerWeaponByID(202);
                            newPlayer.HP = 80;
                            newPlayer.AC = 8;
                            newPlayer.Gold = 100;
                            newPlayer.XP = 175;
                            newPlayer.IsDead = false;
                            break;
                        case "Rogue":
                            newPlayer.PlayerLevel = 1;
                            newPlayer.CurrentRoom = GameAttributes.rooms[0];
                            newPlayer.Equipment = GameAttributes.PlayerWeaponByID(203);
                            newPlayer.HP = 90;
                            newPlayer.AC = 10;
                            newPlayer.Gold = 75;
                            newPlayer.XP = 150;
                            newPlayer.IsDead = false;
                            break;
                        case "Paladin":
                            newPlayer.PlayerLevel = 1;
                            newPlayer.CurrentRoom = GameAttributes.rooms[0];
                            newPlayer.Equipment = GameAttributes.PlayerWeaponByID(204);
                            newPlayer.HP = 110;
                            newPlayer.AC = 14;
                            newPlayer.Gold = 25;
                            newPlayer.XP = 100;
                            newPlayer.IsDead = false;
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                    validClass = true;
                }
                else
                {
                    Console.WriteLine("\nNot a valid Class!\n");
                }
            }
            #endregion Class Options
            
            // Continues to run until the user chooses a race that we have allocated in our enums. 
            #region Race Options
            while (validRace == false)
            {
                Console.WriteLine("Pick Race. Choose Elf, Human, Dwarf, Orc");
                Console.Write("Choose a Race!  > ");
                // Created the class method to make sure that the users entry matches our enum.
                string playerRace = FirstLetterToCap.MakeFirstLetterCap(Console.ReadLine());

                // This accesses our enum race and converts data inside to a string so that we can use our enums as comparision to user's entry.
                if (playerRace == Race.Elf.ToString() || playerRace == Race.Human.ToString() || playerRace == Race.Dwarf.ToString() || playerRace == Race.Orc.ToString())
                {
                    newPlayer.PlayerRace = playerRace;
                    validRace = true;
                }
                else
                {
                    Console.WriteLine("\nNot a valid Class!\n");
                }
            }
            #endregion Race Options
            

            // After all player creations requirements are met the object is passed to another class to save the data to a CSV file.
            PlayerToFile.SavePlayerData(newPlayer);
            // Them the player must login to their new account.
            Console.Write("\nPlease enter your User Name to start: > ");
            return newPlayer = LoadPlayerFromFile.LoadPlayer(Console.ReadLine());
        }

        // Used to validate whether the user met all password requirements. The Any searched though all characters and identifies if any of the 
        // characters meet the requirement allocated.
        #region password validation
        public static string PasswordValidator(string password)
        {

            if (password.Any(char.IsLower))
            {
                if (password.Any(char.IsUpper))
                {
                    if (password.Any(x => char.IsLetterOrDigit(x))) 
                    {
                        return password;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input must contain a Special Character! (example #,!,@...)\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input must contain a Capital letter!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input must contain a lowercase letter!");
            }

            return password;
        }
        #endregion password validation



    }
}
