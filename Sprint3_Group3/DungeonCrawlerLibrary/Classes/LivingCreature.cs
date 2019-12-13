using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
   // Inhertited class for anything that is living in the game //TODO add NPC's
   public class LivingCreature
    {
        private int _hp;
        private int _ac;
        private bool _isDead;


        #region Properties

        public int HP { get { return _hp; } set { _hp = value; } }
        public int AC { get { return _ac; } set { _ac = value; } }
        public bool IsDead { get { return _isDead; } set { _isDead = value; } }

        #endregion

        // Constructor to assign information gathered
        #region Constructors
        public LivingCreature(int hp, int ac, bool isDead)
        {
            HP = hp;
            AC = ac;
            IsDead = isDead;
        }

        #endregion
    }
}
