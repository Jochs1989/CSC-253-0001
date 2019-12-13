using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    
    public class Combat
    {
        public static void RunCombat(Player player, string noun)
        {
            bool exit = false;
            int playerDamage;
            int mobDamage;
            Mob mob = player.CurrentRoom.CurrentMob;

            // Keeps the do while going as long as the mob/player hasn't died.
            do
            {
                if (noun == mob.Name.ToLower())
                {
                    // Checks to make sure the mob isn't dead
                    if (mob.IsDead == false)
                    {
                        // Rolls the players attack
                        Console.ForegroundColor = ConsoleColor.Green;
                        int playerAttack = RandomNumGenerator.NumberBetween(1, 20);
                        Console.WriteLine($"You attack with a {player.Equipment.Name} and roll a {playerAttack}");

                        if (playerAttack >= mob.AC)
                        {
                            playerDamage = RollDice.PlayerDiceRoll(player);

                            Console.WriteLine($"You hit {mob.Name} for {playerDamage} damage!");
                            mob.HP -= playerDamage;
                            Console.WriteLine($"The {mob.Name} has {mob.HP} HP!");
                            // Once mob dies all items are automatically given to player //TODO add a display of what the player gained (xp, gold, items, etc)
                            if (mob.HP <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                mob.IsDead = true;
                                player.Gold += mob.Gold;
                                player.XP += mob.XP;
                                player.PlayerLevel = player.XP / 100;
                                player.Inventory = mob.ItemDrop;
                                exit = true;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You Missed!!!");
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        // Mobs turn to attack if it is still alive, rolls the mobs attacks and continues combat until the player or mob dies
                        if (mob.IsDead == false)
                        {
                            int monsterAttack = RandomNumGenerator.NumberBetween(1, 20);

                            if (monsterAttack > player.AC)
                            {
                                mobDamage = RollDice.MonsterDiceRoll(mob);

                                Console.WriteLine($"The {mob.Name} attacks and rolls a {monsterAttack}");
                                Console.WriteLine($"The {mob.Name} hits for {mobDamage} damage!");
                                player.HP -= mobDamage;
                                Console.WriteLine($"The {player.PlayerName} has {player.HP} HP!");

                                if (player.HP < 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("You have died!");
                                    LoadPlayerFromFile.LoadPlayer(player.PlayerName);
                                    exit = true;
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"The {mob.Name} Missed!");
                            }
                        }
                        else
                        {

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"You have won!");
                            exit = true;
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Press enter to continue!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"The monster is dead");
                        exit = true;
                    }
                }
                else
                {
                    Console.WriteLine($"You do not see a {noun}");
                    exit = true;
                }
                              
            } while (exit == false);

        }

        public static void CombatResults()
        {

        }
    }
}
