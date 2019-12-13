using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Class is used to simulate rolls for games, combat and events
    public class RollDice
    {
        public static int PlayerDiceRoll(Player player)
        {
            int sum = 0;
            int diceAmount = player.Equipment.DiceAmount;
            int diceSides = player.Equipment.DiceSides;
            

            for (int i = 0; i < diceAmount; i++)
            {
                sum += RandomNumGenerator.NumberBetween(1, diceSides);
            }

            return sum;
        }

        public static int MonsterDiceRoll(Mob mob)
        {

            int sum = 0;
            int diceAmount = mob.AttackDiceAmount;
            int diceSides = mob.AttackDiceSides;


            for (int i = 0; i < diceAmount; i++)
            {
                sum += RandomNumGenerator.NumberBetween(1, diceSides);
            }

            return sum;
        }
    }
}
