using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                switch (StandardMessages.StartProgram())
                {
                    case "1":
                        Person.CreateEmployee();
                        break;
                    case "2":
                        Person.CreateSupervisor();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        StandardMessages.GetErrorMessage();
                        break;
                }
            } while (exit == false);
        }
    }
}
