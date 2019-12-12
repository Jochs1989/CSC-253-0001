using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryLibrary
{
    public class ProductionWorker : Employee
    {
        private int _shiftNumber;
        private double _hourlyPayRate;

        public int ShiftNumber { get { return _shiftNumber; } set { _shiftNumber = value; } }
        public double HourlyPayRate { get { return _hourlyPayRate; } set { _hourlyPayRate = value; } }

        public ProductionWorker(int shiftNumber, double hourlyPayRate, string employeeName, string employeeNumber) 
            : base (employeeName, employeeNumber)
        { 
            _shiftNumber = shiftNumber;
            _hourlyPayRate = hourlyPayRate;
        }
    }
}
