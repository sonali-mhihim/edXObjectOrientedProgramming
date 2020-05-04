using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab2
{
    class TechnicalEmployee : Employee
    {
        // Creates integer variable called "successfulCheckIns" and assigns value to 5
        public int successfulCheckIns = 5;

        // Calls upon base-class (Employee Class) constructor from within derived class (TechnicalEmployee Class)
        // Sets baseSalary to 75000 for all TechnicalEmployee objects
        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }

        public override string employeeStatus()
        {
            return $"{this.toString()} has {this.successfulCheckIns} successfull check ins";
        }
    }
}
