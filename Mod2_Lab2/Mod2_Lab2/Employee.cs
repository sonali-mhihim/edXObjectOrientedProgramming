using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab2
{
    abstract class Employee
    {
        // 3 private member variables: employeeName, employeeBaseSalary, and employeeId
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        // Creates integer variable called "employeeCount" and assigns value to 1
        private static int employeeCount = 1;

        // Public properties
        public string Name
        {
            get
            {
                return this.employeeName;
            }

            set
            {
                this.employeeName = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return this.employeeBaseSalary;
            }

            set
            {
                this.employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return this.employeeId;
            }

            set
            {
                this.employeeId = value;
            }
        }

        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        // This method returns the employee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        // This method returns the employee's name
        public string getName()
        {
            return this.Name;
        }

        // This method returns the employee's ID
        public int getEmployeeID()
        {
            return this.ID;
        }

        // This method returns the employee's ID and Name
        public string toString()
        {
            return $"{this.ID} {this.Name}";
            // return this.ID + " " + this.Name;
        }

        public abstract string employeeStatus();
    }
}
