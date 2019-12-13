using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    // Menu class to assign information for the menu
    public class Menu
    {
        public string Options { get; set; }

        // Constructor to assign information gathered
        public Menu(string options)
        {
            Options = options;
        }
    }
}
