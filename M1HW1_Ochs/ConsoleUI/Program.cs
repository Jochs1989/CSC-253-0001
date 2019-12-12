using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PopulationLibrary;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            //variables for results
            int organisms = 0;
            double averageRate = 0;
            int days = 0;
            
            do
            {
                //class method for menu
                StandardMessages.DisplayMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            //calls class method in library to get users number of organisms.
                            organisms = PopulationAttributes.GetNumOrganisms();
                            break;
                        }
                    case "2":
                        {
                            //calls class method in library to get users rate of increase in population.
                            averageRate = PopulationAttributes.GetAverageIncrease();
                            break;
                        }
                    case "3":
                        {
                            //calls class method in library to get users number of days for population to increase.
                            days = PopulationAttributes.GetNumDays();
                            break;
                        }
                    case "4":
                        {
                            //calls class method in library to display results.
                            PopulationAttributes.GetResults(organisms, averageRate, days);
                            break;
                        }
                    case "5":
                        {
                            //exits the program
                            exit = true;
                            break;
                        }
                    default:
                        {
                            //displays an error for invalid entries in the menu
                            StandardMessages.DisplayMenuError();
                            break;
                        }
                }

            } while (exit == false);
        }
    }
}
