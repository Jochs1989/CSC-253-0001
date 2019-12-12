using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryLibrary
{
    public class Person
    {
        #region Employee
        public static void CreateEmployee()
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
            Console.WriteLine($"Pay Rate: ${newWorker.HourlyPayRate.ToString("C2")}");
            Console.WriteLine("\nPress Enter to Continue!");
            Console.ReadLine();
        }
        #endregion Employee

        #region Supervisor
        public static void CreateSupervisor()
        {
            ShiftSupervisor newSupervisor = new ShiftSupervisor(0.00, 0.00, "name", "ID Number");

            bool validEntry = false;

            Console.WriteLine("What is your name?");
            newSupervisor.EmployeeName = Console.ReadLine();

            Console.WriteLine("What is your ID Number?");
            newSupervisor.EmployeeNumber = Console.ReadLine();

            do
            {
                Console.WriteLine("What was your annual salary");
                if (double.TryParse(Console.ReadLine(), out double annualSalary))
                {
                    if (annualSalary > 0)
                    {
                        newSupervisor.AnnualSalary = annualSalary;
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

            do
            {
                Console.WriteLine("Did your shift meet the production goals?");
                Console.Write("Enter 'yes' or 'no': > ");
                switch(Console.ReadLine())
                {
                    case "yes":
                        newSupervisor.ProductionBonus = 5000.00;
                        validEntry = true;
                        break;
                    case "no":
                        validEntry = true;
                        break;
                    default:
                        StandardMessages.GetErrorMessage();
                        break;
                }
            } while (validEntry == false);


            Console.WriteLine($"\nName: {newSupervisor.EmployeeName}");
            Console.WriteLine($"ID Number: {newSupervisor.EmployeeNumber}");
            Console.WriteLine($"Annual Salary: {newSupervisor.AnnualSalary.ToString("C2")}");
            Console.WriteLine($"Annual Production Bonus: {newSupervisor.ProductionBonus.ToString("C2")}");
            Console.WriteLine("\nPress Enter to Continue!");
            Console.ReadLine();
        }
        #endregion Supervisor
    }
}
