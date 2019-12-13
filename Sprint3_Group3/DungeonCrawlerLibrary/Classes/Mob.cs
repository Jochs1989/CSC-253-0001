using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Mob class to assign information for the Mobs
    public class Mob : LivingCreature 
    {
        private int _id;
        private string _name;
        private string _description;
        private int _attSides;
        private int _attAmount;
        private string _attType;
        private int _gold;
        private int _xp;
        private List<InheritItem> _itemDrop;


        public int ID { get{ return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int AttackDiceSides { get { return _attSides; } set { _attSides = value; } }
        public int AttackDiceAmount { get { return _attAmount; } set { _attAmount = value; } }
        public string AttackType { get { return _attType; } set { _attType = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public int XP { get { return _xp; } set { _xp = value; } }
        public List<InheritItem> ItemDrop { get { return _itemDrop; } set { _itemDrop = value; } }

        // Constructor to assign information gathered
        #region Constructors
        public Mob(int id, string name, string description, int hp, int ac, int attSides, int attAmount, string attType, int mobRating,  bool isDead) : base(hp, ac, isDead)
        {
            ID = id;
            Name = name;
            Description = description;
            HP = hp;
            AC = ac;
            AttackDiceSides = attSides;
            AttackDiceAmount = attAmount;
            AttackType = attType;
            Gold = RandomGold(mobRating); 
            XP = RandomXP(mobRating);
            IsDead = isDead;
            ItemDrop = RandomItemsDropped(mobRating);
        }

        // This is how you make a copy of a mob!!!
        public Mob(Mob copy) : base(copy.HP, copy.AC, copy.IsDead)
        {
            ID = copy.ID;
            Name = copy.Name;
            Description = copy.Description;
            HP = copy.HP;
            AC = copy.AC;
            AttackDiceSides = copy.AttackDiceSides;
            AttackDiceAmount = copy.AttackDiceAmount;
            AttackType = copy.AttackType;
            Gold = copy.Gold;
            XP = copy.XP;
            IsDead = copy.IsDead;
            ItemDrop = copy.ItemDrop;
        }
        #endregion
        //TODO Need to figure out how to save randomly generated item to mob for player to find.
        public List<InheritItem> RandomItemsDropped(int itemDrop) 
        {
            List<InheritItem> newItemList = new List<InheritItem>();
            switch (itemDrop)
            {
                case 0:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(401, 413)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(301, 340)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(201, 220)));
                    return newItemList;
                    
                case 1:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(401, 415)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(301, 350)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(212, 236)));
                    return newItemList;
                case 2:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(401, 416)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(301, 360)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(212, 252)));
                    return newItemList;
                case 3:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(401, 419)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(330, 364)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(231, 252)));
                    return newItemList;
                case 4:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(409, 421)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(353, 367)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(253, 268)));
                    return newItemList;
                case 5:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(420, 421)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(353, 367)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(253, 268)));
                    return newItemList;
                default:
                    newItemList.Add(GameAttributes.PlayerItemByID(RandomNumGenerator.NumberBetween(409, 421)));
                    newItemList.Add(GameAttributes.PlayerPotionByID(RandomNumGenerator.NumberBetween(353, 367)));
                    newItemList.Add(GameAttributes.PlayerWeaponByID(RandomNumGenerator.NumberBetween(253, 268)));
                    return newItemList;
            }
        }

        private int RandomGold(int gold)
        {
            switch (gold)
            {
                case 0:
                    return RandomNumGenerator.NumberBetween(10, 20);
                case 1:
                    return RandomNumGenerator.NumberBetween(20, 30);
                case 2:
                    return RandomNumGenerator.NumberBetween(30, 50);
                case 3:
                    return RandomNumGenerator.NumberBetween(50, 75);
                case 4:
                    return RandomNumGenerator.NumberBetween(100, 150);
                case 5:
                    return RandomNumGenerator.NumberBetween(750, 750);
                case 6:
                    return RandomNumGenerator.NumberBetween(1500, 1500);
                default:
                    return 0;
            }
        }

        private int RandomXP(int xp)
        {
            switch (xp)
            {
                case 0:
                    return RandomNumGenerator.NumberBetween(1, 10);
                case 1:
                    return RandomNumGenerator.NumberBetween(5, 15);
                case 2:
                    return RandomNumGenerator.NumberBetween(15, 25);
                case 3:
                    return RandomNumGenerator.NumberBetween(25, 35);
                case 4:
                    return RandomNumGenerator.NumberBetween(35, 50);
                case 5:
                    return RandomNumGenerator.NumberBetween(100, 100);
                case 6:
                    return RandomNumGenerator.NumberBetween(200, 200);
                default:
                    return 0;
            }
        }
    }
}
