using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationLibrary
{
    public class TryParse
    {
        //class for parsing integers
        public static int GetIntParse(string input)
        {

            if (int.TryParse(input, out int output))
            {
                return output;
            }
            else
            {
                return output = -1;
            }
        }
        //class for parsing doubles
        public static double GetDoubleParse(string input)
        {

            if (double.TryParse(input, out double output))
            {
                return output;
            }
            else
            {
                return output = -1;
            } 
        }
    }
}
