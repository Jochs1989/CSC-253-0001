using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationLibrary
{
    public class PopulationAttributes
    {
        //method for user to input number of organisms the population starts with.
        public static int GetNumOrganisms()
        {
            //object used to return data collected
            Population output = new Population();

            //allows the user to enter the organisms starting population and validates entry.
            Console.Write("\nEnter the starting number of organisms (Enter -1 to exit): > ");
            output.NumberOrganisms = TryParse.GetIntParse(Console.ReadLine());

            //returns users entry or exits the method.
            if (output.NumberOrganisms != -1)
            {
                return output.NumberOrganisms;
            }

            return output.NumberOrganisms;
        }
        //method for user to input the rate the population increases.
        public static double GetAverageIncrease()
        {
            //object used to return data collected
            Population output = new Population();

            //allows the user to enter rate of increase for population and validates entry.
            Console.Write("\nEnter the percent increase (Enter -1 to exit): > ");
            output.AverageIncrease = TryParse.GetDoubleParse(Console.ReadLine());

            //returns users entry or exits the method
            if (output.AverageIncrease != -1)
            {
                output.AverageIncrease = output.AverageIncrease * .01;
                return output.AverageIncrease;
            }

            return output.AverageIncrease;
        }
        //method for user to input number of days for population increase.
        public static int GetNumDays()
        {
            //object used to return data collected
            Population output = new Population();

            //allows the user to enter days wanted and validates entry.
            Console.Write("\nEnter the number of days (Enter -1 to exit): > ");
            output.NumberOfDays = TryParse.GetIntParse(Console.ReadLine());

            //returns users entry or exits the method
            if (output.NumberOfDays != -1)
            {
                return output.NumberOfDays;
            }

            return output.NumberOfDays;
        }
        //method to display results over user input days.
        public static void GetResults(int numOrganisms, double averageIncrease, int numDays)
        {
            double result = numOrganisms;
            int index = 1;

            //displays results depending on days.
            while (index <= numDays)
            {
                Console.WriteLine($"Day: {index} | Population: {result}");
                result += result * averageIncrease;
                index++;
            }

            Console.WriteLine("\n Press Enter to Continue!");
            Console.ReadLine();
        }
    }
}
