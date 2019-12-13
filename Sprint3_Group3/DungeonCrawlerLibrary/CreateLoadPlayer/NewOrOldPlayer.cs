using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawlerLibrary
{
    public class NewOrOldPlayer
    {
        public static Player PlayerCreateOrLoad()
        {
            // Class object to store player information along with variables used for varification.
            Player oldUser = new Player("name", "pw", "class", "race", 0, 0, 0, 0, 0, 0, false);
            string userInput;
            string userName;
            string password;
            bool exit = false;

            // Program will continue until the user creates a profile or loads a profile
            while (exit == false)
            {
                Console.WriteLine("\nCreate Account or Load Account");
                Console.WriteLine("Type 'Create' or 'Load' to make a new character or load a character");
                Console.Write(" > ");
                userInput = Console.ReadLine();

                // Here the users input is used as validation for what the program needs to do, either create or load. In this case its for creation.
                if (userInput.ToLower() == "create")
                {
                    oldUser = PlayerCreation.CreatePlayer(oldUser);
                    return oldUser;
                }
                // Here that same user input is used to load a character.
                else if (userInput.ToLower() == "load")
                {
                    // The program takes the player's User Name and passes it to a new class method to see if it is valid.
                    Console.Write("\nPlease enter User Name: > ");

                    userName = Console.ReadLine();
                    oldUser = LoadPlayerFromFile.LoadPlayer(userName);

                    // Here if the players user name is valid it will then ask the user for their password, and as long as their password is correct the program will move on
                    if (File.Exists($"{userName}.csv"))
                    {
                        while (exit == false)
                        {
                            Console.Write("\nPlease Enter your Password: > ");
                            password = Console.ReadLine();

                            if (password == oldUser.Password)
                            {
                                return oldUser;
                            }
                            else
                            {
                                Console.WriteLine("\nIncorrect Password!\n");
                            } 
                        } 
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Input! Please type create or load!\n");
                } 
            }
            return oldUser;
        }
    }
}
