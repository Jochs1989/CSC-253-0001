using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            //varibles for calculation
            double daysCharged = 0;
            double miscCharges = 0;

            do
            {
                //class method for menu
                StandardMessages.DisplayMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            //calls class method in library to get users number of organisms.
                            daysCharged = HospitalAttributes.CalcStayCharges();
                            break;
                        }
                    case "2":
                        {
                            //calls class method in library to get users rate of increase in population.
                            miscCharges = HospitalAttributes.CalcMiscCharges();
                            break;
                        }
                    case "3":
                        {
                            //calls class method in library to display results.
                            HospitalAttributes.GetResults(daysCharged, miscCharges);
                            break;
                        }
                    case "4":
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
