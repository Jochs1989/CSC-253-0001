using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryLibrary
{
    public class Employee
    {
        public string _employeeName;
        public string _employeeNumber;

        public string EmployeeName { get { return _employeeName; } set { _employeeName = value; } }
        public string EmployeeNumber { get { return _employeeNumber; } set { _employeeNumber = value; } }

        public Employee(string employeeName, string employeeNumber)
        {
            _employeeName = employeeName;
            _employeeNumber = employeeNumber;
        }
    }
}
