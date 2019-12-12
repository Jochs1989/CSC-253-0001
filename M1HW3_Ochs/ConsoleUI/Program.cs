using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            Car car = new Car();

            do
            {
                StandardMessages.DisplayMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            car = CarAttributes.GetCarInfo();
                            break;
                        }
                    case "2":
                        {
                            car.Accelerate();
                            StandardMessages.DisplayCarSpeed(car);
                            break;
                        }
                    case "3":
                        {
                            car.Brake();
                            StandardMessages.DisplayCarSpeed(car);
                            break;
                        }
                    case "4":
                        {
                            exit = true;
                            break;
                        }
                    default:
                        {
                            StandardMessages.DisplayMenuError();
                            break;
                        }
                }

            } while (exit == false);
        }
    }
}
