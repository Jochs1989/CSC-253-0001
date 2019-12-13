using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Trying to use the class inheritance to also create a list with just the inherited details for use of creating an inventory.
    public class InheritItem
    {

        private int _id;
        private string _name;
        private string _description;
        private int _price;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public InheritItem(int id, string name, string description, int price)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
