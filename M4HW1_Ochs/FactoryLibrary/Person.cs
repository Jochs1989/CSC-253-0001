using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryLibrary
{
    public class Person
    {
        public static void CreateWorker()
        {
            ProductionWorker newWorker = new ProductionWorker(0, 0.0, "name", "ID Number");

            bool validEntry = false;

            Console.WriteLine("What is your name?");
            newWorker.EmployeeName = Console.ReadLine();

            Console.WriteLine("What is your ID Number?");
            newWorker.EmployeeNumber = Console.ReadLine();

            do
            {
                Console.WriteLine("What shift do you work 1 or 2?");
                if (int.TryParse(Console.ReadLine(), out int shift))
                {
                    if (shift == 1 || shift == 2)
                    {
                        newWorker.ShiftNumber = shift;
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter 1 or 2!");
                    }
                }
                else
                {
                    StandardMessages.GetErrorMessage();
                }
            } while (validEntry == false);

            do
            {
                Console.WriteLine("What is your hourly pay?");
                if (double.TryParse(Console.ReadLine(), out double hourlyPayRate))
                {
                    if (hourlyPayRate > 0)
                    {
                        newWorker.HourlyPayRate = hourlyPayRate;
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Your earnings cannot be below zero!");
                    }
                }
                else
                {
                    StandardMessages.GetErrorMessage();
                }
            } while (validEntry == false);


            Console.WriteLine($"\nName: {newWorker.EmployeeName}");
            Console.WriteLine($"ID Number: {newWorker.EmployeeNumber}");
            switch (newWorker.ShiftNumber)
            {
                case 1:
                    Console.WriteLine("Shift: Day");
                    break;
                case 2:
                    Console.WriteLine("Shift: Night");
                    break;

            }
            Console.WriteLine($"Pay Rate: ${newWorker.HourlyPayRate}");
            Console.WriteLine("\nPress Enter to Continue!");
            Console.ReadLine();
        }
    }
}
