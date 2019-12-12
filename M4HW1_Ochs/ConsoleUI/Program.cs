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
                    case "yes":
                        Person.CreateWorker();
                        break;
                    case "no":
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
