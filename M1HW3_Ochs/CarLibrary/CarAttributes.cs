using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class CarAttributes
    {
        public static Car GetCarInfo()
        {
            Car output = new Car();

            Console.Write("What is the year of the car? > ");
            output.Year = int.Parse(Console.ReadLine());


            Console.Write("What is the make of the car? > ");
            output.Make = Console.ReadLine();

            return output;
        }
    }
}
