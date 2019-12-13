using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public enum Direction
    {
        //okay sorry guys this was of my own research because the east west movement was a little annoying.
        //These are enums they are super useful when dealing with small parameters IE (days of the week or stuff like job status)
        //These are used to compare where the exits are in each room and which direction the user choose.
        //If you hover over them you will see that they are assigned values to each one.
        //That is what is used to compare in our program.
        north,
        south,
        east,
        west
    }
}
