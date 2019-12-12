using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class TryParse
    {
        //class for parsing doubles
        public static double GetDoubleParse(string input)
        {

            if (double.TryParse(input, out double output))
            {
                return output;
            }

            return output;
        }
     }
}
