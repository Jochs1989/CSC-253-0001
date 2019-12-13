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
        private string _options;

        public string Options { get { return _options; } set { _options = value; } }

        // Constructor to assign information gathered
        public Menu(string options)
        {
            Options = options;
        }
    }
}
