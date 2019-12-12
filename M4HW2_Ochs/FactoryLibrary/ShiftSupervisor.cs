using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryLibrary
{
    public class ShiftSupervisor : Employee
    {
        private double _annualSalary;
        private double _productionBonus;

        public double AnnualSalary { get { return _annualSalary; } set { _annualSalary = value; } }
        public double ProductionBonus { get { return _productionBonus; } set { _productionBonus = value; } }

        public ShiftSupervisor(double annualSalary, double productionBonus, string employeeName, string employeeNumber)
            : base(employeeName, employeeNumber)
        {
            _annualSalary = annualSalary;
            _productionBonus = productionBonus;
        }
    }
}
