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
        public static void CreatePlayer()
        {
            // variables and objects for validation and player creation.
            string password = null;
            string name = null;
            bool validName = false;
            bool validClass = false;
            bool validRace = false;
            Player newPlayer = new Player();

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
                    newPlayer.PlayerClass = playerClass;
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

            //After all player creations requirements are met the object is passed to another class to save the data to a CSV file.
            PlayerToFile.SavePlayerData(newPlayer);
        }

        // Used to validate whether the user met all password requirements. The Any searched though all characters and identifies if any of the 
        // characters meet the requirement allocated.
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


        
    }
}
